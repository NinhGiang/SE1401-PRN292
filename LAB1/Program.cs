using Microsoft.VisualBasic;
using System;
using System.Dynamic;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create list of 100 students
            Student[] student_list = Student.Create(100);
            foreach (Student student in student_list)
            {
                // print list of students
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} |", student.ID, student.FullName, student.Birthday.ToString("dd/MM/yyyy"), student.Gender, student.ClassID);
            }
            Console.ReadLine();
        }
    }
}
