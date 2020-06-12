using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Grade
    {
        private string subject;//fk
        private string student;//fk
        private int grade;

        protected string Subject { get => subject; set => subject = value; }
        protected string Student { get => student; set => student = value; }
        protected int Grade { get => grade; set => grade = value; }

        public Grade(string subject, string student, int grade)
        {
            this.Subject = subject;
            this.Student = student;
            this.Grade = grade;
        }
    }
}
