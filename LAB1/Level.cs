using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The Level class
    /// Contains create method and properties of Level. 
    /// </summary>
    public class Level
    {
        /// <summary>
        /// Id of level
        /// </summary>
        protected string _id;

        /// <summary>
        /// Name of level
        /// </summary>
        protected string _name;

        /// <summary>
        /// Gets Id of level
        /// </summary>
        /// <returns>The Id of level</returns>
        public string GetId()
        { return _id; }

        /// <summary>
        /// Sets Id of level
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetId(string value)
        { _id = value; }

        /// <summary>
        /// Gets name of level
        /// </summary>
        /// <returns>The name of level</returns>
        public string GetName()
        { return _name; }

        /// <summary>
        /// Sets name of level
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetName(string value)
        { _name = value; }

        /// <summary>
        /// An empty constructor for level
        /// </summary>
        public Level() { }

        /// <summary>
        /// A constructor for level
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="name">A string value</param>
        public Level(string id, string name)
        {
            _id = id;
            _name = name;
        }

        /// <summary>
        /// Creates a list of levels and returns the result
        /// </summary>
        /// <returns>An array of levels</returns>
        public static Level[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            LevelNameConfig _ = config.LevelNameConfig;

            int size = _.level_name_set.Length;
            List<Level> result = new List<Level>();

            for (int i = 0; i < size; i++)
            {
                string name = _.level_name_set[i].ToString();
                string id = Guid.NewGuid().ToString();
                result.Add(new Level(id, name));
            }
            return result.ToArray();
        }
    }


}
