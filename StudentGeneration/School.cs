using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace StudentGeneration
{
    class School
    {
        private List<Student> _students_list;
        //public List<Student> Schools { get { return _students_list;}}

        public School(Student[] students)
        {
            _students_list = new List<Student>(students);
        }
        public void save(string filename)
        {
            String content = "";
            if (Path.GetExtension(filename) == ".csv")
            {
                content += "ID, Fullname\n";
                foreach (Student student in _students_list)
                {
                    content += student.ID + ", " + student.FullName + "\n";
                }
            } 
            else if(Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this);
            }
            File.WriteAllText(filename, content);
        }
    }
}
