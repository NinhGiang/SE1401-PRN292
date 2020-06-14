using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;

namespace LAB1.StudentGeneration
{
    class Field
    {
        protected string _UUID;
        protected string _Name;

        public Field(string uuid, string name)
        {
            _UUID = uuid;
            _Name = name;
        }

        public string ID
        {
            get { return _UUID; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        static public List<Field> CreateFields()
        {
            List<Field> fields = new List<Field>();
            String content = File.ReadAllText(@"..\..\..\StudentGeneration\dataset.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            FieldDataSet field_config = config.FieldDataSet;
            string[] field_name = field_config.FieldSet;

            for (int i = 0; i < field_name.Length; i++)
            {
                string uuid = System.Guid.NewGuid().ToString();
                string name = field_name[i];
                fields.Add(new Field(uuid, name));
            }

            return fields;
        }
}


}

