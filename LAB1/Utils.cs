using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Utils
    {
        private static String content = File.ReadAllText(@"..\..\..\Configuration.json");
        private static Configuration config = JsonSerializer.Deserialize<Configuration>(content);
        private static Random rand = new Random();
        public static String getRandomFullName(Boolean gender)
        {
            String name;
            int lastNameIndex = rand.Next(config.NameConfig.last_name_set.Length);
            int middleNameIndex = rand.Next(config.NameConfig.middle_name_set.Length);

            int firstNameIndex = rand.Next(config.NameConfig.first_male_name_set.Length);
            if (gender)
            {
                name = config.NameConfig.last_name_set[lastNameIndex] + " "
                    + config.NameConfig.middle_name_set[middleNameIndex] + " "
                    + config.NameConfig.first_male_name_set[firstNameIndex];
            }
            else
            {
                firstNameIndex = rand.Next(config.NameConfig.first_female_name_set.Length);
                name = config.NameConfig.last_name_set[lastNameIndex] + " "
                    + config.NameConfig.middle_name_set[middleNameIndex] + " "
                    + config.NameConfig.first_female_name_set[firstNameIndex];
            }
            return name;
        }
        public static bool getRandomGender()
        {
            bool gender = false;
            int randomGender = rand.Next(1, 3);//random 1 and 2
            if (randomGender == 1)
            {
                gender = true;
            }
            return gender;
        }
        public static DateTime getRandomDateTime(int year)
        {
            DateTime start = new DateTime(year,1,1);
            DateTime end = new DateTime(year + 1, 12, 31);
            return start.AddDays(rand.Next((end-start).Days));
        }
        public static int getRandomAge(int level)
        {
            int age;
            if (level == 10)
            {
                age = rand.Next(15, 19);
            }
            else if (level == 11)
            {
                age = rand.Next(16, 20);
            }
            else
            {
                age = rand.Next(17, 21);
            }
            return age;
        }
        public static string[] getLevelData()
        {
            return config.LevelConfig.level_set;
        }
        public static string[] getFieldData()
        {
            return config.FieldConfig.field_set;
        }
        public static void print()
        {
            //Console.WriteLine(config.LevelConfig.level_set[0]);
        }
    }
}
