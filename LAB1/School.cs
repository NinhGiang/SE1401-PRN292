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

        public void SaveStudent(string filename)
        {
            String content = "ID, Name, Birthday, Gender, Class\n";
            foreach (Student student in _students_list)
            {
                //content += student.ID + ", " + student.FullName + "\n";
                content += student.GetId() + ", ";
                content += student.GetName() + ", ";
                content += student.GetBirthdate().ToString("dd/MM/yyyy") + ", ";
                if (student.GetGender() == true)
                {
                    content += "M" + ", ";
                }
                else
                {
                    content += "F" + ", ";
                }
                content += student.GetClassInfo() + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
