using System;
using System.Collections.Generic;
using System.Text;

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

        
    }
}
