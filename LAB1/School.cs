using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private string schoolName;

        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        public School()
        {

        }

        private List<Level> _level_list;
        public Level[] Levels
        {
            get { return _level_list.ToArray(); }
            set { _level_list = new List<Level>(value); }
        }

        private List<Field> _field_list;
        public Field[] Fields
        {
            get { return _field_list.ToArray(); }
            set { _field_list = new List<Field>(value); }
        }

        public void saveLevels(string filename)
        {
            string content = "UUID, Name\n";
            if (_level_list == null)
            {
                _level_list = new List<Level>();
            }
            foreach(Level level in _level_list)
            {
                content += level.UUID + ", " + level.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }

        public void saveFields(string filename)
        {
            string content = "UUID, Name\n";
            if (_field_list == null)
            {
                _field_list = new List<Field>();
            }
            foreach (Field field in _field_list)
            {
                content += field.UUID + ", " + field.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
