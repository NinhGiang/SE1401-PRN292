using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class School
    {
        private string school_name;

        public School()
        {

        }

        public School(string school_name)
        {
            this.School_name = school_name;
        }

        public string School_name { get => school_name; set => school_name = value; }
    }
}
