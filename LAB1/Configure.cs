using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    public class Configure
    {
        public StudentNameConfig StudentNameConfig
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
        public string[] first_name_set { get; set; }
    }

    public class LevelNameConfig
    {
        public string name_set { get; set; }
    }

    public class FieldNameConfig
    {
        public string name_set { get; set; }
    }

}
