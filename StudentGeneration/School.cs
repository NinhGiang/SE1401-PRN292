using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace StudentGeneration
{
    class School
    {
        private List<Student> _students_list;
        public List<Student> Students {get { return _students_list; } }
        public School(Student[] students)
        {
            _students_list = new List<Student>(students);
        }
        public void save(string filename)
        {
            if(Path.GetExtension(filename) == ".csv")
            {
                String content = "ID, Fullname\n";
                foreach (Student student in _students_list)
                {
                    content += student.ID + ", " + student.FullName + "\n";
                }
                File.WriteAllText(filename, content);
            } else if (Path.GetExtension(filename) == ".json")
            {

                String content = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(filename, content);
            }

        }
    }
}
