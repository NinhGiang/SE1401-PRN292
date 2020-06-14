using System;
using System.IO;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = CLI.CheckCLI(args);
            if (error.Length != 0)
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine("Test lab");
                string schoolName = CLI.SchoolName;

                School school = new School();
                school.SchoolName = schoolName;

                string directory = @"..\..\..\" + schoolName;
                Directory.CreateDirectory(directory);

                Level[] levelList = Level.GenerateLevel();
                school.Levels = levelList;
                school.saveLevels(directory + "\\" + "Level.csv");

                Field[] fieldList = Field.GenerateField();
                school.Fields = fieldList;
                school.saveFields(directory + "\\" + "Field.csv");
            }
            Console.ReadLine();
        }        
    }
}
