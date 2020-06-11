using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Grade
    {
        protected String _subject;
        protected String _student;
        protected int _grade;
        
        public String Subject_info { get { return _subject; } }
        public String Student_info { get { return _student; } }
        public int Grade_info { get { return _grade; } }
        
        public Grade (String Subject_info, String Student_info, int Grade_info)
        {
            _student = Student_info;
            _subject = Subject_info;
            _grade = Grade_info;
        }

        public static Grade[] Create(Student[] student, Subject[] subject)
        {
            Grade[] result = new Grade[4];

            return result;
        }
    }
}
