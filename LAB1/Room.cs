using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Room
    {
        protected string _id;
        protected string _class;
        protected int _no;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string classInfo
        {
            get { return _class; }
            set { _class = value; }
        }

        public int no
        {
            get { return _no; }
            set { _no = value; }
        }

        public Room() { }

        public Room(string id,  string classInfo, int no)
        {
            _id = id;
            _class = classInfo;
            _no = no;
        }
    }
}
