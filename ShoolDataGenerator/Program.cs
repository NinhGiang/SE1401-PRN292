﻿using LAB1;
using System;
using System.Collections.Generic;
using System.ComponentModel;

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

            /*bool[] listGender = Student.GenerateGender(10);
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
            }*/
            /*string[] listClassName = Class.GenerateClassName(12, 20);
            Console.WriteLine(listClassName);*/

            /*int[] listLevel = Level.GenerateLevelName(30);
            foreach (var level in listLevel)
            {
                if (level == 10)
                {
                    Console.WriteLine("10");
                }else if (level == 11)
                {
                    Console.WriteLine("11");
                }
                else{
                    Console.WriteLine("12");
                }
            }*/


            /*string[] listFeildName = Field.GenerateFieldName(9, 50);
            foreach (var field in listFeildName)
            {
                Console.WriteLine(field);
            }*/

            /*//Test No of Room
            int[] listRoomNo = Room.GenrateRoomNo(100);
            foreach (var no in listRoomNo)
            {
                Console.WriteLine(no);
            }*/
            //Test subject
            string[] listSubject = SubjectDTO.GenerateSubject(10, 100);
            foreach (var subject in listSubject)
            {
                Console.WriteLine(subject);
            }
        }


    }
}
