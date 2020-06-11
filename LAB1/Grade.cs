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

        public Grade(string subject, string student, int grade)
        {
            _subject = subject;
            _student = student;
            _grade = grade;
        }
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
        public int Grades
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public static Grade[] CreateGrade()
        {
            Student[] studentList = DatabaseHandler.getStudentIDClassList();
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
