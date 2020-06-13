﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Class
    {
        private string id;
        private string level;//khoa ngoai
        private string room; //khoa ngoai
        private string name; //10A1, 10A2, 10A3

        public string Id { get => id; set => id = value; }
        public string Level { get => level; set => level = value; }
        public string Room { get => room; set => room = value; }
        public string Name { get => name; set => name = value; }

        
        public Class(string id, string level, string room, string name)
        {
            this.Id = id;
            this.Level = level;
            this.Room = room;
            this.Name = name;
        }
    }
}
