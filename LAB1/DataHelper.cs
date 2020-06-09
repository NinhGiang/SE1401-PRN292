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

        public static DateTime GetRandomDateInYear(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static string GetRandomNameByGender(bool gender)
        {
            string fullName;
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

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

            return fullName;
        }
    }
}
