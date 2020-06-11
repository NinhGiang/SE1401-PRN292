using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace LAB1
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        protected DateTime _birthday;
        protected string _uuid;
        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }
        public DateTime Birthday { get { return _birthday; } }
        public string UUID { get { return _uuid; } }
        protected Student(string ID, string FullName, DateTime Birthday, string UUID)
        {
            _id = ID;
            _fullname = FullName;
            _birthday = Birthday;
            _uuid = UUID;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\StudentConfigure.json");
            StudentConfigure config = JsonSerializer.Deserialize<StudentConfigure>(content);
            Random rnd = new Random();
            //generate random student name
            for (uint i = 0; i < number_student; i++)
            {
                //generate random uuid
                string id = Guid.NewGuid().ToString();
                //generate random birthday
                DateTime birthday = Student.randBirthday();
                NameConfig _ = config.NameConfig;
                int last_name_index = rnd.Next(_.last_name_set.Length);
                int first_name_index = rnd.Next(_.first_name_set.Length);
                int middle_name_index = rnd.Next(_.middle_name_set.Length);
                string full_name = _.last_name_set[last_name_index] + " ";
                full_name += _.middle_name_set[middle_name_index] + " ";
                full_name += _.first_name_set[first_name_index];
                result[i] = new Student(i.ToString(), full_name, birthday, id);
            }
            return result;
        }

        public static DateTime randBirthday()
        {
            Random rnd = new Random();
            //ganerate random birthday
            DateTime from = new DateTime(2002, 1, 1);
            DateTime to = new DateTime(2004, 12, 31);
            var range = new TimeSpan(to.Ticks - from.Ticks);
            TimeSpan randTimeSpan = TimeSpan.FromSeconds((long)(range.TotalSeconds - rnd.Next(0, (int)range.TotalSeconds)));
            DateTime birthday = from + randTimeSpan;
            return birthday;
        }
        public void print()
        {
            Console.WriteLine(_id + " | " + _fullname + " | " + _birthday + " | " + _uuid);
        }
    }
}
