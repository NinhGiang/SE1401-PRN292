﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Level class.
    /// Contains all methods for generating a level information.
    /// </summary>
    class Level
    {
        private string uuid;
        private string name;
        private static List<Level> levelList;
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
        /// <value>Gets the value of LevelList.</value>
        public static List<Level> LevelList
        {
            get
            {
                return levelList;
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
        /// <returns>
        /// A Level object.
        /// </returns>
        public static Level Create()
        {
            if (levelList == null)
            {
                levelList = new List<Level>();
            }
            string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
            SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
            Random rnd = new Random();
            LevelConfig levelConfig = config.LevelConfig;
            int levelNameIndex = rnd.Next(levelConfig.LevelNameSet.Length);
            string levelName = levelConfig.LevelNameSet[levelNameIndex];
            Level level = new Level(Guid.NewGuid().ToString(), levelName);
            levelList.Add(level);
            return level;
        }
    }
}
