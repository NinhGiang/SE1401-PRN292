using System;

namespace SchoolGenerating
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list = Student.Create(100);
            foreach (var Student in student_list)
            {
                Student.print();
            }
            Console.ReadLine();
            
        }
    }
}
