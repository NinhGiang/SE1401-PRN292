using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LAB1
{
    class Room
    {
        protected string _uuid;
        protected string _class;
        protected int _no;
        public Room(string uuid, string class_uuid, int no)
        {
            _uuid = uuid;
            _class = class_uuid;
            _no = no;
        }
        public string UUID { get { return _uuid; } set { _uuid = value; } }
        public string Class { get { return _class; } set { _class = value; } }
        public int No { get { return _no; } set { _no = value; } }
        

        public static Room[] Create(uint number_room)
        {
            Room[] result = new Room[number_room];
            string content_class = File.ReadAllText(@"..\..\..\Whatever\Classes.json");
            List<Class> classes = JsonConvert.DeserializeObject<List<Class>>(content_class);
            string content_temp_room = File.ReadAllText(@"..\..\..\Room\RoomConfigure.json");
            List<Room> temp_rooms = JsonConvert.DeserializeObject<List<Room>>(content_temp_room);
            foreach (Room room in temp_rooms)
            {
                foreach (Class cls in classes)
                {
                    if (cls.Room == room.UUID)
                    {
                        room.Class = cls.UUID;
                    }
                }
            }
            result = temp_rooms.ToArray();
            return result;
        }
        public void print()
        {
            Console.WriteLine(_uuid + " | " + _class + " | " + _no);
        }
    }
}

