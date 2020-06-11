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
        public String[] last_name_set { get; set; }
        public String[] middle_name_set { get; set; }
        public String[] first_name_set { get; set; }
    }

    class LevelConfig
    {
        public String[] level_name_set { get; set; }
    }

    class FieldConfig
    {
        public String[] field_name_set { get; set; }
    }
}
