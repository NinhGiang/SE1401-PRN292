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
            _uuid = uuid ?? throw new ArgumentNullException(nameof(uuid));
            _name = name ?? throw new ArgumentNullException(nameof(name));
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
        public List<Level> CreateLevel()
        {
            String[] data = Utils.getLevelData();
            List<Level> list = new List<Level>();
            for (int i = 0; i < data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = data[i];
                Level level = new Level(uuid, name);
                list.Add(level);
            }
            return list;
        }
    }
}
