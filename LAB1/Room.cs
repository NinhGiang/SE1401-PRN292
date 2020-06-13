﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The Room class
    /// Contains create method and properties of Room. 
    /// </summary>
    public class Room
    {
        /// <summary>
        /// Id of room
        /// </summary>
        protected string _id;

        /// <summary>
        /// Class of room
        /// </summary>
        protected string _class;

        /// <summary>
        /// Room number
        /// </summary>
        protected int _no;

        /// <value>
        /// The id of room
        /// </value>
        public string UUID { get { return _id; } }

        /// <value>
        /// The class that use this room
        /// </value>
        public string Class { get { return _class; } }

        /// <value>
        /// The room number
        /// </value>
        public int No { get { return _no; } }

        /// <summary>
        /// An empty constructor for room
        /// </summary>
        public Room() { }

        /// <summary>
        /// A constructor for room
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="classInfo">A string value</param>
        /// <param name="no">A positive integer value</param>
        public Room(string id,  string classInfo, int no)
        {
            _id = id;
            _class = classInfo;
            _no = no;
        }

        /// <summary>
        /// Creates a random list of rooms and returns the result
        /// </summary>
        /// <param name="list">A dictionary value</param>
        /// <returns>An array of rooms</returns>
        public static Room[] Create(Dictionary<string, string> list)
        {
            List<Room> result = new List<Room>();
            int size = list.Count;

            for (uint i = 0; i < size; i++)
            {
                //id
                string uuid = list.ElementAt((int)i).Key;

                //class
                string classInfo = list.ElementAt((int)i).Value;

                //no
                int no = (int)i + 1;

                result.Add(new Room(uuid, classInfo, no));
            }

            return result.ToArray();
        }
    }
}
