using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Configure
    {
        public NameConfig NameConfig { get; set; }
        public LevelConfig LevelConfig { get; set; }
        public FieldConfig FieldConfig { get; set; }
    }

    class NameConfig
    {
        public string[] male_first_name { get; set; }
        public string[] female_first_name { get; set; }
        public string[] middle_name { get; set; }
        public string[] last_name { get; set; }
    }

    class LevelConfig
    {
        public string[] level_set { get; set; }
    }

    class FieldConfig
    {
        public string[] field_set { get; set; }
    }
}
