using System;

namespace LAB1
{
    public class Attendance
    {
        protected String _teacher;
        protected String _class;
        protected String _subject;

        public String teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public String classInfo
        {
            get { return _class; }
            set { _class = value; }
        }

        public String subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public Attendance() { }

        public Attendance(String teacher, String classInfo, String subject)
        {
            _teacher = teacher;
            _class = classInfo;
            _subject = subject;
        }
    }
}