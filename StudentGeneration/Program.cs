using System;

namespace StudentGeneration
{
    class Program
    {
        static string CLIChecker(string[] args)
        {
            String result = "";
            String help_string = @"Help: 
./schoolDatabaseGenerator <<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100 
./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100 
./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.
./schoolDatabaseGenerator <<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.";
            if (args.Length == 0)
                result = help_string;
            else if (args.Length == 1 && args[0] == "-h")
                result = help_string;
            else if(args.Length > 0 && args[0] != "-h" && args[0] != "-s")
                result = "Error: Loi gi gi do";
            else if(args.Length == 1 && args[0] == "-s")
                result = "Error: Lack of the filename parameter";
            return result;
        }
        static void Main(string[] args)
        {
            String info = CLIChecker(args);
            if (info == "")
            {
                Student[] student_list = Student.Create(100);
                School ABC = new School(student_list);
                ABC.save(args[1]);
                Console.WriteLine("File has saved");
            } 
            else
            {  
                Console.WriteLine(info);
            }

        }
    }
}
