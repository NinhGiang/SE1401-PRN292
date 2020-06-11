using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    /// <summary>
    /// The Subject class
    /// Contains method to create Subject and its getter/setter/ctor.
    /// </summary>
    class Subject
    {
        /// <summary>
        /// The 4 values of Room
        /// </summary>
        protected string _uuid;
        protected string _level;
        protected string _field;
        protected string _name;

        /// <summary>
        /// The getter/setter method of Subject values
        /// </summary>
        public string Uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        /// <summary>
        /// The ctor of Room 
        /// Has one blank ctor
        /// </summary>
        /// <param name="uuid">A string value</param>
        /// <param name="level">A string value</param>
        /// <param name="field">A string value</param>
        /// <param name="name">A string value</param>
        public Subject() { }
        public Subject(string uuid, string level, string field, string name)
        {
            _uuid = uuid;
            _level = level;
            _field = field;
            _name = name;
        }

        /// <summary>
        /// Creates a random list of subject and returns the result
        /// </summary>
        /// <returns>An array of subjects</returns>
        public Subject[] createSubject()
        {
            List<string> LevelList = ListStorage.GetLevelList();
            List<string> fieldList = ListStorage.GetFieldList();
            List<Subject> result = new List<Subject>();
            for (int i = 0; i < LevelList.Count; i++)
            {
                for (int j = 0; j < fieldList.Count; j++)
                {
                    string uuid = Guid.NewGuid().ToString(); //generate uuid

                    string line = LevelList[i];
                    string[] levels = line.Split(',');
                    string level = levels[0].Trim();
                    //generate level

                    string[] fields = fieldList[j].Split(',');
                    string field = fields[0].Trim();
                    //generate field

                    string name = fields[1].Trim() + " " + levels[1].Trim();
                    //generate name
                    result.Add(new Subject(uuid, level, field, name));
                }
            }
            return result.ToArray();
        }
    }
}
