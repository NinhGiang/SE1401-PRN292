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

        public static Room[] Create(int number_room)
        {
            List<Room> result = new List<Room>();
            Random rd = new Random();
            for (uint i = 0; i < number_room; i++)
            {
                int no = (int)i + 1;
                string id = Guid.NewGuid().ToString(P); // Generate random UUID V4 (32 bits) start with '{' and end with '}'
                string classInfo = "N/A";
                result.Add(new Room(id, classInfo, no));
            }
            return result.ToArray();
        }

    }
}