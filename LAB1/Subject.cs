using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LAB1
{
    class Subject
    {
        private string id;
        private string level;//FK
        private string field; //fk 

        protected string Id { get => id; set => id = value; }
        protected string Level { get => level; set => level = value; }
        protected string Field { get => field; set => field = value; }

        public Subject(string id, string level, string field)
        {
            this.Id = id;
            this.Level = level;
            this.Field = field;
        }
    }
}
