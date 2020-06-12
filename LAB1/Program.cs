using LAB1;
using System;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] student_list = Student.Create(10);
            Level[] level = Level.Create();
            foreach (var item in student_list)
            {
                item.Print();
            }
            foreach (var item in level)
            {
                item.Print();
            }
            
            Console.WriteLine(student_list);
            Console.WriteLine(level);
            //School ABC = new School(student_list);//
            //ABC.save(@"..\..\..\ABC.csv");//
            Console.ReadLine();
        }
    }
}
