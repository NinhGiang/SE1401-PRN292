using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Level
    {
        protected string _uuid;
        protected string _name;

        public string Uuid
        {
            get { return _uuid; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Level(string Uuid, string Name)
        {
            _uuid = Uuid;
            _name = Name;
        }
        public static Level[] createLevel()
        {
            int level_size = RandomGenerator.GetLevelLength();
            Level[] result = new Level[level_size];
            for (int i = 0; i < level_size; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                string name = RandomGenerator.GetLevelData(i);
                result[i] = new Level(uuid, name);
            }
            return result;
        }
    }
}
