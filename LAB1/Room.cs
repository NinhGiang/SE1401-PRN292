using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    public class Room
    {
        protected string _id;
        protected string _class;
        protected int _no;

        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetClassInfo()
        { return _class; }

        public void SetClassInfo(string value)
        { _class = value; }

        public int GetNo()
        { return _no; }

        public void SetNo(int value)
        { _no = value; }

        public Room() { }

        public Room(string id,  string classInfo, int no)
        {
            _id = id;
            _class = classInfo;
            _no = no;
        }

        public static Room[] Create(int numberOfRoom)
        {
            Room[] result = new Room[numberOfRoom];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();

            for (uint i = 0; i < numberOfRoom; i++)
            {
                //id
                string uuid = Guid.NewGuid().ToString();

                //class
                string classInfo = "tempClass";

                //no
                int no = (int)i;

                result[i] = new Room(uuid, classInfo, no);
            }

            return result;
        }
    }
}
