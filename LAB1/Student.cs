using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Student
    {
        protected string _id;
        protected string _name;
        protected DateTime _birthday;
        protected bool _gender;

        protected Student(String id, String name, DateTime birthday , bool gender)
        {
            _id = id;
            _name = name;
            _birthday = birthday;
            _gender = gender;
        }


        public String GetID()
        { return _id; }
        public void SetID(String id)
        { _id = id; }
        public String GetName()
        { return _name; }
        public void SetName(String name)
        { _name = name; }
        public DateTime GetBirthday()
        { return _birthday; }
        public void SetBirthday(DateTime birthday)
        { _birthday = birthday; }
        public bool IsGender()
        { return _gender; }
        public void SetGender(bool gender)
        { _gender = gender; }
    }
}
