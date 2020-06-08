using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class DataHelper
    {
        public static List<string> GetListOfClass()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Class.csv");

            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            return list;
        }
        public static List<string> GetListOfField()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Field.csv");

            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            return list;
        }

        public static List<string> GetListOfRoom()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Room.csv");

            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            return list;
        }

        public static List<string> GetListOfLevel()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Level.csv");

            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            return list;
        }

        public static DateTime GetRandomDateInYear(int year)
        {
            Random rnd = new Random();
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}
