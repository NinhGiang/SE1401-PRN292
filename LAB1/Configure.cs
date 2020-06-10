using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Configure
    {
        public NameConfig NameConfig { get; set; }
    }
    class NameConfig
    {
        public String[] last_name_set { get; set; }
        public String[] middle_name_set { get; set; }
        public String[] first_name_set { get; set; }
    }
}
