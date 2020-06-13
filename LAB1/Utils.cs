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
        public static bool GetRandomGender()
        {
            bool gender = false;
            int randomGender = rand.Next(1, 3);//random 1 and 2
            if (randomGender == 1)
            {
                gender = true;
            }
            return gender;
        }
        public static DateTime GetRandomDateTime(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year + 1, 12, 31);
            return start.AddDays(rand.Next((end - start).Days));
        }
        public static int GetRandomAge(int level)
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
        public static string[] GetLevelData()
        {
            return config.LevelConfig.level_set;
        }
        public static string[] GetFieldData()
        {
            return config.FieldConfig.field_set;
        }
        public static Dictionary<string, string> GenerateRoomAndClassID(int number)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string roomID = Guid.NewGuid().ToString();
                string classID = Guid.NewGuid().ToString();

                dict.Add(roomID, classID);
            }

            return dict;
        }
        public static int GetRandomStudentNumber()
        {
            return rand.Next(500, 3001);
        }
        public static bool CheckStudentNumber(int number)
        {
            if (number >= 500 && number <= 3000)
            {
                return true;
            }
            return false;
        }
        public static int GetRandomRoomNumber()
        {
            return rand.Next(10, 100);
        }
        public static bool CheckRoomNumber(int number)
        {
            if (number > 0 && number < 100)
            {
                return true;
            }
            return false;
        }
        public static bool ValidateStudentAndRoomNumber(int studentNumber, int roomNumber)
        {
            double check = (double)studentNumber / (double)roomNumber;
            if (check > -30 && check <= 50)
            {
                return true;
            }
            return false;
        }
    }
}
