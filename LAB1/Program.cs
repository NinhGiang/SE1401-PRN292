using System;
using System.IO;
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
            string dir = ABC.createSchoolDir("Whatever");
            //ABC.save(@"..\..\Whatever\ABC.csv");
            ABC.save(dir + "/ABC.csv");
            Console.ReadLine();
            foreach (Student std in student_list)
            {
                std.print();
            }
        }
    }
}
