using System;

namespace LAB1
{
    public class ClassInfo
    {
        protected string _level;
        protected string _room;
        protected string _name;

        public string level
        {
            get { return _level; }
            set { _level = value; }
        }

        public string room
        {
            get { return _room; }
            set { _room = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public ClassInfo() { }

        public ClassInfo(string level, string room, string name)
        {
            _level = level;
            _room = room;
            _name = name;
        }
    }
}