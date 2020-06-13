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

        /// <value>
        /// The id of level
        /// </value>
        public string UUID { get { return _id; } }

        /// <value>
        /// The name of level
        /// </value>
        public string Name { get { return _name; } }

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
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when the object in Json file is not exist or has no data.
        /// </exception>
        public static Level[] Create()
        {
            try
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
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Level _ FileNotFoundException: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Level _ NullReferenceException: " + ex.Message);
            }
            return null;
        }
    }


}
