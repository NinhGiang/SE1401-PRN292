using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class CLI
    {
        private static string schoolName;
        private static int _studentNumber;
        private static int _roomNumber;

        public static string SchoolName
        {
            get { return schoolName; }
        }

        public static int StudentNumber
        {
            get { return _studentNumber; }
        }
        
        public static int RoomNumber
        {
            get { return _roomNumber; }
        }

        public static int CheckArray(string[] args, string value)
        {
            int result = -1;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Equals(value))
                {
                    result = i;
                }
            }
            return result;
        }

        public static string CheckCLI(string[] args)
        {
            String result = "";
            String help_string = @"Help: 
./schoolDatabaseGenerator <<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100 
./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100 
./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.
./schoolDatabaseGenerator <<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.";
            if (args.Length == 0 || (args.Length == 1 && args[0].Equals("-h")))
            {
                result = help_string;
            }
            else if (args.Length > 0 && !args[0].Equals("-h") && args[0].Equals("-r"))
            {
                result = "I dont feel so good :(";
            }
            else if (args.Length == 1 && (args[0].Equals("-s") || args[0].Equals("-r")))
            {
                result = "You forgot school name ???";
            }
            else
            {
                schoolName = args[0];
                int studentIndex = CheckArray(args, "-s") + 1;
                int roomIndex = CheckArray(args, "-r") + 1;
                int studentNumber = 0;
                int roomNumber = 0;
                if (studentIndex != -1)
                {
                    if (!Int32.TryParse(args[studentIndex], out studentNumber))
                    {
                        result = "Incorrect CLI format";
                    }
                    else if (Random.CheckStudentNumber(studentNumber) == -1)
                    {
                        result = "Student out of range!!!";
                    }
                }
                if (roomIndex != -1)
                {
                    if (!Int32.TryParse(args[roomIndex], out roomNumber))
                    {
                        result = "Incorrect CLI format";
                    }
                    else if (Random.CheckStudentNumber(roomNumber) == -1)
                    {
                        result = "Room out of range!!!";
                    }
                }
                if (studentNumber > 0 && roomNumber > 0)
                {
                    bool ratio = Random.CheckRatio(studentNumber, roomNumber);
                    if (!ratio)
                    {
                        result = "The ratio between number of students and rooms is not ok";
                    }
                    _studentNumber = studentNumber;
                    _roomNumber = roomNumber;
                }
            }
            return result;
        }        
    }
}
