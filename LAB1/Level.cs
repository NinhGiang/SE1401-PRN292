using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Level
    {
        protected string _uuid;
        protected string _field;

        public Level(string uuid, string field)
        {
            _uuid = uuid ?? throw new ArgumentNullException(nameof(uuid));
            _field = field ?? throw new ArgumentNullException(nameof(field));
        }
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
    }
}
