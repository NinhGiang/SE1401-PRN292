using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Level
    {
        public string UUID  { get; set; }
        public int Name { get; set; }
        public Level()
        {
            UUID = Guid.NewGuid().ToString();
        }
        public static int[] GenerateLevelName(int length)
        {
            Random rd = new Random();
            int[] level = new int[length];
            for (int i = 0; i < length; i++)
            {
                level[i] = rd.Next(10, 13);
            }
            return level;
        }
    }
}
