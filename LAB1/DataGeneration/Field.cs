using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{   
     /// <summary>
     /// The Field class
     /// Contains method to create Field and its getter/setter/ctor.
     /// </summary>
    class Field
    {
        /// <summary>
        /// The 2 values of Field
        /// </summary>
        protected string _uuid;
        protected string _name;
        
        /// <summary>
        /// The getter/setter method of Field values
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

        /// <summary>
        /// The ctor of Field 
        /// Has one blank ctor
        /// </summary>
        /// <param name="uuid">A string value</param>
        /// <param name="name">A string value</param>
        public Field() { }
        public Field(string uuid, string name)
        {
            _uuid = uuid;
            _name = name;
        }

        /// <summary>
        /// Creates a random list of field and returns the result
        /// </summary>
        /// <returns>An array of fields</returns>
        public static Field[] createField()
        {
            List<Field> result = new List<Field>();
            int fieldSize = DataGenerator.getFieldLength();
            for (uint i = 0; i < fieldSize; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                string fieldName = DataGenerator.getFieldName(i);
                result.Add(new Field(uuid, fieldName));
            }
            return result.ToArray();
        }
    }
}
