using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private List<Student> _students_list;
        public School(Student[] students)
        {
            _students_list = new List<Student>(students);
        }
        public string createSchoolDir(String schoolName)
        {
            string dir = Directory.CreateDirectory(@"..\..\..\" + schoolName).FullName;
            Console.WriteLine(dir);
            return dir;
        }
        public void save(string filename)
        {
            String content = "ID, Fullname\n";
            foreach (Student student in _students_list)
            {
                content += student.ID + ", " + student.UUID + ", " + student.FullName + ", " + student.Birthday + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
