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
                //String id = Guid.NewGuid().ToString(); 
                NameConfig _ = config.NameConfig;
                int last_name_index = rnd.Next(_.last_name_set.Length);
                int first_name_index = rnd.Next(_.first_name_set.Length);
                int middle_name_index = rnd.Next(_.middle_name_set.Length);
                string full_name = _.last_name_set[last_name_index] + " ";
                full_name += _.middle_name_set[middle_name_index] + " ";
                full_name += _.first_name_set[first_name_index];

                DateTime birthday = new DateTime(randNumber(1900, 2020), randNumber(1, 12), randNumber(1, 31));

                //result[i] = new Student(ID, Name, Birthday, Gender, Class);
            }
            return result;
        }
        public static int randNumber(int minNum, int maxNum)
        {
            Random rnd = new Random();
            maxNum = minNum + 1;
            int randNumber = rnd.Next(minNum, maxNum); 
            return randNumber;
        }

        public void print()
        {
            Console.WriteLine(_id + " " + _name + " " + _birthday + " " + _gender + " " + _class);
        }
    }
}