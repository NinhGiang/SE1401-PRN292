using LAB1.DataGeneration;
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
            uint initial = 160;

            Student[] _student_list = Student.createStudent(initial);
            Room[] _room_list = Room.createRoom(initial/40);
            School ABC = new School(_student_list, _room_list);

            ABC.saveStudent(@"..\..\..\DataGeneration\FPT大学.csv");
            ABC.saveRoom(@"..\..\..\DataGeneration\Room.csv");
            Console.WriteLine("Succeed!!!!!!!!");
            Console.ReadLine();


        }
    }
}
