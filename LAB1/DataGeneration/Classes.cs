using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Classes
    {
        protected string _uuid;
        protected string _level;
        protected string _room;
        protected string _name;

        public string Uuid
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
