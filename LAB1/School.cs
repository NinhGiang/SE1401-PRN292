using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        /// <summary>
        /// name of the school
        /// </summary>
        private string school_name;

        /// <summary>
        /// list of levels (10,11,12)
        /// </summary>
        private List<Level> level_list;

        /// <summary>
        /// list of field (math, english, ...)
        /// </summary>
        private List<Field> field_list;

        /// <summary>
        /// list of subject
        /// </summary>
        private List<Subject> subject_list;

        /// <summary>
        /// list of teacher
        /// </summary>
        private List<Teacher> teacher_list;

        /// <summary>
        /// list of room
        /// </summary>
        private List<Room> room_list;

        /// <summary>
        /// list of class
        /// </summary>
        private List<Class> class_list;

        /// <summary>
        /// list of student
        /// </summary>
        private List<Student> student_list;

        /// <summary>
        /// list of grades
        /// </summary>
        private List<Grade> grade_list;

        /// <summary>
        /// list of attendance
        /// </summary>
        private List<Attendance> attendance_list;

        /// <summary>
        /// empty constructor 
        /// </summary>
        public School()
        {

        }

        /// <summary>
        /// school constructor
        /// </summary>
        /// <param name="school_name"></param>
        public School(string school_name)
        {
            this.School_name = school_name;
        }

        public string School_name { get => school_name; set => school_name = value; }
        public List<Student> Students { get { return student_list; } }
        public List<Teacher> Teachers { get { return teacher_list; } }
        public List<Level> Levels { get { return level_list; } }
        public List<Field> Fields { get { return field_list; } }
        public List<Room> Rooms { get { return room_list; } }
        public List<Class> Classes { get { return class_list; } }
        public List<Subject> Subjects { get { return subject_list; } }
        public List<Attendance> Attendances { get { return attendance_list; } }
        public List<Grade> Grades { get { return grade_list; } }

        /// <summary>
        /// Sets list of students
        /// </summary>
        /// <param name="students">An array of Student</param>
        public void SetStudentList(Student[] students)
        { student_list = new List<Student>(students); }

        /// <summary>
        /// Sets list of teachers
        /// </summary>
        /// <param name="teachers">An array of Teacher</param>
        public void SetTeacherList(Teacher[] teachers)
        { teacher_list = new List<Teacher>(teachers); }

        /// <summary>
        /// Sets list of levels
        /// </summary>
        /// <param name="levels">An array of Level</param>
        public void SetLevelList(Level[] levels)
        { level_list = new List<Level>(levels); }

        /// <summary>
        /// Sets list of fields
        /// </summary>
        /// <param name="fields">An array of Field</param>
        public void SetFieldList(Field[] fields)
        { field_list = new List<Field>(fields); }

        /// <summary>
        /// Sets list of rooms
        /// </summary>
        /// <param name="rooms">An array of Room</param>
        public void SetRoomList(Room[] rooms)
        { room_list = new List<Room>(rooms); }

        /// <summary>
        /// Sets list of classes
        /// </summary>
        /// <param name="classes">An array of Class</param>
        public void SetClassList(Class[] classes)
        { class_list = new List<Class>(classes); }

        /// <summary>
        /// Sets list of subjects
        /// </summary>
        /// <param name="subject">An array of Subject</param>
        public void SetSubjectList(Subject[] subject)
        { subject_list = new List<Subject>(subject); }

        /// <summary>
        /// Sets list of attendance
        /// </summary>
        /// <param name="attendance">An array of Attendance</param>
        public void SetAttendanceList(Attendance[] attendance)
        { attendance_list = new List<Attendance>(attendance); }

        /// <summary>
        /// Sets list of grades
        /// </summary>
        /// <param name="grade">An array of Grade</param>
        public void SetGradeList(Grade[] grade)
        { grade_list = new List<Grade>(grade); }


        /// <summary>
        /// Save list of student to .csv file
        /// </summary>
        /// <param name="filename">A string value</param>
        public void SaveStudent(string filename)
        {
            string content = "UUID, Name, Birthday, Gender, Class\n";
            foreach (Student student in student_list)
            {
                content += student.Id + ", ";
                content += student.Name + ", ";
                content += student.Birthday.ToString("dd/MM/yyyy") + ", ";
                content += student.Gender + ", ";
                content += student.Classname + "\n";
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
            foreach (Teacher teacher in teacher_list)
            {
                content += teacher.Id + ", ";
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
            foreach (Level level in level_list)
            {
                content += level.Id + ", ";
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
            foreach (Field field in field_list)
            {
                content += field.Id + ", ";
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
            foreach (Room room in room_list)
            {
                content += room.Id + ", ";
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
            foreach (Class classInfo in class_list)
            {
                content += classInfo.Id + ", ";
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
            foreach (Subject subject in subject_list)
            {
                content += subject.Id + ", ";
                content += subject.Level + ", ";
                content += subject.Field + "\n ";
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
            foreach (Attendance attendance in attendance_list)
            {
                content += attendance.Teacher + ", ";
                content += attendance.ClassInfo + ", ";
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
            foreach (Grade grade in grade_list)
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
