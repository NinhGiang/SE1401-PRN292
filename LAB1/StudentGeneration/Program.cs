using System;
using System.Collections.Generic;

namespace StudentGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list;
            student_list = Student.CreateStudentRandomly(20);

            string input = Console.ReadLine();
            
            switch (input)
            {
                case "s":
                    foreach (Student student in student_list)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}",
                            student.ID, student.Name, student.Gender, student.Birthday.ToString("d"));
                        //, {2}, {3}, {4}
                        //, student.Birthday, student.Gender, student.Class
                    }
                    break;

            }

            

            Console.ReadLine();
        }
    }
}
