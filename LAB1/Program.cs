using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Allow output unicode
            Console.OutputEncoding = Encoding.UTF8;
            //New empty school
            School ABC = new School();
            //Create directory
            string dir = ABC.createSchoolDir("Whatever");
            //Create student list, save csv and json
            Student[] student_list = Student.Create(100);
            ABC.StudentList = new List<Student>(student_list); //add for other usage
            ABC.saveStudent(dir + "/Students.csv");
            ABC.saveStudent(dir + "/Students.json");
            //Create level list, save csv and json
            Level[] level_list = Level.Create(3);
            ABC.LevelList = new List<Level>(level_list); //add for other usage
            ABC.saveLevel(dir + "/Levels.csv");
            ABC.saveLevel(dir + "/Levels.json");
            //Create class list ONLY AFTER save levels.json
            Class[] class_list = Class.Create(100);
            ABC.ClassList = new List<Class>(class_list); //add for other usage
            ABC.saveClass(dir + "/Classes.csv");
            ABC.saveClass(dir + "/Classes.json");
            //Create room list ONLY AFTER save classes.json
            Room[] room_list = Room.Create(100);
            ABC.RoomList = new List<Room>(room_list); //add for other usage
            ABC.saveRoom(dir + "/Rooms.csv");
            ABC.saveRoom(dir + "/Rooms.json");
            //Fill the ABC
            Field[] field_list = Field.Create(5);
            foreach (Student std in student_list)
            {
                std.print();
            }
            foreach (Level lv in level_list)
            {
                lv.print();
            }
            foreach (Field fd in field_list)
            {
                fd.print();
            }
        }
    }
}
