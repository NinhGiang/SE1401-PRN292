using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Teacher
    {
        private static Random rnd = new Random();
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
        public static Teacher[] createTeacher(uint number_teachers)
        {
            List<Teacher> result = new List<Teacher>();
            List<string> fieldList = ListStorage.GetFieldList();
            for (int i = 0; i < number_teachers; i++)
            {
                string uuid = Guid.NewGuid().ToString(); //generate random uuid
                string gender = RandomGenerator.GetRandomGender();
                if (gender.Equals("Male")) 
                {
                    string fullName = RandomGenerator.GetRadomMaleFullName();
                    string fieldID = RandomGenerator.GetRandomFieldID();
                    result.Add(new Teacher(uuid, fullName, gender, fieldID));
                }
                if (gender.Equals("Female"))
                {
                    string fullName = RandomGenerator.GetRadomFemaleFullName();
                    string fieldID = RandomGenerator.GetRandomFieldID();
                    result.Add(new Teacher(uuid, fullName, gender, fieldID));
                }
            }
            return result.ToArray();
        }
    }
   
}
