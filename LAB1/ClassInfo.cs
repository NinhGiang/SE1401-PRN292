using System;

namespace LAB1
{
    public class ClassInfo
    {
        protected String _level;
        protected String _room;
        protected String _name;

        public String level
        {
            get { return _level; }
            set { _level = value; }
        }

        public String room
        {
            get { return _room; }
            set { _room = value; }
        }

        public String name
        {
            get { return _name; }
            set { _name = value; }
        }
        public ClassInfo() { }

        public ClassInfo(String level, String room, String name)
        {
            _level = level;
            _room = room;
            _name = name;
        }
    }
}