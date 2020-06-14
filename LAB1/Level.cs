using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Level Class
    /// Contains properties and methods for Level
    /// </summary>
    class Level
    {
        /// <summary>
        /// Level ID
        /// </summary>
        protected string _uuid;
        /// <summary>
        /// Level Name
        /// </summary>
        protected string _name;

        /// <summary>
        /// Constructor for Level
        /// </summary>
        /// <param name="uuid">string value</param>
        /// <param name="name">string value</param>
        public Level(string uuid, string name)
        {
            _uuid = uuid;
            _name = name;
        }
        /// <summary>
        /// getter and setter for Level ID
        /// </summary>
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// getter and setter for Level Name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Create a list of Level and return result
        /// </summary>
        /// <returns>Return an array of Level</returns>
        public static Level[] CreateLevel()
        {
            String[] data = Utils.GetLevelData();
            Level[] list = new Level[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = data[i];
                Level level = new Level(uuid, name);
                list[i] = level;
            }
            return list;
        }
    }
}
