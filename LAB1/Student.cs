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
                StudentNameConfig _ = config.StudentNameConfig;
                int lastNameIndex = rnd.Next(_.last_name_set.Length);
                int firstNameIndex = rnd.Next(_.first_name_set.Length);
                int middleNameIndex = rnd.Next(_.middle_name_set.Length);
                string fullName = _.last_name_set[lastNameIndex] + " ";
                fullName = _.last_name_set[middleNameIndex] + " ";
                fullName = _.last_name_set[firstNameIndex];
                result[i] = new Student(i.ToString(), fullName, birdate, true, classInfo);
            }
            return result;
        }
    }
}
