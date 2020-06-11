using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StudentGeneration
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Student[] student_list = Student.Create(3000);
            School ABC = new School(student_list);
           
            ABC.save(@"..\..\..\ABC.csv");
            Console.ReadLine();*/


            /* Problem 1
            //UUID Generator
            Guid g = Guid.NewGuid(); // tạo 1 UUID
            Console.WriteLine(g); //version 4
            */
            /*
            List<string> videogames = new List<string>
                {
                    "Starcraft",
                    "Halo",
                    "Legend of Zelda"
                };

            string json = JsonConvert.SerializeObject(videogames);
            */
            //Console.WriteLine(json);
            // ["Starcraft","Halo","Legend of Zelda"]
            //string json = JsonConvert.SerializeObject(.ToArray());

            //write string to file
            // System.IO.File.WriteAllText(@"D:\path.txt", json);    }
            GenerateRandomBirthday // à Đoàn hiểu rồi. code vớ vẩn. random ngyaf luôn cũng đc


        }

        static DateTime GenerateRandomBirthday(DateTime start, DateTime end) // Start là kieur datetime
        {
            // String day = rnd.Next(dayRange) + "/" + rnd.Next(monthRange) + "/" + rnd.Next(YearRange)
            // DateTime date = DateTime.parse(day); // => esier => DOne nhé?

            Random rnd = new Random(); // khởi tạo object random
            // random như cái dòng (end-start).Days thì ta có 1 
            int range = (end - start).Days; //random 1 ngày trong khoảng thời gian đã đưa ra => ở đây là start và end
            return start.AddDays(rnd.Next(range)); //thêm start + một ngày được random trong khoảng range (với range là 1 ngày đã random)
        }
    }
}