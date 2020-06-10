using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Teacher
    {
        protected string _uuid;
        protected string _name;
        protected string _gender;
        protected string _field;
        public string Uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
        public Teacher() { }
        public Teacher(string uuid, string name, string gender, string field)
        {
            _uuid = uuid;
            _name = name;
            _gender = gender;
            _field = field;
        }
    }
}
