using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGenerating
{
    class Room
    {
        private string roomID { get { return roomID; } set { roomID = value; } };
        private string className { get { return className; } set { className = value; } };
        private int no { get { return no; } set { no = value; } };

        public Room()
        {
        }

        public Room(string roomID, string className, int no)
        {
            this.roomID = roomID;
            this.className = className;
            this.no = no;
        }


    }
}
