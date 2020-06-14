using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// class of level contains all properties of level
    /// </summary>
    public class Subject
    {
        private string _uuid;
        private string _name;
        private string _level;
        private string _field;

        /// <summary>
        /// get uuid
        /// </summary>
        /// <returns>uuid</returns>
        public string GetUuid()
        {
            return _uuid;
        }

        /// <summary>
        /// Set uuid for level
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetUuid(string value)
        {
            __uuid = value;
        }

        /// <summary>
        /// Get name for level
        /// </summary>
        /// <returns>The name of level</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Set name for level
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetName(string value)
        {
            _name = value;
        }

        public string GetLevel()
        {
            return _level;
        }

        /// <summary>
        /// Set name for level
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetLevel(string value)
        {
            _level = value;
        }

        public string GetField()
        {
            return _field;
        }

        /// <summary>
        /// Set name for level
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetField(string value)
        {
            _field = value;
        }

        /// <summary>
        /// Empty constructor 
        /// </summary>
        public Subject() { }

        /// <summary>
        /// A constructor with input parameters
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="name">A string value</param>
        public Subject(string uuid, string name, string level, string field)
        {
            _uuid = uuid;
            _name = name;
            _level = level;
            _field = field;
        }

        /// <summary>
        /// Make a list of level in array type
        /// </summary>
        /// <returns>An array</returns>
        public static Subject[] Create()
        {
            //get list of level from csv file
            List<string> levelList = Readcsvjsonhelper.GetLevelList();

            //get list of field from csv file
            List<string> fieldList = Readcsvjsonhelper.GetFieldList();

            //List of subject
            List<Subject> result = new List<Subject>();

            foreach (string line in levelList)
            {
                foreach (string linee in fieldList)
                {
                    //Generate uuid for subject as primary key
                    string uuid = Guid.NewGuid().ToString();

                    //Level
                    string[] levels = line.Split(',');
                    string level = levels[0].Trim();

                    //field
                    string[] fields = linee.Split(',');
                    string field = fields[0].Trim();

                    //name
                    string name = fields[1].Trim() + "-" + levels[1].Trim();

                    result.Add(new Subject(uuid, name, level, field));
                }
            }
            return result.ToArray();
        }
    }
}