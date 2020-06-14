using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Student
    {
        protected string _uuid;
        protected string _name;
        protected DateTime _birthday;
        protected bool _gender;
        protected string _class;

        private static System.Random rd = new System.Random();

        public Student(string uuid, string name, DateTime birthday, bool gender, string @class)
        {
            _uuid = uuid;
            _name = name;
            _birthday = birthday;
            _gender = gender;
            _class = @class;
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        private static String jsonFile = File.ReadAllText(@"..\..\..\Configure.json");
        private static Configure config = JsonSerializer.Deserialize<Configure>(jsonFile);

        public static bool GenerateGender()
        {
            bool gender = false;
            int random = rd.Next(1, 3);
            if (random == 1)
            {
                gender = true;
            }
            return gender;
        }

        public static String getName(Boolean gender)
        {
            String name;
            int lastNameIndex = rd.Next(config.NameConfig.last_name.Length);
            int middleNameIndex = rd.Next(config.NameConfig.middle_name.Length);
            int firstNameIndex = rd.Next(config.NameConfig.male_first_name.Length);
            if (gender)
            {
                name = config.NameConfig.last_name[lastNameIndex] + " " 
                    + config.NameConfig.middle_name[middleNameIndex] + " " 
                    + config.NameConfig.male_first_name[firstNameIndex];
            }
            else
            {
                firstNameIndex = rd.Next(config.NameConfig.female_first_name.Length);
                name = config.NameConfig.last_name[lastNameIndex] + " "
                    + config.NameConfig.middle_name[middleNameIndex] + " "
                    + config.NameConfig.female_first_name[firstNameIndex];
            }
            return name;
        }

        public static int GenerateAge(int level)
        {
            int age = 0;
            if (level == 10)
            {
                age = rd.Next(15, 19);
            }
            else if (level == 11)
            {
                age = rd.Next(16, 20);
            }
            else if (level == 12)
            {
                age = rd.Next(17, 21);
            }
            return age;
        }
    }
}
