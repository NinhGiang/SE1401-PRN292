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
            string info = CLIHelper.ShowCLI(args);
            if (info == "")
            {
                string schoolName = CLIHelper.SchoolName;
                int student = CLIHelper.NumberOfStudent;
                int room = CLIHelper.NumberOfRoom;

                School school = new School(schoolName);
                string directoryPath = @"..\..\..\" + schoolName;
                Directory.CreateDirectory(directoryPath);
                FileHelper.SetDirectoryPath(directoryPath);

                if (student == 0 && room == 0)
                {
                    student = GenerateDataHelper.GenerateRandomStudentAmount();
                    room = GenerateDataHelper.GenerateRoomAmountByStudent(student);
                }
                else if (student == 0 && room > 0)
                {
                    student = GenerateDataHelper.GenerateStudentAmountByRoom(room);
                }
                else if (student > 0 && room == 0)
                {
                    room = GenerateDataHelper.GenerateRoomAmountByStudent(student);
                }

                Level[] level_list = Level.Create();
                school.SetLevelList(level_list);
                school.SaveLevel(directoryPath + "\\" + "Level.csv");

                Field[] field_list = Field.Create();
                school.SetFieldList(field_list);
                school.SaveField(directoryPath + "\\" + "Field.csv");

                Dictionary<string, string> ids = FileHelper.CreateIdForRoomAndClass(room);

                Room[] room_list = Room.Create(ids);
                school.SetRoomList(room_list);
                school.SaveRoom(directoryPath + "\\" + "Room.csv");

                Class[] class_list = Class.Create(ids);
                school.SetClassList(class_list);
                school.SaveClass(directoryPath + "\\" + "Class.csv");

                Subject[] subject_list = Subject.Create();
                school.SetSubjectList(subject_list);
                school.SaveSubject(directoryPath + "\\" + "Subject.csv");

                Student[] student_list = Student.Create(student);
                school.SetStudentList(student_list);
                school.SaveStudent(directoryPath + "\\" + "Student.csv");

                Teacher[] teacher_list = Teacher.Create(student);
                school.SetTeacherList(teacher_list);
                school.SaveTeacher(directoryPath + "\\" + "Teacher.csv");

                Attendance[] attendance_list = Attendance.Create();
                school.SetAttendanceList(attendance_list);
                school.SaveAttendance(directoryPath + "\\" + "Attendance.csv");

                Grade[] grade_list = Grade.Create();
                school.SetGradeList(grade_list);
                school.SaveGrade(directoryPath + "\\" + "Grade.csv");

                Console.WriteLine("Succesful: You have a new school database with " + student + " students and " + room + " rooms");

                school.SaveSchool(directoryPath + "\\" + schoolName + ".json");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(info);
            }

            Console.ReadLine();
        }
    }
}
