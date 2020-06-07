using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Configure
    {
        public StudentNameConfig StudentNameConfig
        { get; set; }

        public BirthdateConfig BirthdateConfig
        { get; set; }

        public LevelNameConfig LevelNameConfig
        { get; set; }

        public FieldNameConfig FieldNameConfig
        { get; set; }
    }

    public class StudentNameConfig
    {
        public string[] last_name_set { get; set; }
        public string[] middle_name_set { get; set; }
        public string[] fem_first_name_set { get; set; }
        public string[] male_first_name_set { get; set; }
    }

    public class BirthdateConfig
    {
        public string[] day_set { get; set; }
        public string[] month_set { get; set; }
        public string[] year_set { get; set; }
    }

    public class LevelNameConfig
    {
        public string[] level_name_set { get; set; }
    }

    public class FieldNameConfig
    {
        public string[] field_name_set { get; set; }
    }

}
