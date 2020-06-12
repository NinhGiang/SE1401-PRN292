using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LAB1
{
    class School
    {
        private List<Student> _students_list;
        private List<Level> _levels_list;
        public School(Student[] students, Level[] levels)
        {
            _students_list = new List<Student>(students);
            _levels_list = new List<Level>(levels);
        }
        public string createSchoolDir(String schoolName)
        {
            string dir = Directory.CreateDirectory(@"..\..\..\" + schoolName).FullName;
            Console.WriteLine(dir);
            return dir;
        }
        //Save student list
        public void saveStudent(string filename)
        {
            String content = "UUID, Fullname, Gender, Birthday\n";
            if (Path.GetExtension(filename) == ".csv")
            {

                foreach (Student student in _students_list)
                {
                    content += student.UUID + ", " + student.FullName + ", " + student.Gender + ", " + student.Birthday + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._students_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
        //Save level list
        public void saveLevel(string filename)
        {
            String content = "UUID, Name\n";
            if (Path.GetExtension(filename) == ".csv")
            {

                foreach (Level level in _levels_list)
                {
                    content += level.UUID + ", " + level.Name + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._students_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
    }
}
