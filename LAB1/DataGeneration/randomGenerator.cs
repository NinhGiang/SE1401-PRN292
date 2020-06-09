using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1.DataGeneration
{
    class RandomGenerator
    {
        static Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"E:/FPT/VS C# & .NET/tieuminh2510/SE1401-PRN292/LAB1/DataGeneration/database.json"));
        static Random rnd = new Random();
        public static DateTime GetRandomDate(int year)
        {
            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year +1, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        public static string GetRadomFullName()
        {
            String fullname;
            NameDataSet nameDB = config.NameDataSet;
            int firstname_index = rnd.Next(nameDB.MaleFirstNameSet.Length); //generate one random firstname
            int midlename_index = rnd.Next(nameDB.MiddleNameSet.Length); //generate one random middlename;
            int lastname_index = rnd.Next(nameDB.LastNameSet.Length); //generate one random lastname
            fullname = nameDB.LastNameSet[lastname_index] + " ";
            fullname += nameDB.MiddleNameSet[midlename_index] + " ";
            fullname += nameDB.MaleFirstNameSet[firstname_index] + " ";
            return fullname;
        }//generate a random fullname;
        public static string GetRandomClass()
        {
            ClassDataSet classDB = config.ClassDataSet;
            int class_index = rnd.Next(classDB.ClassSet.Length);
            return classDB.ClassSet[class_index];
        }//generate a random Class
    }
}
