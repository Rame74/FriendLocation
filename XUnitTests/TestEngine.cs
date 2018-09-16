using Friends.Engine;
using Friends.Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    public class TestEngine
    {
        readonly ConnectionStrings connectionStrings;

        public TestEngine()
        {
            connectionStrings = new ConnectionStrings()
            {
                Default = "Server=DESKTOP-CVID96I\\SQLEXPRESS;Database=Friends;User Id=sa;Password=sqlexpress;"
            };
        }

        [Fact]
        public void GetFriendList()
        {
            new Facade(connectionStrings).GetFriendList();
        }

        [Fact]
        public void GetFriend()
        {
            new Facade(connectionStrings).GetFriend(1);
        }
    }
}
