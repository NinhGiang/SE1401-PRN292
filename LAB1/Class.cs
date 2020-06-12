using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Class
    {
        protected string _id;
        protected string _level;
        protected string _room;
        protected string _name;

        public string ID
        {
            get
            {
                return _id;
            }
        }
        public string Level
        {
            get
            {
                return _level;
            }
        }
        public string Room
        {
            get
            {
                return _room;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public Class(string ID, string level, string Room, string Name)
        {
            _id = ID;
            _level = level;
            _room = Room;
            _name = Name;
        }
        public static Class[] Create()
        {
            List<string> ClassList = DataH
        }


    }
}
