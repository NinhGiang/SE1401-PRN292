
using System;
using System.IO;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// The main SchoolDatabaseGenerator class.
    /// Contains all methods for generating a school database.
    /// </summary>
    class SchoolDatabaseGenerator
    {       
        /// <summary>
        /// Used to test method.
        /// </summary>
        /// <param name="args">A string array contains command from command-line.</param>
        public static void Main(string[] args)
        {
            /*bool valid;
            if (args.Length < 5)
            {
                valid = true;
                foreach (var command in args)
                {
                    if (!string.Equals(command, "-s") || !string.Equals(command, "-r") || Regex.IsMatch(command, @"\d"))
                    {
                        valid = false;
                    }
                    else if (string.Equals(command, "-h"))
                    {
                        valid = true;
                        Console.WriteLine("Help:");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>>: Generate a school database " +
                            "with number students in range 500 to 3000, and the largest number rooms is 100");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: " +
                            "Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: " +
                            "Generate a school database with <<number_rooms>> and number students in range 500 to 3000");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>> -s <<number_students>> " +
                            "-r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>");
                    }
                    else
                    {
                        valid = true;
                    }
                }              
            } 
            else
            {
                valid = false;
                
            }

            if (valid == true)
            {
                Console.WriteLine("Valid command!");
            }
            else
            {
                Console.WriteLine("Invalid command!");
            }*/
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            uint noOfStudentInClass = (uint) rnd.Next(30, 51);
            uint noOfClass = (uint) 100 / noOfStudentInClass;
            uint noOfClassPerLevel = (uint)noOfClass / 3;
            //Test Create method in Level class
            Level.Create();
            //Test Create method in Class class
            foreach (var level in Level.LevelList)
            {
                for (int i = 0; i < noOfClassPerLevel; i++)
                {
                    Class.Create(level);
                    Room.Create(Class.ClassList[i].UUID);
                }
            }
          
            //Test Create method in Student class
            foreach (var classObject in Class.ClassList)
            {
                
                for (int i = 0; i < noOfStudentInClass; i++)
                {
                    Student.Create(100, classObject);
                }
            }
            
            Student.SaveStudents(@"..\..\..\Students.csv");
            Class.SaveClasses(@"..\..\..\Classes.csv");
            Level.SaveLevels(@"..\..\..\Levels.csv");
            /*foreach (var student in Student.StudentList)
            {
                Console.WriteLine(student.UUID + ", " + student.Name + ", " + student.Birthday + ", " + student.Gender + ", " + student.ClassUUID);
            }
            
            foreach (var level in Level.LevelList)
            {
                Console.WriteLine(level.UUID + ", " + level.Name);
            }*/
        }
    }
}
