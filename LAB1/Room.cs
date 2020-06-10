using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class Room
    {
        protected string _uuid;
        protected string _class;
        protected int _no;

        public Room() { }

        public Room(string uuid, string classInfo, int no)
        {
            _uuid = uuid;
            _class = classInfo;
            _no = no;
        }

        public string UUID { get { return _uuid;  } set { _uuid = value; } }
        public string ClassInfo { get { return _class; } set { _class = value; } }
        public int No { get { return _no; } set { _no = value; } }
         
        public static Room[]  Create(uint _noOfRoom)
        {
            Room[] room = new Room[_noOfRoom];
            for (int i = 0; i < _noOfRoom; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                String class_info = Guid.NewGuid().ToString();
                int no = i + 1;
                room[i] = new Room(uuid, class_info, no);
            }
            return room;
        }
    }
} 