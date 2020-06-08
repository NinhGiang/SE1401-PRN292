using System;

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

            Room[] room_list = Room.Create(20);
            school.SetRoomList(room_list);
            school.SaveRoom(@"..\..\..\Room.csv");
            Console.WriteLine("Room");

            ClassInfo[] class_list = ClassInfo.Create();
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

            Console.ReadLine();
        }
    }
}
