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
        protected Student(string StuID, string FullName)
        {
            stuID = StuID;
            fullname = FullName;
        }
            public static Student[] CreateStudent(uint numberOfStudent)
        {
            Student[] studentList = new Student[numberOfStudent];
            string content = File.ReadAllText(@"..\..\..\SystemConfigure.json");
            SystemConfigure config = JsonSerializer.Deserialize<SystemConfigure>(content);

            Random ran = new Random();
            for (uint i = 0; i < numberOfStudent; i++)
            {
                // uuid
                string uuid = Guid.NewGuid().ToString();
                // fullname
                StuNameConfig con = config.StuNameConfig;
                int ranGender = ran.Next(10);
                int maleLastNameIndex = ran.Next(con.maleFirstNameSet.Length);
                int femaleLastNameIndex = ran.Next(con.femaleFirstNameSet.Length);
                int middleNameIndex = ran.Next(con.middleNameSet.Length);
                int firstNameIndex = ran.Next(con.lastNameSet.Length);
                string fullName = "";
                if (ranGender % 2 == 1)
                {
                    fullName = con.lastNameSet[firstNameIndex] + " "
                        + con.middleNameSet[middleNameIndex] + " "
                        + con.maleFirstNameSet[maleLastNameIndex] + " ";
                }
                else
                {
                    fullName = con.lastNameSet[firstNameIndex] + " "
                        + con.middleNameSet[middleNameIndex] + " "
                        + con.femaleFirstNameSet[femaleLastNameIndex] + " ";
                }
                
                studentList[i] = new Student(uuid, fullName);
                // birthday
                
            }

            return studentList;
        }
    }
}
