using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Room
    {
        protected string _uuid;
        protected string _class;
        protected int _number;

        public Room(string uuid, string @class, int number)
        {
            _uuid = uuid;
            _class = @class;
            _number = number;
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
