using System;
using System.Text;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] student_list = Student.Create(100);
            School ABC = new School(student_list);
            ABC.save(@"..\..\..\ABC.csv");
            foreach (Student std in student_list)
            {
                std.print();
            }
            Console.ReadLine();
        }
    }
}
