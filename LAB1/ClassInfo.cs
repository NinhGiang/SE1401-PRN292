using System;

namespace LAB1
{
    public class ClassInfo
    {
        protected string _level;
        protected string _room;
        protected string _name;

        public string GetLevel()
        { return _level; }

        public void SetLevel(string value)
        { _level = value; }

        public string GetRoom()
        { return _room; }

        public void SetRoom(string value)
        { _room = value; }

        public string GetName()
        { return _name; }

        public void SetName(string value)
        { _name = value; }

        public ClassInfo() { }

        public ClassInfo(string level, string room, string name)
        {
            _level = level;
            _room = room;
            _name = name;
        }


    }
}