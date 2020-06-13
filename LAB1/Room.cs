using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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
            string content = File.ReadAllText(@"..\..\..\Class\ClassConfigure.json");
            ClassConfigure config_class = JsonSerializer.Deserialize<ClassConfigure>(content);
            int count = 0;
            for (uint i = 0; i < (number_room % 3 == 0 ? number_room/3 : number_room/3 + 1); i++)
            {
                //generate level name (fixed 3 levels
                if (count < number_room)
                {
                    string id = RandomGenerator.randUUID();
                    result[count] = new Room(id, config_class.ClassNameConfig.grade_10_name_set[i], count);
                    count++;
                }
                if (count < number_room)
                {
                    string id = RandomGenerator.randUUID();
                    result[count] = new Room(id, config_class.ClassNameConfig.grade_11_name_set[i], count);
                    count++;
                }
                if (count < number_room)
                {
                    string id = RandomGenerator.randUUID();
                    result[count] = new Room(id, config_class.ClassNameConfig.grade_12_name_set[i], count);
                    count++;
                }
            }
            return result;
        }
        public void print()
        {
            Console.WriteLine(_uuid + " | " + _class + " | " + _no);
        }
    }
}

