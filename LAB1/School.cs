using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace LAB1
{
    /// <summary>
    /// The School class.
    /// Contains methods to save file.
    /// </summary>
    class School
    {
        /// <summary>
        /// The name of the school
        /// </summary>
        private string _school_name;

        /// <summary>
        /// The list of student
        /// </summary>
        private List<Student> _students_list;

        /// <summary>
        /// The list of teacher
        /// </summary>
        private List<Teacher> _teachers_list;

        /// <summary>
        /// The list of level
        /// </summary>
        private List<Level> _levels_list;

        /// <summary>
        /// The list of field
        /// </summary>
        private List<Field> _fields_list;

        /// <summary>
        /// The list of room
        /// </summary>
        private List<Room> _rooms_list;

        /// <summary>
        /// The list of class
        /// </summary>
        private List<Class> _classes_list;

        /// <summary>
        /// The list of subject
        /// </summary>
        private List<Subject> _subjects_list;

        /// <summary>
        /// The list of attendance
        /// </summary>
        private List<Attendance> _attendances_list;

        /// <summary>
        /// The list of grade
        /// </summary>
        private List<Grade> _grades_list;

        /// <summary>
        /// An empty constructor for school
        /// </summary>
        public School() { }

        /// <summary>
        /// A constructor for school
        /// </summary>
        /// <param name="schoolName">A string value</param>
        public School(string schoolName)
        {
            _school_name = schoolName;
        }

        public List<Student> Students { get { return _students_list; } }
        public List<Teacher> Teachers { get { return _teachers_list; } }
        public List<Level> Levels { get { return _levels_list; } }
        public List<Field> Fields { get { return _fields_list; } }
        public List<Room> Rooms { get { return _rooms_list; } }
        public List<Class> Classes { get { return _classes_list; } }
        public List<Subject> Subjects { get { return _subjects_list; } }
        public List<Attendance> Attendances { get { return _attendances_list; } }
        public List<Grade> Grades { get { return _grades_list; } }

        /// <summary>
        /// Sets list of students
        /// </summary>
        /// <param name="students">An array of Student</param>
        public void SetStudentList(Student[] students)
        { _students_list = new List<Student>(students); }

        /// <summary>
        /// Sets list of teachers
        /// </summary>
        /// <param name="teachers">An array of Teacher</param>
        public void SetTeacherList(Teacher[] teachers)
        { _teachers_list = new List<Teacher>(teachers); }

        /// <summary>
        /// Sets list of levels
        /// </summary>
        /// <param name="levels">An array of Level</param>
        public void SetLevelList(Level[] levels)
        { _levels_list = new List<Level>(levels); }

        /// <summary>
        /// Sets list of fields
        /// </summary>
        /// <param name="fields">An array of Field</param>
        public void SetFieldList(Field[] fields)
        { _fields_list = new List<Field>(fields); }

        /// <summary>
        /// Sets list of rooms
        /// </summary>
        /// <param name="rooms">An array of Room</param>
        public void SetRoomList(Room[] rooms)
        { _rooms_list = new List<Room>(rooms); }

        /// <summary>
        /// Sets list of classes
        /// </summary>
        /// <param name="classes">An array of Class</param>
        public void SetClassList(Class[] classes)
        { _classes_list = new List<Class>(classes); }

        /// <summary>
        /// Sets list of subjects
        /// </summary>
        /// <param name="subject">An array of Subject</param>
        public void SetSubjectList(Subject[] subject)
        { _subjects_list = new List<Subject>(subject); }

        /// <summary>
        /// Sets list of attendance
        /// </summary>
        /// <param name="attendance">An array of Attendance</param>
        public void SetAttendanceList(Attendance[] attendance)
        { _attendances_list = new List<Attendance>(attendance); }

        /// <summary>
        /// Sets list of grades
        /// </summary>
        /// <param name="grade">An array of Grade</param>
        public void SetGradeList(Grade[] grade)
        { _grades_list = new List<Grade>(grade); }


        /// <summary>
        /// Save list of student to .csv file
        /// </summary>
        /// <param name="filename">A string value</param>
        public void SaveStudent(string filename)
        {
            string content = "UUID, Name, Birthday, Gender, Class\n";
            foreach (Student student in _students_list)
            {
                content += student.UUID + ", ";
                content += student.Name + ", ";
                content += student.Birthday.ToString("dd/MM/yyyy") + ", ";
                content += student.Gender + ", ";
                content += student.Class + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of teacher to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveTeacher(string filename)
        {
            string content = "UUID, Name, Gender, Field\n";
            foreach (Teacher teacher in _teachers_list)
            {
                content += teacher.UUID + ", ";
                content += teacher.Name + ", ";
                content += teacher.Gender + ", ";
                content += teacher.Field + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of level to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveLevel(string filename)
        {
            string content = "UUID, Name\n";
            foreach (Level level in _levels_list)
            {
                content += level.UUID + ", ";
                content += level.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of field to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveField(string filename)
        {
            string content = "UUID, Name\n";
            foreach (Field field in _fields_list)
            {
                content += field.UUID + ", ";
                content += field.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of room to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveRoom(string filename)
        {
            string content = "UUID, Class, No.\n";
            foreach (Room room in _rooms_list)
            {
                content += room.UUID + ", ";
                content += room.Class + ", ";
                content += room.No + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of class to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveClass(string filename)
        {
            string content = "UUID, Level, Room, Name\n";
            foreach (Class classInfo in _classes_list)
            {
                content += classInfo.UUID + ", ";
                content += classInfo.Level + ", ";
                content += classInfo.Room + ", ";
                content += classInfo.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of subject to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveSubject(string filename)
        {
            string content = "UUID, Level, Field, Name\n";
            foreach (Subject subject in _subjects_list)
            {
                content += subject.UUID + ", ";
                content += subject.Level + ", ";
                content += subject.Field + ", ";
                content += subject.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of attendance to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveAttendance(string filename)
        {
            string content = "Teacher, Class, Subject\n";
            foreach (Attendance attendance in _attendances_list)
            {
                content += attendance.Teacher + ", ";
                content += attendance.Class + ", ";
                content += attendance.Subject + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// Save list of grade to .csv file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveGrade(string filename)
        {
            string content = "Subject, Student, Grade\n";
            foreach (Grade grade in _grades_list)
            {
                content += grade.Subject + ", ";
                content += grade.Student + ", ";
                content += grade.Grades + "\n";
            }
            File.WriteAllText(filename, content);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public void SaveSchool(string filename)
        {
            string content = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filename, content);
        }
    }
}
