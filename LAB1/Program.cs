﻿using System;
using System.Collections.Generic;
using System.IO;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Lab");
            
            School school = new School();
            school.SchoolName = "ABC";
            //create school folder
            string directoryPath = @"..\..\..\" + school.SchoolName;
            Directory.CreateDirectory(directoryPath);
            DataReader dr = new DataReader();
            dr.DirectoryPath = directoryPath;
            //create level
            Level[] level_list = Level.CreateLevel();
            school.LevelList = level_list;
            school.saveLevel(directoryPath + "\\" + "Level.csv");

            //create field
            Field[] field_list = Field.CreateField();
            school.FieldList = field_list;
            school.saveField(directoryPath + "\\" + "Field.csv");

            //create subject
            Subject[] subject_list = Subject.createSubject();
            school.SubjectList = subject_list;
            school.saveSubject(directoryPath + "\\" + "Subject.csv");
            
            //create Teacher
            Teacher[] teacher_list = Teacher.createTeacher(30);
            school.TeacherList = teacher_list;
            school.saveTeacher(directoryPath + "\\" + "Teacher.csv");

            //create room and class
            Dictionary<string, string> roomAndClassIDList = Utils.generateRoomAndClassID(20);
            Room[] room_list = Room.createRoom(roomAndClassIDList);
            school.RoomList =  room_list;
            school.saveRoom(directoryPath + "\\" + "Room.csv");

            Class[] class_list = Class.createClass(roomAndClassIDList);
            school.ClassList = class_list;
            school.saveClass(directoryPath + "\\" + "Class.csv");

            Console.ReadLine();
        }

    }
}
