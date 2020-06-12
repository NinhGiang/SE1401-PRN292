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
        private uint numbOfClass;

        public string Uuid { get { return uuid; } }
        public string Name { get { return name; } }

        public uint NumbOfClass { get { return numbOfClass; } }

        public Level(string uuid, string name, uint numbOfClass)
        {
            this.uuid = uuid;
            this.name = name;
            this.numbOfClass = numbOfClass;
        }

        public static List<Level> CreateLevel(uint numbOfRoom)
        {
            List<Level> levelList = new List<Level>();
            string configContent = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(configContent);
            LevelConfigure levelConfig = config.LevelConfig;
            for (int i = levelConfig.level_name_set.Length; i > 0 ; i--)
            {
                uint numbOfClass = (uint) Math.Ceiling((double)numbOfRoom / i);
                numbOfRoom -= numbOfClass;
                string uuid = Guid.NewGuid().ToString();
                string levelName = levelConfig.level_name_set[levelConfig.level_name_set.Length - i];
                levelList.Add(new Level(uuid, levelName, numbOfClass));
            }
            return levelList;
        }
        public static void SaveLevel(List<Level> levelList)
        {
            String content = "UUID, Name, Number of Class";
            foreach (Level level in levelList)
            {
                content += "\n" + level.Uuid + ", " + level.Name + ", " + level.NumbOfClass;
            }
            File.WriteAllText(@"..\..\..\Levels.csv", content);
        }
    }
}
