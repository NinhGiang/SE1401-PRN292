using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Subject Class
    /// Contains methods and properties for Subject
    /// </summary>
    class Subject
    {
        /// <summary>
        /// Subject ID
        /// </summary>
        protected string _uuid;
        /// <summary>
        /// Subject Name
        /// </summary>
        protected string _name;
        /// <summary>
        /// Level ID
        /// </summary>
        protected string _level;
        /// <summary>
        /// Field ID
        /// </summary>
        protected string _field;

        /// <summary>
        /// Empty constructor for Subject
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Constructor for subject
        /// </summary>
        /// <param name="uuid">string value</param>
        /// <param name="name">string value</param>
        /// <param name="level">string value</param>
        /// <param name="field">string value</param>
        public Subject(string uuid, string name, string level, string field)
        {
            _uuid = uuid;
            _name = name;
            _level = level;
            _field = field;
        }

        /// <summary>
        /// getter setter for Subject ID
        /// </summary>
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// getter setter for Subject Name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// getter setter for Level ID
        /// </summary>
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        /// <summary>
        /// getter setter for Field ID
        /// </summary>
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
        /// <summary>
        /// Create a list of Subject and return result
        /// </summary>
        /// <returns>Return an array of Subject</returns>
        public static Subject[] CreateSubject()
        {
            Field[] fieldList = DatabaseHandler.GetFieldList();
            Level[] levelList = DatabaseHandler.GetLevelList();
            Subject[] list = new Subject[fieldList.Length*levelList.Length];
            int size = 0;
            for (int i = 0; i < fieldList.Length; i++)
            {
                for (int j = 0; j < levelList.Length; j++)
                {
                    string id = Guid.NewGuid().ToString();
                    string name = fieldList[i].Name + " " + levelList[j].Name;
                    Subject subject = new Subject(id, name, levelList[j].UUID, fieldList[i].UUID);
                    list[size] = subject;
                    size++;
                }
            }
            return list;
            
        }
    }
}
