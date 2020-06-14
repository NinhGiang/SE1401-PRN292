using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Room Class
    /// Contains properties and methods for Room
    /// </summary>
    class Room
    {
        /// <summary>
        /// ID of Room
        /// </summary>
        protected string _uuid;
        /// <summary>
        /// ID of Class
        /// </summary>
        protected string _classInfo;
        /// <summary>
        /// Room number
        /// </summary>
        protected int _no;

        /// <summary>
        /// Constructor for Room
        /// </summary>
        /// <param name="uuid">string value</param>
        /// <param name="classInfo">string value</param>
        /// <param name="no">integer</param>
        public Room(string uuid, string classInfo, int no)
        {
            _uuid = uuid;
            _classInfo = classInfo;
            _no = no;
        }

        /// <summary>
        /// getter and setter for Room ID
        /// </summary>
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// getter and setter for Class ID
        /// </summary>
        public string ClassInfo
        {
            get { return _classInfo; }
            set { _classInfo = value; }
        }
        /// <summary>
        /// getter and setter for Room Number
        /// </summary>
        public int No
        {
            get { return _no; }
            set { _no = value; }
        }
        /// <summary>
        /// Create a list of Room using a Dictionary of Room and Class id and return result
        /// </summary>
        /// <param name="ids">Dictionary pair</param>
        /// <returns>return an array of Room</returns>
        public static Room[] CreateRoom(Dictionary<string,string> ids)
        {
            int count = 0;
            Room[] list = new Room[ids.Count];
            foreach (KeyValuePair<string,string> entry in ids)
            {
                String id = entry.Key;
                String classInfo = entry.Value;
                list[count] = new Room(id, classInfo, count + 1);
                count++;
            }
            return list;
        }
    }
}
