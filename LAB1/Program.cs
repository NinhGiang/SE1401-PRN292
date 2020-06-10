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
            ABC.saveLevel(@"..\..\..\LAB1\Level.csv");
            Console.WriteLine("Level saved!");

            Room[] _room_list = Room.Create(initial / 40);
            ABC.SetRooms(_room_list);
            ABC.saveRoom(@"..\..\..\LAB1\Room.csv");
            Console.WriteLine("Room saved!");

            ClassInfo[] _classes_list = ClassInfo.Create(initial / 40);
            ABC.SetClasses(_classes_list);
            ABC.saveClasses(@"..\..\..\LAB1\Class.csv");
            Console.WriteLine("Class saved!");      



            Student[] _student_list = Student.Create(initial);
            ABC.SetStudents(_student_list);
            ABC.saveStudent(@"..\..\..\LAB1\FPT.csv");
            Console.WriteLine("Student saved!"); 

            Console.WriteLine("Succeed!!!!!!!!");
            Console.ReadLine();
        }
    }
}
