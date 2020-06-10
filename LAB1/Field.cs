using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Field class.
    /// Contains all methods for generating a field information.
    /// </summary>
    public class Field
    {
        private string uuid;
        private string name;
        private static List<Field> fieldList;
        /// <value>Gets the value of UUID.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of Name.</value>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <value>Gets the value of FieldList.</value>
        public static List<Field> FieldList
        {
            get
            {
                return fieldList;
            }
        }
        public Field(string newUUID, string newName)
        {
            uuid = newUUID;
            name = newName;
        }
        /// <summary>
        /// Generate a random class.
        /// </summary>
        /// <returns>
        /// A Class object.
        /// </returns>
        public static void Create()
        {
            if (fieldList == null)
            {
                fieldList = new List<Field>();
            }
            string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
            SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
            FieldConfig fieldName = config.FieldConfig;
            for (int i = 0; i < fieldName.FieldSet.Length; i++)
            {
                Field newField = new Field(Guid.NewGuid().ToString(), fieldName.FieldSet[i]);
                fieldList.Add(newField);
            }
        }
        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveFields(string filename)
        {
            String content = "UUID, Name\n";
            foreach (Field field in fieldList)
            {
                content += field.UUID + ", " + field.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
