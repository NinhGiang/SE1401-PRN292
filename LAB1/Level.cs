using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
