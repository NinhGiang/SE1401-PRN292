using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LAB1
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        protected DateTime _birthday;
        protected bool _gender;
        static Random rnd = new Random();
        public string FullName { get { return _fullname; } }
        public string ID { get { return _id; } }
        public DateTime Birthday { get { return _birthday; } }
        public bool Gender { get { return _gender; } }

        protected Student(string ID, string FullName, DateTime Birthday)
        {
            _id = ID;
            _fullname = FullName;
            _birthday = Birthday;
            _gender = Gender;
        }

        public static Student[] Create(int number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);


            for (uint i = 0; i < number_student; i++)
            {
                GenderConfig _ = config.GenderConfig;
                bool gender = rnd.Next(2) == 1;
                //int gender_index = rnd.Next(_.gender_set.Length);
                //string gender = _.gender_set[gender_index];
                if (gender == true)
                {
                    NameConfig name = config.NameConfig;
                    int last_name_index = rnd.Next(name.last_name_set.Length);
                    int male_middle_name_index = rnd.Next(name.male_middle_name_set.Length);
                    int male_first_name_index = rnd.Next(name.male_first_name_set.Length);
                    string full_name = name.last_name_set[last_name_index] + " ";
                    full_name += name.male_middle_name_set[male_middle_name_index] + " ";
                    full_name += name.male_first_name_set[male_first_name_index];
                }
                if (gender == false)
                {
                    NameConfig name = config.NameConfig;
                    int last_name_index = rnd.Next(name.last_name_set.Length);
                    int female_middle_name_index = rnd.Next(name.female_middle_name_set.Length);
                    int female_first_name_index = rnd.Next(name.female_first_name_set.Length);
                    string full_name = name.last_name_set[last_name_index] + " ";
                    full_name += name.female_middle_name_set[female_middle_name_index] + " ";
                    full_name += name.female_first_name_set[female_first_name_index];
                }



            }
            return result;


        }

        private static DateTime GetRandomDateInYear(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 1, 1);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        public static DateTime GetRandomBirthdayByLevel(string level)
        {
            try
            {
                int levelNumber = Int32.Parse(level);
                int currentYear = DateTime.Now.Year;
                int minAge = 15 + (levelNumber - 10);
                int maxAge = 15 + (levelNumber - 10);
                int maxYear = currentYear - minAge;
                int minYear = currentYear - maxAge;

                int year = rnd.Next(minYear, maxYear + 1);
                return GetRandomDateInYear(year);
            }
            catch (FormatException ex)
            {

            }
            return new DateTime(1900, 1, 1);

        }
    }
}
