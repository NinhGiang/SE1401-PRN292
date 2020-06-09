using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    public class Room
    {
        private string id;
        private string @class;
        private int no;

        protected string Id { get => id; set => id = value; }
        protected string Class { get => @class; set => @class = value; }
        protected int No { get => no; set => no = value; }

        public Room()
        {
               
        }

        public Room(string id, string @class, int no)
        {
            Id = id;
            Class = @class;
            No = no;
        }

        public static Room[] Create(int numberOfRoom)
        {
            Room[] result = new Room[numberOfRoom];

            for (int i = 0; i < numberOfRoom; i++)
            {
                string uuid = Guid.NewGuid().ToString();

                int no = i + 1;

                result[i] = new Room(uuid, "tempClass", no);
            }

            return result;
        }
    }
}
