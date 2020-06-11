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
        public string[] maleLastNameSet { get; set; }
        public string[] femaleLastNameSet { get; set; }
        public string[] middleNameSet { get; set; }
        public string[] firstNameSet { get; set; }
    }
    
}
