using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Grade
    {
        protected string _subject;
        protected string _student;
        protected int _grade;
        private static Random rnd = new Random();
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public string Student
        {
            get { return _student; }
            set { _student = value; }
        }
        public int GradeNumb
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public Grade() { }
        public Grade(string subject, string student, int grade)
        {
            _subject = subject;
            _student = student;
            _grade = grade; 
        }
        public static Grade[] createGrade()
        {
            List<Grade> result = new List<Grade>();
            List<string> studentList = ListStorage.GetTeacherList();
            foreach (string student in studentList)
            {
                //student id
                string[] info = student.Split(',');
                string id = info[0].Trim();
                List<string> subjects = ListStorage.GetSubjectsByStudent(student);
                foreach (string subject in subjects)
                {
                    string[] subjectInfo = subject.Split(',');
                    string sId = subjectInfo[2].Trim();

                    //random grade
                    int grade = rnd.Next(101);

                    result.Add(new Grade(sId, id, grade));
                }
                }
                return result.ToArray();
        }
    } 
}
