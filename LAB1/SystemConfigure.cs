using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class SystemConfigure
    {
            public StuNameConfig StuNameConfig { get; set; }
    }
    class StuNameConfig
    {
        public string[] maleFirstNameSet { get; set; }
        public string[] femaleFirstNameSet { get; set; }
        public string[] middleNameSet { get; set; }
        public string[] lastNameSet { get; set; }
    }
    
}
