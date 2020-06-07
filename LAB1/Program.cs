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

            Student[] student_list = Student.Create(20);
            school.SetStudentList(student_list);            
            school.SaveStudent(@"..\..\..\Student.csv");

            Level[] level_list = Level.Create();
            school.SetLevelList(level_list);
            school.SaveLevel(@"..\..\..\Level.csv");

            Field[] field_list = Field.Create();
            school.SetFieldList(field_list);
            school.SaveField(@"..\..\..\Field.csv");

            Console.ReadLine();
        }
    }
}
