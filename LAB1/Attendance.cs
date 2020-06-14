using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Attendance class
    /// Contains properties and methods of Attendance
    /// </summary>
    class Attendance
    {
        /// <summary>
        /// ID of teacher
        /// </summary>
        protected string _teacher;
        /// <summary>
        /// ID of class
        /// </summary>
        protected string _classInfo;
        /// <summary>
        /// ID of subject
        /// </summary>
        protected string _subject;

        /// <summary>
        /// Constructor of attendance
        /// </summary>
        /// <param name="teacher">String value</param>
        /// <param name="classInfo">String value</param>
        /// <param name="subject">String value</param>
        public Attendance(string teacher, string classInfo, string subject)
        {
            _teacher = teacher;
            _classInfo = classInfo;
            _subject = subject;
        }
        /// <summary>
        /// getter and setter for teacher ID
        /// </summary>
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        /// <summary>
        /// getter and setter for class ID
        /// </summary>
        public string ClassInfo
        {
            get { return _classInfo; }
            set { _classInfo = value; }
        }
        /// <summary>
        /// getter and setter for subject ID
        /// </summary>
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        /// <summary>
        /// Create a list of Attendance data and return result
        /// </summary>
        /// <returns>return an array of Attendance</returns>
        public static Attendance[] CreateAttendance()
        {
            Teacher[] teacherList = DatabaseHandler.GetTeacherList();
            Subject[] subjectList = DatabaseHandler.GetSubjectList();
            Class[] classList = DatabaseHandler.GetClassList();

            List<Attendance> list = new List<Attendance>();

            Random rand = new Random();
            foreach (Teacher teacher in teacherList)
            {
                int number = rand.Next(4, 11);
                for (int i = 0; i < number; i++)
                {
                    Class classToTeach = classList[rand.Next(classList.Length)];
                    foreach (Subject subject in subjectList)
                    {
                        if (subject.Field.Equals(teacher.Field) & subject.Level.Equals(classToTeach.Level))
                        {
                            list.Add(new Attendance(teacher.UUID, classToTeach.UUID, subject.UUID));
                        }
                    }
                }
            }
            return list.ToArray();
        }
    }
}
