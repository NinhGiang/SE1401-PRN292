using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// Utils Class
    /// Contains properties and methods for Utils
    /// Used for helping other classes
    /// </summary>
    class Utils
    {
        /// <summary>
        /// Content path of Configuraion.json file
        /// </summary>
        private static readonly String content = File.ReadAllText(@"..\..\..\Configuration.json");
        /// <summary>
        /// Configuration of Configuration.json file
        /// </summary>
        private static readonly Configuration config = JsonSerializer.Deserialize<Configuration>(content);
        /// <summary>
        /// Random
        /// </summary>
        private static readonly Random rand = new Random();

        /// <summary>
        /// Generate a random name based on gender
        /// </summary>
        /// <param name="gender">boolean value</param>
        /// <returns>Return a string</returns>
        public static String GenerateRandomFullName(Boolean gender)
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
        /// <summary>
        /// Generate random gender 
        /// </summary>
        /// <returns>Return a boolean</returns>
        public static bool GenerateRandomGender()
        {
            bool gender = false;
            int randomGender = rand.Next(1, 3);//random 1 and 2
            if (randomGender == 1)
            {
                gender = true;
            }
            return gender;
        }
        /// <summary>
        /// Generate a random birthday
        /// </summary>
        /// <param name="year">integer value</param>
        /// <returns>Return a Datetime</returns>
        public static DateTime GenerateRandomBirthday(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year + 1, 12, 31);
            return start.AddDays(rand.Next((end - start).Days));
        }
        /// <summary>
        /// Generate a random age
        /// </summary>
        /// <param name="level">integer value</param>
        /// <returns>Return an integer</returns>
        public static int GerateRandomAge(int level)
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
        /// <summary>
        /// Get level config data
        /// </summary>
        /// <returns>Return an array of string</returns>
        public static string[] GetLevelData()
        {
            return config.LevelConfig.level_set;
        }
        /// <summary>
        /// Get field config data
        /// </summary>
        /// <returns>Return an array of string</returns>
        public static string[] GetFieldData()
        {
            return config.FieldConfig.field_set;
        }
        /// <summary>
        /// Generate a list of room and class ids
        /// </summary>
        /// <param name="number">integer value</param>
        /// <returns>Return a Dictionary pair</returns>
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
        /// <summary>
        /// Generate a random number of Student
        /// </summary>
        /// <returns>Return an integer</returns>
        public static int GenerateRandomStudentNumber()
        {
            return rand.Next(500, 3001);
        }
        /// <summary>
        /// Generate a random number of Student based on room number
        /// </summary>
        /// <param name="roomNumber">integer value</param>
        /// <returns>Return an integer value</returns>
        public static int GenerateRandomStudentNumberByRoomNumber(int roomNumber)
        {
            int minNum = roomNumber * 30;
            int maxNum = roomNumber * 50;
            return rand.Next(minNum, maxNum);
        }
        /// <summary>
        /// Check if a number is in range
        /// </summary>
        /// <param name="number">integer value</param>
        /// <param name="min">integer value</param>
        /// <param name="max">integer value</param>
        /// <returns>Return a boolean value</returns>
        public static bool CheckNumber(int number , int min , int max)
        {
            if (number >= min && number <= max)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Generate a random number of Room based on Student number
        /// </summary>
        /// <param name="studentNumber">integer value</param>
        /// <returns>Return an integer value</returns>
        public static int GenerateRandomRoomNumberByStudentNumber(int studentNumber)
        {
            int minNum = (int) Math.Ceiling( (double) studentNumber / 50);
            int maxNum = (int)Math.Ceiling((double)studentNumber / 30);
            return rand.Next(minNum, maxNum);
        }
        /// <summary>
        /// Validate the ratio of student to number
        /// </summary>
        /// <param name="studentNumber">integer value</param>
        /// <param name="roomNumber">integer value</param>
        /// <returns>Return a boolean value</returns>
        public static bool ValidateStudentAndRoomNumber(int studentNumber, int roomNumber)
        {
            double check = (double)studentNumber / (double)roomNumber;
            if (check >= 30 && check <= 50)
            {
                return true;
            }
            return false;
        }
    }
}
