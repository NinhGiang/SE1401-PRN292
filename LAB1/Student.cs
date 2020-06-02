using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Student
    {
        protected String _id;
        protected String _name;
        protected DateTime _birthdate;
        protected bool _gender;
        protected String _class;

        public String id
        {
            get { return _id; }
        }

        public String name
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
        public String classAttend
        {
            get { return _class; }
            set { _class = value; }
        }

        public Student() { }

        public Student(String id, String name, DateTime birthdate, bool gender, String classA )
        {
            _id = id;
            _name = name;
            _birthdate = birthdate;
            _gender = gender;
            _class = classA;
        }

    }
}
