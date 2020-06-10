using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected string subjectLevel;
        protected string subjectField;

        public string SubjectLevel { get { return subjectLevel; } }
        public string SubjectField { get { return subjectField; } }

        protected Subject(string SubjectLevel, string SubjectField)
        {
            subjectLevel = SubjectLevel;
            subjectField = SubjectField;
        }
        protected Subject() { }


    }
}
