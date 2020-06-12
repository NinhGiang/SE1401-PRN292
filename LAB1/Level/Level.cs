using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Level
    {
        protected string _uuid;
        protected string _name;

        public Level(string uuid, string name)
        {
            _uuid = uuid;
            _name = name;
        }
        public string UUID { get { return _uuid; } set { _uuid = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public static Level[] Create(uint number_level)
        {
            Level[] result = new Level[number_level];
            string content = File.ReadAllText(@"..\..\..\Level\LevelConfigure.json");
            LevelConfigure config = JsonSerializer.Deserialize<LevelConfigure>(content);
            for (uint i = 0; i < number_level; i++)
            {
                //generate random uuid
                string id = RandomGenerator.randUUID();
                //generate level name (fixed 3 levels)
                string level_name = config.LevelNameConfig.level_name_set[i];
                result[i] = new Level(id, level_name);
            }
            return result;
        }

        public void print()
        {
            Console.WriteLine(_uuid + " | " + _name);
        }
    }
}
