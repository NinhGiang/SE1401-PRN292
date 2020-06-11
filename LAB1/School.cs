using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private string _school_name;
        private List<Level> _level_list;
        private List<Field> _field_list;
        private List<Subject> _subject_list;
        private List<Teacher> _teacher_list;
        private List<Room> _room_list;
        private List<Class> _class_list;
        private List<Student> _student_list;

        public School()
        {
        }
        public string SchoolName
        {
            get { return _school_name; }
            set { _school_name = value; }
        }
        public Level[] LevelList
        {
            set { _level_list = new List<Level>(value); }
        }
        public Field[] FieldList
        {
            set { _field_list = new List<Field>(value); }
        }
        public Subject[] SubjectList
        {
            set { _subject_list = new List<Subject>(value); }
        }
        public Teacher[] TeacherList
        {
            set { _teacher_list = new List<Teacher>(value); }
        }
        public Room[] RoomList
        {
            set { _room_list = new List<Room>(value); }
        }
        public Class[] ClassList
        {
            set { _class_list = new List<Class>(value); }
        }
        public Student[] StudentList
        {
            set { _student_list = new List<Student>(value); }
        }

        public void SaveLevel(String filename)
        {
            String content = "ID, Name\n";
            try
            {
                if (_level_list == null)
                {
                    _level_list = new List<Level>();
                }
                foreach (Level level in _level_list)
                {
                    content += level.UUID + ", ";
                    content += level.Name + "\n";
                }
                File.WriteAllText(filename, content);
            } catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveLevel : " + ex.Message);
            }
        }
        public void SaveField(String filename)
        {
            String content = "ID, Name\n";
            try
            {
                if (_field_list == null)
                {
                    _field_list = new List<Field>();
                }
                foreach (Field field in _field_list)
                {
                    content += field.UUID + ", ";
                    content += field.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveField : " + ex.Message);
            }
        }
        public void SaveSubject(String filename)
        {
            String content = "ID, Name, Level, Field\n";
            try
            {
                if (_subject_list == null)
                {
                    _subject_list = new List<Subject>();
                }
                foreach (Subject subject in _subject_list)
                {
                    content += subject.UUID + ", ";
                    content += subject.Name + ", ";
                    content += subject.Level + ", ";
                    content += subject.Field + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveSubject : " + ex.Message);
            }
        }
        public void SaveTeacher(String filename)
        {
            String content = "ID, Name, Gender, Field\n";
            if (_teacher_list == null)
            {
                _teacher_list = new List<Teacher>();
            }
            try
            {
                foreach (Teacher teacher in _teacher_list)
                {
                    content += teacher.UUID + ", ";
                    content += teacher.Name + ", ";
                    if (teacher.Gender)
                    {
                        content += "M" + ", ";
                    }
                    else content += "F" + ", ";
                    content += teacher.Field + "\n";
                }
                File.WriteAllText(filename, content);
            }
            
            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveTeacher : " + ex.Message);
            }
        }
        public void SaveRoom(String filename)
        {
            String content = "ID, Class, No\n";
            if (_room_list == null)
            {
                _room_list = new List<Room>();
            }
            try
            {
                foreach (Room room in _room_list)
                {
                      content += room.UUID + ", ";
                      content += room.ClassInfo + ", ";
                      content += room.No + "\n"; 
                }
                File.WriteAllText(filename, content);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveRoom : " + ex.Message);
            }
        }
        public void SaveClass(String filename)
        {
            String content = "ID, Level, Room, Name\n";
            if (_class_list == null)
            {
                _class_list = new List<Class>();
            }
            try
            {
                foreach (Class classInfo in _class_list)
                {
                    content += classInfo.UUID + ", ";
                    content += classInfo.Level + ", ";
                    content += classInfo.Room + ", ";
                    content += classInfo.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveClass : " + ex.Message);
            }
        }
        public void SaveStudent(String filename)
        {
            String content = "ID, Name, Birthday, Gender, Class\n";
            if (_student_list == null)
            {
                _student_list = new List<Student>();
            }
            try
            {
                foreach (Student student in _student_list)
                {
                    content += student.UUID + ", ";
                    content += student.Name + ", ";
                    content += student.Birthday + ", ";
                    if (student.Gender)
                    {
                        content += "M" + ", ";
                    }
                    else content += "F" + ", ";
                    content += student.Class + "\n";
                }
                File.WriteAllText(filename, content);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveStudent : " + ex.Message);
            }
        }
    }
}
