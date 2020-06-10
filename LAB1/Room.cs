﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Room
    {
        protected string _uuid;
        protected string _classInfo;
        protected int _no;

        public Room(string uuid, string classInfo, int no)
        {
            _uuid = uuid ?? throw new ArgumentNullException(nameof(uuid));
            _classInfo = classInfo ?? throw new ArgumentNullException(nameof(classInfo));
            _no = no;
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string ClassInof
        {
            get { return _classInfo; }
            set { _classInfo = value; }
        }
        public int No
        {
            get { return _no; }
            set { _no = value; }
        }
        public void create()
        {

        }
    }
}
