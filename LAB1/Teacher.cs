using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Teacher
    {
        protected String _tcuuid;
        protected String _tcfullname;
        protected String _tcgender;
        protected String _field;

        public String StUUID { get { return _tcuuid; } }
        public String StFullName { get { return _tcfullname; } }
        public String StGender { get { return _tcgender; } }
        public String Field { get { return _field; } }
        public Teacher(String TcUUID, String TcFullName, String TcGender, String Field)
        {
            _tcuuid = StUUID;
            _tcfullname = StFullName;
            _tcgender = StGender;
            _field = Field;
        }

        public void print()
        {
            Console.WriteLine(_tcuuid + " " + _tcfullname);
        }
    }
}
