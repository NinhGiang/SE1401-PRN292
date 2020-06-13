using LAB1.StudentGeneration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            get { return _UUID; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public String Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public String Current_class
        {
            get { return _class; }
            set { _class = value; }
        }

        static public List<Student> CreateStudentRandomly(uint number_of_students)
        {
            List<Student> students = new List<Student>();
            Dictionary<string, int> classes = new Dictionary<string, int>();

            //finding the general number of students of a class
            int students_of_class = (int)Math.Round((double)(number_of_students / DataGetting.GetRoomList().Count),
    MidpointRounding.ToZero) + 1;

            for (int i = 0; i < number_of_students; i++)
            {
                //generate uuid
                string student_id = System.Guid.NewGuid().ToString();

                //generate name
                string fullname = Generator.createFullnameRandomly();

                //generate gender
                string gender_gen = Generator.createGenderRandomly();

                //generate class
                int value;
                string current_class = "";
                do
                {
                    value = 0;
                    string[] class_info = DataGetting.GetClassData();
                    if (classes.TryGetValue(class_info[0], out value))
                    {
                        if (value < students_of_class)
                        {
                            current_class = class_info[0];
                            classes[current_class] = value + 1;
                        }
                    }
                    else
                    {
                        value = 1;
                        current_class = class_info[0];
                        classes.Add(current_class, value);
                    }
                } while (value > students_of_class);


                //generate birthday
                int year;
                if (current_class.Contains("10"))
                {
                    year = Generator.getRandomInteger(2001, 2005);
                }
                else
                {
                    year = current_class.Contains("11") ? Generator.getRandomInteger(2000, 2004) :
                        Generator.getRandomInteger(1999, 2003);
                }
                DateTime dob = Generator.getRandomDate(year);

                //Add student to student list
                students.Add(new Student(student_id, fullname, gender_gen,
                    dob, current_class));
            }
            for (int i = 0; i < classes.Count; i++)
            {
                Console.WriteLine("{0}, {1}", classes.ElementAt(i).Key, classes.ElementAt(i).Value);
            }
            return students;
        }
    }

}
