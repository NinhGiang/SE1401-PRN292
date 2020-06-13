using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.StudentGeneration
{
    class Room
    {
        protected string _id;
        protected string _class;
        protected int _no;

        public Room() { }

        public Room(string id, string school_class, int no)
        {
            _id = id;
            _class = school_class;
            _no = no;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Class_using
        {
            get { return _class; }
            set { _class = value; }
        }

        public int No
        {
            get { return _no; }
            set { _no = value; }
        }
        
        public static List<Room> createRoomRandomly(uint number_of_rooms)
        {
            List<Room> rooms = new List<Room>();
            for (int i = 0; i < number_of_rooms; i++)
            {
                string uuid = System.Guid.NewGuid().ToString();
                string class_using = System.Guid.NewGuid().ToString();
                int room_number = i + 1;
                rooms.Add(new Room(uuid, class_using, room_number));
            }
            return rooms;
        }
    }
}
