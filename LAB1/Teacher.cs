using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Teacher
    {
        protected string _uuid;
        protected string _name;
        protected bool _gender;
        protected string _field;

        public Teacher(string uuid, string name, bool gender, string field)
        {
            _uuid = uuid;
            _name = name;
            _gender = gender;
            _field = field;
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
    }
}
