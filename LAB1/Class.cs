using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Class
    {
        protected String _level;
        protected String _room;
        protected String _class_name;

        public String Level_info { get { return _level; } }
        public String Room_info { get { return _room; } }
        public String Class_name { get { return _class_name; } }

        public Class (String Level_info, String Room_info, String Class_name)
        {
            _level = Level_info;
            _room = Room_info;
            _class_name = Class_name;
        }
    }
}
