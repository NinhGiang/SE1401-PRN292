using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Teacher
    {
        protected String _tcuuid;
        protected String _tcfullname;
        protected Boolean _tcgender;

        public String StUUID { get { return _tcuuid; } }
        public String StFullName { get { return _tcfullname; } }
        public Boolean StGender { get { return _tcgender; } }

        public Teacher(String StUUID, String StFullName, Boolean StGender)
        {
            _tcuuid = StUUID;
            _tcfullname = StFullName;
            _tcgender = StGender;
        }

        public void print()
        {
            Console.WriteLine(_tcuuid + " " + _tcfullname);
        }
    }
}
