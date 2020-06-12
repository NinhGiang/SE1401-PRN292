using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Teacher
    {
        private string id;
        private string name;
        private string field; //FK
        private bool gender;

        protected string Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected string Field { get => field; set => field = value; }
        protected bool Gender { get => gender; set => gender = value; }

        public Teacher(string id, string name, string field, bool gender)
        {
            this.Id = id;
            this.Name = name;
            this.Field = field;
            this.Gender = gender;
        }
    }
}
