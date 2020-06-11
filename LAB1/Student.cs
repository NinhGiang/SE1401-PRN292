using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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

        public static Student[] CreateStudent(uint numberOfStudent)
        {
            Student[] studentList = new Student[numberOfStudent];
            string content = File.ReadAllText(@"..\..\..\StudentConfigure.json");
            SystemConfigure config = JsonSerializer.Deserialize<SystemConfigure>(content);

            Random ran = new Random();
            for (uint i = 0; i < numberOfStudent; i++)
            {
                StuNameConfig con = config.StuNameConfig;
                int gender = ran.Next(10);
                int maleLastNameIndex = ran.Next(con.maleLastNameSet.Length);
                int femaleLastNameIndex = ran.Next(con.femaleLastNameSet.Length);
                int firstNameIndex = ran.Next(con.firstNameSet.Length);
                int middleNameIndex = ran.Next(con.middleNameSet.Length);
                string fullName = con.maleLastNameSet[maleLastNameIndex] + " ";
                fullName += con.middleNameSet[middleNameIndex] + " ";
                fullName += con.firstNameSet[firstNameIndex];
                studentList[i] = new Student(i.ToString(), fullName);

                string aaaa = Guid.NewGuid().ToString();
            }

            return studentList;
        }
    }
}
