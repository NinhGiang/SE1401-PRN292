using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Level
    {
        private string id;
        private string name;

        protected string Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }

        public Level()
        {

        }

        public Level(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public static Level[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            config config = JsonSerializer.Deserialize<config>(content);
            LevelConfig lvl = config.LevelConfig;
            int size = lvl.Level_Set.Length;
            Level[] result = new Level[size];

            for (int i = 0; i < size; i++)
            {
                string name = lvl.Level_Set[i].ToString();
                string id = Guid.NewGuid().ToString();
                result[i] = new Level(id, name);
                
            }
            return result;
        }
    }
}
