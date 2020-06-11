using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected String Level, Field;

        public Subject(String Level , String Field)
        {
            this.Level = Level;
            this.Field = Field;
        }

        public String GetLevel()
        {
            return this.Level;
        }

        public void SetString(String Level)
        {
            this.Level = Level;
        }

        public String GetField()
        {
            return this.Field;
        }

        public void SetField(String Field)
        {
            this.Field = Field;
        }
    }
}
