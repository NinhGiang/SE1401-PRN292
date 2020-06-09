using System;
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
        private static Random rnd = new Random();
        public static int GetLevelLength()
        {
            return classDB.ClassSet.Length;
        }
        public static string GetLevelData(int index)
        {
            return classDB.ClassSet[index];
        }
        public static string getLevel()
        {
            List<string> levelList = ListStorage.GetLevelList();
            int index = rnd.Next(levelList.Count);
            string[] levelInfo = levelList[index].Split(',');
            string level = levelInfo[1].Trim();
            string levelId = levelInfo[0].Trim();
            return levelId;
        }
        public static string getClass(string levelId)
        {
            List<string> listOfClasses = ListStorage.GetListOfClassByLevel(levelId);
            int index = rnd.Next(listOfClasses.Count);
            string[] classes = listOfClasses[index].Split(',');
            string classInfo = classes[0].Trim();
            return classInfo;
        }

    }
}
