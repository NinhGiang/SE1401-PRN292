using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ProgramManagerStudent
{
    public class Level
    {
        private string uuid;
        private string name;
        private static List<Level> levelList;

        public string Uuid { get { return uuid; } }

        public string Name { get { return name; } }

        public static List<Level> LevelList{ get{ return levelList;} }
        public Level(string newUUID, string newName)
        {
            uuid = newUUID;
            name = newName;
        }

        public static void Create()
        {
            if (levelList == null)
            {
                levelList = new List<Level>();
            }
            string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            LevelConfig levelConfig = config.LevelConfig;
            for (int i = 0; i < levelConfig.level_name_set.Length; i++)
            {
                string levelName = levelConfig.level_name_set[i];
                Level level = new Level(Guid.NewGuid().ToString(), levelName);
                levelList.Add(level);
            }
        }
    }
}
