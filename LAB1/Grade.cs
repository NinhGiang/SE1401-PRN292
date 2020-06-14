using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{

    class Grade
    {
        protected int _grade;

        protected string _subject;

        protected string _student;

        public string Subject { get { return _subject; } }


        public string Student { get { return _student; } }


        public int Grades { get { return _grade; } }


        public Grade() { }

        /// <summary>
        /// A constructor for grade
        /// </summary>
        public Grade(string subject, string student, int grade)
        {
            _subject = subject;
            _student = student;
            _grade = grade;
        }

        /// <summary>
        /// Generate a list of grade
        /// </summary>
        public static Grade[] Create()
        {
            Random rnd = new Random();

            List<Grade> result = new List<Grade>();

            List<string> StudentList= Readcsvjsonhelper.GetStudentList();

            foreach (string student in StudentList)
            {
                //student's id
                string[] info = student.Split(',');
                string studentId = info[0].Trim();

                //subjects
                List<string> subjects = Readcsvjsonhelper.GetListOfSubjectOfStudent(info);
                foreach (string subject in subjects)
                {
                    //subject id
                    string[] subjectInfo = subject.Split(',');
                    string subjectId = subjectInfo[2].Trim();

                    //random grade
                    int grade = rnd.Next(101);

                    result.Add(new Grade(subjectId, studentId, grade));
                }

            }

            return result.ToArray();
        }
       
    }
}