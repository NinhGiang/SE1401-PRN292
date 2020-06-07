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

            Level[] level_list = Level.Create();
            school.SetLevelList(level_list);
            school.SaveLevel(@"..\..\..\Level.csv");

            Field[] field_list = Field.Create();
            school.SetFieldList(field_list);
            school.SaveField(@"..\..\..\Field.csv");

            Room[] room_list = Room.Create(20);
            school.SetRoomList(room_list);
            school.SaveRoom(@"..\..\..\Room.csv");

            ClassInfo[] class_list = ClassInfo.Create();
            school.SetClassList(class_list);
            school.SaveClass(@"..\..\..\Class.csv");

            Student[] student_list = Student.Create(20);
            school.SetStudentList(student_list);            
            school.SaveStudent(@"..\..\..\Student.csv");


            Console.ReadLine();
        }
    }
}
