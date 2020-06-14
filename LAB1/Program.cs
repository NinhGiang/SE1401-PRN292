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
            //Create student list ONLY AFTER save classes.json
            Student[] student_list = Student.Create(200);
            ABC.StudentList = new List<Student>(student_list); //add for other usage
            ABC.saveStudent(dir + "/Students.csv");
            ABC.saveStudent(dir + "/Students.json");


            //Create field list, save csv and json
            Field[] field_list = Field.Create(14);
            ABC.FieldList = new List<Field>(field_list); //add for other usage
            ABC.saveField(dir + "/Fields.csv");
            ABC.saveField(dir + "/Fields.json");
            //Create subject list ONLY AFTER save fields.json
            Subject[] subject_list = Subject.Create();
            ABC.SubjectList = new List<Subject>(subject_list); //add for other usage
            ABC.saveSubject(dir + "/Subjects.csv");
            ABC.saveSubject(dir + "/Subjects.json");
            //Create teacher list ONLY AFTER save fields.json
            Teacher[] teacher_list = Teacher.Create(42);
            ABC.TeacherList = new List<Teacher>(teacher_list); //add for other usage
            ABC.saveTeacher(dir + "/Teachers.csv");
            ABC.saveTeacher(dir + "/Teachers.json");

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
            foreach (Subject sbj in subject_list)
            {
                sbj.print();
            }
        }
    }
}
