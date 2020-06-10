using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Field
    {
        protected String _uuid;
        protected String _subname;

        public String UUID { get { return _uuid; } }
        public String SubName { get { return _subname; } }

        public Field (String UUID, String SubName)
        {
            _uuid = UUID;
            _subname = SubName;
        }
    }
}
