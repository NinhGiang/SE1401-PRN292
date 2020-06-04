using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Teacher
    {
        protected string _id;
        protected string _name;
        protected bool _gender;
        protected string _field;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool gender
        {
            get { return _gender; }
            set { gender = value; }
        }

        public string field
        {
            get { return _field; }
            set { _field = value; }
        }

        public Teacher() { }

        public Teacher(string id, string name, bool gender, string field)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _field = field;
        }
    }
}
