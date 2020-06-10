using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected String _level;
        protected String _field;

        public String Level_info { get { return _level; } }
        public String Field_info { get { return _field; } }

        public Subject (String Level_info, String Field_info) 
        {
            _level = Level_info;
            _field = Field_info;
        }
    }
}
