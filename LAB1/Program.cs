using System;
using System.IO;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            School sc = new School();
            sc.School_name = "ABC";
            string directorypath = @"..\..\..\" + sc.School_name;
            Directory.CreateDirectory(directorypath);
        }
    }
}
