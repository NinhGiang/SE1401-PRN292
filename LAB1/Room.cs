using System;
using System.Collections.Generic;
using System.IO;
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

        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetClassInfo()
        { return _class; }

        public void SetClassInfo(string value)
        { _class = value; }

        public int GetNo()
        { return _no; }

        public void SetNo(int value)
        { _no = value; }

        public Room() { }

        public Room(string id,  string classInfo, int no)
        {
            _id = id;
            _class = classInfo;
            _no = no;
        }

        public static Room[] Create(int numberOfRoom)
        {
            List<Room> result = new List<Room>();

            Random rnd = new Random();

            for (uint i = 0; i < numberOfRoom; i++)
            {
                //id
                string uuid = Guid.NewGuid().ToString();

                //class
                string classInfo = "tempClass";

                //no
                int no = (int)i + 1;

                result.Add(new Room(uuid, classInfo, no));
            }

            return result.ToArray();
        }
    }
}
