using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The ClassInfo class.
    /// Contains create method and properties of ClassInfo. 
    /// </summary>
    public class ClassInfo
    {
        /// <summary>
        /// Id of class
        /// </summary>
        protected string _id;

        /// <summary>
        /// Level of class
        /// </summary>
        protected string _level;

        /// <summary>
        /// Room of class
        /// </summary>
        protected string _room;

        /// <summary>
        /// Name of class
        /// </summary>
        protected string _name;

        /// <summary>
        /// Gets Id of class
        /// </summary>
        /// <returns>The Id of class</returns>
        public string GetId()
        { return _id; }

        /// <summary>
        /// Sets Id of class
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetId(string value)
        { _id = value; }

        /// <summary>
        /// Gets level of class
        /// </summary>
        /// <returns>The level of class</returns>
        public string GetLevel()
        { return _level; }

        /// <summary>
        /// Sets level of class
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetLevel(string value)
        { _level = value; }

        /// <summary>
        /// Gets room of class
        /// </summary>
        /// <returns>The room of class</returns>
        public string GetRoom()
        { return _room; }

        /// <summary>
        /// Sets room of class
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetRoom(string value)
        { _room = value; }

        /// <summary>
        /// Gets name of class
        /// </summary>
        /// <returns>The name of class</returns>
        public string GetName()
        { return _name; }

        /// <summary>
        /// Sets name of class
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetName(string value)
        { _name = value; }

        /// <summary>
        /// An empty constructor for class
        /// </summary>
        public ClassInfo() { }

        /// <summary>
        /// A constructor for class
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="level">A string value</param>
        /// <param name="room">A string value</param>
        /// <param name="name">A string value</param>
        public ClassInfo(string id, string level, string room, string name)
        {
            _id = id;
            _level = level;
            _room = room;
            _name = name;
        }

        /// <summary>
        /// Creates a random list of classes and returns the result
        /// </summary>
        /// <param name="list">A dictionary value</param>
        /// <returns>An array of classes</returns>
        public static ClassInfo[] Create(Dictionary<string, string> list)
        {
            List<ClassInfo> result = new List<ClassInfo>();

            List<string> listOfLevel = FileHelper.GetListOfLevel();

            Random rnd = new Random();

            for (uint i = 0; i < list.Count; i++)
            {
                //id
                string uuid = list.ElementAt((int)i).Value;

                //level
                int levelIndex = rnd.Next(listOfLevel.Count);
                string[] level = listOfLevel[levelIndex].Split(',');
                string levelId = level[0].Trim();

                //room
                string roomId = list.ElementAt((int)i).Key;

                //name
                string levelName = level[1].Trim();
                string roomName = GetRoomNameById(roomId);
                string name = levelName + "-" + roomName;

                result.Add(new ClassInfo(uuid, levelId, roomId, name));
            }

            return result.ToArray();
        }

        /// <summary>
        /// Get room name by room id
        /// </summary>
        /// <param name="id">A string value</param>
        /// <returns>The name of room</returns>
        private static string GetRoomNameById(string id)
        {
            string room = FileHelper.GetRoomByPrimaryKey(id);
            string[] info = room.Split(',');
            string name = info[2].Trim();
            return name;
        }
    }
}