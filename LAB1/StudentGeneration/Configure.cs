using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGeneration
{
    class Configure
    {
        public NameConfig NameConfig { get; set; }
        public GenderConfig GenderConfig { get; set; }
        public FieldConfig FieldConfig { get; set; }
        public ClassConfig ClassConfig { get; set; }

    }
    class NameConfig
    {
        public string[] first_Male_set { get; set; }
        public string[] first_Female_set { get; set; }
        public string[] last_name_set { get; set; }
        public string[] middle_name_set { get; set; }
    }
    class GenderConfig
    {
        public string[] Gender_set { get; set; }
    }
    class FieldConfig
    {
        public string [] Field_set { get; set; }
    }
    class ClassConfig
    {
        public string[] Class_set { get; set; }
    }

}
