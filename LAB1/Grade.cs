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

        public static Grade[] GradeCreate(Student[] student, Subject[] subject)
        {
            Random rnd = new Random();
            int n = rnd.Next(30, 51);
            int subLength = subject.Length;
            Grade[] result = new Grade[n];
            for (int i = 0; i < n; i++)
            {
                String stuName = student[i].StFullName.ToString();
                int grade = rnd.Next(101);
                String sub_name = subject[rnd.Next(subLength)].SubName.ToString();
                result[i] = new Grade(sub_name, stuName, grade);
            }
            return result;
        }
    }
}
