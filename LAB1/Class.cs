using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Class
    {
        protected string classID;
        protected string room;
        protected string className;

        public string ClassID { get { return classID; } }
        public string Room { get { return room; } }
        public string ClassName { get { return className; } set { className = value; } }

        protected Class (string ClassID, string Room, string ClassName)
        {
            classID = ClassID;
            room = Room;
            className = ClassName;
        }
        protected Class() { }


    }
}
