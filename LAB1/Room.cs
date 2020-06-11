using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Room
    {
        private String UUID , Class ;
        private int No;

        public Room(String UUID , String Class , int No)
        {
            this.UUID = UUID;
            this.Class = Class;
            this.No = No;
        }

        public String GetUUID()
        {
            return this.UUID;
        }

        public void SetUUID(String UUID)
        {
            this.UUID = UUID;
        }
        public String GetClass()
        {
            return this.Class;
        }
        public void SetClsss(String Class)
        {
            this.Class = Class;
        }

        public int GetNo()
        {
            return this.No;
        }

        public void SetNo(int No)
        {
            this.No = No;
        }
    }
}
