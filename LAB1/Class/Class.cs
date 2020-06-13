using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Class
    {
        protected string _level;
        protected string _uuid;
        protected string _room;
        protected string _name;

        public Class(string level, string uuid, string room, string name)
        {
            _level = level;
            _uuid = uuid;
            _room = room;
            _name = name;
        }
        public string Level { get { return _level; } set { _level = value; } }
        public string UUID { get { return _uuid; } set { _uuid = value; } }
        public string Room { get { return _room; } set { _room = value; } }
        public string Name { get { return _name; } set { _name = value; } }
    }
}
