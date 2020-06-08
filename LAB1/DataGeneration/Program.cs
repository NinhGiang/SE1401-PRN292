using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stuList;
            stuList = Student.Create(20);
            foreach(Student student in stuList)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", student.Uuid, student.Name, student.Gender, student.Birthday, student.Class);
            }
            Console.ReadLine();
            
        }
    }
}
