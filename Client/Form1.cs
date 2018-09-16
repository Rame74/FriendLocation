using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnk_getFriendList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel1.Controls.Cast<object>().FirstOrDefault()?.GetType() != typeof(FriendsList))
            {
                var control = new FriendsList();

                panel1.Controls.Clear();
                panel1.Controls.Add(control);

                control.Start();
            }
        }

        private void lnk_setNearFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel1.Controls.Cast<object>().FirstOrDefault()?.GetType() != typeof(NearFriends))
            {
                var control = new NearFriends();

                panel1.Controls.Clear();
                panel1.Controls.Add(control);

                control.Start();
            }
        }
    }
}
