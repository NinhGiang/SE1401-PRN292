using System;
using System.Data.SqlClient;

namespace StudentGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list = Student.Create(3000);
            School ABC = new School(student_list);
            ABC.save(@"..\..\..\ABC.csv");
            Console.ReadLine();
        }
    }
}
