using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGeneration
{
    public class Configure
    {
        public NameConfig NameConfig { get; set; }

        public LevelConfig LevelConfig { get; set; }

        public FieldConfig FieldConfig { get; set; }
    }
    public class NameConfig
    {
        public string[] last_name_set { get; set; }
        public string[] middle_name_set { get; set; }
        public string[] first_name_set { get; set; }
    }

    public class LevelConfig
    {
        public string[] level_set { get; set; }
    }

    public class FieldConfig
    {
        public string[] field_type { get; set; }
    }
}
