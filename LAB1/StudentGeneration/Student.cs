using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;
using LAB1.StudentGeneration;

namespace StudentGeneration
{
    class Student
    {
        protected string _UUID;
        protected string _fullname;
        protected string _dayofbirth;
        protected string _gender;
        protected string _class;
        public string ID { get { return _UUID; } }
        public string FullName { get { return _fullname; } }
        public string DayOfBirth { get { return _dayofbirth; } }
        public string Gender { get{ return _gender; } }
        public string Class { get{ return _class; } }

        protected Student(string ID, string FullName,string Dayofbirth,string Gender,string Class)
        {
            _UUID = ID;
            _fullname = FullName;
            _dayofbirth = Dayofbirth;
            _gender = Gender;
            _class = Class;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                string UUID = Guid.NewGuid().ToString();//create new uuid
                int gender_index = DataSetter.GetRandomGender();
                //if Male
                if (gender_index == 0)
                {
                    //create random Malename
                    string fullname = DataSetter.RandomMaleName();
                    //birthday

                  
                    
                }

            }
            return result;
        }
        public void print()
        {
            Console.WriteLine(_UUID +1 + " " + _fullname);
        }
    }
}
