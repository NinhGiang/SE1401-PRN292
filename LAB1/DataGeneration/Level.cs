using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    /// <summary>
    /// The Level class
    /// Contains method to create Level and its getter/setter/ctor.
    /// </summary>
    class Level
    {
        /// <summary>
        /// The 2 values of Level
        /// </summary>
        protected string _uuid;
        protected string _name;

        /// <summary>
        /// The getter/setter method of Level values
        /// </summary>
        public string Uuid
        {
            get { return _uuid; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// The ctor of Level 
        /// Has one blank ctor
        /// </summary>
        /// <param name="uuid">A string value</param>
        /// <param name="name">A string value</param>
        public Level() { }
        public Level(string uuid, string name)
        {
            _uuid = uuid;
            _name = name;
        }

        /// <summary>
        /// Creates a random list of level and returns the result
        /// </summary>
        /// <returns>An array of levels</returns>
        public static Level[] createLevel()
        {
            int level_size = DataGenerator.GetLevelLength();
            Level[] result = new Level[level_size];
            for (int i = 0; i < level_size; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                string name = DataGenerator.GetLevelDataInIndex(i);
                result[i] = new Level(uuid, name);
            }
            return result;
        }
    }
}
