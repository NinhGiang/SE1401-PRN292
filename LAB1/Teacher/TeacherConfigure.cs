using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class TeacherConfigure
    {
        public TeacherNameConfig TeacherNameConfig { get; set; }
    }
    class TeacherNameConfig
    {
        public string[] last_name_set { get; set; }
        public string[] middle_male_name_set { get; set; }
        public string[] first_male_name_set { get; set; }
        public string[] middle_female_name_set { get; set; }
        public string[] first_female_name_set { get; set; }
    }
}
