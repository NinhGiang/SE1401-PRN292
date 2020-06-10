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
        protected string _classInfo;

        public Student(string uuid, string name, DateTime birthday, bool gender, string classInfo)
        {
            _uuid = uuid ?? throw new ArgumentNullException(nameof(uuid));
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _birthday = birthday;
            _gender = gender;
            _classInfo = classInfo ?? throw new ArgumentNullException(nameof(classInfo));
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
        public string ClassInfo
        {
            get { return _classInfo; }
            set { _classInfo = value; }
        }
        public void Create(int numberOfStudent)
        {
            List<Student> list = new List<Student>();
            Random rand = new Random();
            for (int i = 0; i < numberOfStudent; i++)
            {
                String id = Guid.NewGuid().ToString();
                bool gender = false;
               
                int randomGender = rand.Next(1,2);
                if (randomGender == 1)
                {
                    gender = true;
                }


            }
            
        }
    }
}
