using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client
{
    public partial class FriendsList : UserControl
    {
        public FriendsList()
        {
            InitializeComponent();            
        }

        private void dgv_friends_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = ((Friend)dgv_friends.Rows[e.RowIndex].DataBoundItem).Id;

            var nearFriendsList = Conector.GetApiResult<List<Friend>>(new Uri($"http://localhost:60474/api/nearfriends/{Id}"));

            dgv_nearFriends.DataSource = nearFriendsList;
        }

        internal void Start()
        {
            var friendList = Conector.GetApiResult<List<Friend>>(new Uri("http://localhost:60474/api/friends"));

            dgv_friends.DataSource = friendList;

            dgv_friends.CurrentCell.Selected = false;
        }
    }
}
