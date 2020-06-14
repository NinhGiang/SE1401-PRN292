using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Grade class
    /// Contains properties and methods of Grade
    /// </summary>
    class Grade
    {
        /// <summary>
        /// Subject ID
        /// </summary>
        protected string _subject;
        /// <summary>
        /// Student ID
        /// </summary>
        protected string _student;
        /// <summary>
        /// Grade number
        /// </summary>
        protected int _grade;
        /// <summary>
        /// Constructor for Grade
        /// </summary>
        /// <param name="subject">String value</param>
        /// <param name="student">String value</param>
        /// <param name="grade">Integer</param>
        public Grade(string subject, string student, int grade)
        {
            _subject = subject;
            _student = student;
            _grade = grade;
        }
        /// <summary>
        /// getter and setter for Subject ID
        /// </summary>
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        /// <summary>
        /// getter and setter for Student ID
        /// </summary>
        public string Student
        {
            get { return _student; }
            set { _student = value; }
        }
        /// <summary>
        /// getter and setter for grade 
        /// </summary>
        public int Grades
        {
            get { return _grade; }
            set { _grade = value; }
        }
        /// <summary>
        /// Create a list of Grade and return result
        /// </summary>
        /// <returns>Return an array of Grade</returns>
        public static Grade[] CreateGrade()
        {
            Student[] studentList = DatabaseHandler.GetStudentIDClassList();
            Random rand = new Random();
            List<Grade> list = new List<Grade>();
            //Grade[] list = new Grade[studentList.Length];
            foreach (Student student in studentList)
            {
                String level = DatabaseHandler.GetClassLevelByID(student.Class);
                String[] subjectIDList =  DatabaseHandler.GetSubjectIDByLevelList(level);
                foreach (string subject in subjectIDList)
                {
                    list.Add(new Grade(subject, student.UUID, rand.Next(101)));
                }
            }
            return list.ToArray();
        }
    }
}
