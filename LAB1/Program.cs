using System;
using System.Collections.Generic;
using System.IO;

namespace LAB1
{
    /// <summary>
    /// The main Program class.
    /// Contains main methods.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Performs functions.
        /// </summary>
        /// <param name="args">A string array contains command from command-line</param>
        public static void Main(string[] args)
        {
            CLIHelper helper = new CLIHelper();
            AddInstruction(helper);

            while (true)
            {
                string schoolName;
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please input command line.");
                }   //input rỗng
                else if (!input.Contains("./schoolDatabaseGenerator"))
                {
                    Console.WriteLine("Wrong format");
                }   //không có tên chương trình
                else if (input.Contains("-h"))
                {
                    helper.DisplayInstruction();
                }   //-h show menu
                else
                {
                    if (!input.Contains("-s") && !input.Contains("-r"))
                    {
                        schoolName = input.Replace("./schoolDatabaseGenerator", "").Trim();
                    }   //chỉ có tên trường
                    else
                    {
                        schoolName = GenerateDataHelper.GetSchoolName(input);
                    }

                    if (schoolName != null)
                    {
                        bool err = false;
                        int numberOfStudent = 0, numberOfRoom = 0;
                        if (input.Contains("-s"))
                        {
                            numberOfStudent = GenerateDataHelper.GetStudentAmount(input);
                        }

                        if (input.Contains("-r"))
                        {
                            numberOfRoom = GenerateDataHelper.GetRoomAmount(input);
                        }

                        //invalid input
                        if (numberOfStudent == -1)
                        {
                            Console.WriteLine("You must input number student in range 500 to 3000");
                            err = true;
                        }

                        if (numberOfRoom == -1)
                        {
                            Console.WriteLine("You must input number room smaller than 100");
                            err = true;
                        }

                        if (!err)
                        {
                            School school = new School(schoolName);
                            string directoryPath = @"..\..\..\" + schoolName;
                            Directory.CreateDirectory(directoryPath);
                            FileHelper.SetDirectoryPath(directoryPath);

                            if (numberOfStudent == 0 && numberOfRoom == 0)
                            {
                                numberOfStudent = GenerateDataHelper.GenerateRandomStudentAmount();
                                numberOfRoom = GenerateDataHelper.GenerateRoomAmountByStudent(numberOfStudent);
                            }
                            else if (numberOfStudent == 0 && numberOfRoom > 0)
                            {
                                numberOfStudent = GenerateDataHelper.GenerateStudentAmountByRoom(numberOfRoom);
                            }
                            else if (numberOfStudent > 0 && numberOfRoom == 0)
                            {
                                numberOfRoom = GenerateDataHelper.GenerateRoomAmountByStudent(numberOfStudent);
                            }

                            Level[] level_list = Level.Create();
                            school.SetLevelList(level_list);
                            school.SaveLevel(directoryPath + "\\" + "Level.csv");

                            Field[] field_list = Field.Create();
                            school.SetFieldList(field_list);
                            school.SaveField(directoryPath + "\\" + "Field.csv");

                            Dictionary<string, string> ids = FileHelper.CreateIdForRoomAndClass(numberOfRoom);

                            Room[] room_list = Room.Create(ids);
                            school.SetRoomList(room_list);
                            school.SaveRoom(directoryPath + "\\" + "Room.csv");

                            ClassInfo[] class_list = ClassInfo.Create(ids);
                            school.SetClassList(class_list);
                            school.SaveClass(directoryPath + "\\" + "Class.csv");

                            Subject[] subject_list = Subject.Create();
                            school.SetSubjectList(subject_list);
                            school.SaveSubject(directoryPath + "\\" + "Subject.csv");

                            Student[] student_list = Student.Create(numberOfStudent);
                            school.SetStudentList(student_list);
                            school.SaveStudent(directoryPath + "\\" + "Student.csv");

                            Teacher[] teacher_list = Teacher.Create(numberOfStudent);
                            school.SetTeacherList(teacher_list);
                            school.SaveTeacher(directoryPath + "\\" + "Teacher.csv");

                            Attendance[] attendance_list = Attendance.Create();
                            school.SetAttendanceList(attendance_list);
                            school.SaveAttendance(directoryPath + "\\" + "Attendance.csv");

                            Grade[] grade_list = Grade.Create();
                            school.SetGradeList(grade_list);
                            school.SaveGrade(directoryPath + "\\" + "Grade.csv");

                            Console.WriteLine("Generate successfully");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please input school name");
                    }
                }
            }
        }


        /// <summary>
        /// Add instruction to show in CLI view
        /// </summary>
        /// <param name="helper"></param>
        private static void AddInstruction(CLIHelper helper)
        {
            helper.AddInstruction("./schoolDatabaseGenerator <<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100");
            helper.AddInstruction("./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100");
            helper.AddInstruction("./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.");
            helper.AddInstruction("./schoolDatabaseGenerator <<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.");
        }
    }
}
