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

            School ABC = new School();
            Level[] _level_list = Level.createLevel();
            ABC.setLevels(_level_list);
            ABC.saveLevel(@"..\..\..\DataGeneration\Level.csv");
            Console.WriteLine("Level saved!");
          
            Room[] _room_list = Room.createRoom(initial / 40);
            ABC.setRooms(_room_list);
            ABC.saveRoom(@"..\..\..\DataGeneration\Room.csv");
            Console.WriteLine("Room saved!");

            Classes[] _classes_list = Classes.createClasses(initial / 40);
            ABC.setClasses(_classes_list);
            ABC.saveClasses(@"..\..\..\DataGeneration\Class.csv");
            Console.WriteLine("Class saved!");



            Student[] _student_list = Student.createStudent(initial);
            ABC.setStudents(_student_list);
            ABC.saveStudent(@"..\..\..\DataGeneration\FPT大学.csv");
            Console.WriteLine("Student saved!");

            Console.WriteLine("Succeed!!!!!!!!");
            Console.ReadLine();
        }
    }
}
