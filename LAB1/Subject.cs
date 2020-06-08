using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected string _id;
        protected string _level;
        protected string _field;

        public Subject() { }

        public Subject(string id, string level, string field)
        {
            _id = id;
            _level = level;
            _field = field;
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
        /*
        public Subject[] Create()
        {
            private static List<string> GetListOfClass()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Class.csv");

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
        */
    }
}
