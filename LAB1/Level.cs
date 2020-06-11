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

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private static String jsonFile = File.ReadAllText(@"..\..\..\Configure.json");
        private static Configure config = JsonSerializer.Deserialize<Configure>(jsonFile);

        public static string[] getLevel()
        {
            return config.LevelConfig.level_set;
        }

        public static Level[] GenerateLevel()
        {
            String[] data = getLevel();
            Level[] levelList = new Level[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = data[i];
                Level level = new Level(uuid, name);
                levelList[i] = level;
            }
            return levelList;
        }
    }
}
