using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class CLIHandler
    {
        public static string CLI(string[] args)
        {
            string result = "";
            string help = @"Help: 
 ./ schoolDatabaseGenerator << school_name >>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100
 ./ schoolDatabaseGenerator << school_name >> -s << number_students >>: Generate a school database with << number_students >> in range 500 to 3000 and the largest number rooms is 100
 ./ schoolDatabaseGenerator << school_name >> -r << number_rooms >>: Generate a school database with << number_rooms >> and number students in range 500 to 3000.
 ./ schoolDatabaseGenerator << school_name >> -s << number_students >> -r << number_rooms >>: Generate a school database with << number_students >> and << number_rooms >>.";
            if (args.Length == 0 || (args.Length == 1 && args[0].Equals("-h") ) )
            {
                result = help;
            }
            else if (args.Length > 0 && !args[0].Equals("-h") && !args[0].Equals("-s") )
            {
                result = "Something is wrong";
            }
            else if (args.Length == 1 && args[1].Equals("-s"))
            {
                result = "Need a filename";
            }
            return result;
        }
    }
}
