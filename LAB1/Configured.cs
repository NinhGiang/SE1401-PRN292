using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1
{
    class Configured
    {
        public NameConfig NameConfig { get; set; }
    }
    class NameConfig
    {
        public string[] FamilyNameSet { get; set; }
        public string[] FemaleMiddleNameSet { get; set; }

        public string[] MaleMiddleNameSet { get; set; }
        public string[] FemaleNameSet { get; set; }
        public string[] MaleNameSet { get; set; }
    }
}
