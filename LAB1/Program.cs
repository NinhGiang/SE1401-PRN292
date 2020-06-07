using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Test!!!");
            Console.ReadLine();
            Student[] student_list = Student.Create(20);
            School school = new School(student_list);
            school.Save(@"..\..\..\School.csv");
            Console.ReadLine();
        }
    }
}
