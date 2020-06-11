using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Teacher
    {
        protected String UUID , Name , Field;
        protected Boolean Gender;

        public Teacher(String UUID , String Name , Boolean Gender , String Field)
        {
            this.UUID = UUID;
            this.Name = Name;
            this.Gender = Gender;
            this.Field = Field;
        }

        public String GetUUID()
        {
            return this.UUID;
        }

        public void SetUUID(String UUID)
        {
            this.UUID = UUID;
        }

        public String GetName()
        {
            return this.Name;
        }

        public void SetName(String Name)
        {
            this.Name = Name;
        }

        public Boolean GetGender()
        {
            return this.Gender;
        }

        public void SetGender(Boolean Gender)
        {
            this.Gender = Gender;
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
