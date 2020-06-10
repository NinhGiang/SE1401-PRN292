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
        protected Guid _UUID;
        protected String _name;
        DateTime _birthday;
        protected String _gender;
        //protected String _class;

        public Student(String name, String gender, DateTime birthday)
        {
            //, String birthday, String currentClass
            this._UUID = System.Guid.NewGuid();
            this._name = name;
            this._birthday = birthday;
            this._gender = gender;
            //this._class = currentClass;
        }

        public Guid ID
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

        //public String Class 
        //{
        //    get{ return _class; }
        //    set{ _class = value; }
        //}

        static public Student[] CreateStudentRandomly(int number_of_students)
        {
            Student[] students = new Student[number_of_students];
            String content = File.ReadAllText(@"..\..\..\StudentGeneration\dataset.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            for (int i = 0; i < number_of_students; i++) 
            {
                //generate name
                string fullname = createFullnameRandomly(config);

                //generate gender
                string gender_gen = createGenderRandomly();

                //generate birthday
                int year = Generator.getRandomInteger(2004, 2007);
                DateTime dob = Generator.getRandomDate(year);

                //generate class
                //String class_gen;
                //ClassDataSet class_config = new ClassDataSet();
                //int class_index = rd.Next(class_config.class_set.Length);
                //class_gen = class_config.class_set[class_index];

                students[i] = new Student(fullname, gender_gen, dob);
                //, class_gen
            }
            return students;
        }

        private static string createFullnameRandomly(Configure config)
        {
            NameDataSet name_config = config.NameDataSet;
            int lastname_length_inDB = name_config.LastNameSet.Length;
            int middelname_length_inDB = name_config.MiddleNameSet.Length;
            int firstname_length_inDB = name_config.FirstNameSet.Length;

            int last_name_index = Generator.getRandomInteger(lastname_length_inDB);
            int middle_name_index = Generator.getRandomInteger(middelname_length_inDB);
            int first_name_index = Generator.getRandomInteger(firstname_length_inDB);
            String fullname = name_config.LastNameSet[last_name_index] + " ";
            fullname += name_config.MiddleNameSet[middle_name_index] + " ";
            fullname += name_config.FirstNameSet[first_name_index];

            return fullname;
        }

        private static string createGenderRandomly()
        {
            String gender_gen = "Female";
            int gender_int = Generator.getRandomInteger(0, 2);
            if (gender_int == 0)
            {
                gender_gen = "Male";
            }
            return gender_gen;
        }
    }

}
