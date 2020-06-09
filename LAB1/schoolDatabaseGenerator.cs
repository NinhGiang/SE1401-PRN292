﻿
using System;
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
            //Test Create method in Student class
            Student.Create(10);
            foreach (var student in Student.StudentList)
            {
                Console.WriteLine(student.UUID + ", " + student.Name + ", " + student.Birthday + ", " + student.Gender + ", " + student.ClassUUID);
            }
        }
    }
}
