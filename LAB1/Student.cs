using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace LAB1
{
    class Student
    {
        private string id;
        private string name;
        private string classname;
        private DateTime birthday;
        private bool gender;

        protected string Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected string Classname { get => classname; set => classname = value; }
        protected DateTime Birthday { get => birthday; set => birthday = value; }
        protected bool Gender { get => gender; set => gender = value; }

        public Student(string id, string name, string classname, DateTime birthday, bool gender)
        {
            this.Id = id;
            this.Name = name;
            this.Classname = classname;
            this.Birthday = birthday;
            this.Gender = gender;
        }

        public static Student[] Create(uint numberOfStudent)
        {
            Student[] result = new Student[numberOfStudent];
            string content = File.ReadAllText(@"..\..\..\config.json");
            config config = JsonSerializer.Deserialize<config>(content);
            




            return result;
        }
    }

}
