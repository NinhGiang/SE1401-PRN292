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

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private static String jsonFile = File.ReadAllText(@"..\..\..\Configure.json");
        private static Configure config = JsonSerializer.Deserialize<Configure>(jsonFile);

        public static string[] getField()
        {
            return config.FieldConfig.field_set;
        }

        public static Field[] GenerateField()
        {
            String[] data = getField();
            Field[] fieldList = new Field[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = data[i];
                Field field = new Field(uuid, name);
                fieldList[i] = field;
            }
            return fieldList;
        }
    }
}
