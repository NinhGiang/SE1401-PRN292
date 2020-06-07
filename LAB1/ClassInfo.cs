using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    public class ClassInfo
    {
        protected string _id;
        protected string _level;
        protected string _room;
        protected string _name;

        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetLevel()
        { return _level; }

        public void SetLevel(string value)
        { _level = value; }

        public string GetRoom()
        { return _room; }

        public void SetRoom(string value)
        { _room = value; }

        public string GetName()
        { return _name; }

        public void SetName(string value)
        { _name = value; }

        public ClassInfo() { }

        public ClassInfo(string id, string level, string room, string name)
        {
            _id = id;
            _level = level;
            _room = room;
            _name = name;
        }

        public static ClassInfo[] Create()
        {
            List<string> listOfRoom = GetListOfRoom();
            int numberOfRoom = listOfRoom.Count;
            ClassInfo[] result = new ClassInfo[numberOfRoom];

            List<string> listOfLevel = GetListOfLevel();
            
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();

            for (uint i = 0; i < numberOfRoom; i++)
            {
                //id
                string uuid = Guid.NewGuid().ToString();

                //level
                int levelIndex = rnd.Next(listOfLevel.Count);
                string[] level = listOfLevel[levelIndex].Split(',');
                string levelId = level[0].Trim();

                //room
                int roomIndex = rnd.Next(listOfRoom.Count);
                string[] room = listOfRoom[roomIndex].Split(',');
                string roomId = room[0].Trim();

                //name
                string levelName = level[1].Trim();
                string roomName = room[2].Trim();
                string name = levelName + "-" + roomName;

                result[i] = new ClassInfo(uuid, levelId, roomId, name);
            }

            return result;
        }

        private static List<string> GetListOfRoom()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Room.csv");

            sr.ReadLine();  //skip first line
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                list.Add(line);
            }
            sr.Close();
            return list;
        }

        private static List<string> GetListOfLevel()
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(@"..\..\..\Level.csv");

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