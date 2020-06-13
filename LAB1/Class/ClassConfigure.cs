using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class ClassConfigure
    {
        public ClassNameConfig ClassNameConfig { get; set; }
    }
    class ClassNameConfig
    {
        public string[] grade_10_name_set { get; set; }
        public string[] grade_11_name_set { get; set; }
        public string[] grade_12_name_set { get; set; }
    }
}
