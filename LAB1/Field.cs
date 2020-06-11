using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace LAB1
{
    class Field
    {
        protected String _uuid;
        protected String _name;

        public String UUID { get { return _uuid; } }
        public String Name { get { return _name; } }

        public Field (String UUID, String Name)
        {
            _uuid = UUID;
            _name = Name;
        }

        public static Field[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);
            String[] field_data = config.FieldConfig.field_name_set;
            Field[] result = new Field[field_data.Length];
            for(int i = 0; i < field_data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = field_data[i];
                Field field = new Field(uuid, name);
                result[i] = field;
            }
            return result;
        }
    }
}
