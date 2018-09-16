using System;
using System.Collections.Generic;
using System.Text;

namespace Friends.Engine.Models
{
    public class Friend
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }

        public List<Friend> Friends = new List<Friend>();
    }
}
