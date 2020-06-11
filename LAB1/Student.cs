using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Student
    {
        protected String UUID , Name;
        protected DateTime BirthDay;
        protected Boolean Gender;
        protected String ClassName;

        public Student(String uUID, String name, DateTime birthDay, bool gender, String className)
        {
            UUID = uUID;
            Name = name;
            BirthDay = birthDay;
            Gender = gender;
            ClassName = className;
        }

        public String GetUUID()
        {
            return UUID;
        }
        public void SetUUID(String UUID)
        {
            this.UUID = UUID;
        }

        public String GetName()
        {
            return Name;
        }

        public void SetName(String name)
        {
            this.Name = name;
        }

        public DateTime GetBirthDay()
        {
            return BirthDay;
        }

        public void SetBirthDay(DateTime BirthDay)
        {
            this.BirthDay = BirthDay;
        } 

        public Boolean GetGender()
        {
            return Gender;
        }

        public void SetGender(Boolean Gender)
        {
            this.Gender = Gender;
        }

        public String GetClassName()
        {
            return ClassName;
        }

        public void SetClassName(String ClassName)
        {
            this.ClassName = ClassName;
        }
    }
}
