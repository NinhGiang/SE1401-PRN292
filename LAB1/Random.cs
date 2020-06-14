using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Random
    {
        public static int CheckStudentNumber(int number)
        {
            if (number >= 500 && number <= 3000)
            {
                return number;
            }
            return -1;
        }

        public static int CheckRoomNumber(int number)
        {
            if (number >= 3 && number <= 100)
            {
                return number;
            }
            return -1;
        }

        public static bool CheckRatio(int student, int room)
        {
            double ratio = (double)student / (double)room;
            if (ratio >= 30 && ratio <= 50)
            {
                return true;
            }
            return false;
        }
    }
}
