using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LAB1
{
    class School
    {
        private List<Student> _students_list;
        private List<Level> _levels_list;
        private List<Class> _classes_list;
        private List<Room> _rooms_list;
        private List<Field> _fields_list;
        private List<Subject> _subjects_list;
        private List<Teacher> _teachers_list;
        public School(Student[] students, Level[] levels, Class[] classes, Room[] rooms)
        {
            _students_list = new List<Student>(students);
            _levels_list = new List<Level>(levels);
            _classes_list = new List<Class>(classes);
            _rooms_list = new List<Room>(rooms);
        }
        public List<Student> StudentList { get { return _students_list; } set { _students_list = value; } }
        public List<Level> LevelList { get { return _levels_list; } set { _levels_list = value; } }
        public List<Class> ClassList { get { return _classes_list; } set { _classes_list = value; } }
        public List<Room> RoomList { get { return _rooms_list; } set { _rooms_list = value; } }
        public List<Field> FieldList { get { return _fields_list; } set { _fields_list = value; } }
        public List<Subject> SubjectList { get { return _subjects_list; } set { _subjects_list = value; } }
        public List<Teacher> TeacherList { get { return _teachers_list; } set { _teachers_list = value; } }
        public School()
        {
        }
        public string createSchoolDir(String schoolName)
        {
            string dir = Directory.CreateDirectory(@"..\..\..\" + schoolName).FullName;
            Console.WriteLine(dir);
            return dir;
        }
        //Save student list
        public void saveStudent(string filename)
        {
            String content = "UUID, Name, Gender, Birthday, Class\n";
            if (Path.GetExtension(filename) == ".csv")
            {

                foreach (Student student in _students_list)
                {
                    content += student.UUID + ", " + student.Name + ", " + student.Gender + ", " + student.Birthday + ", " + student.Class + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._students_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
        //Save level list
        public void saveLevel(string filename)
        {
            String content = "UUID, Name\n";
            if (Path.GetExtension(filename) == ".csv")
            {

                foreach (Level level in _levels_list)
                {
                    content += level.UUID + ", " + level.Name + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._levels_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
        //Save room list
        public void saveRoom(string filename)
        {
            String content = "UUID, Class, No\n";
            if (Path.GetExtension(filename) == ".csv")
            {

                foreach (Room room in _rooms_list)
                {
                    content += room.UUID + ", " + room.Class + ", " + room.No + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._rooms_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
        //Save class list
        public void saveClass(string filename)
        {
            String content = "Level, UUID, Room, Name\n";
            if (Path.GetExtension(filename) == ".csv")
            {

                foreach (Class cls in _classes_list)
                {
                    content += cls.Level + ", " + cls.UUID + ", " + cls.Room + ", " + cls.Name + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._classes_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
        //Save field list
        public void saveField(string filename)
        {
            String content = "UUID, Name\n";
            if (Path.GetExtension(filename) == ".csv")
            {

                foreach (Field fld in _fields_list)
                {
                    content += fld.UUID + ", " + fld.Name + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._fields_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
        //Save subject list
        public void saveSubject(string filename)
        {
            String content = "Level, Field, Name\n";
            if (Path.GetExtension(filename) == ".csv")
            {
                foreach (Subject sbj in _subjects_list)
                {
                    content += sbj.Level + ", " + sbj.Field + ", " + sbj.Name + "\n";
                }
            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._subjects_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }

        //Save teacher list
        public void saveTeacher(string filename)
        {
            String content = "UUID, Name, Gender, Field\n";
            if (Path.GetExtension(filename) == ".csv")
            {
                foreach (Teacher tchr in _teachers_list)
                {
                    content += tchr.UUID + ", " + tchr.Name + ", " + tchr.Gender + ", " + tchr.Field + "\n";
                }
            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this._teachers_list, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
        }
    }
}