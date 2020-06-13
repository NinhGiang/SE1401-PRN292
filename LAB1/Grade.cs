using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Grade
    {
        private string subject;//fk
        private string student;//fk
        private int grades;

        public string Subject { get => subject; set => subject = value; }
        public string Student { get => student; set => student = value; }
        public int Grades { get => grades; set => grades = value; }

        public Grade(string subject, string student, int grade)
        {
            this.Subject = subject;
            this.Student = student;
            this.Grades = grade;
        }
    }
}
