using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using StudentGeneration.Configure;

namespace StudentGeneration
{
    public class Student
    {
        protected int _UUID;
        protected String _name;
        protected String _birthday;
        protected Boolean _gender;
        protected String _class;

        public Student(int UUID, String name, String birthday, Boolean gender, String currentClass)
        {
            this._UUID = UUID;
            this._name = name;
            this._birthday = birthday;
            this._gender = gender;
            this._class = currentClass;
        }

        public int ID
        {
            get{ return _UUID; }
        }

        public String Name 
        {
            get{ return _name; }
            set{ _name = value; }
        }

        public String Birthday 
        {
            get{ return _birthday; }
            set{ _birthday = value; }
        }

        public Boolean Gender  
        {
            get{ return _gender; }
            set{ _gender = value; }
        }

        public String Class 
        {
            get{ return _class; }
            set{ _class = value; }
        }

        static public Student[] CreateStudentRandomly(uint number_of_students)
        {
            Student[] students = new Student[numberOfStudents];
            Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"../../../dataset.json"));

            Random rd = new Random();
            for (int i = 0; i < number_of_students; i++) 
            {
                //generate name
                NameDataSet name_config = config.NameDataSet;
                int last_name_index = rd.Next(name_config.last_name_set.Length);
                int middle_name_index = rd.Next(name_config.middle_name_set.Length);
                int first_name_index = rd.Next(name_config.first_name_set.Length);
                String fullname = name_config.last_name_set[last_name_index] + " ";
                fullname += name_config.middle_name_set[middle_name_index] + " ";
                fullname += name_config.first_name_set[first_name_index];

                //generate gender
                Boolean gender_gen = true;
                int gender_int = rd.Next(0, 1);
                if(gender_int == 0)
                {
                    gender_gen = false; 
                }

                //generate birthday
                String birthday_gen;
                DateDataSet birthday_config = config.DateDataSet;
                int day_index = rd.Next(birthday_config.day_set.Length);
                int month_index = rd.Next(birthday_config.month_set.Length);
                int year_index = rd.Next(birthday_config.year_set.Length);
                birthday_gen = birthday_config.day_set[day_index] + "/";
                birthday_gen += birthday_config.month_set[month_index] + "/";
                birthday_gen += birthday_config.year_set[year_index];

                //generate class
                String class_gen;
                ClassDataSet class_config = config.ClassDataSet;
                int class_index = rd.Next(class_config.class_set.Length);
                class_gen = class_config.class_set[class_index];

                students[i] = new Student(i, fullname, birthday_gen, gender_gen, class_gen);
            }
            return students;
        }
    }
}
