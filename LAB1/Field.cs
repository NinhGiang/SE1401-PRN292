using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    public class Field
    {
        protected string _id;
        protected string _name;

        public string GetId()
        {
            return _id;
        }

        public void SetId(string value)
        {
            _id = value;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public Field() { }

        public Field(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public static Field[] Create()
        {

            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            FieldNameConfig _ = config.FieldNameConfig;

            int size = _.field_name_set.Length;
            Field[] result = new Field[size];

            for (int i = 0; i < size; i++)
            {
                string name = _.field_name_set[i].ToString();
                string id = Guid.NewGuid().ToString();
                result[i] = new Field(id, name);
            }
            return result;
        }
    }
}
