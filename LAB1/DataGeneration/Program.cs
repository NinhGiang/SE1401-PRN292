using System;
using System.Dynamic;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   
            Student[] stuList;
               stuList = Student.Create(20);
               foreach (Student student in stuList)
               {
                   Console.WriteLine("{0}, {1}, {2}, {3}, {4}", student.Uuid, student.Name, student.Gender, student.Birthday.ToString("d"), student.Class);
               }
               Console.ReadLine(); 
               */
            
            Student[] student_list = Student.Create(20);
            School ABC = new School(student_list);
            ABC.saveStudent(@"E:/FPT/VS C# & .NET/tieuminh2510/SE1401-PRN292/LAB1/DataGeneration/FPT大学.csv");
            Console.WriteLine("Succeed!!!!!!!!");
            Console.ReadLine();
            
        }
    }
}
