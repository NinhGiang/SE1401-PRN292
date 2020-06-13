using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Class
    {
        public string UUID { get; set; }
        public Level Level { get; set; }
        public Room Room { get; set; }
        public string Name { get; set; }
        public Class()
        {
            UUID = Guid.NewGuid().ToString() ;
        }
        public static string[] GenerateClassName(int level, int length)
        {
            Random rd = new Random();
            int minusClass = rd.Next(1, 4);

            if (level == 10)
            {
                for (int i = 1; i <= length; i++)
                {
                    Console.WriteLine(level + "A" + i);
                }
            }
            if (level == 11)
            {
                for (int i = 0; i < length - minusClass; i++)
                {
                    Console.WriteLine(level + "A" + i);
                }
            }
            if (level == 12)
            {
                for (int i = 0; i < length - minusClass; i++)
                {
                    Console.WriteLine(level + "A" + i);
                }
            }
            string[] listClass = new string[length];
            for (int i = 0; i < length; i++)
            {
                listClass[i] = rd.Next(level).ToString();
            }
            return listClass;
        }

        
    }
}
