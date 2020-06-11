using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected String _level;
        protected String _field;
        protected String _sub_name;

        public String Level_info { get { return _level; } }
        public String Field_info { get { return _field; } }
        public String SubName { get { return _sub_name; } }

        public Subject(String Level_info, String Field_info, String SubName)
        {
            _level = Level_info;
            _field = Field_info;
            _sub_name = SubName;
        }

        public static Subject[] Create(Level[] level, Field[] field)
        {
            int n = level.Length * field.Length;
            Subject[] result = new Subject[n];
            for(int i = 0; i < n; i++)
            {
                String level_info = level[i].Level_name;
                String field_info = field[i].Name;
                String sub_name = level_info + " " + field_info;
                result[i] = new Subject(level_info, field_info, sub_name);
            }
            return result;
        }
    }
}
