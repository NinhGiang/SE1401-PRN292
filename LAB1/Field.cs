using System;
using System.Collections.Generic;
using System.IO;
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
        private static List<Field> fieldsList;
        /// <value>Gets the value of uuid.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of name.</value>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <value>Gets the value of fieldsList.</value>
        public static List<Field> FieldsList
        {
            get
            {
                return fieldsList;
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
        /// <exception cref="System.NullReferenceException">
        /// Thrown when an object does not exist but it is used.
        /// </exception>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the file is not found (wrong path, wrong filename or file is not existed).
        /// </exception>
        /// <exception cref="System.Text.Json.JsonException">
        /// Thrown when cannot parse a value in Json file into an instance.
        /// </exception>
        public static void Create()
        {
            try
            {
                if (fieldsList == null)
                {
                    fieldsList = new List<Field>();
                }
                string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
                SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
                FieldConfig fieldName = config.FieldConfig;
                for (int i = 0; i < fieldName.FieldSet.Length; i++)
                {
                    Field newField = new Field(Guid.NewGuid().ToString(), fieldName.FieldSet[i]);
                    fieldsList.Add(newField);
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Field _ NullReference: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Field _ FileNotFound: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Field _ Json: " + ex.Message);
            }
        }

        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveFields(string filename)
        {
            try
            {
                String content = "UUID, Name\n";
                foreach (Field field in fieldsList)
                {
                    content += field.UUID + ", " + field.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Field _ DirectoryNotFound: " + ex.Message);
            }            
        }
    }
}
