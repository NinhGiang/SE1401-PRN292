using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private List<Student> _students_list;
        private List<Teacher> _teacher_list;
        private List<Level> _level_list;
        private List<Field> _field_list;
        private List<Room> _room_list;
        private List<ClassInfo> _class_list;
        private List<Subject> _subject_list;
        private List<Attendance> _attendance_list;

        public School() { }

        public List<Student> GetStudentList()
        { return _students_list; }

        public void SetStudentList(Student[] students)
        { _students_list = new List<Student>(students); }

        public List<Teacher> GetTeacherList()
        { return _teacher_list; }

        public void SetTeacherList(Teacher[] teachers)
        { _teacher_list = new List<Teacher>(teachers); }

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

        public List<ClassInfo> GetClassList()
        { return _class_list; }

        public void SetClassList(ClassInfo[] classes)
        { _class_list = new List<ClassInfo>(classes); }

        public List<Subject> GetSubjectList()
        { return _subject_list; }

        public void SetSubjectList(Subject[] subject)
        { _subject_list = new List<Subject>(subject); }

        public void SetAttendanceList(Attendance[] attendance)
        { _attendance_list = new List<Attendance>(attendance); }

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
        public void SaveTeacher(string filename)
        {
            string content = "ID, Name, Gender, Field\n";
            foreach (Teacher teacher in _teacher_list)
            {
                content += teacher.GetId() + ", ";
                content += teacher.GetName() + ", ";
                if (teacher.GetGender() == true)
                {
                    content += "M" + ", ";
                }
                else
                {
                    content += "F" + ", ";
                }
                content += teacher.GetField() + "\n";
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

        public void SaveClass(String filename)
        {
            string content = "ID, Level, Room, Name\n";
            foreach (ClassInfo classInfo in _class_list)
            {
                content += classInfo.GetId() + ", ";
                content += classInfo.GetLevel() + ", ";
                content += classInfo.GetRoom() + ", ";
                content += classInfo.GetName() + "\n";
            }
            File.WriteAllText(filename, content);
        }

        public void SaveSubject(String filename)
        {
            string content = "ID, Level, Field, Name\n";
            foreach (Subject subject in _subject_list)
            {
                content += subject.GetId() + ", ";
                content += subject.GetLevel() + ", ";
                content += subject.GetField() + ", ";
                content += subject.GetName() + "\n";
            }
            File.WriteAllText(filename, content);
        }

        public void SaveAttendance(String filename)
        {
            string content = "Teacher, Class, Subject\n";
            foreach (Attendance attendance in _attendance_list)
            {
                content += attendance.GetTeacher() + ", ";
                content += attendance.GetClassInfo() + ", ";
                content += attendance.GetSubject() + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
