using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramManagerStudent
{
    class Room
    {
        private string uuid;
        private string classUUID;
        private uint no;
        private static List<Room> roomList;

        public string Uuid { get { return uuid; }; set { uuid = value; } }
        public string ClassUUID { get { return classUUID; }; set { classUUID = value; } }
        public uint No { get { return no; }; set { no = value; } }

        public Room(string uuid, string classUUID, uint no)
        {
            this.uuid = uuid;
            this.classUUID = classUUID;
            this.no = no;
        }

        public Room()
        {

        }


    }
}
