using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB1.Container
{
    class TeacherContainer
    {
        private List<Teacher> _teacher_list;

        public TeacherContainer(Teacher[] teacher)
        {
            _teacher_list = new List<Teacher>(teacher);
        }

        public void TeacherSave (String filename)
        {
            String content = "ID, Fullname, Gender, Field\n";
            foreach (Teacher teacher in _teacher_list)
            {
                content += teacher.TcUUID + ", " + teacher.TcFullName + ", " + teacher.TcGender + ", " + teacher.Field_info + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
