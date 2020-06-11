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
        private static List<Room> roomsList;
        /// <value>Gets the value of uuid.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of classUUID.</value>
        public string ClassUUID
        {
            get
            {
                return classUUID;
            }
        }
        /// <value>Gets the value of no.</value>
        public uint No
        {
            get
            {
                return no;
            }
        }
        /// <value>Gets the value of roomList.</value>
        public static List<Room> RoomsList
        {
            get
            {
                return roomsList;
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
            if (roomsList == null)
            {
                roomsList = new List<Room>();
            }
            Room newRoom = new Room(Guid.NewGuid().ToString(), classObject.UUID, no);
            roomsList.Add(newRoom);
            return newRoom;
        }
        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveRooms(string filename)
        {
            try
            {
                String content = "UUID, ClassUUID, No\n";
                foreach (Room room in roomsList)
                {
                    content += room.UUID + ", " + room.ClassUUID + ", " + room.No + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Room _ DirectoryNotFound: " + ex.Message);
            }           
        }
    }
}
