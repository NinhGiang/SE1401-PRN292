using System;
using System.IO;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Lab");
            Console.ReadLine();
            School school = new School();
            school.SchoolName = "ABC";
            string directoryPath = @"..\..\..\" + school.SchoolName;
            Directory.CreateDirectory(directoryPath);

            Level[] level_list = Level.CreateLevel();
            school.saveLevel(directoryPath+"\\Level.csv");
        }
    }
}
