using System;
using System.Collections.Generic;

namespace StudentGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student_list = new List<Student>();
            student_list = Student.CreateStudentRandomly(10);
            foreach(Student student in student_list)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", student.ID, student.Name, student.Birthday, student.Gender, student.Class);
            }
            
            Console.ReadLine();
        }
    }
}
