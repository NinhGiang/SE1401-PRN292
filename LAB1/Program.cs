using System;
using System.Collections.Generic;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Test!!!");
            Console.ReadLine();

            School school = new School();
            Console.WriteLine("Test Test!!!");

            Level[] level_list = Level.Create();
            school.SetLevelList(level_list);
            school.SaveLevel(@"..\..\..\Level.csv");
            Console.WriteLine("Level");

            Field[] field_list = Field.Create();
            school.SetFieldList(field_list);
            school.SaveField(@"..\..\..\Field.csv");
            Console.WriteLine("Field");

            Dictionary<string, string> ids = DataHelper.CreateIdForRoomAndClass(20);

            Room[] room_list = Room.Create(ids);
            school.SetRoomList(room_list);
            school.SaveRoom(@"..\..\..\Room.csv");
            Console.WriteLine("Room");

            ClassInfo[] class_list = ClassInfo.Create(ids);
            school.SetClassList(class_list);
            school.SaveClass(@"..\..\..\Class.csv");
            Console.WriteLine("ClassInfo");

            Subject[] subject_list = Subject.Create();
            school.SetSubjectList(subject_list);
            school.SaveSubject(@"..\..\..\Subject.csv");
            Console.WriteLine("Subject");

            Student[] student_list = Student.Create(20);
            school.SetStudentList(student_list);            
            school.SaveStudent(@"..\..\..\Student.csv");
            Console.WriteLine("Student");

            Teacher[] teacher_list = Teacher.Create(20);
            school.SetTeacherList(teacher_list);
            school.SaveTeacher(@"..\..\..\Teacher.csv");
            Console.WriteLine("Teacher");

            Attendance[] attendance_list = Attendance.Create();
            school.SetAttendanceList(attendance_list);
            school.SaveAttendance(@"..\..\..\Attendance.csv");
            Console.WriteLine("Attendance");

            Grade[] grade_list = Grade.Create();
            school.SetGradeList(grade_list);
            school.SaveGrade(@"..\..\..\Grade.csv");
            Console.WriteLine("Grade");

            Console.ReadLine();
        }
    }
}
