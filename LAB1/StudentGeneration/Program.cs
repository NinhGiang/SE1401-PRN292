using LAB1.StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentGeneration
{
    class Program
    {
        public static Helper helper = new Helper();
        static void Main(string[] args)
        {
            Student[] student_list;
            createHelper();
            int i = 0; //số lượng school đã được tạo
            string input;

            /*input = Console.ReadLine();
            string school_name = SupportTools.getSchoolName(input);
            int number_of_students = SupportTools.getStudentAmount(input);
            int number_of_rooms = SupportTools.getRoomAmount(input);

            Console.WriteLine("{0}, {1}, {2}", 
                school_name, number_of_students, number_of_rooms);*/

            List<School> schools = new List<School>();
            while (true)
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "h":
                        helper.displayInstruction();
                        break;

                    case "s":
                        input = Console.ReadLine();
                        string school_name = SupportTools.getSchoolName(input);
                        int number_of_students = SupportTools.getStudentAmount(input);
                        int number_of_rooms = SupportTools.getRoomAmount(input);

                        student_list = Student.CreateStudentRandomly(number_of_students);

                        schools.Add(new School(student_list));
                        /*string filename_csv = school_name + ".csv";
                        Directory.CreateDirectory(@"..\..\..\StudentGeneration\" + school_name);
                        //string filepath = "..\..\..\StudentGeneration\"" + school_name + ".csv";*/
                        schools[i].save(school_name);
                        break;
                }
            }
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
