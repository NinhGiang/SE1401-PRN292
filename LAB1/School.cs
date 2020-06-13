using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private List<Level> _level_list;
        public List<Level> Levels
        {
            get { return _level_list; }
        }
        public void SetLevel(Level[] levels)
        {
            _level_list = new List<Level>(levels);
        }

        private List<Field> _field_list;
        public List<Field> Fields
        {
            get { return _field_list; }
        }
        public void SetField(Field[] fields)
        {
            _field_list = new List<Field>(fields);
        }

        public void saveLevels(string filename)
        {
            string content = "UUID, Name\n";
            foreach(Level level in _level_list)
            {
                content = level.UUID + ", " + level.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }

        public void saveFields(string filename)
        {
            string content = "UUID, Name\n";
            foreach (Field field in _field_list)
            {
                content = field.UUID + ", " + field.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
