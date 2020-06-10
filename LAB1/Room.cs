using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// The main Room class.
    /// Contains all methods for generating a room information.
    /// </summary>
    class Room
    {
        private string uuid;
        private string classUUID;
        private static uint no = 1;
        private static List<Room> roomList;
        /// <value>Gets the value of UUID.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of ClassUUID.</value>
        public string ClassUUID
        {
            get
            {
                return classUUID;
            }
        }
        /// <value>Gets the value of No.</value>
        public uint No
        {
            get
            {
                return no;
            }
        }
        /// <value>Gets the value of RoomList.</value>
        public List<Room> RoomList
        {
            get
            {
                return roomList;
            }
        }
        public Room(string newUUID, string newClassUUID, uint newNo)
        {
            uuid = newUUID;
            classUUID = newClassUUID;
            no = newNo;
        }
        /// <summary>
        /// Generate a random room.
        /// </summary>
        /// <returns>
        /// A Room object.
        /// </returns>
        public static Room Create(string classUUID)
        {
            if (roomList == null)
            {
                roomList = new List<Room>();
            }
            Room newRoom = new Room(Guid.NewGuid().ToString(), classUUID, no);
            roomList.Add(newRoom);
            no++;
            return newRoom;
        }
    }
}
