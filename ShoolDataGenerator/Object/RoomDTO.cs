using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class RoomDTO
    {
        public string UUID { get; set; }
        public int No { get; set; }
        
        public RoomDTO()
        {
            UUID = Guid.NewGuid().ToString();
        }
        public static int[] GenrateRoomNo(int length)
        {
            int[] no = new int[length];
            for (int i = 0; i < length; i++)
            {
                no[i] = i + 1;
            }
            return no;
        }
    }
}
