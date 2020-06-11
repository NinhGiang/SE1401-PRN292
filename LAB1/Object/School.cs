using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.Object
{
    class School
    {
        private List<Student> _students_list;
        public School(Student[] students)
        {
            _students_list = new List<Student>(students);
        }
        public void save(string filename)
        {
            String content = "ID, Fullname\n";
            foreach (Student student in _students_list)
            {
                content += student.ID + ", " + student.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}