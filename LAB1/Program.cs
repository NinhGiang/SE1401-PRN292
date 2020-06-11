using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list = Student.Create(10);
            Field[] field_list = Field.Create();
            Teacher[] teacher_list = Teacher.Create(10, field_list);

            Container.StudentContainer stCon = new Container.StudentContainer(student_list);
            stCon.StudentSave(@"..\..\..\CSVPackage\Student.csv");
            Console.ReadLine();
        }
    }
}
