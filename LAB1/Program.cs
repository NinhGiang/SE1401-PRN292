using System;
using System.IO;
using System.Text;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] student_list = Student.Create(100);
            Level[] level_list = Level.Create(3);
            Field[] field_list = Field.Create(5);
            //Subject[] subject_list = Subject.Create();
            Room[] room_list = Room.Create(100);
            School ABC = new School(student_list, level_list);
            string dir = ABC.createSchoolDir("Whatever");
            //ABC.save(@"..\..\Whatever\ABC.csv");
            ABC.saveStudent(dir + "/Students.csv");
            ABC.saveStudent(dir + "/Students.json");
            ABC.saveLevel(dir + "/Levels.csv");
            ABC.saveLevel(dir + "/Levels.json");
            //Create Subject only after generating Levels.json
            Subject[] subject_list = Subject.Create();

            //print for tracking
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
            foreach (Room rm in room_list)
            {
                rm.print();
            }
        }
    }
}
