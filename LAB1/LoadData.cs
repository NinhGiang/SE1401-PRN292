using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class LoadData
    {
        private static readonly string CONFIG = @"..\..\..\Configure.json";
        private static Random rd = new Random();
        private static string subject = File.ReadAllText(CONFIG);
        private static Configure config = JsonSerializer.Deserialize<Configure>(subject);

        public LoadData() { }
        private static DateTime GetRandomDate(int year)
        {
            DateTime begin = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - begin).Days;
            return start.AddDays(rd.Next(range));
        }

        public static DateTime GetRandomBirthday(string level)
        {
            try
            {
                int level1 = Int32.Parse(level);

                int nowYear = DateTime.Now.Year;

                int minAge = 15 + (level1 - 10);

                int maxAge = 19 + (level1 - 10);

                int maxYear = currentYear - minAge;

                int minYear = currentYear - maxAge;

                int year = rd.Next(minYear, maxYear + 1);

                return GetRandomDate(year);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("LoadData _ FormatException: " + ex.Message);
            }
            return new DateTime(1900, 1, 1);
        }

        public static string GetNameforGender(bool gen)
        {
            string LongName;
            int lastNameNumber;
            int firstNameNumber;
            int middleNameNumber;
            string firstname;
            try
            {
                NameConfig genconfig = config.NameConfig;

                int lastNameNumber = rd.Next(genconfig.last_name_set.Length);
                
                if (gen == true)
                {
                    firstNameNumber = rd.Next(genconfig.male_first_name_set.Length);
                    firstname = genconfig.male_first_name_set[firstNameNumber];
                }
                else
                {
                    firstNameNumber = rd.Next(genconfig.female_first_name_set.Length);
                    firstname = genconfig.female_first_name_set[firstNameNumber];
                }

                middleNameNumber = rd.Next(genconfig.middle_name_set.Length);

                LongName = genconfig.last_name_set[lastNameNumber];
                LongName += " " + genconfig.middle_name_set[middleNameNumber];
                LongName += " " + firstname;

                LongName = LongName.Trim();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Loaddata _ FileNotFoundException: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Loaddata _ NullReferenceException: " + ex.Message);
            }
            return LongName;
        }


    }
}