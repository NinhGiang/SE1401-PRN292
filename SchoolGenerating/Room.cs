using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGenerating
{
    class Room
    {
        private string roomID { get { return roomID; } set { roomID = value; } }
        private string className { get { return className; } set { className = value; } }
        private int no { get { return no; } set { no = value; } }

        public Room()
        {
        }

        public Room(string roomID, string className, int no)
        {
            this.roomID = roomID;
            this.className = className;
            this.no = no;
        }

        public static Room[] Create(uint number_of_Room)
        {
            Room[] result = new Room[number_of_Room];
            for (int i = 0; i < result.Length; i++)
            {
                String UUID = Guid.NewGuid().ToString();
                int no_of_room = i+=1;

            }
            return result;
        }


    }
}
