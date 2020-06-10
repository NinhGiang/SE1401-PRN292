using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class DataConnection
    {   
        private static Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"E:\C# and .NET\LAB1\SE1401-PRN292\LAB1\Configure.json"));
        private static LevelNameConfig level = config.LevelNameConfig;
        private static Random rnd = new Random();
        public static int GetLevelLength()            
        {
            return level.LevelSet.Length;
        }
        public static string GetLevelData(int index)
        {
            return level.LevelSet[index];
        }
        public static string[] getLevelInfo()
        {
            List<string> levelList = ListControl.GetLevelList();
            int index = rnd.Next(levelList.Count);
            string[] levelInfo = levelList[index].Split(',');
            return levelInfo;
        }
        public static string getClassByLevelID(string levelId)
        {
            List<string> listOfClasses = ListControl.GetListOfClassByLevel(levelId);
            int index = rnd.Next(listOfClasses.Count);
            string[] classes = listOfClasses[index].Split(',');
            string classInfo = classes[0].Trim();
            return classInfo;
        }
        public static string[] getRoomInfo()
        {
            List<string> listOfRooms = ListControl.GetRoomList();
            int roomIndex = rnd.Next(listOfRooms.Count);
            string[] roomInfo = listOfRooms[roomIndex].Split(',');
            return roomInfo;
        }

    }
}