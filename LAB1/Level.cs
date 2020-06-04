using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Level
    {
        protected string _id;
        protected string _name;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Level() { }

        public Level(string id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
