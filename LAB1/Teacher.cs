using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    public class Teacher
    {
        protected string _id;
        protected string _name;
        protected bool _gender;
        protected string _field;

        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetName()
        { return _name; }

        public void SetName(string value)
        { _name = value; }

        public bool GetGender()
        { return _gender; }

        public void SetGender(bool value)
        { _gender = value; }

        public string GetField()
        { return _field; }

        public void SetField(string value)
        { _field = value; }

        public Teacher() { }

        public Teacher(string id, string name, bool gender, string field)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _field = field;
        }

        public static Teacher[] Create(int numberOfTeacher)
        {
            Teacher[] result = new Teacher[numberOfTeacher];

            List<string> listOfField = DataHelper.GetListOfField();
            Random rnd = new Random();

            for (uint i = 0; i < numberOfTeacher; i++)
            {
                //id
                String uuid = Guid.NewGuid().ToString();

                //gender
                bool gender = rnd.Next(2) == 1;

                //name
                string fullName = DataHelper.GetRandomNameByGender(gender);

                //Field
                int index = rnd.Next(listOfField.Count);
                string[] fields = listOfField[index].Split(',');
                string field = fields[0].Trim();

                result[i] = new Teacher();
                result[i].SetId(uuid);
                result[i].SetName(fullName);
                result[i].SetGender(gender);
                result[i].SetField(field);
            }
            return result;
        }
    }
}
