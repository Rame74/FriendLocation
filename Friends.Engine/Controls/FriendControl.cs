using Friends.Engine.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Friends.Engine.Controls
{
    class FriendControl
    {
        private ConnectionStrings connectionStrings;

        public FriendControl(ConnectionStrings connStrings)
        {
            this.connectionStrings = connStrings;
        }

        internal List<Friend> GetList()
        {
            var friends = new List<Friend>();

            using (var conn = new SqlConnection(connectionStrings.Default))
            using (var comm = new SqlCommand() { Connection = conn })
            using (var adpt = new SqlDataAdapter(comm))
            {
                comm.CommandText = @"SELECT FriendId
                                          ,Name
                                          ,Latitude
                                          ,Longitude
                                      FROM Friend
                                      ORDER BY Name";

                DataSet ds = new DataSet();

                adpt.Fill(ds);

                friends = ParseFriends(ds);
            }

            return friends;
        }

        internal void SetNearFriends(Friend friend)
        {
            using (var conn = new SqlConnection(connectionStrings.Default))
            using (var comm = new SqlCommand() { Connection = conn })
            {
                var Id = friend.Id;

                comm.CommandText = @"DELETE FROM WhosNear WHERE FriendId_1_FK = @Id";

                comm.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = Id });

                conn.Open();

                comm.ExecuteNonQuery();

                conn.Close();

                comm.Parameters.Clear();

                foreach (var frd in friend.Friends)
                {
                    comm.CommandText = "INSERT INTO WhosNear VALUES (@Id1, @Id2)";

                    comm.Parameters.Add(new SqlParameter("@Id1", SqlDbType.Int) { Value = Id });

                    comm.Parameters.Add(new SqlParameter("@Id2", SqlDbType.Int) { Value = frd.Id });

                    conn.Open();

                    comm.ExecuteNonQuery();

                    conn.Close();

                    comm.Parameters.Clear();
                }
            }
        }

        internal List<Friend> GetNearFriends(int Id)
        {
            var friends = new List<Friend>();

            using (var conn = new SqlConnection(connectionStrings.Default))
            using (var comm = new SqlCommand() { Connection = conn })
            using (var adpt = new SqlDataAdapter(comm))
            {
                comm.CommandText = @"SELECT fr2.FriendId, fr2.Name, fr2.Latitude, fr2.Longitude FROM WhosNear AS wn
                                        INNER JOIN Friend AS fr2 ON fr2.FriendId = wn.FriendId_2_FK
                                        WHERE wn.FriendId_1_FK = @id";

                comm.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = Id });

                DataSet ds = new DataSet();

                adpt.Fill(ds);

                friends = ParseFriends(ds);
            }

            return friends;
        }

        internal void AddFriend(Friend friend)
        {
            throw new NotImplementedException();
        }

        internal Friend GetFriend(int Id)
        {
            Friend friend = null;

            using (var conn = new SqlConnection(connectionStrings.Default))
            using (var comm = new SqlCommand() { Connection = conn })
            using (var adpt = new SqlDataAdapter(comm))
            {
                comm.CommandText = string.Concat(new[] {
                    @"SELECT FriendId
                            ,Name
                            ,Latitude
                            ,Longitude FROM Friend
                        WHERE FriendId = @id;",

                    @"SELECT fr2.FriendId, fr2.Name, fr2.Latitude, fr2.Longitude FROM WhosNear AS wn
                        INNER JOIN Friend AS fr2 ON fr2.FriendId = wn.FriendId_2_FK
                        WHERE wn.FriendId_1_FK = @id"
                });

                comm.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = Id });

                DataSet ds = new DataSet();

                adpt.Fill(ds);

                friend = ParseFriends(ds)?.First();
            }

            return friend;
        }

        List<Friend> ParseFriends(DataSet ds)
        {
            List<Friend> friends = null;

            if (ds.Tables[0].Rows.Count > 0)
            {
                friends = ds.Tables[0].Select().Select(o => new Friend()
                {
                    Id = Convert.ToInt32(o["FriendId"]),
                    Name = o["name"].ToString(),
                    Latitude = Convert.ToInt32(o["Latitude"]),
                    Longitude = Convert.ToInt32(o["Longitude"]),
                    Friends = (ds.Tables.Count > 1) ? ds.Tables[1]?.Select().Select(ox => new Friend()
                    {
                        Id = Convert.ToInt32(ox["FriendId"]),
                        Name = ox["name"].ToString(),
                        Latitude = Convert.ToInt32(ox["Latitude"]),
                        Longitude = Convert.ToInt32(ox["Longitude"]),
                        Friends = null
                    }).ToList() : null
                }).ToList();
            }

            return friends;
        }
    }
}
