using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    class Level
    {
        protected string _uuid;
        protected string _name;
        public string Name { get { return _name; } }
        public string ID { get { return _uuid; } }
        protected Level(string ID, string Name)
        {
            _uuid = ID;
            _name = Name;
        }
    
        
    public static Level[] Create(int number_level)
        {
            Level[] result = new Level[number_level];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for (int i = 0; i < number_level; i++)
            {
                LevelConfig a = config.LevelConfig;
                int level_name_index = rnd.Next(a.level_name_set.Length);
                string name = a.level_name_set[level_name_index];

            }
            return result;


        }

        public void print()
        {
            Console.WriteLine(_uuid + 1 + " " + _name);
        }
    }

    }

