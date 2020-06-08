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
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            List<string> listOfField = GetListOfField();
            Random rnd = new Random();

            for (uint i = 0; i < numberOfTeacher; i++)
            {
                //id
                String uuid = Guid.NewGuid().ToString();

                //gender
                bool gender = rnd.Next(2) == 1;

                //name
                NameConfig _ = config.NameConfig;
                int lastNameIndex = rnd.Next(_.last_name_set.Length);
                int firstNameIndex;
                string firstname;
                if (gender == true)
                {
                    firstNameIndex = rnd.Next(_.male_first_name_set.Length);
                    firstname = _.male_first_name_set[firstNameIndex];
                }
                else
                {
                    firstNameIndex = rnd.Next(_.fem_first_name_set.Length);
                    firstname = _.fem_first_name_set[firstNameIndex];
                }

                int middleNameIndex = rnd.Next(_.middle_name_set.Length);
                string fullName = _.last_name_set[lastNameIndex] + " ";
                fullName += _.middle_name_set[middleNameIndex] + " ";
                fullName += firstname;

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

        /**
         * 
         */
        private static List<string> GetListOfField()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Field.csv");

            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            return list;
        }

    }
}
