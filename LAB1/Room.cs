using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Room
    {
        protected string roomID;
        protected string roomClass;
        protected int roomNumber;

        public string RoomID { get { return roomID; } }
        public string RoomClass { get { return roomClass; } }
        public int RoomNumber { get { return roomNumber; } set { roomNumber = value; } }

        protected Room(string RoomID, string RRoomClassoom, int RoomNumber)
        {
            roomID = RoomID;
            roomClass = RoomClass;
            roomNumber = RoomNumber;
        }
        protected Room() { }


    }
}
