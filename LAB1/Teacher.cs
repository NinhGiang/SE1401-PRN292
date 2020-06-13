using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The Teacher class
    /// Contains create method and properties of Teacher. 
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// Id of teacher
        /// </summary>
        protected string _id;

        /// <summary>
        /// Name of teacher
        /// </summary>
        protected string _name;

        /// <summary>
        /// Gender of teacher
        /// </summary>
        protected bool _gender;

        /// <summary>
        /// Field teacher teaches
        /// </summary>
        protected string _field;

        /// <value>
        /// The id of teacher
        /// </value>
        public string UUID { get { return _id; } }

        /// <value>
        /// The name of teacher
        /// </value>
        public string Name { get { return _name; } }

        /// <value>
        /// The gender of teacher
        /// </value>
        public bool Gender { get { return _gender; } }

        /// <value>
        /// The field of teacher
        /// </value>
        public string Field { get { return _field; } }

        /// <summary>
        /// An empty constructor for teacher
        /// </summary>
        public Teacher() { }

        /// <summary>
        /// A constructor for teacher
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="name">A string value</param>
        /// <param name="gender">A boolean value</param>
        /// <param name="field">A string value</param>
        public Teacher(string id, string name, bool gender, string field)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _field = field;
        }

        /// <summary>
        /// Creates a random list of teachers and returns the result
        /// </summary>
        /// <param name="numberOfTeacher">An integer value</param>
        /// <returns>An array of teachers</returns>
        public static Teacher[] Create(int numberOfTeacher)
        {
            List<Teacher> result = new List<Teacher>();

            List<string> listOfField = FileHelper.GetListOfField();
            Random rnd = new Random();

            for (uint i = 0; i < numberOfTeacher; i++)
            {
                //id
                String uuid = Guid.NewGuid().ToString();

                //gender
                bool gender = rnd.Next(2) == 1;

                //name
                string fullName = GenerateDataHelper.GetRandomNameByGender(gender);

                //Field
                int index = rnd.Next(listOfField.Count);
                string[] fields = listOfField[index].Split(',');
                string field = fields[0].Trim();

                result.Add(new Teacher(uuid, fullName, gender, field));
            }
            return result.ToArray();
        }
    }
}
