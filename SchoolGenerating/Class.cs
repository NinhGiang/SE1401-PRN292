using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGenerating
{
    class Class
    {
        private String classID { get { return level; } set { this.classID = value; } }
        private String level{ get { return level; } set { this.level = value; } }
        private String room { get { return level; } set { this.room = value; } }
        private String className { get { return level; } set { this.className = value; } }

        public Class(string classID, string level, string room, string className)
        {
            this.classID = classID;
            this.level = level;
            this.room = room;
            this.className = className;
        }

        //generate Class
        public static Class[] Create(uint number_of_Classes)
        {
            Class[] result = new Class[number_of_Classes];
            for (int i = 0; i < result.Length; i++)
            {

            }
            return result;
        }
    }
}
