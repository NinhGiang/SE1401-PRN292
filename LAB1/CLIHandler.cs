using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// The CLIHandler Class.
    /// Contains all methods regarding CLI
    /// </summary>
    class CLIHandler
    {
        /// <summary>
        /// Name of school
        /// </summary>
        private static string _school_name;
        /// <summary>
        /// Number of students
        /// </summary>
        private static int _student_num;
        /// <summary>
        /// Number of rooms
        /// </summary>
        private static int _room_num;

        /// <summary>
        /// Get name of school
        /// </summary>
        public static string SchoolName
        {
            get { return _school_name; }
        }
        /// <summary>
        /// Get number of students
        /// </summary>
        public static int StudentNum
        {
            get { return _student_num; }
        }
        /// <summary>
        /// Get number of rooms
        /// </summary>
        public static int RoomNum
        {
            get { return _room_num; }
        }
        /// <summary>
        /// Check if the command line contains target word
        /// </summary>
        /// <param name="args">An array of string</param>
        /// <param name="value">A string value</param>
        /// <returns>Return the target word if found , return -1 if not </returns>
        public static int getIndexFromArray (string[] args, string value)
        {
            int result = -1;
            bool found = false;
            for (int i = 0; i < args.Length && found == false ; i++)
            {
                if (args[i].Equals(value))
                {
                    result = i;
                }
            }
            return result;
        }
        /// <summary>
        /// Check CLI, show error if any
        /// </summary>
        /// <param name="args">An array of string</param>
        /// <returns>Return CLI message </returns>
        public static string CheckCLI(string[] args)
        {
            string result = "";
            string help = @"Help: 
 ./ schoolDatabaseGenerator << school_name >>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100
 ./ schoolDatabaseGenerator << school_name >> -s << number_students >>: Generate a school database with << number_students >> in range 500 to 3000 and the largest number rooms is 100
 ./ schoolDatabaseGenerator << school_name >> -r << number_rooms >>: Generate a school database with << number_rooms >> and number students in range 500 to 3000.
 ./ schoolDatabaseGenerator << school_name >> -s << number_students >> -r << number_rooms >>: Generate a school database with << number_students >> and << number_rooms >>.";
            if (args.Length == 0 || (args.Length == 1 && args[0].Equals("-h") ) )
            {
                result = help;
            }
            else if (args.Length > 0 && !args[0].Equals("-h") && !args[0].Equals("-s") && args[0].Equals("-r"))
            {
                result = "Error : Something is wrong";
            }
            else if (args.Length == 1 && ( args[0].Equals("-s") || args[0].Equals("-r") ))
            {
                result = "Please input a school name";
            }
            else
            {
                _school_name = args[0];
                int studentNumIndex = getIndexFromArray(args, "-s") + 1;
                int roomNumIndex = getIndexFromArray(args, "-r") + 1;
                int studentNum = 0;
                int roomNum = 0;
                bool foundError = false;

                if (studentNumIndex > 0)
                {
                    bool checkParse = Int32.TryParse(args[studentNumIndex], out studentNum);
                    if (!checkParse)
                    {
                        result += "Error : CLI format for student number is incorrect .\n";
                        foundError = true;
                    }
                    else
                    {
                        if (!Utils.CheckNumber(studentNum,500,3000))
                        {
                            result += "Error : Student number must be 500 to 3000 .\n";
                            foundError = true;
                        }
                    }
                }
                if (roomNumIndex > 0)
                {
                    bool checkParse = Int32.TryParse(args[roomNumIndex], out roomNum);
                    if (!checkParse)
                    {
                        result += "Error : CLI format for room number is incorrect .\n";
                        foundError = true;
                    }
                    else
                    {
                        if (!Utils.CheckNumber(roomNum,1,99))
                        {
                            result += "Error : Room number must be below 100 .\n";
                            foundError = true;
                        }
                    }
                }
                if (!foundError)
                {
                    if (studentNumIndex == 0 && roomNumIndex == 0)
                    {
                        studentNum = Utils.GenerateRandomStudentNumber();
                        roomNum = Utils.GenerateRandomRoomNumberByStudentNumber(studentNum);
                    }
                    else if (studentNumIndex > 0 && roomNumIndex == 0)
                    {
                        roomNum = Utils.GenerateRandomRoomNumberByStudentNumber(studentNum);
                    }
                    else if (studentNumIndex == 0 && roomNumIndex > 0)
                    {
                        studentNum = Utils.GenerateRandomStudentNumberByRoomNumber(roomNum);
                    }
                    else
                    {
                        if (!Utils.ValidateStudentAndRoomNumber(studentNum, roomNum))
                        {
                            result = "Invalid student to room ratio (Each room must have 30 - 50 student)";
                        }
                    }
                    _student_num = studentNum;
                    _room_num = roomNum;
                }
            }
            return result;
        }
    }
}
