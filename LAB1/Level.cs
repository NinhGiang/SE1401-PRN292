using System;
using System.Collections.Generic;
using System.Text;

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
        public static Level[] CreateLevel()
        {
            String[] data = Utils.getLevelData();
            Level[] list = new Level[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = data[i];
                Level level = new Level(uuid, name);
                list[i] = level;
            }
            return list;
        }
    }
}
