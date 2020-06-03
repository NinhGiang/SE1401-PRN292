using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Level
    {
        protected String _id;
        protected String _name;

        public String id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Level() { }

        public Level(String id, String name)
        {
            _id = id;
            _name = name;
        }
    }
}
