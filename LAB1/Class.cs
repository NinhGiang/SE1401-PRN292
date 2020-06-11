using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace LAB1
{
    class Class
    {
        protected String Level , Room , Name ;

        public Class(String Level , String Room , String Name)
        {
            this.Level = Level;
            this.Room = Room;
            this.Name = Name;
        }

        public String GetLevel()
        {
            return this.Level;
        }

        public void SetLevel(String Level)
        {
            this.Level = Level;
        }

        public String GetRoom()
        {
            return this.Room;
        }

        public void SetRoom(String Room)
        {
            this.Room = Room;
        }

        public String GetName()
        {
            return this.Name;
        }
        public void SetName(String Name)
        {
            this.Name = Name;
        }
    }
}
