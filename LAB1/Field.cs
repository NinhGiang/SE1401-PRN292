using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Field
    {
        private string id;
        private string name;

        protected string Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }

        public Field(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
