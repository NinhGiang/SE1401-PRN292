using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.StudentGeneration
{
    class Generator
    {
        private static Random rd;
        public static int getRandomInteger(int range)
        {
            rd = new Random();
            return rd.Next(range);
        }

        public static int getRandomInteger(int lowerBound, int upperBound)
        {
            rd = new Random();
            return rd.Next(lowerBound, upperBound);
        }

        public static DateTime getRandomDate(int year)
        {
            rd = new Random();
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);
            int randomDay = rd.Next((endDate - startDate).Days);
            return startDate.AddDays(randomDay);
        }
    }
}
