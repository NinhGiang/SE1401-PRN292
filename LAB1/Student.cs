using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Student
    {
        protected string _id;
        protected string _name;
        protected DateTime _birthdate;
        protected bool _gender;
        protected string _class;

        public string id
        {
            get { return _id; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string classInfo
        {
            get { return _class; }
            set { _class = value; }
        }

        public Student() { }

        public Student(string id, string name, DateTime birthdate, bool gender, string classInfo )
        {
            _id = id;
            _name = name;
            _birthdate = birthdate;
            _gender = gender;
            _class = classInfo;
        }

        public static Student[] create(uint numberOfStudent)
        {
            Student[] result = new Student[numberOfStudent];
            string
        }
    }
}
