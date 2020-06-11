using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB1.Container
{
    class StudentContainer
    {
        private List<Student> _students_list;

        public StudentContainer (Student[] student)
        {
            _students_list = new List<Student>(student);
        }

        public void StudentSave (String filename)
        {
            String content = "ID, Fullname, Birthday, Gender, Class\n";
            foreach (Student student in _students_list)
            {
                content += student.StUUID + ", " + student.StFullName + ", " + student.StBirthday + ", " + student.StGender + ", " + student.Class + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
