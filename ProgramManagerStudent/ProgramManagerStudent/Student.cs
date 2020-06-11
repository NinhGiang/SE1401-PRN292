using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Text.Json;


namespace StudentGeneration
{
    class Student
    {
        private string _id;
        private string _fullname;
        private DateTime _birthday;
        private bool _gender;
        private string _classID;
        private static List<Student> studentList;

        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }

        public DateTime Birthday { get { return _birthday; } }
        public bool Gender { get { return _gender}; }

        public string ClassID { get { return _classID; } }

        public static List<Student> StudentList { get { return studentList; } }

        public Student(string id, string fullname, DateTime birthday, bool gender, string classID)
        {
            _id = id;
            _fullname = fullname;
            _birthday = birthday;
            _gender = gender;
            _classID = classID;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                NameConfig _ = config.NameConfig;
                int last_name_index = rnd.Next(_.last_name_set.Length);
                int male_first_name_index = rnd.Next(_.male_first_name_set.Length);
                int male_middle_name_index = rnd.Next(_.male_middle_name_set.Length);
                string full_name = _.last_name_set[last_name_index] + " ";
                full_name += _.male_middle_name_set[male_middle_name_index] + " ";
                full_name += _.male_first_name_set[male_first_name_index];
                result[i] = new Student(i.ToString(), full_name);
            }
            return result;
        }
        public void print()
        {
            Console.WriteLine(_id+1 + " " + _fullname);
        }
    }
}
