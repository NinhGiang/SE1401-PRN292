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
    public class Field
    {
        private string _uuid;
        private string _name;

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
        public void SetId(string value)
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

        /// <summary>
        /// Empty constructor 
        /// </summary>
        public Field() { }

        /// <summary>
        /// A constructor with input parameters
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="name">A string value</param>
        public Field(string uuid, string name)
        {
            _uuid = uuid;
            _name = name;
        }

        /// <summary>
        /// Make a list of level in array type
        /// </summary>
        /// <returns>An array</returns>
        public static Field[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\Configure.json");

            Configure config = JsonSerializer.Deserialize<Configure>(content);

            FieldConfig x = config.FieldConfig;

            List<Field> result = new List<Field>();

            for (int i = 0; i < x.field_type.Length; i++)
            {
                string name = x.field_type[i].ToString();

                string uuid = Guid.NewGuid().ToString();

                result.Add(new Field(uuid, name));
            }
            return result.ToArray();
        }
    }
}