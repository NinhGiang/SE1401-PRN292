using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private List<Student> _students_list;
        private List<Room> _room_list;
        private List<ClassInfo> _class_list;
        private List<Level> _level_list;

        public School() { }

        public School(Student[] studentList, Room[] roomList, ClassInfo[] classList, Level[] levelList)
        {
            _students_list = new List<Student>(studentList);
            _room_list = new List<Room>(roomList);
            _class_list = new List<ClassInfo>(classList);
            _level_list = new List<Level>(levelList);
        }

        public List<Student> GetStudents { get { return _students_list; } }
        public void SetStudents(Student[] student) { _students_list = new List<Student>(student); }

        public List<Room> GetRooms { get { return _room_list; } }
        public void SetRooms(Room[] room) { _room_list = new List<Room>(room); }

        public List<Level> GetLevels { get { return _level_list; } }
        public void SetLevels(Level[] levels) { _level_list = new List<Level>(levels); }

        public List<ClassInfo> GetClasses { get { return _class_list; } }
        public void SetClasses(ClassInfo[] student) { _class_list = new List<ClassInfo>(student); }

        public void saveStudent(string filename)
        {
            String content = "ID, Fullname, Birthday, Gender, ClassID\n";
            try
            {
                if (_students_list == null)
                {
                    _students_list = new List<Student>();
                }
                foreach (Student student in _students_list)
                {
                    content += student.ID + " | " + student.FullName + " | " + student.Birthday + " | " + student.Gender + " | "
                        + student.ClassID + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("School.cs _ saveStudent(): " + ex.Message);
            }
        }

        public void saveRoom(String filename)
        {
            string content = "ID, Class, No\n";
            try
            {
                if (_room_list == null)
                {
                    _room_list = new List<Room>();
                }
                foreach (Room room in _room_list)
                {
                    content += room.UUID + " | " + room.ClassInfo + " | " + room.No + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("School.cs _ saveRoom: " + ex.Message);
            }
        }

        public void saveLevel(string filename)
        {
            string content = "ID, Name\n";
            try
            {
                if (_level_list == null)
                {
                    _level_list = new List<Level>();
                }
                foreach (Level level in _level_list)
                {
                    content += level.Uuid + " | " + level.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error in saveLevel:" + ex.Message);
            }
        }

        public void saveClasses(string filename)
        {
            string content = "ID, Level, Room, Name\n";
            try
            {
                if (_class_list == null)
                {
                    _class_list = new List<ClassInfo>();
                }                    
                foreach (ClassInfo classes in _class_list)
                {
                    content += classes.UUID + ", ";
                    content += classes.Level + ", ";
                    content += classes.Room + ", ";
                    content += classes.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error in saveClasses: " + ex.Message);
            }
        }
    }
}
