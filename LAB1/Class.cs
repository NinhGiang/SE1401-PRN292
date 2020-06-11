using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Class class.
    /// Contains all methods for generating a class information.
    /// </summary>
    public class Class
    {
        private string uuid;
        private string levelUUID;
        private string roomUUID;
        private string name;
        private static List<Class> classesList;
        /// <value>Gets the value of uuid.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of levelUUID.</value>
        public string LevelUUID
        {
            get
            {
                return levelUUID;
            }
        }
        /// <value>Gets the value of roomUUID.</value>
        public string RoomUUID
        {
            get
            {
                return roomUUID;
            }
            set
            {
                roomUUID = value;
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
        /// <value>Gets the value of classesList.</value>
        public static List<Class> ClassesList
        {
            get
            {
                return classesList;
            }
        }
        public Class(string newUUID, string newLevelUUID, string newRoomUUID, string newName)
        {
            uuid = newUUID;
            levelUUID = newLevelUUID;
            roomUUID = newRoomUUID;
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
        /// <param name="level">A Level object.</param>
        /// <param name="roomUUID">A string.</param>
        /// <param name="index">An integer.</param>
        public static void Create(Level level, string roomUUID, int index)
        {
            try
            {
                if (classesList == null)
                {
                    classesList = new List<Class>();
                }
                string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
                SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
                ClassConfig randomClassName = config.ClassConfig;
                int classNameIndex = index;
                string uuid = Guid.NewGuid().ToString();
                string classname = level.Name + randomClassName.ClassNameSet[classNameIndex];
                Class newClass = new Class(uuid, level.UUID, roomUUID, classname);
                classesList.Add(newClass);               
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Class _ NullReference: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Class _ FileNotFound: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Class _ Json: " + ex.Message);
            }
        }

        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveClasses(string filename)
        {
            try
            {
                String content = "UUID, LevelUUID, RoomUUID, Name\n";
                foreach (Class classObject in classesList)
                {
                    content += classObject.UUID + ", " + classObject.LevelUUID + ", " + classObject.RoomUUID + ", " + classObject.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Class _ DirectoryNotFound: " + ex.Message);
            }            
        }
    }
}
