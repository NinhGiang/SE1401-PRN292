using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Attendance
    {
        protected string _teacher;
        protected string _classInfo;
        protected string _subject;

        public Attendance(string teacher, string classInfo, string subject)
        {
            _teacher = teacher;
            _classInfo = classInfo;
            _subject = subject;
        }
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public string ClassInfo
        {
            get { return _classInfo; }
            set { _classInfo = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public static Attendance[] createAttendance()
        {
            Teacher[] teacherList = DatabaseHandler.GetTeacherList();
            Subject[] subjectList = DatabaseHandler.GetSubjectList();
        }
    }
}
