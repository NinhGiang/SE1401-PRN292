using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// The Field Class
    /// Contains properties and methods of Field
    /// </summary>
    class Field
    {
        /// <summary>
        /// ID of Field
        /// </summary>
        protected string _uuid;
        /// <summary>
        /// Name of Field
        /// </summary>
        protected string _name;
        /// <summary>
        /// Constructor for Field
        /// </summary>
        /// <param name="uuid">A string value</param>
        /// <param name="name">A string value</param>
        public Field(string uuid, string name)
        {
            _uuid = uuid;
            _name = name;
        }
        /// <summary>
        /// getter and setter for field ID
        /// </summary>
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// getter and setter for field Name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Create a list of Field and return result
        /// </summary>
        /// <returns>Return an array of Field</returns>
        public static Field[] CreateField()
        {
            String[] data = Utils.GetFieldData();
            Field[] list = new Field[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = data[i];
                Field field = new Field(uuid, name);
                list[i] = field;
            }
            return list;
        }
    }
}
