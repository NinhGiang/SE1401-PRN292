using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    public class Student
    {
        protected string _id;
        protected string _name;
        protected DateTime _birthdate;
        protected bool _gender;
        protected string _class;

        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetName()
        { return _name; }

        public void SetName(string value)
        { _name = value; }

        public DateTime GetBirthdate()
        { return _birthdate; }

        public void SetBirthdate(DateTime value)
        { _birthdate = value; }

        public bool GetGender()
        { return _gender; }

        public void SetGender(bool value)
        { _gender = value; }

        public string GetClassInfo()
        { return _class; }

        public void SetClassInfo(string value)
        { _class = value; }

        public Student() { }

        public Student(string id, string name, DateTime birthdate, bool gender, string classInfo)
        {
            _id = id;
            _name = name;
            _birthdate = birthdate;
            _gender = gender;
            _class = classInfo;
        }

        public static Student[] Create(uint numberOfStudent)
        {
            Student[] result = new Student[numberOfStudent];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();

            for (uint i = 0; i < numberOfStudent; i++)
            {
                //id
                String uuid = Guid.NewGuid().ToString();

                //gender
                bool gender = rnd.Next(2) == 1;

                //name
                StudentNameConfig _ = config.StudentNameConfig;
                int lastNameIndex = rnd.Next(_.last_name_set.Length);
                int firstNameIndex;
                string firstname;
                if (gender == true)
                {
                    firstNameIndex = rnd.Next(_.male_first_name_set.Length);
                    firstname = _.male_first_name_set[firstNameIndex];
                }
                else
                {
                    firstNameIndex = rnd.Next(_.fem_first_name_set.Length);
                    firstname = _.fem_first_name_set[firstNameIndex];
                }

                int middleNameIndex = rnd.Next(_.middle_name_set.Length);
                string fullName = _.last_name_set[lastNameIndex] + " ";
                fullName += _.middle_name_set[middleNameIndex] + " ";
                fullName += firstname;

                //birthdate
                int year = rnd.Next(2003, 2005);
                DateTime birthdate = GetRandomDate(year);

                //Class
                string classInfo = "tempClass";

                result[i] = new Student();
                result[i].SetId(uuid);
                result[i].SetName(fullName);
                result[i].SetGender(true);
                result[i].SetBirthdate(birthdate);
                result[i].SetClassInfo(classInfo);
            }
            return result;
        }

        private static DateTime GetRandomDate(int year)
        {
            Random rnd = new Random();
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        private static Student CreateMale()
        {
            Student result = new Student();
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            Random rnd = new Random();

            //id
            String uuid = Guid.NewGuid().ToString();

            //name
            StudentNameConfig _ = config.StudentNameConfig;
            int lastNameIndex = rnd.Next(_.last_name_set.Length);
            int firstNameIndex = rnd.Next(_.male_first_name_set.Length);
            int middleNameIndex = rnd.Next(_.middle_name_set.Length);
            string fullName = _.last_name_set[lastNameIndex] + " ";
            fullName = _.last_name_set[middleNameIndex] + " ";
            fullName = _.last_name_set[firstNameIndex];

            //birthdate
            int year = rnd.Next(2003, 2005);
            DateTime birthdate = GetRandomDate(year);

            //Class
            string classInfo = "tempClass";

            result.SetId(uuid);
            result.SetName(fullName);
            result.SetGender(true);
            result.SetBirthdate(birthdate);
            result.SetClassInfo(classInfo);

            return result;
        }
    }
}
