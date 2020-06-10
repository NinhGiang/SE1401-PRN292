using System;
using System.Collections.Generic;
using System.IO;

namespace LAB1
{
    /// <summary>
    /// The main Room class.
    /// Contains all methods for generating a room information.
    /// </summary>
    public class Room
    {
        private string uuid;
        private string classUUID;
        private uint no;
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
        public static List<Room> RoomList
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
        public static Room Create(Class classObject, uint no)
        {
            if (roomList == null)
            {
                roomList = new List<Room>();
            }
            Room newRoom = new Room(Guid.NewGuid().ToString(), classObject.UUID, no);
            roomList.Add(newRoom);
            return newRoom;
        }
        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveRooms(string filename)
        {
            String content = "UUID, ClassUUID, No\n";
            foreach (Room room in roomList)
            {
                content += room.UUID + ", " + room.ClassUUID + ", " + room.No + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
