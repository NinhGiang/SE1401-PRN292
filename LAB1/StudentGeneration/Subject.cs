using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.StudentGeneration
{
    class Subject
    {
        protected string _UUID;
        protected string _Level;
        protected string _Field;
        protected string _Name;

        public Subject(string uuid, string level, string field, string name)
        {
            _UUID = uuid;
            _Level = level;
            _Field = field;
            _Name = name;
        }

        public string ID
        {
            get { return _UUID; }
        }

        public string Level
        {
            get { return _Level; }
            set { _Level = value; }
        }

        public string Field
        {
            get { return _Field; }
            set { _Field = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        static public List<Subject> createSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            Random rd = new Random();
            for (int i = 0; i < 3; i++)
            {
                string[] level_info = DataGetting.GetLevelData(i);
                int number_of_subjects = rd.Next(8, 11);
                for (int j = 0; j < number_of_subjects; j++)
                {
                    string uuid = System.Guid.NewGuid().ToString();
                    string level_id = level_info[0];
                    string level_name = level_info[1];
                    string[] field_info = DataGetting.GetFieldData(j);
                    string field_id = field_info[0];
                    string field_name = field_info[1];
                    subjects.Add(new Subject(uuid, level_id, field_id, field_name + level_name));
                }
            }
            return subjects;
        }
    }
}
