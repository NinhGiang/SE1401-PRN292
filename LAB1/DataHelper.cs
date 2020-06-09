using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class DataHelper
    {
        private static Random rnd = new Random();
        private static string content = File.ReadAllText(@"..\..\..\Configure.json");
        private static Configure config = JsonSerializer.Deserialize<Configure>(content);

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

        public static List<string> GetListOfSubjectByField(string fieldId)
        {
            string path = @"..\..\..\Subject.csv";
            int column = GetColumn(path, "Field");
            return GetDataByInfo(path, fieldId, column);
        }

        public static List<string> GetListOfClassByLevel(string levelId)
        {
            string path = @"..\..\..\Class.csv";
            int column = GetColumn(path, "Level");
            return GetDataByInfo(path, levelId, column);
        }

        public static List<string> GetListOfClass()
        {
            return GetCsvData(@"..\..\..\Class.csv");
        }

        public static List<string> GetListOfField()
        {
            return GetCsvData(@"..\..\..\Field.csv");
        }

        public static List<string> GetListOfRoom()
        {
            return GetCsvData(@"..\..\..\Room.csv");
        }

        public static List<string> GetListOfLevel()
        {
            return GetCsvData(@"..\..\..\Level.csv");
        }

        public static List<string> GetListOfStudent()
        {
            return GetCsvData(@"..\..\..\Student.csv");
        }

        public static List<string> GetListOfTeacher()
        {
            return GetCsvData(@"..\..\..\Teacher.csv");
        }

        private static DateTime GetRandomDateInYear(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

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
