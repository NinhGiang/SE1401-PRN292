using LAB1.StudentGeneration;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace StudentGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            FileDataManagement.createDirectory("abc");

            List<Level> levels = Level.createLevels(3);
            FileDataManagement.saveLevels("abc", levels);

            List<Room> rooms = Room.createRoomRandomly(45);
            FileDataManagement.saveRooms("abc", rooms);

            List<SchoolClass> classes = SchoolClass.createClasses("abc", 45);
            FileDataManagement.saveClass("abc", classes);

            List<Student> students = Student.CreateStudentRandomly(2000);
            FileDataManagement.saveStudents("abc", students);

            List<Field> fields = Field.CreateFields();
            FileDataManagement.saveFields("abc", fields);

            List<Subject> subjects = Subject.createSubjects();
            FileDataManagement.saveSubjects("abc", subjects);
            Console.ReadLine();
        }

        public static void displayHelp()
        {
            Console.WriteLine(@"./schoolDatabaseGenerator <<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100 
	./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100 
	./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.
	./schoolDatabaseGenerator <<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.");    
        }
    }
}
