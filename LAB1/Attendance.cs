using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Attendance
    {
        protected string _teacher;
        protected string _class;
        protected string _subject;

        public Attendance(string teacher, string @class, string subject)
        {
            _teacher = teacher;
            _class = @class;
            _subject = subject;
        }

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
