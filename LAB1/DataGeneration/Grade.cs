using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Grade
    {
        protected string _subject;
        protected string _student;
        protected string _grade;
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
        public string GradeNumb
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public Grade() { }
        public Grade(string subject, string student, string grade)
        {
            _subject = subject;
            _student = student;
            _grade = grade; 
        }
    } 
}
