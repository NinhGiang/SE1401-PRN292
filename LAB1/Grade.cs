using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LAB1
{
    class Grade
    {
        protected String Subject, Student;
        protected int Score;

        public Grade(String Subject , String Student , int Score)
        {
            this.Subject = Subject;
            this.Student = Student;
            this.Score = Score;
        }

        public String GetSubject()
        {
            return this.Subject;
        }

        public void SetSubject(String Subject)
        {
            this.Subject = Subject;
        }

        public String GetStudent()
        {
            return this.Student;
        }

        public void SetStudent(String Student)
        {
            this.Student = Student;
        }

        public int GetScore()
        {
            return this.Score;
        }

        public void SetScore(int Score)
        {
            this.Score = Score;
        }
    }
}
