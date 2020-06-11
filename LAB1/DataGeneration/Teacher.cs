using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    /// <summary>
    /// The Teacher class
    /// Contains method to create Teacher and its getter/setter/ctor.
    /// </summary>
    class Teacher
    {
        /// <summary>
        /// The 4 values of Teacher
        /// </summary>
        private static Random rnd = new Random();
        protected string _uuid;
        protected string _name;
        protected string _gender;
        protected string _field;

        /// <summary>
        /// The getter/setter method of Teacher values
        /// </summary>
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

        /// <summary>
        /// The ctor of Teacher 
        /// Has one blank ctor
        /// </summary>
        /// <param name="uuid">A string value</param>
        /// <param name="name">A string value</param>
        /// <param name="gender">A string value</param>
        /// <param name="field">A string value</param>
        public Teacher() { }
        public Teacher(string uuid, string name, string gender, string field)
        {
            _uuid = uuid;
            _name = name;
            _gender = gender;
            _field = field;
        }

        /// <summary>
        /// Creates a random list of teacher and returns the result
        /// </summary>
        /// <param name="number_teachers">An integer value</param>
        /// <returns>An array of teachers</returns>
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
