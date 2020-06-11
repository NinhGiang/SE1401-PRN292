using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.Object
{
    class Level
    {
        protected string _id;
        protected string _fullname;

        public string ID
        {
            get { return _id; }
        }
        public string FullName
        {
            get { return _fullname; }
        }

        protected Level(string ID, string FullName)
        {
            _id = ID;
            _fullname = FullName;
        }
        
        /*
        public static Level[] addNewLevel()
        {

            return;
        }
        */

    }
}
