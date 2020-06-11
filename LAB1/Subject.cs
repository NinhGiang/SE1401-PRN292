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
        /// Gets Id of subject
        /// </summary>
        /// <returns>The Id of subject</returns>
        public string GetId()
        {
            return _id;
        }

        /// <summary>
        /// Sets Id of subject
        /// </summary>
        /// <param name="id">A string value</param>
        public void SetId(string id)
        {
            _id = id;
        }

        /// <summary>
        /// Gets level of subject
        /// </summary>
        /// <returns>The level id of subject</returns>
        public string GetLevel()
        {
            return _level;
        }

        /// <summary>
        /// Sets level of subject
        /// </summary>
        /// <param name="level">A string value</param>
        public void SetLevel(string level)
        {
            _level = level;
        }

        /// <summary>
        /// Gets field of subject
        /// </summary>
        /// <returns>The field id of subject</returns>
        public string GetField()
        {
            return _field;
        }

        /// <summary>
        /// Sets field of subject
        /// </summary>
        /// <param name="field">A string value</param>
        public void SetField(string field)
        {
            _field = field;
        }


        /// <summary>
        /// Gets name of subject
        /// </summary>
        /// <returns>The name of subject</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Sets name of subject
        /// </summary>
        /// <param name="name">A string value</param>
        public void SetName(string name)
        {
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
