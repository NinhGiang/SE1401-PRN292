using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    class Keyboard
    {
        public static string inputString(string message)
        {
            string result;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    result = Console.ReadLine();
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                    throw;
                }
            }
        }
        public static int inputInt(string message)
        {
            int result;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    result = Int32.Parse(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                    throw;
                }
            }
        }
        public static bool inputBool(string message)
        {
            bool result;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    result = Boolean.Parse(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                    throw;
                }
            }
        }
    }
}
