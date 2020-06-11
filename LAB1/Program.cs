using System;
using System.Text;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] student_list = Student.Create(200);
            foreach (var item in student_list)
            {
                item.Print();
            }
            Console.WriteLine(student_list);
            //School ABC = new School(student_list);//
            //ABC.save(@"..\..\..\ABC.csv");//
            Console.ReadLine();
        }
    }
}
