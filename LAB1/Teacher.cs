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

        public Teacher()
        {
        }

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
        public static Teacher[] createTeacher(int number) 
        {
            Teacher[] list = new Teacher[number];
            
            string[] fieldIDList = DatabaseHandler.getFieldIDList();
            Random rand = new Random();
            for (int i = 0; i < number; i++)
            {
                String id = Guid.NewGuid().ToString();
                bool gender = Utils.GenerateRandomGender();
                String name = Utils.GenerateRandomFullName(gender);
                string fieldID = fieldIDList[rand.Next(fieldIDList.Length)];
                list[i] = new Teacher(id,name,gender, fieldID);
            }
            return list;
        }
    }
}
