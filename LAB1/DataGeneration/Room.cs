using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.DataGeneration
{
    /// <summary>
    /// The Room class
    /// Contains method to create Room and its getter/setter/ctor.
    /// </summary>
    class Room
    {
        /// <summary>
        /// The 3 values of Room
        /// </summary>
        protected string _uuid;
        protected string _class;
        protected int _no;

        /// <summary>
        /// The getter/setter method of Level values
        /// </summary>
        public string Uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Class_info
        {
            get { return _class; }
            set { _class = value; }
        }
        public int No
        {
            get { return _no; }
            set { _no = value; }
        }

        /// <summary>
        /// The ctor of Room 
        /// Has one blank ctor
        /// </summary>
        /// <param name="uuid">A string value</param>
        /// <param name="classInfo">A string value</param>
        /// <param name="no">An integer value</param>
        public Room(){  }
        public Room(string uuid, string classInfo, int no)
        {
            _uuid = uuid;
            _class = classInfo;
            _no = no;
        }

        /// <summary>
        /// Creates a random list of room and returns the result
        /// </summary>
        /// <param name="number_room">An integer value</param>
        /// <returns>An array of rooms</returns>
        public static Room[] createRoom(uint number_room)
        {
            Room[] result = new Room[number_room];
            for (int i = 0; i < number_room; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String class_taken = Guid.NewGuid().ToString();
                int no = i+1;
                result[i] = new Room(uuid, class_taken, no);
            }
            return result;
        }
    }

}
