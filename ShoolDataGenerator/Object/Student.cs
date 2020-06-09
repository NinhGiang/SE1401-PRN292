using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{

    class Student
    {
        public static int[] LimitYearForLevel10 { get; set; }
        public static int[] LimitYearForLevel11 { get; }
        public static int[] LimitYearForLevel12 { get; }
        static Student()
        {
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            // level 10
            int minYear = currentYear - 19;
            int maxYear = minYear + 4;
            LimitYearForLevel10 = new int[2] { minYear, maxYear };
            // level 11, 12
            LimitYearForLevel11 = LimitYearForLevel10.Select(x => x + 1).ToArray();
            LimitYearForLevel12 = LimitYearForLevel11.Select(x => x + 1).ToArray();
        }
        public string UUID { get; set; }
        public string Name { get; set; }
        public int Birthday { get; set; }
        public string Gender { get; set; }
        public Class Class { get; set; }

        public Student()
        {
            UUID = Guid.NewGuid().ToString();
        }

        public static string[] GenerateRandomFullname(int length)
        {
            Random rd = new Random();
            string[] listName = new string[length];
            string[] lastName = { "Nguyen", "Tran", "Vo", "Mai", "Vu" };
            string[] middleName = { "Thi", "Ngoc", "Hoang", "Anh", "Oanh" };
            string[] firstName = { "Tuyet", "Mai", "Trang", "Van", "Ngan" };
            for (int i = 0; i < length; i++)
            {
                string name = lastName[rd.Next(lastName.Length)] + " ";
                name += middleName[rd.Next(middleName.Length)] + " ";
                name += firstName[rd.Next(firstName.Length)];
                listName[i] = name;
            }
            return listName;
        }
        public static DateTime[] GenerateRandomBirthday(int length, int level)
        {
            DateTime[] listRandomDate = new DateTime[length];


            int[] limit = null;
            if (level == 10)
            {
                limit = LimitYearForLevel10;
            }
            else if (level == 11)
            {
                limit = LimitYearForLevel11;
            }
            else
            {
                limit = LimitYearForLevel12;
            }
            Random rd = new Random();
            DateTime start = new DateTime(limit[0], 1, 1);
            DateTime end = new DateTime(limit[1] + 1, 1, 1);
            int range = (end - start).Days;
            Console.WriteLine(limit[0]);
            Console.WriteLine(limit[1]);
            for (int i = 0; i < length; i++)
            {
                listRandomDate[i] = start.AddDays(rd.Next(range));
            }
            return listRandomDate;
        }
        public static bool[] GenerateGender(int length)
        {
            Random rd = new Random();
            bool[] male = new bool[length];
            for (int i = 0; i < length; i++)
            {
                male[i] = rd.Next(1, 3) == 1;
            }
            return male;
        }
    }
}
