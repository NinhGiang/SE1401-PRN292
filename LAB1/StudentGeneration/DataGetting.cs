using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1.StudentGeneration
{
    class DataGetting
    {
        private static Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"..\..\..\StudentGeneration\dataset.json"));
        private static LevelDataSet levelDB = config.LevelDataSet;
        private static Random rnd = new Random();

        public static string[] GetClassData()
        {
            List<string> classList = GetClassList();
            int index = rnd.Next(classList.Count);
            string[] classInfo = classList[index].Split(',');
            return classInfo;
        }

        public static string GetLevelDataInIndex(int index)
        {
            return levelDB.LevelSet[index];
        }
        public static string[] GetLevelData()
        {
            List<string> levelList = GetLevelList();
            int index = rnd.Next(levelList.Count);
            string[] levelInfo = levelList[index].Split(',');
            return levelInfo;
        }
        public static string[] GetRoomData()
        {
            List<string> listOfRooms = GetRoomList();
            int roomIndex = rnd.Next(listOfRooms.Count);
            string[] roomInfo = listOfRooms[roomIndex].Split(',');
            return roomInfo;
        }

        public static List<string> GetLevelList()
        {
            return FileDataManagement.CsvReader(@"..\..\..\StudentGeneration\abc\Levels.csv");
        }

        public static List<string> GetRoomList()
        {
            return FileDataManagement.CsvReader(@"..\..\..\StudentGeneration\abc\Rooms.csv");
        }

        private static List<string> GetClassList()
        {
            return FileDataManagement.CsvReader(@"..\..\..\StudentGeneration\abc\Classes.csv");
        }

        public static List<string> GetStudentList()
        {
            return FileDataManagement.CsvReader(@"..\..\..\StudentGeneration\abc\Students.csv");
        }
    }
}
