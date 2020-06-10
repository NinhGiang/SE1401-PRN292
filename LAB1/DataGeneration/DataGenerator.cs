﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1.DataGeneration
{
    class DataGenerator
    {
        private static Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"..\..\..\DataGeneration\database.json"));
        private static ClassDataSet classDB = config.ClassDataSet;
        private static FieldDataSet fieldDB = config.FieldDataSet;
        private static Random rnd = new Random();
        public static int GetLevelLength()
        {
            return classDB.ClassSet.Length;
        }
        public static string GetLevelData(int index)
        {
            return classDB.ClassSet[index];
        }
        public static string[] getLevelInfo()
        {
            List<string> levelList = ListStorage.GetLevelList();
            int index = rnd.Next(levelList.Count);
            string[] levelInfo = levelList[index].Split(',');
           // string level = levelInfo[1].Trim();
           // string levelId = levelInfo[0].Trim();
            return levelInfo;
        }
        public static string getClassByLevelID(string levelId)
        {
            string[] classes = null;
           // try
          //  {


                List<string> listOfClasses = ListStorage.GetListOfClassByLevel(levelId);
                int index = rnd.Next(listOfClasses.Count);
                classes = listOfClasses[index].Split(',');
                string classInfo = classes[0].Trim();
                return classInfo;
           // } catch (ArgumentOutOfRangeException ex)
           // {
           //     Console.WriteLine("The current array: " + classes);
           // }
           // return classes.ToString();
        }
        public static string[] getRoomInfo()
        {
            List<string> listOfRooms = ListStorage.GetRoomList();
            int roomIndex = rnd.Next(listOfRooms.Count);
            string[] roomInfo = listOfRooms[roomIndex].Split(',');
            // string roomId = room[0].Trim();
            // string roomClass = room[1].Trim();
            // string romNo = room[2].Trim();
            return roomInfo;
        }
        public static int getFieldLength()
        {
            return fieldDB.FieldNameSet.Length;
        }
        public static string getFieldName(uint index)
        {
            return fieldDB.FieldNameSet[index].ToString();
        }
    }
}