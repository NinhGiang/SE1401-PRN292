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

        protected string Teacher { get => teacher; set => teacher = value; }
        protected string ClassInfo { get => classInfo; set => classInfo = value; }
        protected string Subject { get => subject; set => subject = value; }

        public Attendance(string teacher, string classInfo, string subject)
        {
            this.Teacher = teacher;
            this.ClassInfo = classInfo;
            this.Subject = subject;
        }
    }
}
