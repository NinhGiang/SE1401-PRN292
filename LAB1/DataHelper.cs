using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The DataHelper class
    /// Contains all methods related to .csv file and methods that generate random data 
    /// </summary>
    class DataHelper
    {
        /// <summary>
        /// Random object to random value later
        /// </summary>
        private static Random rnd = new Random();

        /// <summary>
        /// String of text read from Configure.json file
        /// </summary>
        private static string content = File.ReadAllText(@"..\..\..\Configure.json");

        /// <summary>
        /// Deserialize content to different objects
        /// </summary>
        private static Configure config = JsonSerializer.Deserialize<Configure>(content);

        /// <summary>
        /// Get list of lines from a specific .csv file
        /// </summary>
        /// <param name="path">A string value</param>
        /// <returns>List of string from input filepath</returns>
        private static List<string> GetCsvData(string path)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);

            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            return list;
        }

        /// <summary>
        /// Search for list of lines from a specific .csv file that contains search info
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="info">A string value</param>
        /// <param name="column">An integer value</param>
        /// <returns>List of lines from a specific .csv file that contains search info</returns>
        private static List<string> GetDataByInfo(string path, string info, int column)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);
            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] split = line.Split(',');
                if (split[column].Trim().Equals(info.Trim()))
                {
                    list.Add(line);
                }
            }
            sr.Close();
            return list;
        }

        /// <summary>
        /// Search for column index from a specific .csv file by column name
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="info">A string value</param>
        /// <returns>The column index or -1 if not found</returns>
        private static int GetColumn(string path, string info)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            string[] split = line.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Trim().Equals(info.Trim()))
                {
                    return i;
                }
            }
            sr.Close();
            return -1;
        }

        /// <summary>
        /// Get list of subject by field id
        /// </summary>
        /// <param name="fieldId">A string value</param>
        /// <returns>List of subject contains field id</returns>
        public static List<string> GetListOfSubjectByField(string fieldId)
        {
            string path = @"..\..\..\Subject.csv";
            int column = GetColumn(path, "Field");
            return GetDataByInfo(path, fieldId, column);
        }

        /// <summary>
        /// Get list of class by level id
        /// </summary>
        /// <param name="levelId">A string value</param>
        /// <returns>List of class contains level id</returns>
        public static List<string> GetListOfClassByLevel(string levelId)
        {
            string path = @"..\..\..\Class.csv";
            int column = GetColumn(path, "Level");
            return GetDataByInfo(path, levelId, column);
        }

        /// <summary>
        /// Get all classes from Class.csv file
        /// </summary>
        /// <returns>List of classes</returns>
        public static List<string> GetListOfClass()
        {
            return GetCsvData(@"..\..\..\Class.csv");
        }

        /// <summary>
        /// Get all fields from Field.csv file
        /// </summary>
        /// <returns>List of fields</returns>
        public static List<string> GetListOfField()
        {
            return GetCsvData(@"..\..\..\Field.csv");
        }

        /// <summary>
        /// Get all rooms from Room.csv file
        /// </summary>
        /// <returns>List of rooms</returns>
        public static List<string> GetListOfRoom()
        {
            return GetCsvData(@"..\..\..\Room.csv");
        }

        /// <summary>
        /// Get all levels from Level.csv file
        /// </summary>
        /// <returns>List of levels</returns>
        public static List<string> GetListOfLevel()
        {
            return GetCsvData(@"..\..\..\Level.csv");
        }

        /// <summary>
        /// Get all students from Student.csv file
        /// </summary>
        /// <returns>List of students</returns>
        public static List<string> GetListOfStudent()
        {
            return GetCsvData(@"..\..\..\Student.csv");
        }

        /// <summary>
        /// Get all teachers from Teacher.csv file
        /// </summary>
        /// <returns>List of teachers</returns>
        public static List<string> GetListOfTeacher()
        {
            return GetCsvData(@"..\..\..\Teacher.csv");
        }

        /// <summary>
        /// Get a random date in a specific year
        /// </summary>
        /// <param name="year">An integer value</param>
        /// <returns>A random date in a specific year</returns>
        private static DateTime GetRandomDateInYear(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        /// <summary>
        /// Get a random birthdate by student's level
        /// </summary>
        /// <param name="level">A string value</param>
        /// <returns>A random DateTime value</returns>
        public static DateTime GetRandomBirthdayByLevel(string level)
        {
            Int32.TryParse(level, out int levelNumber);
            int currentYear = DateTime.Now.Year;
            int minAge = 15 + (levelNumber - 10);
            int maxAge = 19 + (levelNumber - 10);
            int maxYear = currentYear - minAge;
            int minYear = currentYear - maxAge;

            int year = rnd.Next(minYear, maxYear);
            return GetRandomDateInYear(year);
        }

        /// <summary>
        /// Get a random name by gender
        /// </summary>
        /// <param name="gender">A boolean value</param>
        /// <returns>A random string of name from config file</returns>
        public static string GetRandomNameByGender(bool gender)
        {
            string fullName;

            NameConfig _ = config.NameConfig;
            int lastNameIndex = rnd.Next(_.last_name_set.Length);
            int firstNameIndex;
            string firstname;
            if (gender == true)
            {
                firstNameIndex = rnd.Next(_.male_first_name_set.Length);
                firstname = _.male_first_name_set[firstNameIndex];
            }
            else
            {
                firstNameIndex = rnd.Next(_.fem_first_name_set.Length);
                firstname = _.fem_first_name_set[firstNameIndex];
            }

            int middleNameIndex = rnd.Next(_.middle_name_set.Length);

            fullName = _.last_name_set[lastNameIndex] + " ";
            fullName += _.middle_name_set[middleNameIndex] + " ";
            fullName += firstname;

            return fullName.Trim();
        }
    }
}
