using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ProgramManagerStudent;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace StudentGeneration
{
    class Program
    {
        
        static void Main(string[] args)
        {/*
            Student[] student_list = Student.Create(3000);
            School ABC = new School(student_list);
           
            ABC.save(@"..\..\..\ABC.csv");
            Console.ReadLine();*/


            /* Problem 1
            //UUID Generator
            Guid g = Guid.NewGuid(); // tạo 1 UUID
            Console.WriteLine(g); //version 4
            */
            /*
            List<string> videogames = new List<string>
                {
                    "Starcraft",
                    "Halo",
                    "Legend of Zelda"
                };

            string json = JsonConvert.SerializeObject(videogames);
            */
            //Console.WriteLine(json);
            // ["Starcraft","Halo","Legend of Zelda"]
            //string json = JsonConvert.SerializeObject(.ToArray());

            //write string to file
            //System.IO.File.WriteAllText(@"D:\path.txt", json);    }
            //À Đoàn hiểu rồi. code vớ vẩn. random ngyaf luôn cũng đc
            
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();

            //Tạo Room
            uint numbOfStudentInShool = (uint)rnd.Next(500, 3001);
            Console.WriteLine(numbOfStudentInShool);
            List<Room> roomList = Room.CreateRoom(numbOfStudentInShool);
            Room.SaveRooms(roomList);
            Console.WriteLine("Created Room!!");

            //Tạo Level
            uint numbOfRoom = (uint)roomList.Count();
            List<Level> levelList = Level.CreateLevel(numbOfRoom);
            Level.SaveLevel(levelList);
            Console.WriteLine("Created Level!!");

            //Tao Class


            uint numbOfClass = (uint)roomList.Count();

            /*

            uint numbOfClass = (uint)Math.Ceiling((double)numbOfStudentInShool / numbOfStudentInClass);
            uint numbOfClassOfLevel = (uint)Math.Ceiling((double)numbOfClass / 3);
            uint numbOfRoom = 1;
            int count = 0; //used when create class (add RoomUUID to Class object)
            uint numbOfTeacher = (uint)Math.Ceiling((double)numbOfClass / rnd.Next(4, 11));
            //Test Create method in Level class
            Level.Create();
            //Test Create method in Class class
            foreach (var level in Level.LevelList)
            {
                for (int i = 0; i < numbOfClassOfLevel; i++)
                {
                    Class.Create(level, "", i);
                    Room.Create(Class.ClassList[i], roomNo);
                    Class.ClassList[count].RoomUUID = Room.RoomList[count].UUID;
                    count++;
                    roomNo++;
                }
            }
            //Test Create method in Student class
            foreach (var classObject in Class.ClassList)
            {
                for (int i = 0; i < noOfStudentInClass; i++)
                {
                    Student.Create(classObject);
                }
            }
            //Test Create method in Field class
            /*Field.Create();
            for (int i = 0; i < noOfTeacher; i++)
            {
                Teacher.Create(Field.FieldList[rnd.Next(10)]);
            }
            */
            /*
            Level.SaveLevels(@"..\..\..\Levels.csv");
            Class.SaveClasses(@"..\..\..\Classes.csv");
            Room.SaveRooms(@"..\..\..\Rooms.csv");
            Student.SaveStudents(@"..\..\..\Students.csv");
            Field.SaveFields(@"..\..\..\Fields.csv");
            Teacher.SaveTeachers(@"..\..\..\Teachers.csv");
            */

        }

    }
}