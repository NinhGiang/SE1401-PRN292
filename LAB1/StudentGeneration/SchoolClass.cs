using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.StudentGeneration
{
    class SchoolClass
    {
        protected string _uuid;
        protected string _level;
        protected string _room;
        protected string _name;

        public SchoolClass(string id, string level, string room, string name)
        {
            _uuid = id;
            _level = level;
            _room = room;
            _name = name;
        }

        public string ID
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
