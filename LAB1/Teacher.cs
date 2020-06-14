using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Teacher Class
    /// Contains methods and properties of Teacher
    /// </summary>
    class Teacher
    {
        /// <summary>
        /// Teacher ID
        /// </summary>
        protected string _uuid;
        /// <summary>
        /// Teacher Name
        /// </summary>
        protected string _name;
        /// <summary>
        /// Teacher Gender
        /// </summary>
        protected bool _gender;
        /// <summary>
        /// Field ID
        /// </summary>
        protected string _field;

        /// <summary>
        /// Empty Constructor for Teacher
        /// </summary>
        public Teacher()
        {
        }

        /// <summary>
        /// Constructor for Teacher
        /// </summary>
        /// <param name="uuid">string value</param>
        /// <param name="name">string value</param>
        /// <param name="gender">boolean value</param>
        /// <param name="field">string value</param>
        public Teacher(string uuid, string name, bool gender, string field)
        {
            _uuid = uuid;
            _name = name;
            _gender = gender;
            _field = field;
        }
        /// <summary>
        /// getter setter Teacher ID
        /// </summary>
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// getter setter Teacher Name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// getter setter Teacher Gender
        /// </summary>
        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        /// <summary>
        /// getter setter Field ID
        /// </summary>
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
        /// <summary>
        /// Create a list of Teacher and return resutl
        /// </summary>
        /// <param name="number">integer value</param>
        /// <returns>Return an array of Teacher</returns>
        public static Teacher[] CreateTeacher(int number) 
        {
            Teacher[] list = new Teacher[number];
            
            string[] fieldIDList = DatabaseHandler.GetFieldIDList();
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
