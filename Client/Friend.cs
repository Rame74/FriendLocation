using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Client
{
    public class Friend
    {
        [Browsable(false)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }

        public List<Friend> Friends = null;
    }
}
