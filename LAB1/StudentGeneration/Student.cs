using LAB1.StudentGeneration;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudentGeneration
{
    public class Student
    {
        protected string _UUID;
        protected String _name;
        DateTime _birthday;
        protected String _gender;
        protected String _class;

        public Student(String id, String name, String gender, DateTime birthday,
            String currentClass)
        {
            this._UUID = id;
            this._name = name;
            this._birthday = birthday;
            this._gender = gender;
            this._class = currentClass;
        }

        public string ID
        {
            get{ return _UUID; }
        }

        public String Name 
        {
            get{ return _name; }
            set{ _name = value; }
        }

        public DateTime Birthday 
        {
            get{ return _birthday; }
            set{ _birthday = value; }
        }

        public String Gender  
        {
            get{ return _gender; }
            set{ _gender = value; }
        }

        public String Current_class 
        {
            get{ return _class; }
            set{ _class = value; }
        }

        static public Student[] CreateStudentRandomly(uint number_of_students)
        {
            Student[] students = new Student[number_of_students];
            String content = File.ReadAllText(@"..\..\..\StudentGeneration\dataset.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            for (int i = 0; i < number_of_students; i++) 
            {
                //generate uuid
                string student_id = System.Guid.NewGuid().ToString();

                //generate name
                string fullname = Generator.createFullnameRandomly(config);

                //generate gender
                string gender_gen = Generator.createGenderRandomly(config);

                //generate birthday
                int year = Generator.getRandomInteger(2004, 2007);
                DateTime dob = Generator.getRandomDate(year);

                //generate class
                string current_class = Generator.createClassRandomly(config);
                
                students[i] = new Student(student_id ,fullname, gender_gen, 
                    dob, current_class);
            }
            return students;
        }
    }

}
