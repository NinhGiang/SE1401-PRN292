using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.DataGeneration
{
    class ListStorage
    {
        private static Random rnd = new Random();
        private static List<string> CsvReader(string link)
        {
            List<string> curr_list = new List<string>();
            StreamReader sr = new StreamReader(link);

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                curr_list.Add(line);
            }
            sr.Close();
            return curr_list;
        }
        private static int GetColumn(string link, string col_name)
        {
            StreamReader sr = new StreamReader(link);

            string line = sr.ReadLine();
            string[] split = line.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Trim().Equals(col_name.Trim()))
                {
                    return i;
                }
            }
            sr.Close();
            return -1;
        }
        public static List<string> GetDataInColumn(string link, string data, int column)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(link);
            try
            {
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] split = line.Split(',');
                if (split[column].Trim().Equals(data.Trim()))
                {
                    list.Add(line);
                }
            }
            sr.Close();
            return list;
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine("Error in GetDataInColumn : " + ex.Message);
            }
            return null;
        }
        public static List<string> GetSubjectListByField(string fieldID)
        {
            string link = @"..\..\..\DataGeneration\Subject.csv";
            int column = GetColumn(link, "Field");
            return GetDataInColumn(link, fieldID, column);
        }
        public static List<string> GetListOfClassByLevel(string levelId)
        {
            string path = @"..\..\..\DataGeneration\Class.csv";
            int column = GetColumn(path, "Level");
            return GetDataInColumn(path, levelId, column);
        }
        public static List<string> GetListofSubjectByClass(string classID)
        {
            string link = @"..\..\..\DataGeneration\Attendance.csv";
            int column = GetColumn(link, "Class");
            return GetDataInColumn(link, classID, column);
        }
        public static List<string> GetSubjectsByStudent(string student)
        {
            List<string> subjects;
            string[] info = student.Split(',');
            string classId = info[4].Trim();
            subjects = GetListofSubjectByClass(classId);
            return subjects;
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

        public static List<string> GetLevelList()
        {
            return CsvReader(@"..\..\..\DataGeneration\Level.csv");
        }
        public static List<string> GetRoomList()
        {
            return CsvReader(@"..\..\..\DataGeneration\Room.csv");
        }
        public static List<string> GetFieldList()
        {
            return CsvReader(@"..\..\..\DataGeneration\Field.csv");
        }
        public  static List<string> GetTeacherList()
        {
            return CsvReader(@"..\..\..\DataGeneration\Teacher.csv");
        }
        public static List<string> GetStudentList()
        {
            return CsvReader(@"..\..\..\DataGeneration\FPT大学.csv");
        }
    }
}
    
