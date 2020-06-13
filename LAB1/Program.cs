using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace LAB1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string checkError = CLIHandler.CheckCLI(args);
            if (checkError.Length != 0)
            {
                Console.WriteLine(checkError);
            }
            else
            {
                Console.WriteLine("Test Lab");

                string schoolName = "ABC";
                int roomAndClassNum = 20;
                int studentNum = 200;

                School school = new School();
                school.SchoolName = schoolName;

                //create school folder
                string directoryPath = @"..\..\..\" + school.SchoolName;
                Directory.CreateDirectory(directoryPath);
                DatabaseHandler dr = new DatabaseHandler();
                dr.DirectoryPath = directoryPath;
                //create level
                Level[] level_list = Level.CreateLevel();
                school.LevelList = level_list;
                school.SaveLevel(directoryPath + "\\" + "Level.csv");

                //create field
                Field[] field_list = Field.CreateField();
                school.FieldList = field_list;
                school.SaveField(directoryPath + "\\" + "Field.csv");

                //create subject
                Subject[] subject_list = Subject.createSubject();
                school.SubjectList = subject_list;
                school.SaveSubject(directoryPath + "\\" + "Subject.csv");

                //create Teacher
                Teacher[] teacher_list = Teacher.createTeacher(30);
                school.TeacherList = teacher_list;
                school.SaveTeacher(directoryPath + "\\" + "Teacher.csv");

                //create room and class
                Dictionary<string, string> roomAndClassIDList = Utils.GenerateRoomAndClassID(roomAndClassNum);
                Room[] room_list = Room.createRoom(roomAndClassIDList);
                school.RoomList = room_list;
                school.SaveRoom(directoryPath + "\\" + "Room.csv");

                Class[] class_list = Class.createClass(roomAndClassIDList);
                school.ClassList = class_list;
                school.SaveClass(directoryPath + "\\" + "Class.csv");

                Student[] student_list = Student.createStudent(studentNum);
                school.StudentList = student_list;
                school.SaveStudent(directoryPath + "\\" + "Student.csv");

                Grade[] grade_list = Grade.CreateGrade();
                school.GradeList = grade_list;
                school.SaveGrade(directoryPath + "\\" + "Grade.csv");

                Attendance[] attendance_list = Attendance.CreateAttendance();
                school.AttendanceList = attendance_list;
                school.SaveAttendance(directoryPath + "\\" + "Attendance.csv");

                File.WriteAllText(directoryPath + "\\" + "Database.json", JsonSerializer.Serialize(school));

            }

            Console.ReadLine();
        }

    }
}
