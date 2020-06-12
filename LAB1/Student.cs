using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;


namespace StudentGeneration
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        protected DateTime _birth;
        protected bool _gender;
        protected string _class;
        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }
        public string Class { get { return _class; } }
        public DateTime Birth { get { return _birth; } }
        public bool Gender { get { return _gender; } }

        protected Student(string ID, string FullName, DateTime Birth, bool Gender, string Class)
        {
            _id = ID;
            _fullname = FullName;
            _birth = Birth;
            _gender = Gender;
            _class = Class;
        }

        public static Student[] Create(uint number_student)
        {
            try
            {
                Student[] result = new Student[number_student];
                string content = File.ReadAllText(@"..\..\..\Configure.json");
                Configure config = JsonSerializer.Deserialize<Configure>(content);

                Random rnd = new Random();
                for (uint i = 0; i < number_student; i++)
                {
                    //id
                    String uuid = Guid.NewGuid().ToString();


                    result[i] = new Student(uuid,null,null,false,null);
                }
                return result;
            }
            catch( FileNotFoundException ex)
            {
                Console.WriteLine("Student _ FileNotFoundException" + ex.Message);
            }
            
        }
        public void print()
        {
            Console.WriteLine(_id+1 + " " + _fullname);
        }
    }
}
