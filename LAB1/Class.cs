﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Class class.
    /// Contains all methods for generating a class information.
    /// </summary>
    class Class
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
        public static Class Create()
        {
            if (classList == null)
            {
                classList = new List<Class>();
            }
            Level newLevel = Level.Create();
            Class newClass = new Class(Guid.NewGuid().ToString(), newLevel.UUID, Guid.NewGuid().ToString(), "Classname");
            classList.Add(newClass);
            return newClass;
        }
    }
}
