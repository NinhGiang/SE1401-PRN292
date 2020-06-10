using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Grade
    {
        protected string _subject;
        protected string _student;
        protected int _grade;

        public void SetSubject(string value)
        {
            _subject = value;
        }

        public void SetStudent(string value)
        {
            _student = value;
        }

        public void SetGrade(int value)
        {
            _grade = value;
        }

        public string GetSubject()
        {
            return _subject;
        }

        public string GetStudent()
        {
            return _student;
        }

        public int GetGrade()
        {
            return _grade;
        }

        public Grade() { }

        public Grade(string subject, string student, int grade)
        {
            _subject = subject;
            _student = student;
            _grade = grade;
        }

        public static Grade[] Create()
        {
            Random rnd = new Random();

            List<Grade> result = new List<Grade>();
            List<string> listOfStudents = DataHelper.GetListOfStudent();
            foreach (string student in listOfStudents)
            {
                //student id
                string[] info = student.Split(',');
                string id = info[0].Trim() + " (" + info[2].Trim() + ")";

                //subjects
                List<string> subjects = GetSubjectsByStudent(student);
                foreach (string subject in subjects)
                {
                    //subject id
                    string[] sInfo = subject.Split(',');
                    string sId = sInfo[2].Trim();

                    //random grade
                    int grade = rnd.Next(0, 100);

                    result.Add(new Grade(sId, id, grade));
                }

            }

            return result.ToArray();
        }

        private static List<string> GetSubjectsByStudent(string student)
        {
            List<string> subjects;
            string[] info = student.Split(',');
            string classId = info[4].Trim();
            subjects = DataHelper.GetListOfSubjectByClass(classId);
            return subjects;
        }
    }
}
