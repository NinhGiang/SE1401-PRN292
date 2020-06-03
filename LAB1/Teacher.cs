using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Teacher
    {
        protected String _id;
        protected String _name;
        protected bool _gender;
        protected String _field;

        public String id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool gender
        {
            get { return _gender; }
            set { gender = value; }
        }

        public String field
        {
            get { return _field; }
            set { _field = value; }
        }

        public Teacher() { }

        public Teacher(String id, String name, bool gender, String field)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _field = field;
        }
    }
}
