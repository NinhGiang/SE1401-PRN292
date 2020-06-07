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
        private List<Field> _field_list;
        private List<Room> _room_list;

        public School() { }

        public List<Student> GetStudentList()
        { return _students_list; }

        public void SetStudentList(Student[] students)
        { _students_list = new List<Student>(students); }

        public List<Level> GetLevelList()
        { return _level_list; }

        public void SetLevelList(Level[] levels)
        { _level_list = new List<Level>(levels); }

        public List<Field> GetFieldList()
        { return _field_list; }

        public void SetFieldList(Field[] fields)
        { _field_list = new List<Field>(fields); }

        public List<Room> GetRoomList()
        { return _room_list; }

        public void SetRoomList(Room[] rooms)
        { _room_list = new List<Room>(rooms); }

        public void SaveStudent(string filename)
        {
            string content = "ID, Name, Birthday, Gender, Class\n";
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
            string content = "ID, Name\n";
            foreach (Level level in _level_list)
            {
                content += level.GetId() + ", ";
                content += level.GetName() + "\n";
            }
            File.WriteAllText(filename, content);
        }

        public void SaveField(string filename)
        {
            string content = "ID, Name\n";
            foreach (Field field in _field_list)
            {
                content += field.GetId() + ", ";
                content += field.GetName() + "\n";
            }
            File.WriteAllText(filename, content);
        }

        public void SaveRoom(String filename)
        {
            string content = "ID, Class, No.\n";
            foreach (Room room in _room_list)
            {
                content += room.GetId() + ", ";
                content += room.GetClassInfo() + ", ";
                content += room.GetNo() + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
