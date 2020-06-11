using System;
using System.IO;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************School system*******************");


            Student[] stuList;
            stuList = Student.CreateStudent(10);

            foreach (Student student in stuList)
            {
                Console.WriteLine("{0}, {1}", student.StuID, student.Fullname);
            }

            string stuContent = "ID, Fullname\n";
            string stuFile = @"..\..\..\Student.csv";
            foreach (Student student in stuList)
            {
                stuContent += student.StuID + ", "
                    + student.Fullname + "\n";
            }
            File.WriteAllText(stuFile, stuContent);

            Console.ReadLine();
        }
    }
}
