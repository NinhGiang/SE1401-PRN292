using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Room
    {
        protected string _id;
        protected string _classInfo;
        protected int _no;

        public Room(string id, string classInfo, int no)
        {
            _id = id ?? throw new ArgumentNullException(nameof(id));
            _classInfo = classInfo ?? throw new ArgumentNullException(nameof(classInfo));
            _no = no;
        }

        public string GetClassInfo()
        {
            return _classInfo;
        }
        public void SetClassInfo(String classInfo)
        {
            _classInfo = classInfo;
        }
        public int GetNo()
        {
            return _no;
        }
        public void SetNo(int no)
        {
            _no = no;
        }
        
    }
}
