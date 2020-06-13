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

        /// <value>
        /// The id of class
        /// </value>
        public string UUID { get { return _id; } }

        /// <value>
        /// The level of class
        /// </value>
        public string Level { get { return _level; } }

        /// <value>
        /// The room of class
        /// </value>
        public string Room { get { return _room; } }

        /// <value>
        /// The name of class
        /// </value>
        public string Name { get { return _name; } }

        /// <summary>
        /// An empty constructor for class
        /// </summary>
        public Class() { }

        /// <summary>
        /// A constructor for class
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
        /// Creates a random list of classes and returns the result
        /// </summary>
        /// <param name="list">A dictionary value</param>
        /// <returns>An array of classes</returns>
        public static Class[] Create(Dictionary<string, string> list)
        {
            List<Class> result = new List<Class>();

            List<string> listOfLevel = FileHelper.GetListOfLevel();
            int amountEachLevel = (int)Math.Ceiling((double)list.Count / listOfLevel.Count);
            int count = 0;
            int levelIndex = 0;

            for (uint i = 0; i < list.Count; i++)
            {
                count++;
                //id
                string uuid = list.ElementAt((int)i).Value;

                //level
                string[] level = listOfLevel[levelIndex].Split(',');
                string levelId = level[0].Trim();

                //room
                string roomId = list.ElementAt((int)i).Key;

                //name
                string levelName = level[1].Trim();
                string name = levelName + "A" + count;

                result.Add(new Class(uuid, levelId, roomId, name));

                if(count == amountEachLevel)
                {
                    levelIndex++;
                    count = 0;
                }
            }

            return result.ToArray();
        }
    }
}