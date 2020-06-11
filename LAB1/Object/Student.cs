using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;


namespace LAB1.Object
{
    class Student
    {
        protected string _id;
        protected string _name;
        protected DateTime _birthday;
        protected string _gender;
        protected string _class;

        public string ID
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }         
        }
        public DateTime Birthday
        {
            get { return _birthday; }           
        }
        public string Gender
        {
            get { return _gender; }           
        }
        public string Class
        {
            get { return _class; }
        }

        public Student(String ID, String Name, DateTime Birthday, String Gender, String Class)
        {
            _id = ID;
            _name = Name;
            _birthday = Birthday;
            _gender = Gender;
            _class = Class;
        }

        public static Student[] addNewStudent(uint number_student)
        {   
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                //String id = Guid.NewGuid().ToString(); - Random ID
                NameConfig _ = config.NameConfig;
                int last_name_index = rnd.Next(_.last_name_set.Length);
                int first_name_index = rnd.Next(_.first_name_set.Length);
                int middle_name_index = rnd.Next(_.middle_name_set.Length);
                string full_name = _.last_name_set[last_name_index] + " ";
                full_name += _.middle_name_set[middle_name_index] + " ";
                full_name += _.first_name_set[first_name_index];

                //result[i] = new Student(ID, Name, Birthday, Gender, Class);
            }
            return result;
        }

        /*
        public static DateTime randBirthday()
        {
            Random rnd = new Random();
            DateTime from = new DateTime(2002, 1, 1);
            DateTime to = new DateTime(2004, 12, 31);

            DateTime birthday;
            return birthday;
        }
        */

        public void print()
        {
            Console.WriteLine(_id + 1 + " " + _name);
        }
    }
}