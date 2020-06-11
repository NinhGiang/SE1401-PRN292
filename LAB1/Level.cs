using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Level class.
    /// Contains all methods for generating a level information.
    /// </summary>
    public class Level
    {
        private string uuid;
        private string name;
        private static List<Level> levelsList;
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
        /// <value>Gets the value of levelsList.</value>
        public static List<Level> LevelsList
        {
            get
            {
                return levelsList;
            }
        }
        public Level(string newUUID, string newName)
        {
            uuid = newUUID;
            name = newName;
        }
        /// <summary>
        /// Generate a random level.
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
                if (levelsList == null)
                {
                    levelsList = new List<Level>();
                }
                string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
                SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
                LevelConfig levelConfig = config.LevelConfig;
                for (int i = 0; i < levelConfig.LevelNameSet.Length; i++)
                {
                    string levelName = levelConfig.LevelNameSet[i];
                    Level level = new Level(Guid.NewGuid().ToString(), levelName);
                    levelsList.Add(level);
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Level _ NullReference: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Level _ FileNotFound: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Level _ Json: " + ex.Message);
            }                                 
        }
        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveLevels(string filename)
        {
            try
            {
                String content = "UUID, Name\n";
                foreach (Level level in levelsList)
                {
                    content += level.UUID + ", " + level.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Level _ DirectoryNotFound: " + ex.Message);
            }           
        }
    }
}
