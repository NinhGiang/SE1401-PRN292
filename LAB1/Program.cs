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
            Console.ReadLine();

            Level[] level_list = Level.Create();
            school.SetLevelList(level_list);
            school.SaveLevel(@"..\..\..\Level.csv");
            Console.ReadLine();
        }
    }
}
