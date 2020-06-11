using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace LAB1
{
    class Level
    {
        protected String _uuid;
        protected String _level_name;

        public String UUID { get { return _uuid; } }
        public String Level_name {  get { return _level_name; } }

        public Level (String UUID, String Level_name)
        {
            _uuid = UUID;
            _level_name = Level_name;
        }

        public static Level[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            String[] level_data = config.LevelConfig.level_name_set;
            Level[] result = new Level[level_data.Length];

            for(int i = 0; i < level_data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String level_name = level_data[i];
                Level level = new Level(uuid, level_name);
                result[i] = level;
            }
            return result;
        }
    }
}
