using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The Field class
    /// Contains create method and properties of Field. 
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Id of field
        /// </summary>
        protected string _id;

        /// <summary>
        /// Name of field
        /// </summary>
        protected string _name;

        /// <summary>
        /// Gets Id of field
        /// </summary>
        /// <returns></returns>
        public string GetId()
        {
            return _id;
        }

        /// <summary>
        /// Sets Id of field
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetId(string value)
        {
            _id = value;
        }

        /// <summary>
        /// Gets name of field
        /// </summary>
        /// <returns>The name of field</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Sets name of field
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetName(string value)
        {
            _name = value;
        }

        /// <summary>
        /// An empty constructor for field
        /// </summary>
        public Field() { }

        /// <summary>
        /// A constructor for field
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="name">A string value</param>
        public Field(string id, string name)
        {
            _id = id;
            _name = name;
        }

        /// <summary>
        /// Creates a list of fields and returns the result
        /// </summary>
        /// <returns>An array of fields</returns>
        public static Field[] Create()
        {
            List<Field> result = new List<Field>();
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            FieldNameConfig _ = config.FieldNameConfig;

            int size = _.field_name_set.Length;

            for (int i = 0; i < size; i++)
            {
                string name = _.field_name_set[i].ToString();
                string id = Guid.NewGuid().ToString();
                result.Add(new Field(id, name));
            }
            return result.ToArray();
        }
    }
}
