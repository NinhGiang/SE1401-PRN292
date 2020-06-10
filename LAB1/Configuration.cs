using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Configuration
    {
        public NameConfig NameConfig { get; set; }
        public LevelConfig LevelConfig { get; set; }
        
    }
    class NameConfig
    {
        public string[] first_male_name_set { get; set; }
        public string[] first_female_name_set { get; set; }
        public string[] middle_name_set { get; set; }
        public string[] last_name_set { get; set; }
    }
    class LevelConfig
    {
        public String[] level_set { get; set; }
    }
}
