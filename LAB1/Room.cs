using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Room
    {
        protected String _id;
        protected String _class;
        protected int _no;

        public String id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String classInfo
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

        public Room(String id,  String classInfo, int no)
        {
            _id = id;
            _class = classInfo;
            _no = no;
        }
    }
}
