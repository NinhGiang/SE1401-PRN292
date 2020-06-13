﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class CLIHelper
    {
        private static int _numberOfStudent;
        private static int _numberOfRoom;
        private static string _schoolName;

        public static int NumberOfStudent
        { get { return _numberOfStudent; } }

        public static int NumberOfRoom
        { get { return _numberOfRoom; } }

        public static string SchoolName
        { get { return _schoolName; } }

        public static int CheckContain(string[] args, string targetValue)
        {
            int result = -1;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Equals(targetValue))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Show CLI message
        /// </summary>
        /// <param name="args">An array of strings</param>
        /// <returns>CLI message</returns>
        public static String ShowCLI(string[] args)
        {
            string helpString = @"  Help: 
./schoolDatabaseGenerator <<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100 
./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100 
./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.
./schoolDatabaseGenerator <<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.";


            if ((args.Length == 0) || (args.Length == 1 && args[0].Equals("-h")))
            {
                return helpString;

            }
            else if (args.Length > 0 && !args[0].Equals("-h") && (args[0].Equals("-s") || args[0].Equals("-r")))
            {
                return "Please input school name.";
            }
            else
            {
                _schoolName = args[0];
                int indexStudent = CheckContain(args, "-s");
                int indexRoom = CheckContain(args, "-r");
                int numberOfStudent = 0, numberOfRoom = 0;
                if (indexStudent != -1)
                {
                    if ((indexStudent + 1) == args.Length || !Int32.TryParse(args[indexStudent + 1], out numberOfStudent))
                    {
                        return "Error: Your CLI format is not correct.";
                    }
                    else
                    {
                        if (GenerateDataHelper.CheckStudentAmount(numberOfStudent) == -1)
                        {
                            return "Error: You must input number student in range 500 to 3000";
                        }
                    }
                }

                if (indexRoom != -1)
                {
                    if ((indexRoom + 1) == args.Length || !Int32.TryParse(args[indexRoom + 1], out numberOfRoom))
                    {
                        return "Error: Your CLI format is not correct.";
                    }
                    else
                    {
                        if (GenerateDataHelper.CheckRoomAmount(numberOfRoom) == -1)
                        {
                            return "Error: You must input number room smaller than 100";
                        }
                    }
                }

                if (numberOfStudent > 0 && numberOfRoom > 0)
                {
                    bool check = GenerateDataHelper.CheckValidNumber(numberOfStudent, numberOfRoom);
                    if (!check)
                    {
                        return "Error: Invalid number of student or room. (Each room can only contains 30-50 students)";
                    }
                    _numberOfStudent = numberOfStudent;
                    _numberOfRoom = numberOfRoom;
                }
            }
            return "";
        }
    }
}
