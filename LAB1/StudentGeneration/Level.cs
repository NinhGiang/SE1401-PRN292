using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1.StudentGeneration
{
    class Level
    {
        protected string _uuid;
        protected string _name;

        public Level(string id, string name)
        {
            _uuid = id;
            _name = name;
        }

        public string ID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static List<Level> createLevels(uint number_of_levels)
        {
            List<Level> levels = new List<Level>();
            String content = File.ReadAllText(@"..\..\..\StudentGeneration\dataset.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            for (int i = 0; i < number_of_levels; i++)
            {
                string id = System.Guid.NewGuid().ToString();
                string name = config.LevelDataSet.LevelSet[i];
                levels.Add(new Level(id, name));
            }
            
            return levels;
        }
    }
}
