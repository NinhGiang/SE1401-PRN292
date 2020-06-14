using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace LAB1
{

    class School
    {
        private List<Teacher> _teacherList;
        private List<Class> _classList;
        private List<Level> _levelList;
        private List<Field> _fieldList;
        private List<Room> _roomList;
        private List<Attendance> _attendanceList;
        private List<Subject> _subjectList;
        private List<Grade> _gradelist;
        private List<Student> _studentList;
        private string _schoolName;

        public School() { }

        public School(string schoolName)
        {
            _schoolName = schoolName;
        }

        public List<Student> Student { get { return _studentList; } }
        public List<Teacher> Teacher { get { return _teacherList; } }
        public List<Level> Level { get { return _levelList; } }
        public List<Field> Field { get { return _fieldList; } }
        public List<Room> Room { get { return _roomList; } }
        public List<Class> Classe { get { return _classList; } }
        public List<Subject> Subject { get { return _subjectList; } }
        public List<Attendance> Attendance { get { return _attendanceList; } }
        public List<Grade> Grade { get { return _gradeList; } }


        public void SetStudentList(Student[] students)
        { _studentList = new List<Student>(students); }


        public void SetTeacherList(Teacher[] teachers)
        { _teacherList = new List<Teacher>(teachers); }


        public void SetLevelList(Level[] levels)
        { _levelList = new List<Level>(levels); }


        public void SetFieldList(Field[] fields)
        { _fieldList = new List<Field>(fields); }


        public void SetRoomList(Room[] rooms)
        { _roomList = new List<Room>(rooms); }


        public void SetClassList(Class[] classes)
        { _classList = new List<Class>(classes); }


        public void SetSubjectList(Subject[] subject)
        { _subjectList = new List<Subject>(subject); }


        public void SetAttendanceList(Attendance[] attendance)
        { _attendanceList = new List<Attendance>(attendance); }


        public void SetGradeList(Grade[] grade)
        { _gradeList = new List<Grade>(grade); }



        public void SaveStudent(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "UUID, Name, Birthday, Gender, Class";
                w.WriteLine(content);
                w.Flush();
                foreach (Student student in _studentList)
                {
                    string line = string.Format("{0},{1},{2},{3},{4}", student.ID, student.FullName, student.Birth.ToString("dd/MM/yyyy"), student.Gender, student.Class);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveTeacher(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "UUID, Name, Gender, Field";
                w.WriteLine(content);
                w.Flush();
                foreach (Teacher teacher in _teacherList)
                {
                    string line = string.Format("{0},{1},{2},{3}", teacher.ID, teacher.Name, teacher.Gender, teacher.Field);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveLevel(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "UUID, Name";
                w.WriteLine(content);
                w.Flush();
                foreach (Level level in _levelList)
                {
                    string line = string.Format("{0},{1}", level.GetUuid(), level.GetName());
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveField(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "UUID, Name";
                w.WriteLine(content);
                w.Flush();
                foreach (Field field in _fieldList)
                {
                    string line = string.Format("{0},{1}", Field.GetUuid(), Field.GetName());
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveRoom(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "UUID, Class, No.";
                w.WriteLine(content);
                w.Flush();
                foreach (Room room in _roomList)
                {
                    string line = string.Format("{0},{1},{3}", room.GetUuid(), room.GetClass(), room.GetNo());
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveClass(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "UUID, Level, Room, Name";
                w.WriteLine(content);
                w.Flush();
                foreach (Class classIn in _classList)
                {
                    string line = string.Format("{0},{1},{3},{4}", classIn.GetId(), classIn.GetLevel(), classIn.GetRoom(), classIn.GetName());
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveSubject(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "UUID, Level, Field, Name";
                w.WriteLine(content);
                w.Flush();
                foreach (Subject subject in _subjectList)
                {
                    string line = string.Format("{0},{1},{3},{4}", subject.GetUuid(), subject.GetLevel(), subject.GetField(), subject.GetName());
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveAttendance(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "Teacher, Class, Subject";
                w.WriteLine(content);
                w.Flush();
                foreach (Attendance attendance in _attendanceList)
                {
                    string line = string.Format("{0},{1},{3}", attendance.Teacher, attendance.Class, attendance.Subject);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveGrade(string path)
        {
            File.Create(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                string content = "Subject, Student, Grade";
                w.WriteLine(content);
                w.Flush();
                foreach (Grade grade in _gradeList)
                {
                    string line = string.Format("{0},{1},{3}", grade.Subject, grade.Student, grade.Grades);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }


        public void SaveSchool(string path)
        {
            string content = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filename, content);
        }
    }
}