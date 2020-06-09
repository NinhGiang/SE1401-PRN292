using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.DataGeneration
{
    class Room
    {
        protected string _uuid;
        protected string _class;
        protected int _no;

        public Room()
        {

        }
        public Room(string uuid, string classInfo, int no)
        {
            _uuid = uuid;
            _class = classInfo;
            _no = no;
        }
        public string Uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Class_info
        {
            get { return _class; }
            set { _class = value; }
        }

        public int No
        {
            get { return _no; }
            set { _no = value; }
        }
        public static Room[] createRoom(uint number_room)
        {
            Room[] result = new Room[number_room];
            //string content = File.ReadAllText(@"..\..\..\DataGeneration.database.json");
            for (int i = 0; i < number_room; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String class_taken = Guid.NewGuid().ToString();
                int no = i+1;
                result[i] = new Room(uuid, class_taken, no);
            }
            return result;
        }
    }

}
