using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Student
    {
        protected string _uuid;
        protected string _name;
        protected DateTime _birthday;
        protected bool _gender;
        protected string _class;

        public Student(string uuid, string name, DateTime birthday, bool gender, string Class)
        {
            _uuid = uuid;
            _name = name;
            _birthday = birthday;
            _gender = gender;
            _class = Class;
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
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public void Create(int numberOfStudent)
        {
            List<Student> list = new List<Student>();
            Random rand = new Random();
            for (int i = 0; i < numberOfStudent; i++)
            {
                String id = Guid.NewGuid().ToString();
                bool gender = Utils.getRandomGender();
                String name = Utils.getRandomFullName(gender);
                int age = rand.Next(15,21);
                DateTime birth = Utils.getRandomDateTime(2020-age);
                //list.Add(new Student(id, name, birth, gender,));
            }
            
        }
    }
}
