using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Attendance
    {
        protected string _teacher;
        protected string _className;
        protected string _subject;

        public Attendance(string teacher, string className, string subject)
        {
            _teacher = teacher;
            _className = className;
            _subject = subject;
        }

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public string className
        {
            get { return _className; }
            set { _className = value; }
        }
        public string Subject
        {
            get { return _subject}
            set { _subject = value; }
        }
    }
}
