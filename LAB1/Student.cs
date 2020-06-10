using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Student
    {
        protected string stuID;
        protected string fullname;
        protected DateTime birthday;
        protected Boolean gender;
        protected string stuClass;

        public string StuID { get { return stuID; } }
        public string Fullname { get { return fullname; } set { fullname = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public Boolean Gender { get { return gender; } set { gender = value; } }
        public string StuClass { get { return stuClass; } }

        protected Student(string StuID, string FullName, DateTime Birthday, Boolean Gender, string StuClass)
        {
            stuID = StuID;
            fullname = FullName;
            birthday = Birthday;
            gender = Gender;
            stuClass = StuClass;
        }
        protected Student() { }


    }
}
