using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LAB1
{
    class Teacher
    {
        protected string _uuid;
        protected string _name;
        protected bool _gender;
        protected string _field;
        public string UUID { get { return _uuid; } set { _uuid = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public bool Gender { get { return _gender; } set { _gender = value; } }
        public string Field { get { return _field; } set { _field = value; } }
        protected Teacher(string UUID, string Name, bool Gender, string Field)
        {
            _uuid = UUID;
            _name = Name;
            _gender = Gender;
            _field = Field;
        }
        public static Teacher[] Create(uint number_teacher)
        {
            Teacher[] result = new Teacher[number_teacher];
            string content = File.ReadAllText(@"..\..\..\Teacher\TeacherConfigure.json");
            TeacherConfigure config = JsonSerializer.Deserialize<TeacherConfigure>(content);
            string content_field = File.ReadAllText(@"..\..\..\Whatever\Fields.json");
            List<Field> fields = JsonConvert.DeserializeObject<List<Field>>(content_field);
            for (uint i = 0; i < number_teacher; i++)
            {
                //generate random uuid
                string id = RandomGenerator.randUUID();
                //generate random gender
                bool gender = RandomGenerator.randGender();
                //generate random field uuid
                string field_uuid = RandomGenerator.randFieldUUID(fields);
                if (gender)
                {
                    //generate random teacher name
                    string full_name = RandomGenerator.randMaleTeacherName(config);
                    result[i] = new Teacher(id, full_name, gender, field_uuid);
                }
                else
                {
                    string full_name = RandomGenerator.randFemaleTeacherName(config);
                    result[i] = new Teacher(id, full_name, gender, field_uuid);
                }
            }
            return result;
        }
    }
}
