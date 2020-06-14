using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected String _uuid;
        protected String _level;
        protected String _field;
        protected String _sub_name;

        public String UUID { get { return _uuid; } }
        public String Level_info { get { return _level; } }
        public String Field_info { get { return _field; } }
        public String SubName { get { return _sub_name; } }

        public Subject(String UUID, String SubName, String Level_info, String Field_info )
        {
            _uuid = UUID;
            _level = Level_info;
            _field = Field_info;
            _sub_name = SubName;
        }

        public static Subject[] Create(Level[] level, Field[] field)
        {
            int n = level.Length * field.Length;
            Subject[] result = new Subject[n];
            int s = 0;
            
            for(int i = 0; i < field.Length; i++)
            {
                for(int j = 0; j < level.Length; j++)
                {
                    String id = Guid.NewGuid().ToString();
                    String level_info = level[j].UUID;
                    String field_info = field[i].UUID;
                    String sub_name = field[i].Name + " " + level[j].Level_name;
                    result[s] = new Subject(id, sub_name, level_info, field_info);
                    s++;
                }
            }
            return result;
        }
    }
}
