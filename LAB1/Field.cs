using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    class Field
    {
        protected string _uuid;
        protected string _name;

        public string Name { get { return _name; } }
        public string ID { get { return _uuid; } }

        protected Field(string ID, string Name)
        {
            _uuid = ID;
            _name = Name;
        }
        public static Field[] Create(int number_name)
        {
            Field[] result = new Field[number_name];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for (int i = 0; i < number_name; i++)
                {
                FieldConfig _ = config.FieldConfig;
                int field_name_index = rnd.Next(_.field_name_set.Length);
                string name = _.field_name_set[field_name_index];

            }
            return result;


        }
        public void print()
        {
            Console.WriteLine(_uuid + 1 + " " + _name);
        }


    }
}
