using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Subject
    {
        protected string _id;
        protected string _level;
        protected string _field;
        protected string _name;

        public Subject() { }

        public Subject(string id, string level, string field, string name)
        {
            _id = id;
            _level = level;
            _field = field;
            _name = name;
        }

        public string GetId()
        {
            return _id;
        }

        public void SetId(string id)
        {
            _id = id;
        }

        public string GetLevel()
        {
            return _level;
        }

        public void SetLevel(string level)
        {
            _level = level;
        }

        public string GetField()
        {
            return _field;
        }

        public void SetField(string field)
        {
            _field = field;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public static Subject[] Create()
        {
            List<string> listOfLevels = DataHelper.GetListOfLevel();
            List<string> listOfFields = DataHelper.GetListOfField();
            int size = listOfFields.Count * listOfLevels.Count;

            Subject[] result = new Subject[size];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();

            int count = 0; 
            for (int i = 0; i < listOfLevels.Count; i++)
            {
                for(int j = 0; j < listOfFields.Count; j++)
                {
                    //id
                    string uuid = Guid.NewGuid().ToString();

                    //level
                    string line = listOfLevels[i];
                    string[] levels = line.Split(',');
                    string level = levels[0].Trim();

                    //field
                    string[] fields = listOfFields[j].Split(',');
                    string field = fields[0].Trim();

                    //name
                    string name = fields[1].Trim() + " " + levels[1].Trim();

                    result[count] = new Subject(uuid, level, field, name);
                    count++;
                }
            }

            return result;
        }
    }
}
