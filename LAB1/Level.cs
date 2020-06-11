﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Level
    {
        private String UUID, Name;

        public Level(String UUID , String Name)
        {
            this.UUID = UUID;
            this.Name = Name;
        }

        public String GetUUID()
        {
            return this.UUID;
        }
        public void SetUUID(String UUID)
        {
            this.UUID = UUID;
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
