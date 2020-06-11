using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGenerating
{
    class Configure
    {

        public NameConfig NameConfig { get; set; }

    }
    class NameConfig
    {
        public string[] Last_name_set { get; set; }
        public string[] Middle_name_set { get; set; }
        public string[] First_name_set { get; set; }
    }
}
