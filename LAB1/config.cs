using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class config
    {
        public NameConfig NameConfig
        { get; set; }

        public BirthdateConfig BirthdateConfig
        { get; set; }

        public LevelConfig LevelConfig
        { get; set; }

        public FieldConfig FieldConfig
        { get; set; }
    }
    public class NameConfig
    {
        public string[] Last_name_set { get; set; }
        public string[] Middle_name_set { get; set; }
        public string[] Female_Name_Set { get; set; }
        public string[] Male_Name_Set { get; set; }
    }


    public class BirthdateConfig
    {
        public string[] Day_set { get; set; }
        public string[] Month_set { get; set; }
        public string[] Year_set { get; set; }
    }

    public class LevelConfig
    {
        public string[] Level_Set { get; set; }
    }

    public class FieldConfig
    {
        public string[] field_Name_Set { get; set; }
    }



}