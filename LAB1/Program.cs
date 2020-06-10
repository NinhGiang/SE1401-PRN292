using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list = Student.Create(20);
            School FPT = new School(student_list);
            FPT.save(@"..\..\..\FPT.csv");
            Console.ReadLine();

        }
    }
}
