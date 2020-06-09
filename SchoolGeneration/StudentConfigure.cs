using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class StudentConfigure
    {
        public NameConfig NamCongfig { get; set; }
    }
    class NameConfig
    {
        public string[] Last_name_set { get; set; }
        public string[] Middle_name_set { get; set; }
        public string[] First_name_set { get; set; }
    }
}
