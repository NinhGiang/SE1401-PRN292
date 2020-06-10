using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected string _level;
        protected string _field;

        public Subject(string level, string field)
        {
            _level = level ?? throw new ArgumentNullException(nameof(level));
            _field = field ?? throw new ArgumentNullException(nameof(field));
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
    }
}
