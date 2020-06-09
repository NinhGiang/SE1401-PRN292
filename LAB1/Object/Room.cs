using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class Room
    {
        protected string _id;
        protected string _class;
        protected int _no;

        public Room()
        {

        }

        public Room(string id, string classInfo, int no)
        {
            _id = id;
            _class = classInfo;
            _no = no;
        }
        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetClassInfo()
        { return _class; }

        public void SetClassInfo(string value)
        { _class = value; }

        public int GetNo()
        { return _no; }

        public void SetNo(int value)
        { _no = value; }

        

        
    }
}