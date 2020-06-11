using System;
using System.Text;
using System.IO;


namespace LAB1.Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] student_list = Student.addNewStudent(100);
            School ABC = new School(student_list);
            ABC.save(@"..\..\..\ABC.csv");
            Console.ReadLine();
        }
    }
}
