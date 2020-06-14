using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Field
    {
        protected string _uuid;
        protected string _name;

        public Field(string uuid, string name)
        {
            _uuid = uuid;
            _name = name;
        }
        public string UUID { get { return _uuid; } set { _uuid = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public static Field[] Create(uint number_field)
        {
            Field[] result = new Field[number_field];
            string content = File.ReadAllText(@"..\..\..\Field\FieldConfigure.json");
            FieldConfigure config = JsonSerializer.Deserialize<FieldConfigure>(content);
            for (uint i = 0; i < number_field; i++)
            {
                //generate random uuid
                string id = RandomGenerator.randUUID();
                //generate field name (fixed 14 fields)
                string field_name = config.FieldNameConfig.field_name_set[i];
                result[i] = new Field(id, field_name);
            }
            return result;
        }

        public void print()
        {
            Console.WriteLine(_uuid + " | " + _name);
        }
    }
}
