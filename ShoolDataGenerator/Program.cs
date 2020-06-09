using LAB1;
using System;
using System.Collections.Generic;

namespace ShoolDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] listName = Student.GenerateRandomFullname(10);
             foreach (var name in listName)
             {
                 Console.WriteLine(name);
             }*/
            /*DateTime[] listBirthDay = Student.GenerateRandomBirthday(5000, 11);
            foreach (var date in listBirthDay)
            {
                    Console.WriteLine(date.ToString("dd/MM/yyyy"));
            }*/
            bool[] listGender = Student.GenerateGender(10);
            foreach (var male in listGender)
            {
                if (male)
                {
                    Console.WriteLine("male");
                }
                else
                {
                    Console.WriteLine("female");
                }
            }

        }
    }
}
