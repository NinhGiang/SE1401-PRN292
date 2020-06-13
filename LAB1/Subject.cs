using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The Subject class
    /// Contains create method and properties of Subject. 
    /// </summary>
    class Subject
    {
        /// <summary>
        /// Id of subject
        /// </summary>
        protected string _id;

        /// <summary>
        /// Level of subject
        /// </summary>
        protected string _level;

        /// <summary>
        /// Field of subject
        /// </summary>
        protected string _field;

        /// <summary>
        /// Name of subject
        /// </summary>
        protected string _name;

        /// <value>
        /// The id the subject
        /// </value>
        public string UUID { get { return _id; } }

        /// <value>
        /// The level the subject
        /// </value>
        public string Level { get { return _level; } }

        /// <value>
        /// The field the subject
        /// </value>
        public string Field { get { return _field; } }

        /// <value>
        /// The name the subject
        /// </value>
        public string Name { get { return _name; } }

        /// <summary>
        /// An empty constructor for subject
        /// </summary>
        public Subject() { }

        /// <summary>
        /// A constructor for subject
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="level">A string value</param>
        /// <param name="field">A string value</param>
        /// <param name="name">A string value</param>
        public Subject(string id, string level, string field, string name)
        {
            _id = id;
            _level = level;
            _field = field;
            _name = name;
        }

        /// <summary>
        /// Creates a random list of subjects and returns the result
        /// </summary>
        /// <returns>An array of subjects</returns>
        public static Subject[] Create()
        {
            List<string> listOfLevels = FileHelper.GetListOfLevel();
            List<string> listOfFields = FileHelper.GetListOfField();

            List<Subject> result = new List<Subject>();

            for (int i = 0; i < listOfLevels.Count; i++)
            {
                //int numberOfField = rnd.Next(8, 10);
                //for(int j = 0; j < numberOfField; j++)
                for (int j = 0; j < listOfFields.Count; j++)
                {
                    //id
                    string uuid = Guid.NewGuid().ToString();

                    //level
                    string line = listOfLevels[i];
                    string[] levels = line.Split(',');
                    string level = levels[0].Trim();

                    //field
                    string[] fields = listOfFields[j].Split(',');
                    string field = fields[0].Trim();

                    //name
                    string name = fields[1].Trim() + " " + levels[1].Trim();

                    result.Add(new Subject(uuid, level, field, name));
                }
            }

            return result.ToArray();
        }
    }
}
