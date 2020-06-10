using System;
using System.IO;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Lab");
            
            School school = new School();
            school.SchoolName = "ABC";
            //create school folder
            string directoryPath = @"..\..\..\" + school.SchoolName;
            Directory.CreateDirectory(directoryPath);

            //create level
            Level[] level_list = Level.CreateLevel();
            school.LevelList = level_list;
            school.saveLevel(directoryPath + "\\" + "Level.csv");

            //create field
            Field[] field_list = Field.CreateField();
            school.FieldList = field_list;
            school.saveField(directoryPath + "\\" + "Field.csv");

            //create subject
            Subject[] subject_list = Subject.createSubject(field_list, level_list);


            Console.ReadLine();
        }

    }
}
