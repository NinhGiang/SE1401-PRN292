using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Class
    {
        protected string _uuid;
        protected string _level;
        protected string _room;
        protected string _name;

        public Class(string uuid, string level, string room, string name)
        {
            _uuid = uuid ?? throw new ArgumentNullException(nameof(uuid));
            _level = level ?? throw new ArgumentNullException(nameof(level));
            _room = room ?? throw new ArgumentNullException(nameof(room));
            _name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
