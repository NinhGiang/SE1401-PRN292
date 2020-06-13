using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The Room's class that contains all properties of Room
    /// </summary>
    public class Room
    {
        /// <summary>
        /// Room's UUid
        /// </summary>
        protected string _uuid;

        /// <summary>
        ///  Room's Class
        /// </summary>
        protected string _class;

        /// <summary>
        ///  Room's number
        /// </summary>
        protected int _no;

        /// <summary>
        /// Gets Room's uuid
        /// </summary>
        /// <returns>The uuid of room</returns>
        public string GetUuid()
        { 
            return _uuid;
        }

        /// <summary>
        /// Set Room's uuid
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetUuid(string value)
        {
            _uuid = value;
        }

        /// <summary>
        /// Get Room'class
        /// </summary>
        /// <returns>The class's uuid of room</returns>
        public string GetClass()
        { 
            return _class;
        }

        /// <summary>
        /// Set Room's class
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetClass(string value)
        {
            _class = value;
        }

        /// <summary>
        /// Get Room's number
        /// </summary>
        /// <returns>The room's number</returns>
        public int GetNo()
        { 
            return _no;
        }

        /// <summary>
        /// Set Room's number
        /// </summary>
        /// <param name="value">A positive integer value</param>
        public void SetNo(int value)
        {
            _no = value;
        }

        /// <summary>
        /// A constructor for room that contains input parameters
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="classin">A string value</param>
        /// <param name="noin">A positive integer value</param>
        public Room(string id, string classin, int noin)
        {
            _uuid = id;
            _class = classin;
            _no = noin;
        }

         /// <summary>
         /// An empty constructor
         /// </summary>
         public Room() { }


        /// <summary>
        /// Generate a list of Room and return
        /// </summary>
        /// <param name="list">A dictionary <tkey,tvalue></param>
        /// <returns>An array of rooms</returns>
        public static Room[] Create(Dictionary<string, string> list)
        {
            List<Room> result = new List<Room>();

            for (uint i = 0; i < list.Count; i++)
            {
                //id
                string uuid = list.ElementAt((int)i).Key;

                //class
                string classin = list.ElementAt((int)i).Value;

                //no
                int noin = (int)i + 1;

                result.Add(new Room(uuid, classin, noin));
            }

            return result.ToArray();
        }
    }
}