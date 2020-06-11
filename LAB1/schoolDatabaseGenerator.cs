
using System;
using System.IO;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// The main SchoolDatabaseGenerator class.
    /// Contains Main method.
    /// </summary>
    class SchoolDatabaseGenerator
    {       
        /// <summary>
        /// Used to perform functions.
        /// </summary>
        /// <param name="args">A string array contains command from command-line.</param>
        public static void Main(string[] args)
        {
            /*bool valid;
            if (args.Length < 5)
            {
                valid = true;
                foreach (var command in args)
                {
                    if (!string.Equals(command, "-s") || !string.Equals(command, "-r") || Regex.IsMatch(command, @"\d"))
                    {
                        valid = false;
                    }
                    else if (string.Equals(command, "-h"))
                    {
                        valid = true;
                        Console.WriteLine("Help:");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>>: Generate a school database " +
                            "with number students in range 500 to 3000, and the largest number rooms is 100");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: " +
                            "Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: " +
                            "Generate a school database with <<number_rooms>> and number students in range 500 to 3000");
                        Console.WriteLine("/t./schoolDatabaseGenerator <<school_name>> -s <<number_students>> " +
                            "-r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>");
                    }
                    else
                    {
                        valid = true;
                    }
                }              
            } 
            else
            {
                valid = false;
                
            }

            if (valid == true)
            {
                Console.WriteLine("Valid command!");
            }
            else
            {
                Console.WriteLine("Invalid command!");
            }*/
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            uint noOfStudentsInClass = (uint) rnd.Next(30, 51);
            uint noOfClasses = (uint) Math.Ceiling((double) 1000 / noOfStudentsInClass);
            uint noOfClassesPerLevel = (uint) Math.Ceiling((double) noOfClasses / 3);
            uint roomNo = 1;
            int start = (int)Math.Ceiling((double)noOfClasses / 10);
            int end = (int)Math.Ceiling((double)noOfClasses / 4);
            uint noOfTeachers;
            int count = 0; //used when create class (add RoomUUID to Class object)
            
            //Test Create method in Level class
            Level.Create();
            //Test Create method in Field class
            Field.Create();
            //Test Create method in Class class
            foreach (var level in Level.LevelsList)
            {
                noOfTeachers = (uint)rnd.Next(start, end + 1);
                for (int i = 0; i < noOfClassesPerLevel; i++)
                {
                    Class.Create(level, "", i);
                    Room.Create(Class.ClassesList[i], roomNo);
                    Class.ClassesList[count].RoomUUID = Room.RoomsList[count].UUID;
                    count++;
                    roomNo++;
                }
                for (int i = 0; i < noOfTeachers; i++)
                {
                    Teacher.Create(Field.FieldsList[rnd.Next(10)]);
                    Subject.Create(level, Field.FieldsList[i]);
                    for (int j = 0; j < rnd.Next(4, 11); j++)
                    {
                        Attendance.Create(Teacher.TeachersList[i], Class.ClassesList[j], Subject.SubjectsList[i]);
                    }
                    
                }
            }
          
            //Test Create method in Student class
            foreach (var classObject in Class.ClassesList)
            {               
                for (int i = 0; i < noOfStudentsInClass; i++)
                {
                    Student.Create(classObject);
                    foreach (var subject in Subject.SubjectsList)
                    {
                        if (string.Equals(subject.LevelUUID, classObject.LevelUUID))
                        {
                            Grade.Create(subject, Student.StudentList[i]);
                        } //end if subject belongs to the same level as class
                    } //end for each subject in subjectsList                                    
                } //end for i from 0 to noOfStudentsInClass
            } //end for each class in classesList

            Level.SaveLevels(@"..\..\..\Levels.csv");
            Class.SaveClasses(@"..\..\..\Classes.csv");
            Room.SaveRooms(@"..\..\..\Rooms.csv");
            Student.SaveStudents(@"..\..\..\Students.csv");
            Field.SaveFields(@"..\..\..\Fields.csv");
            Teacher.SaveTeachers(@"..\..\..\Teachers.csv");
            Subject.SaveSubjects(@"..\..\..\Subjects.csv");
            Attendance.SaveAttendances(@"..\..\..\Attendances.csv");
            Grade.SaveGrades(@"..\..\..\Grades.csv");
            
            /*foreach (var student in Student.StudentList)
            {
                Console.WriteLine(student.UUID + ", " + student.Name + ", " + student.Birthday + ", " + student.Gender + ", " + student.ClassUUID);
            }
            
            foreach (var level in Level.LevelList)
            {
                Console.WriteLine(level.UUID + ", " + level.Name);
            }*/
        }
    }
}
