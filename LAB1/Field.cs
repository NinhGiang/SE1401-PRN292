using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Field
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Field(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public static Field[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            config config = JsonSerializer.Deserialize<config>(content);
            FieldConfig fieldConfig = config.FieldConfig;
            int size = fieldConfig.field_Name_Set.Length;
            Field[] result = new Field[size];

            for (int i = 0; i < size; i++)
            {
                string name = fieldConfig.field_Name_Set[i].ToString(); //set value field
                string id = Guid.NewGuid().ToString();
                result[i] = new Field(id, name);

            }
            return result;
        }

    }
}
