using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.DataGeneration
{
    class ListStorage
    {
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
        public static List<string> GetListOfClassByLevel(string levelId)
        {
            string path = @"..\..\..\DataGeneration\Class.csv";
            int column = GetColumn(path, "Level");
            return GetDataInColumn(path, levelId, column);
        }
        public static List<string> GetLevelList()
        {
            return CsvReader(@"..\..\..\DataGeneration\Level.csv");
        }
    }
}
