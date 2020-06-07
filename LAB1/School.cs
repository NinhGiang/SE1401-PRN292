using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private List<Student> _students_list;
        private List<Level> _level_list;

        public School() { }

        public List<Student> GetStudentList()
        { return _students_list; }

        public void SetStudentList(Student[] students)
        { _students_list = new List<Student>(students); }

        public List<Level> GetLevelList()
        { return _level_list; }

        public void SetLevelList(Level[] levels)
        { _level_list = new List<Level>(levels); }

        public void SaveStudent(string filename)
        {
            String content = "ID, Name, Birthday, Gender, Class\n";
            foreach (Student student in _students_list)
            {
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

        public void SaveLevel(string filename)
        {
            String content = "ID, Name";
            foreach (Level level in _level_list)
            {
                content += level.GetId() + ", ";
                content += level.GetName() + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
