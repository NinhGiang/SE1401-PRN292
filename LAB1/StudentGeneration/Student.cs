using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;


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
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                NameConfig name = config.NameConfig;
                BirthDayConfig dob = config.BirthdayConfig;
                int gender_index = rnd.Next(config.GenderConfig.Gender_set.Length);
                ClassConfig classname = config.ClassConfig;
                //if Male
                if (gender_index == 0)
                {
                    //name
                    int last_name_index = rnd.Next(name.last_Male_set.Length);
                    int first_name_index = rnd.Next(name.first_Male_set.Length);
                    int middle_name_index = rnd.Next(name.middle_Male_set.Length);
                    string full_name = name.last_Male_set[last_name_index] + " ";
                    full_name += name.middle_Male_set[middle_name_index] + " ";
                    full_name += name.first_Male_set[first_name_index];
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
