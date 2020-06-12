using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.StudentGeneration
{
    class Teacher
    {
        protected string _ID;
        protected string _fullname;
        protected string _gender;
        protected string _field;

        public string ID { get { return _ID; } set { _ID = value; } }
        public string Fullname { get { return _fullname; } set { _fullname = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string Field { get { return _field; } set { _field = value; } }

        protected Teacher(string id, string name, string gender, string field)
        {
            _ID = id;
            _fullname = name;
            _gender = gender;
            _field = field;
        }

        public static Teacher[] Create (uint number_teacher){
            Teacher[] result = new Teacher[number_teacher];

            return result ;
    }
}
}
