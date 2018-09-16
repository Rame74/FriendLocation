using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class NearFriends : UserControl
    {
        public NearFriends()
        {
            InitializeComponent();
        }

        internal void Start()
        {
            var friendList = Conector.GetApiResult<List<Friend>>(new Uri("http://localhost:60474/api/friends"));

            dgv_friend.DataSource = friendList;

            dgv_friend.CurrentCell.Selected = false;

            dgv_friends.DataSource = friendList.Select(o => new Friend()
            {
                Id = o.Id,
                Latitude = o.Latitude,
                Longitude = o.Longitude,
                Name = o.Name
            }).ToList();

            dgv_friends.CurrentCell.Selected = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var selRowsFriend = dgv_friend.SelectedRows;

            if (selRowsFriend.Count > 0)
            {
                var selRowsFriends = dgv_friends.SelectedRows;

                if (selRowsFriends.Count > 3)
                {
                    MessageBox.Show("More then 3 Near Friends Selected");

                    return;
                }

                if (selRowsFriends.Count > 0)
                {
                    var friend = ((Friend)dgv_friend.Rows[selRowsFriend[0].Index].DataBoundItem);

                    friend.Friends = new Func<List<Friend>>(() =>
                    {
                        var friends = selRowsFriends.Cast<DataGridViewRow>().Take(3).Select(o => (Friend)o.DataBoundItem).ToList();

                        return friends;
                    })();

                    Conector.PostToApi(new Uri("http://localhost:60474/api/nearfriends"), JsonConvert.SerializeObject(friend));

                    MessageBox.Show("Near Friends Saved, Check Friends List");
                }
                else
                {
                    MessageBox.Show("No Near Friend Selected");
                }
            }
            else
            {
                MessageBox.Show("No Friend Selected");
            }
        }
    }
}
