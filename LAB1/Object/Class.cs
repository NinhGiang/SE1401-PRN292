using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.Object
{
    class Class
    {
        protected string _id;
        protected string _level;
        protected string _room;
        protected string _name;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
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
