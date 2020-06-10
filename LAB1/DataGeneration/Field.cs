using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Field
    {
        protected string _uuid;
        protected string _name;
        public string Uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Field() { }
        public Field(string Uuid, string name)
        {
            _uuid = Uuid;
            _name = name;
        }
        public Field[] createField()
        {
            List<Field> result = new List<Field>();
            int size = DataGenerator.getFieldLength();
            for (uint i = 0; i < size; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                string fieldName = DataGenerator.getFieldName(i);
                result.Add(new Field(uuid, fieldName));
            }
            return result.ToArray();
        }
    }
}
