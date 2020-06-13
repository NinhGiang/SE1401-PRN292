using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Grade
    {
        /// <summary>
        /// Id of subject
        /// </summary>
        protected string _subject;

        /// <summary>
        /// Id of student
        /// </summary>
        protected string _student;

        /// <summary>
        /// Grade of the subject
        /// </summary>
        protected int _grade;

        /// <value>
        /// The subject of grade
        /// </value>
        public string Subject { get { return _subject; } }

        /// <value>
        /// The student of grade
        /// </value>
        public string Student { get { return _student; } }

        /// <value>
        /// The grade
        /// </value>
        public int Grades { get { return _grade; } }

        /// <summary>
        /// An empty constructor for grade
        /// </summary>
        public Grade() { }

        /// <summary>
        /// A constructor for grade
        /// </summary>
        /// <param name="subject">A string value</param>
        /// <param name="student">A string value</param>
        /// <param name="grade">A positive integer value</param>
        public Grade(string subject, string student, int grade)
        {
            _subject = subject;
            _student = student;
            _grade = grade;
        }

        /// <summary>
        /// Creates a random list of grade of each student and returns the result
        /// </summary>
        /// <returns>An array of grade</returns>
        public static Grade[] Create()
        {
            Random rnd = new Random();

            List<Grade> result = new List<Grade>();
            List<string> listOfStudents = FileHelper.GetListOfStudent();
            foreach (string student in listOfStudents)
            {
                //student id
                string[] info = student.Split(',');
                string id = info[0].Trim();

                //subjects
                List<string> subjects = GetSubjectsByStudent(student);
                foreach (string subject in subjects)
                {
                    //subject id
                    string[] sInfo = subject.Split(',');
                    string sId = sInfo[2].Trim();

                    //random grade
                    int grade = rnd.Next(101);

                    result.Add(new Grade(sId, id, grade));
                }

            }

            return result.ToArray();
        }

        /// <summary>
        /// Get list of subject student studies
        /// </summary>
        /// <param name="student">A string value</param>
        /// <returns>List of subject string</returns>
        private static List<string> GetSubjectsByStudent(string student)
        {
            List<string> subjects;
            string[] info = student.Split(',');
            string classId = info[4].Trim();
            subjects = FileHelper.GetListOfSubjectByClass(classId);
            return subjects;
        }
    }
}
