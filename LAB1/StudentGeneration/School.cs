using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.StudentGeneration
{
    class School
    {
        private List<Student> students;
        public School(Student[] students)
        {
            this.students = new List<Student>(students);
        }
        public void save(string filename)
        {
            String content = "ID, Fullname\n";
            foreach (Student student in students)
            {
                content += student.ID + ", " + student.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
