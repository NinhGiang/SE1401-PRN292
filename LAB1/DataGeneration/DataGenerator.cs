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
        private static FieldDataSet fieldDB = config.FieldDataSet;
        private static Random rnd = new Random();
        public static int GetLevelLength()
        {
            return classDB.ClassSet.Length;
        }
        public static string GetLevelDataInIndex(int index)
        {
            return classDB.ClassSet[index];
        }
        public static string[] GetLevelData()
        {
            List<string> levelList = ListStorage.GetLevelList();
            int index = rnd.Next(levelList.Count);
            string[] levelInfo = levelList[index].Split(',');
            return levelInfo;
        }
        public static string[] GetRoomData()
        {
            List<string> listOfRooms = ListStorage.GetRoomList();
            int roomIndex = rnd.Next(listOfRooms.Count);
            string[] roomInfo = listOfRooms[roomIndex].Split(',');
            return roomInfo;
        }
        public static string[] GetTeacherData(int index)
        {
            List<string> teacherList = ListStorage.GetTeacherList();
            string[] teacherInfo = teacherList[index].Split(",");
            return teacherInfo;
        }
        public static string GetStudentData(string index)
        {
            return null;
        }//current proccess
       public static string[] GetSubjectData(string field)
        {
            List<string> subjectList = ListStorage.GetSubjectListByField(field);
            int index = rnd.Next(subjectList.Count);
            string[] subjectInfo = subjectList[index].Split(",");
            return subjectInfo;
        }
        public static string[] GetClassData(string level)
        {
            List<string> classesList = ListStorage.GetListOfClassByLevel(level);
            int index = rnd.Next(classesList.Count);
            string[] classesInfo = classesList[index].Split(",");
            return classesInfo;
        }
        public static int getFieldLength()
        {
            return fieldDB.FieldNameSet.Length;
        }
        public static string getFieldName(uint index)
        {   
            return fieldDB.FieldNameSet[index];
        }
    }
}
