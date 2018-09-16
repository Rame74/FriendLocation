using Friends.Engine.Controls;
using Friends.Engine.Models;
using System;
using System.Collections.Generic;

namespace Friends.Engine
{
    public class Facade
    {
        private ConnectionStrings settings;

        public Facade(ConnectionStrings settings)
        {
            this.settings = settings;
        }

        public Friend GetFriend(int Id) => new FriendControl(settings).GetFriend(Id);

        public List<Friend> GetFriendList() => new FriendControl(settings).GetList();

        public void AddFriend(Friend friend) => new FriendControl(settings).AddFriend(friend);

        public List<Friend> GetNearFriends(int Id) => new FriendControl(settings).GetNearFriends(Id);

        public void SetNearFriends(Friend value) => new FriendControl(settings).SetNearFriends(value);
    }
}
