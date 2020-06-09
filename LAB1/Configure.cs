using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    // get/set for each config
    class Configure
    {
        public NameConfig NameConfig { get; set; }
        public LevelNameConfig LevelNameConfig { get; set; }
        public GenderConfig GenderConfig { get; set; }
    }

    // get/set json name's list
    class NameConfig
    {
        public string[] LastNameSet { get; set; }
        public string[] MiddleNameSet { get; set; }
        public string[] MaleFirstNameSet { get; set; }
        public string[] FemaleFirstNameSet { get; set; }
    }

    // get/set json level's list
    public class LevelNameConfig
    {
        public string[] LevelSet { get; set; }
    }

    // get/set json gender's list
    public class GenderConfig
    {
        public string[] GenderSet { get; set; }
    }
}
