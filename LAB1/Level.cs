using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    public class Level
    {
        protected string _id;
        protected string _name;

        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetName()
        { return _name; }

        public void SetName(string value)
        { _name = value; }

        public Level() { }

        public Level(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public static Level[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            LevelNameConfig _ = config.LevelNameConfig;

            int size = _.level_name_set.Length;
            Level[] result = new Level[size];

            for (int i = 0; i < size; i++)
            {
                string name = _.level_name_set[i].ToString();
                string id = Guid.NewGuid().ToString();
                result[i] = new Level(id, name);
            }
            return result;
        }
    }


}
