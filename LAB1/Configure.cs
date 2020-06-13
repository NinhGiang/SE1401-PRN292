using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Configure
    {
        public NameConfig NameConfig { get; set; }
        public FieldConfig FieldConfig { get; set; }
        public LevelConfig LevelConfig { get; set; }
        public GenderConfig GenderConfig { get; set; }
    }
    class NameConfig
    {
        public string[] last_name_set { get; set; }
        public string[] male_middle_name_set { get; set; }
        public string[] female_middle_name_set { get; set; }
        public string[] male_first_name_set { get; set; }
        public string[] female_first_name_set { get; set; }
    }
    class FieldConfig
    {
        public string[] field_name_set { get; set; }
    }
    class LevelConfig
    {
        public string[] level_name_set { get; set; }
    }
    class GenderConfig
    {
        public string[] gender_set { get; set; }
    }
}   
