using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Attendence
    {
        protected String _teacher;
        protected String _class;
        protected String _subject;

        public String Teacher { get { return _teacher; } }
        public String Class_info { get { return _class; } }
        public String Subject { get { return _subject; } }

        public Attendence (String teacher, String class_info, String subject)
        {
            _teacher = teacher;
            _class = class_info;
            _subject = subject;
        }


    }
}
