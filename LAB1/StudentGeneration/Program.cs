using LAB1.StudentGeneration;
using System;
using System.Collections.Generic;

namespace StudentGeneration
{
    class Program
    {
        public static Helper helper = new Helper();
        static void Main(string[] args)
        {
            Student[] student_list;
            createHelper();
           
            string input;

            input = Console.ReadLine();
            string school_name = SupportTools.getSchoolName(input);
            int number_of_students = SupportTools.getStudentAmount(input);

            Console.WriteLine("{0}, {1}", school_name, number_of_students);

            /*while (true)
            {
                input = Console.ReadLine(); 
                switch (input)
                {
                    case "h":
                        helper.displayInstruction();
                        break;

                    case "s":
                        student_list = Student.CreateStudentRandomly(20);
                        foreach (Student student in student_list)
                        {
                            Console.WriteLine("{0}, {1}, {2}, {3}",
                                student.ID, student.Name, student.Gender, student.Birthday.ToString("d"));
                        }
                        break;
                }
            }*/
            //Console.ReadLine();
        }

        public static void createHelper()
        {
            helper.addInstruction("<<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100");
            helper.addInstruction("<<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100");
            helper.addInstruction("<<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.");
            helper.addInstruction("<<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.");
        }
    }
}
