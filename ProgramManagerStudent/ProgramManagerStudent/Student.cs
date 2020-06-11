using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Text.Json;



// Task list
//1. khoi tao json => Serializing JSON => chuyển 1 list thành String Json. lưu thành file txt.
//2. luu du lieu vao json va doc json => Lưu ở 1. rồi -> đọc là Deserializing JSON
//3. luu thanh dang csv => Thư viện support Excel của C#. hoặc đơn giản hoá thì lưu một string voà file, xong set đuôi file (Extension) là csv


namespace StudentGeneration
{
    class Student
    {
        private string _id;
        private string _fullname;
        private DateTime _birthday;
        private bool _gender;
        private string _classID;

        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }

        public DateTime Birthday { get { return _birthday; } }
        public bool Gender { get { return _gender; } }

        public string ClassID { get { return _classID; } }

        public Student(string id, string fullname, DateTime birthday, bool gender, string classID)
        {
            _id = id;
            _fullname = fullname;
            _birthday = birthday;
            _gender = gender;
            _classID = classID;
        }
        private static DateTime GenerateRandomBirthday(DateTime start, DateTime end)
        {
            Random rnd = new Random();
            String date;
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Configure.json"); // đọc file Configure.json và ghi nội dung vào content
            Configure config = JsonSerializer.Deserialize<Configure>(content); // Deserialize là dịch ngược json. serialize là dịch object qua json.

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                NameConfigure _ = config.NameConfig;
                int last_name_index = rnd.Next(_.last_name_set.Length);
                int male_first_name_index = rnd.Next(_.male_first_name_set.Length);
                int male_middle_name_index = rnd.Next(_.male_middle_name_set.Length);
                string full_name = _.last_name_set[last_name_index] + " ";
                full_name += _.male_middle_name_set[male_middle_name_index] + " ";
                full_name += _.male_first_name_set[male_first_name_index];

                //result[i] = new Student(i, full_name,DateTime.Now, 1, "SE1401");
            }
            return result;
        }
        public void print()
        {
            Console.WriteLine(_id+1 + " " + _fullname);
        }
    }
}
