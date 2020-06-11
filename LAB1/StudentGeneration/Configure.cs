using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGeneration
{
    class Configure
    {
        public NameConfig NameConfig { get; set; }
        public BirthDayConfig BirthdayConfig { get; set; }
        public GenderConfig GenderConfig { get; set; }
        public ClassConfig ClassConfig   {get;set; }

    }
    class NameConfig
    {
        public string[] last_Male_set { get; set; }
        public string[] middle_Male_set { get; set; }
        public string[] first_Male_set { get; set; }
        public string[] last_Female_set { get; set; }
        public string[] middle_Female_set { get; set; }
        public string[] first_Female_set { get; set; }
    }
    class BirthDayConfig
    {
        public string[] Day_set { get; set; }
        public string[] Month_set { get; set; }
        public string[] Year_set { get; set; }
    }
    class GenderConfig
    {
        public string[] Gender_set { get; set; }
    }
    class ClassConfig
    {
        public string[] Class_set { get; set; }
    }

}
