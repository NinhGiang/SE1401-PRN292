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
    public class Class
    {
        /// <summary>
        /// Class's Id
        /// </summary>
        protected string _id;

        /// <summary>
        /// Class's level
        /// </summary>
        protected string _level;

        /// <summary>
        /// class's room
        /// </summary>
        protected string _room;

        /// <summary>
        /// Class's name
        /// </summary>
        protected string _name;

        /// <summary>
        /// ID getter
        /// </summary>
        /// <returns>Class's id/returns>
        public string GetId()
        {
            return _id; 
        }

        /// <summary>
        /// Id setter
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetId(string value)
        {
            _id = value;
        }

        /// <summary>
        /// Level setter
        /// </summary>
        /// <returns>Class' level</returns>
        public string GetLevel()
        {
            return _level;
        }

        /// <summary>
        /// Class setter
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetLevel(string value)
        {
            _level = value;
        }

        /// <summary>
        /// Room getter
        /// </summary>
        /// <returns>Class's room</returns>
        public string GetRoom()
        {
            return _room;
        }

        /// <summary>
        /// Room setter
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetRoom(string value)
        {
            _room = value;
        }

        /// <summary>
        /// Name getter
        /// </summary>
        /// <returns>Class's name</returns>
        public string GetName()
        { 
            return _name;
        }

        /// <summary>
        /// Class setter
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetName(string value)
        {
            _name = value;
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Class() { }

        /// <summary>
        /// A constructor for class that contains all input parameters
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="level">A string value</param>
        /// <param name="room">A string value</param>
        /// <param name="name">A string value</param>
        public Class(string id, string level, string room, string name)
        {
            _id = id;
            _level = level;
            _room = room;
            _name = name;
        }

        /// <summary>
        /// Make a list of class
        /// </summary>
        /// <param name="list">A dictionary value</param>
        /// <returns>An array of classes</returns>
        public static Class[] Create(Dictionary<string, string> list)
        {
            List<Class> result = new List<Class>();

            List<string> levelList = Readcsvjsonhelper.GetLevelList();
            
            //calculate each level should have how many class
            int levelamount = (int)Math.Ceiling((double)list.Count / levelList.Count);

            //flag for changing level
            int count = 0;

            //current level
            int levelIndex = 0;


            for (int i = 0; i < list.Count; i++)
            {
                //id
                string uuid = list.ElementAt(i).Value;


                //room
                string roomId = list.ElementAt(i).Key;

                //level
                string[] level = listOfLevel[levelIndex].Split(',');
                string levelId = level[0].Trim();

                //name
                string levelName = level[1].Trim();
                string roomName = GetRoomNumber(roomId);
                string name = levelName + "A" + roomName;

                result.Add(new ClassInfo(uuid, levelId, roomId, name));
                //when a class created count ++
                count++;

                //if number of class in a level is enough then increase levelnumber and set count = 0
                if(count == levelamount)
                {
                    levelIndex++;
                    count = 0;
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Get room name by room id
        /// </summary>
        /// <param name="id">A string value</param>
        /// <returns>The name of room</returns>
        private static string GetRoomNumber(string id)
        {
            string room = Readcsvjsonhelper.GetRoomNumber(id);
            string[] info = room.Split(',');
            string number = info[2].Trim();
            return number;
        }
    }
}