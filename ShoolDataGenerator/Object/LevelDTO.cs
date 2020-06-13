using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class LevelDTO
    {
        public static readonly string[] listLevelName = new string[] { "10", "11", "12" };
        public string UUID { get; set; }
        public int Name { get; set; }
        public string[] ListLevelName { get { return listLevelName; } }
        public LevelDTO()
        {
            UUID = Guid.NewGuid().ToString();
        }
       /* public static int[] GenerateLevelName(int length)
        {
            Random rd = new Random();
            int[] level = new int[length];
            for (int i = 0; i < length; i++)
            {
                level[i] = rd.Next(10, 13);
            }
            return level;
        }*/
    }
}
