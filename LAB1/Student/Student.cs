using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LAB1
{
    class Student
    {
        protected string _fullname;
        protected DateTime _birthday;
        protected string _uuid;
        protected bool _gender;
        protected string _class;
        public string FullName { get { return _fullname; } }
        public DateTime Birthday { get { return _birthday; } }
        public string UUID { get { return _uuid; } }
        public bool Gender { get { return _gender; } }
        public string Class { get { return _class; } set { _class = value; } }
        protected Student(string FullName, bool Gender, DateTime Birthday, string UUID, string Class)
        {
            _fullname = FullName;
            _birthday = Birthday;
            _uuid = UUID;
            _gender = Gender;
            _class = Class;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result_default = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Student\StudentConfigure.json");
            StudentConfigure config = JsonSerializer.Deserialize<StudentConfigure>(content);
            for (uint i = 0; i < number_student; i++)
            {
                //generate random uuid
                string id = RandomGenerator.randUUID();
                //generate random birthday
                DateTime birthday = RandomGenerator.randBirthday();
                //generate random gender
                bool gender = RandomGenerator.randGender();
                //generate random student name
                if (gender)
                {
                    string full_name = RandomGenerator.randMaleStudentName(config);
                    result_default[i] = new Student(full_name, gender, birthday, id, "default");
                } else
                {
                    string full_name = RandomGenerator.randFemaleStudentName(config);
                    result_default[i] = new Student(full_name, gender, birthday, id, "default");
                }
            }
            return Student.AssignStudent(result_default);
        }
        public static Student[] AssignStudent(Student[] student_list)
        {
            //get class list
            string content_class = File.ReadAllText(@"..\..\..\Whatever\Classes.json");
            List<Class> classes = JsonConvert.DeserializeObject<List<Class>>(content_class);
            Class[] class_list = classes.ToArray();
            //get level list
            string content_level = File.ReadAllText(@"..\..\..\Whatever\Levels.json");
            List<Level> levels = JsonConvert.DeserializeObject<List<Level>>(content_level);
            string[] lv = new string[class_list.Length];
            for (int i = 0; i < lv.Length; i++)
            {
                if (class_list[i].Level.Equals(levels.ElementAt(0).UUID))
                {
                    lv[i] = levels.ElementAt(0).Name;
                }
                else if (class_list[i].Level.Equals(levels.ElementAt(1).UUID))
                {
                    lv[i] = levels.ElementAt(1).Name;
                }
                else
                {
                    lv[i] = levels.ElementAt(2).Name;
                }
            }
            List<Student> students = new List<Student>(student_list);
            int classcount = 0;
            Random rnd = new Random();
            while (students.Any())
            { 
                int classsize = rnd.Next(30, 51);    
                int currentsize = 0;
                switch (lv[classcount])
                {
                    case "Khối 10":
                        for (int i = 0; i < student_list.Length; i++)
                        {
                            if (currentsize < classsize)
                            {
                                if (student_list[i].Class.Equals("default"))
                                {
                                    if (student_list[i].Birthday.Year > 2001 && student_list[i].Birthday.Year < 2007)
                                    {
                                        student_list[i].Class = class_list[classcount].Name;
                                        currentsize++;
                                        students.Remove(student_list[i]);
                                    }
                                }
                            }
                            else i = student_list.Length;
                        }
                        classcount++;
                        break;
                    case "Khối 11":
                        for (int i = 0; i < student_list.Length; i++)
                        {
                            if (currentsize < classsize)
                            {
                                if (student_list[i].Class.Equals("default"))
                                {
                                    if (student_list[i].Birthday.Year > 2000 && student_list[i].Birthday.Year < 2006)
                                    {
                                        student_list[i].Class = class_list[classcount].Name;
                                        currentsize++;
                                        students.Remove(student_list[i]);
                                    }
                                }
                            }
                            else i = student_list.Length;
                        }
                        classcount++;
                        break;
                    case "Khối 12":
                        for (int i = 0; i < student_list.Length; i++)
                        {
                            if (currentsize < classsize)
                            {
                                if (student_list[i].Class.Equals("default"))
                                {
                                    if (student_list[i].Birthday.Year > 1999 && student_list[i].Birthday.Year < 2005)
                                    {
                                        student_list[i].Class = class_list[classcount].Name;
                                        currentsize++;
                                        students.Remove(student_list[i]);
                                    }
                                }
                            }
                            else i = student_list.Length;
                        }
                        classcount++;
                        break;
                    default:
                        break;
                }
            }
            return student_list;
        }

        public void print()
        {
            Console.WriteLine(_class + " | " + _fullname + " | " + _birthday + " | " + _uuid);
        }
    }
}