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

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

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
            try
            {
                string content = File.ReadAllText(@"..\..\..\Configure.json");
                config config = JsonSerializer.Deserialize<config>(content);
                LevelConfig lvl = config.LevelConfig;
                int size = lvl.Level_Set.Length;
                List<Level> result = new List<Level>();

                for (int i = 0; i < size; i++)
                {
                    string name = lvl.Level_Set[i].ToString(); //set value level
                    string id = Guid.NewGuid().ToString();
                    result[i] = new Level(id, name);

                }
                return result.ToArray();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Level _ FileNotFoundException: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Level _ NullReferenceException: " + ex.Message);
            }
            return null;
        }
    }
}
