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

        public string Uuid { get { return uuid; } }
        public string Name { get { return name; } }

        public Level(string newUUID, string newName)
        {
            uuid = newUUID;
            name = newName;
        }

        public static List<Level> CreateLevel()
        {
            List<Level> levelList = new List<Level>();
            string configContent = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(configContent);
            LevelConfigure levelConfig = config.LevelConfig;
            for (int i = 0; i < levelConfig.level_name_set.Length; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                string levelName = levelConfig.level_name_set[i];
                levelList.Add(new Level(uuid, levelName));
            }
            return levelList;
        }
        public static void SaveLevel(List<Level> levelList)
        {
            String content = "UUID, Name";
            foreach (Level level in levelList)
            {
                content += "\n" + level.Uuid + ", " + level.Name;
            }
            File.WriteAllText(@"..\..\..\Levels.csv", content);
        }
    }
}
