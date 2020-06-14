using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// School Class
    /// Contains methods and properties for School
    /// </summary>
    class School
    {
        /// <summary>
        /// School name
        /// </summary>
        private string _school_name;
        /// <summary>
        /// List of Level
        /// </summary>
        private List<Level> _level_list;
        /// <summary>
        /// List of Field
        /// </summary>
        private List<Field> _field_list;
        /// <summary>
        /// List of Subject
        /// </summary>
        private List<Subject> _subject_list;
        /// <summary>
        /// List of Teacher
        /// </summary>
        private List<Teacher> _teacher_list;
        /// <summary>
        /// List of Room
        /// </summary>
        private List<Room> _room_list;
        /// <summary>
        /// List of Class
        /// </summary>
        private List<Class> _class_list;
        /// <summary>
        /// List of Student
        /// </summary>
        private List<Student> _student_list;
        /// <summary>
        /// List of Grace
        /// </summary>
        private List<Grade> _grade_list;
        /// <summary>
        /// List of Attendance
        /// </summary>
        private List<Attendance> _attendance_list;
        
        /// <summary>
        /// Empty constructor for school
        /// </summary>
        public School()
        {
        }
        /// <summary>
        /// getter and setter for school name
        /// </summary>
        public string SchoolName
        {
            get { return _school_name; }
            set { _school_name = value; }
        }
        /// <summary>
        /// getter and setter for level list
        /// </summary>
        public Level[] LevelList
        {
            get { return _level_list.ToArray(); }
            set { _level_list = new List<Level>(value); }
        }
        /// <summary>
        /// getter and setter for field list
        /// </summary>
        public Field[] FieldList
        {
            get { return _field_list.ToArray(); }
            set { _field_list = new List<Field>(value); }
        }
        /// <summary>
        /// getter and setter for subject list
        /// </summary>
        public Subject[] SubjectList
        {
            get { return _subject_list.ToArray(); }
            set { _subject_list = new List<Subject>(value); }
        }
        /// <summary>
        /// getter and setter for teacher list
        /// </summary>
        public Teacher[] TeacherList
        {
            get { return _teacher_list.ToArray(); }
            set { _teacher_list = new List<Teacher>(value); }
        }
        /// <summary>
        /// getter and setter for room list
        /// </summary>
        public Room[] RoomList
        {
            get { return _room_list.ToArray(); }
            set { _room_list = new List<Room>(value); }
        }
        /// <summary>
        /// getter and setter for class list
        /// </summary>
        public Class[] ClassList
        {
            get { return _class_list.ToArray(); }
            set { _class_list = new List<Class>(value); }
        }
        /// <summary>
        /// getter and setter for student list
        /// </summary>
        public Student[] StudentList
        {
            get { return _student_list.ToArray(); }
            set { _student_list = new List<Student>(value); }
        }
        /// <summary>
        /// getter and setter for grade list
        /// </summary>
        public Grade[] GradeList
        {
            get { return _grade_list.ToArray(); }
            set { _grade_list = new List<Grade>(value); }
        }
        /// <summary>
        /// getter and setter for attendance list
        /// </summary>
        public Attendance[] AttendanceList
        {
            get { return _attendance_list.ToArray(); }
            set { _attendance_list = new List<Attendance>(value); }
        }
        /// <summary>
        /// Save Level list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
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
        /// <summary>
        /// Save Field list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
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
        /// <summary>
        /// Save Subject list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
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
        /// <summary>
        /// Save Teacher list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
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
        /// <summary>
        /// Save Room list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
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
        /// <summary>
        /// Save Teacher list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
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
        /// <summary>
        /// Save Student list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
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
        /// <summary>
        /// Save Grade list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
        public void SaveGrade(String filename)
        {
            String content = "Subject, Student, Grade\n";
            if (_grade_list == null)
            {
                _grade_list = new List<Grade>();
            }
            try
            {
                foreach (Grade grade in _grade_list)
                {
                    content += grade.Subject + ", ";
                    content += grade.Student + ", ";
                    content += grade.Grades + "\n";
                }
                File.WriteAllText(filename, content);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveClass : " + ex.Message);
            }
        }
        /// <summary>
        /// Save Attendance list into a file
        /// </summary>
        /// <param name="filename">string value (name and path)</param>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when encounter null reference
        /// </exception>
        public void SaveAttendance(String filename)
        {
            String content = "Teacher, Class, Subject\n";
            if (_attendance_list == null)
            {
                _attendance_list = new List<Attendance>();
            }
            try
            {
                foreach (Attendance attendance in _attendance_list)
                {
                    content += attendance.Teacher + ", ";
                    content += attendance.ClassInfo + ", ";
                    content += attendance.Subject + "\n";
                }
                File.WriteAllText(filename, content);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("SaveAttendance : " + ex.Message);
            }
        }
        public void SaveSchool (string filename)
        {
            
        }
    }
}
