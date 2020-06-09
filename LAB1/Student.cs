using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;



namespace LAB1
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        protected DateTime _birthday;
        protected string _gender;
        protected string _classID;
        static Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"E:\C# and .NET\LAB1\SE1401-PRN292\LAB1\Configure.json"));
        static Random rnd = new Random();

        // create get/set method for student's class
        public string ID { get { return _id; } set { _id = value; } }
        public string FullName { get { return _fullname; } set { _fullname = value; } }
        public DateTime Birthday { get { return _birthday; } set { _birthday = value; } }
        public string Gender { get { return _gender; } set{ _gender = value;} }
        public string ClassID { get { return _classID; } set { _classID = value; } }

        // create student's constructor
        protected Student(string ID, string FullName, DateTime Birthday, string Gender, string ClassID)
        {
            _id = ID;
            _fullname = FullName;
            _birthday = Birthday;
            _gender = Gender;
            _classID = ClassID;
        }

        // generate random date for birthday
        public static DateTime GetRandomDate(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year+1, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        // generate random name
        public static string GetRadomFullName()
        {
            String fullname;
            NameConfig stuName = config.NameConfig;
            int firstname_index = rnd.Next(stuName.MaleFirstNameSet.Length); //generate one random firstname
            int midlename_index = rnd.Next(stuName.MiddleNameSet.Length); //generate one random middlename;
            int lastname_index = rnd.Next(stuName.LastNameSet.Length); //generate one random lastname
            fullname = stuName.LastNameSet[lastname_index] + " ";
            fullname += stuName.MiddleNameSet[midlename_index] + " ";
            fullname += stuName.MaleFirstNameSet[firstname_index] + " ";
            return fullname;
        }

        // create list of student
        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {                
                String uuID = Guid.NewGuid().ToString();
                NameConfig _ = config.NameConfig;
                GenderConfig gender = config.GenderConfig;
                LevelNameConfig classLevel = config.LevelNameConfig;

                int gender_index = rnd.Next(gender.GenderSet.Length);
                if (gender_index == 0)
                {
                    String fullname = GetRadomFullName();
                    int class_index = rnd.Next(classLevel.LevelSet.Length);

                    int year = rnd.Next(2003, 2005);
                    DateTime birthday = GetRandomDate(year);
                    result[i] =
                    new Student(uuID, fullname, birthday, gender.GenderSet[gender_index], classLevel.LevelSet[class_index]);
                }
                else if (gender_index == 1)
                {
                    String fullname = GetRadomFullName();
                    int class_index = rnd.Next(classLevel.LevelSet.Length);

                    int year = rnd.Next(2003, 2005);
                    DateTime birthday = GetRandomDate(year);
                    result[i] =
                    new Student(uuID, fullname, birthday, gender.GenderSet[gender_index], classLevel.LevelSet[class_index]);
                }
            }
            return result;
        }
    }
}
