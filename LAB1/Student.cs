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
        protected string _class;

        public Student(string id, string name, DateTime birthday, bool gender, string @class)
        {
            _id = id;
            _name = name;
            _birthday = birthday;
            _gender = gender;
            _class = @class;
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
        public String GetClass()
        { return _class; }
        public void SetClass(String classID)
        { _class = classID; }
        public void Create(int numberOfStudent)
        {
            List<Student> list = new List<Student>();
            for (int i = 0; i < numberOfStudent; i++)
            {
                String id = Guid.NewGuid().ToString();
                String name = ;

            }
            
        }
    }
}
