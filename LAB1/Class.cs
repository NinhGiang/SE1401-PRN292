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
        private static List<Class> classList;
        /// <value>Gets the value of UUID.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of LevelUUID.</value>
        public string LevelUUID
        {
            get
            {
                return levelUUID;
            }
        }
        /// <value>Gets the value of RoomUUID.</value>
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
        /// <value>Gets the value of Name.</value>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <value>Gets the value of ClassList.</value>
        public static List<Class> ClassList
        {
            get
            {
                return classList;
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
        /// <returns>
        /// A Class object.
        /// </returns>
        public static Class Create(Level level, string roomUUID, int index)
        {
            if (classList == null)
            {
                classList = new List<Class>();
            }
            string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
            SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
            ClassConfig randomClassName = config.ClassConfig;
            int classNameIndex = index;
            string uuid = Guid.NewGuid().ToString();
            string classname = level.Name + randomClassName.ClassNameSet[classNameIndex];
            Class newClass = new Class(uuid, level.UUID, roomUUID, classname);
            classList.Add(newClass);
            return newClass;
        }
        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveClasses(string filename)
        {
            String content = "UUID, LevelUUID, RoomUUID, Name\n";
            foreach (Class classObject in classList)
            {
                content += classObject.UUID + ", " + classObject.LevelUUID + ", " + classObject.RoomUUID + ", " + classObject.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
