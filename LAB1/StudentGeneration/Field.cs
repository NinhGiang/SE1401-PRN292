using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using StudentGeneration;

namespace LAB1.StudentGeneration
{
    class Field
    {
        protected string _ID;
        protected string _name;

        public string ID { get { return _ID; } set { _ID = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        protected Field(string id, string name)
        {
            _ID = id;
            _name = name;
        }

        public static Field[] Create()
        {
            List<Field> result = new List<Field>();
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            for(uint i=0; i < config.FieldConfig.Field_set.Length; i++)
            {
                string id = Guid.NewGuid().ToString();
                string name = config.FieldConfig.Field_set[i].ToString();
                result.Add(new Field(id, name));
            }
            return result.ToArray();
        }

    }
}
