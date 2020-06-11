using Microsoft.VisualBasic;
using System;
using System.Dynamic;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint initial = 200;

            School ABC = new School();
            Level[] _level_list = Level.Create();
            ABC.SetLevels(_level_list);
            ABC.createCsvLevel(@"..\..\..\Level.csv");
            Console.WriteLine("Level saved!");

            Room[] _room_list = Room.Create(initial / 40);
            ABC.SetRooms(_room_list);
            ABC.createCsvRoom(@"..\..\..\Room.csv");
            Console.WriteLine("Room saved!");

            ClassInfo[] _classes_list = ClassInfo.Create(initial / 40);
            ABC.SetClasses(_classes_list);
            ABC.createCsvClasses(@"..\..\..\Class.csv");
            Console.WriteLine("Class saved!");      



            Student[] _student_list = Student.Create(initial);
            ABC.SetStudents(_student_list);
            ABC.createCsvStudent(@"..\..\..\FPT.csv");
            Console.WriteLine("Student saved!"); 

            /*Student[] stuList;
              stuList = Student.Create(20);
              foreach (Student student in stuList)
              {
                  Console.WriteLine("{0}, {1}, {2}, {3}, {4}", student.ID, student.FullName, student.Gender, student.Birthday.ToString("d"), student.ClassID);
              }
            Console.WriteLine("Succeed!!!!!!!!");
            Console.ReadLine();*/
        }
    }
}
