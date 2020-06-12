using Lab_1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class Level
    {
        protected string _ID;
        protected string _name;

        public string ID
        {
            get
            {
                return _ID;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }

        protected Level(string ID, string Name)
        {
            _ID = ID;
            _name = Name;
        }
        public static Level[] Create()
        {
            string content = File.ReadAllText(@"..\..\..\SE1401.json");
            Configured config = JsonSerializer.Deserialize<Configured>(content);
            LevelList _ = config.LevelList;
            Level[] result = new Level[3];


            for (int i = 0; i < 3; i++)
            {
                string id = Guid.NewGuid().ToString();
                string name = _.LevelName[i];
                result[i] = new Level(id, name);
            }
            return result;
        }//create level
        public void Print()
        {
            Console.WriteLine(ID + 1 + " " + _name);
        }
    }
    
}
