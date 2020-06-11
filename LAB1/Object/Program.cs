using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list = Student.Create(100);
            School ABC = new School(student_list);
            ABC.save(@"..\..\..\ABC.csv");
            Console.ReadLine();
        }
    }
}
