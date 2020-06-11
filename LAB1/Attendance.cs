using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Attendance
    {
        public String Teacher, Class, Subject;

        public Attendance(String Teacher , String Class , String Subject)
        {
            this.Teacher = Teacher;
            this.Class = Class;
            this.Subject = Subject;
        }

        public String GetTeacher()
        {
            return this.Teacher;
        }

        public void SetTeacher(String Teacher)
        {
            this.Teacher = Teacher;
        }

        public String GetClass()
        {
            return this.Class;
        }

        public void SetClass(String Class)
        {
            this.Class = Class;
        }

        public String GetSubject()
        {
            return this.Subject;
        }

        public void SetSubject(String Subject)
        {
            this.Subject = Subject;
        }

    }
}
