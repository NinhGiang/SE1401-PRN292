using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Room
    {
        protected String uuid;
        protected int No;
        protected String class_info;

        public String UUID { get { return uuid; } }
        public int RNum {  get { return No; } }
        public String Class_info {  get { return class_info; } }

        public Room(String id, int num, String _class_info)
        {
            uuid = id;
            No = num;
            class_info = _class_info;
        }

        public static Room[] Create (int num_rooms, Class[] _class) 
        {
            Room[] result = new Room[num_rooms];
            for(int i = 0; i < num_rooms; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String class_info = _class[i].Class_name;
                int No = i+1;
                result[i] = new Room(uuid, No, class_info);
            }
            return result;
        }
    } 
}
