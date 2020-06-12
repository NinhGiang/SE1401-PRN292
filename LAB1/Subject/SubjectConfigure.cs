using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class SubjectConfigure
    {
        public SubjectNameConfig SubjectNameConfig { get; set; }
    }
    class SubjectNameConfig
    {
        public string[] experimentalscience_subject_name_set { get; set; }
        public string[] socialscience_subject_name_set { get; set; }
        public string[] language_subject_name_set { get; set; }
        public string[] math_subject_name_set { get; set; }
        public string[] miscellaneous_subject_name_set { get; set; }
    }
}
