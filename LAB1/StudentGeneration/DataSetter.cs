using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using StudentGeneration;

namespace LAB1.StudentGeneration
{
    class DataSetter
    {
        private static Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"..\..\..\DataGeneration\database.json"));
        private static Random rnd = new Random();
        private static NameConfig name = config.NameConfig;
        private static ClassConfig classes = config.ClassConfig;
        private static GenderConfig gender = config.GenderConfig;
        //generate a random day;
        public static DateTime GetRandomBirthday(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        //generate random Gender
        public static int GetRandomGender()
        {
            int gender_index = rnd.Next(gender.Gender_set.Length);
            return gender_index;
        }

        //generate a random Malename;
        public static string RandomFullNameByGender(int genderIndex)
        {
            string fullname = null;
            if (genderIndex == 0)
            {
                int firstNameIndex = rnd.Next(config.NameConfig.first_Male_set.Length);
                int lastNameIndex = rnd.Next(config.NameConfig.last_name_set.Length);
                int middleNameIndex = rnd.Next(config.NameConfig.middle_name_set.Length);
                fullname = name.last_name_set[lastNameIndex] + " ";
                fullname += name.middle_name_set[middleNameIndex] + " ";
                fullname += name.first_Male_set[firstNameIndex];
                return fullname;
            }
            else if(genderIndex == 1) {
                int firstNameIndex = rnd.Next(config.NameConfig.first_Female_set.Length);
                int lastNameIndex = rnd.Next(config.NameConfig.last_name_set.Length);
                int middleNameIndex = rnd.Next(config.NameConfig.middle_name_set.Length);
                fullname = name.last_name_set[lastNameIndex] + " ";
                fullname += name.middle_name_set[middleNameIndex] + " ";
                fullname += name.first_Female_set[firstNameIndex];
                return fullname;
            }
                return fullname ;
        }

        //generate a random class
        public static string GetRandomClass()
        {
            int class_index = rnd.Next(classes.Class_set.Length);
            return classes.Class_set[class_index];
        }

    }
}
