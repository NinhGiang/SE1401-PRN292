using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Class class
    /// Contains properties and methods of Class
    /// </summary>
    class Class
    {
        /// <summary>
        /// ID of class
        /// </summary>
        protected string _uuid;
        /// <summary>
        /// ID of level
        /// </summary>
        protected string _level;
        /// <summary>
        /// ID of room
        /// </summary>
        protected string _room;
        /// <summary>
        /// Name of class
        /// </summary>
        protected string _name;

        /// <summary>
        /// An empty constructor of Class
        /// </summary>
        public Class()
        {
        }
        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="uuid">string value</param>
        /// <param name="level">string value</param>
        /// <param name="room">string value</param>
        /// <param name="name">string value</param>
        public Class(string uuid, string level, string room, string name)
        {
            _uuid = uuid;
            _level = level;
            _room = room;
            _name = name;
        }
        /// <summary>
        /// getter and setter for class ID
        /// </summary>
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// getter and setter for level ID
        /// </summary>
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        /// <summary>
        /// getter and setter for room ID
        /// </summary>
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
        /// <summary>
        /// getter and setter for class name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Create a list of Class using a Dictionary of Room and Class id and return result
        /// </summary>
        /// <param name="ids">Dictionary pair</param>
        /// <returns>Return an array of Class</returns>
        public static Class[] CreateClass(Dictionary<String,String> ids)
        {
            Level[] levelList = DatabaseHandler.GetLevelList();
            Class[] list = new Class[ids.Count];
            int count = 0;
            int numberOfClass = (int) Math.Floor((double)ids.Count / levelList.Length);
            int leftover = ids.Count - numberOfClass * levelList.Length; // ids.Count % numberOfClass does not work
            int levelIndex = 0;
            int classLevelCount = 1;
            foreach (KeyValuePair<string,string> entry in ids)
            {
                String id = entry.Value;
                Level currLevel = levelList[levelIndex];
                String level = currLevel.UUID;
                String room = entry.Key;
                
                String name = currLevel.Name + "A" + classLevelCount;
                
                list[count] = new Class(id,level,room,name);
                count++;

                if (classLevelCount < numberOfClass)
                {
                    classLevelCount++;
                }
                else if (levelIndex == 0 & classLevelCount < numberOfClass + leftover)
                {
                        classLevelCount++;
                }
                else
                {
                    if (levelIndex < levelList.Length - 1)
                    {
                        levelIndex++;
                        classLevelCount = 1;
                    }
                    /*                   
                    else
                    {
                        levelIndex = 0;
                        classLevelCount = numberOfClass + 1;
                        numberOfClass += leftover;
                    } 
                    */
                }
            }
            return list;
        }
        /*
        public static void print(Dictionary<String, String> ids, Level[] levelList)
        {
            int idCount = ids.Count;
            int count = levelList.Length;

            Console.WriteLine(idCount);
            Console.WriteLine(count);

            Console.WriteLine(idCount/=count);
            Console.WriteLine(idCount % count);
        }
        */
    }
}
