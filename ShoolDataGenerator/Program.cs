using LAB1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ShoolDataGenerator
{
    class Program
    {
        private static readonly string HELP = "Help: \n" +
"	./schoolDatabaseGenerator <<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100 \n" +
"	./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100 \n" +
"	./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.\n" +
"	./schoolDatabaseGenerator <<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.";
        private static readonly string CMD_FAILED = "CMD Invalid";
        private static bool stop = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SchoolDataGenerator");
            do
            {
                string inputCLI = Console.ReadLine();
                string[] inputPart = inputCLI.Split(" ");
                ParamHandeling(inputPart);
            } while (!stop);
        }
        private static void ParamHandeling(string[] inputPart)
        {
            // neu nhap 'exit' thi dung chuong trinh
            if (inputPart.Length > 0 && inputPart[0].Equals("exit"))
            {
                stop = true;
            }
            // kiem tra part[0] == './schoolDatabaseGenerator' tiep tuc
            else if (inputPart.Length > 0 && inputPart[0].Equals("./schoolDatabaseGenerator"))
            {
                // part[1] rong hoac == '-h' thi hien thi HELP
                if (inputPart.Length == 1 || inputPart.Length > 1 && inputPart[1].Equals("-h"))
                {
                    Console.WriteLine(HELP);
                    return;
                }
                // part[1] != '-h' thi kiem tra == '-s' || '-r'
                else
                {
                    int numberOfStudent = 0;
                    int numberOfRoom = 0;
                    int index = 1;
                    // duyet den het part
                    while (index < inputPart.Length)
                    {
                        // part[1] == '-s' thi kiem tra co part[2] khong
                        if (inputPart[index].Equals("-s") && inputPart.Length > index)
                        {
                            // kiem tra part[2] co phai so hay khong
                            if (inputPart[index + 1].All(char.IsNumber))
                            {
                                // luu so luong hoc sinh
                                numberOfStudent = Int32.Parse(inputPart[index + 1]);
                            }
                            else
                            {
                                // khong phai so thi hien thi CMD_FAILED
                                Console.WriteLine(CMD_FAILED); return;
                            }
                        }
                        // part[1] == '-r' thi kiem tra co part[2] khong
                        else if (inputPart[index].Equals("-r") && inputPart.Length > index)
                        {
                            // kiem tra part[2] co phai so hay khong
                            if (inputPart[index + 1].All(char.IsNumber))
                            {
                                // luu so luong phong
                                numberOfRoom = Int32.Parse(inputPart[index + 1]);
                            }
                            else
                            {
                                // khong phai so thi hien thi CMD_FAILED
                                Console.WriteLine(CMD_FAILED); return;
                            }
                        }
                        else
                        {
                            // khong phai '-r' || '-s' thi hien thi CMD_FAILED
                            Console.WriteLine(CMD_FAILED); return;
                        }
                        // moi lan duyet 2 part nen += 2
                        index += 2;
                        // lap lai neu chau het part
                    }
                    // xu li theo so luong
                    GenerateStudentAndRoom(numberOfStudent, numberOfRoom);
                }
            }
        }
        private static void GenerateStudentAndRoom(int numberOfStudent, int numberOfRoom)
        {
            Console.WriteLine(numberOfStudent);
            Console.WriteLine(numberOfRoom);
        }
    }
}
