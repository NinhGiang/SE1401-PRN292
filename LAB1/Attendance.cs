using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Attendance
    {
        private string teacher;//fk
        private string classInfo;//fk
        private string subject;//fk

        public string Teacher { get => teacher; set => teacher = value; }
        public string ClassInfo { get => classInfo; set => classInfo = value; }
        public string Subject { get => subject; set => subject = value; }

        public Attendance(string teacher, string classInfo, string subject)
        {
            this.Teacher = teacher;
            this.ClassInfo = classInfo;
            this.Subject = subject;
        }
    }
}
