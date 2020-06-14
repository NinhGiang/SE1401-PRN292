using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LAB1
{
    class Class
    {
        protected string _level;
        protected string _uuid;
        protected string _room;
        protected string _name;

        public Class(string level, string uuid, string room, string name)
        {
            _level = level;
            _uuid = uuid;
            _room = room;
            _name = name;
        }
        public string Level { get { return _level; } set { _level = value; } }
        public string UUID { get { return _uuid; } set { _uuid = value; } }
        public string Room { get { return _room; } set { _room = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public static Class[] Create(uint number_class)
        {
            CreateTempRoom(number_class);
            //Get room (temp) list from RoomConfigure.json
            string content_room = File.ReadAllText(@"..\..\..\Room\RoomTemp.json");
            List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(content_room);
            //Get level list from Levels.json
            string content_level = File.ReadAllText(@"..\..\..\Whatever\Levels.json");
            List<Level> levels = JsonConvert.DeserializeObject<List<Level>>(content_level);
            Level[] level_list = levels.ToArray();
            Class[] result = new Class[number_class];
            int count = 0;
            foreach (Room rm in rooms)
            {
                string uuid = RandomGenerator.randUUID();
                string room = rm.UUID;
                string name = rm.Class;
                string level;
                if (name.Contains("10"))
                {
                    level = level_list[0].UUID;
                }
                else if (name.Contains("11"))
                {
                    level = level_list[1].UUID;
                }
                else
                {
                    level = level_list[2].UUID;
                }
                result[count] = new Class(level, uuid, room, name);
                count++;
            }
            return result;
        }
        public static void CreateTempRoom(uint number_room)
        {
            List<Room> result = new List<Room>();
            string content = File.ReadAllText(@"..\..\..\Class\ClassConfigure.json");
            ClassConfigure config_class = JsonSerializer.Deserialize<ClassConfigure>(content);
            int count = 0;
            for (uint i = 0; i < (number_room % 3 == 0 ? number_room / 3 : number_room / 3 + 1); i++)
            {
                //generate level name (fixed 3 levels
                if (count < number_room)
                {
                    string id = RandomGenerator.randUUID();
                    result.Add(new Room(id, config_class.ClassNameConfig.grade_10_name_set[i], count));
                    count++;
                }
                if (count < number_room)
                {
                    string id = RandomGenerator.randUUID();
                    result.Add(new Room(id, config_class.ClassNameConfig.grade_11_name_set[i], count));
                    count++;
                }
                if (count < number_room)
                {
                    string id = RandomGenerator.randUUID();
                    result.Add(new Room(id, config_class.ClassNameConfig.grade_12_name_set[i], count));
                    count++;
                }
            }
            string content_temp = JsonConvert.SerializeObject(result, Formatting.Indented);
            File.WriteAllText(@"..\..\..\Room\RoomConfigure.json", content_temp);
        }
    }
}
