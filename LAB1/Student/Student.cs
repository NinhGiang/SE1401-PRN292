using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace LAB1
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        protected DateTime _birthday;
        protected string _uuid;
        protected bool _gender;
        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }
        public DateTime Birthday { get { return _birthday; } }
        public string UUID { get { return _uuid; } }
        public bool Gender { get { return _gender; } }
        protected Student(string ID, string FullName, bool Gender, DateTime Birthday, string UUID)
        {
            _id = ID;
            _fullname = FullName;
            _birthday = Birthday;
            _uuid = UUID;
            _gender = Gender;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Student\StudentConfigure.json");
            StudentConfigure config = JsonSerializer.Deserialize<StudentConfigure>(content);
            for (uint i = 0; i < number_student; i++)
            {
                //generate random uuid
                string id = RandomGenerator.randUUID();
                //generate random birthday
                DateTime birthday = RandomGenerator.randBirthday();
                //generate random gender
                bool gender = RandomGenerator.randGender();
                //generate random student name
                if (gender)
                {
                    string full_name = RandomGenerator.randMaleStudentName(config);
                    result[i] = new Student(i.ToString(), full_name, gender, birthday, id);
                } else
                {
                    string full_name = RandomGenerator.randFemaleStudentName(config);
                    result[i] = new Student(i.ToString(), full_name, gender, birthday, id);
                }
            }
            return result;
        }


        public void print()
        {
            Console.WriteLine(_id + " | " + _fullname + " | " + _birthday + " | " + _uuid);
        }
    }
}