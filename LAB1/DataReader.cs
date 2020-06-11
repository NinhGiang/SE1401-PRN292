using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class DataReader
    {
        private static string _directory_path;
        public string DirectoryPath
        {
            set { _directory_path = value; }
        }
        private static List<String> CsvFileReader (String path)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine();//skip header
                    while (!sr.EndOfStream)// read until the end
                    {
                        String currLine = sr.ReadLine(); // read current line
                        list.Add(currLine); //add current line
                    }
                    sr.Close();
                }
            } 
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            return list;
        }
        private static int GetColumnID(string path, string col)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string headerLine = sr.ReadLine();
                    string[] entry = headerLine.Split(",");
                    for (int i = 0; i < entry.Length; i++)
                    {
                        if (entry[i].Trim().Equals(col.Trim()))
                        {
                            return i;
                        }
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            return -1;
        }
        private static List<string> GetColumnData(string path, int col)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine(); //skip header
                    while (!sr.EndOfStream)
                    {
                        string currLine = sr.ReadLine();
                        string[] entry = currLine.Split(",");
                        list.Add(entry[col]);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            return list;
        }
        private static List<string> GetRowDataInColumn(string path,string data, int col)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine(); //skip header
                    while(!sr.EndOfStream)
                    {
                        string currLine = sr.ReadLine();
                        string[] entry = currLine.Split(",");
                        if (entry[col].Trim().Equals(data.Trim()))
                        {
                            list.Add(currLine);
                        }
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            return list;
        }
        public static Level[] getLevelList()
        {
            List<string> list = CsvFileReader(_directory_path + "\\" + "Level.csv");
            Level[] levelList = new Level[list.Count];
            int index = 0;
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[0].Trim();
                string name = entry[1].Trim();
                levelList[index++] = new Level(id, name);
            }
            return levelList;
        }
        public static Field[] getFieldList()
        {
            List<string> list = CsvFileReader(_directory_path + "\\" + "Field.csv");
            Field[] fieldList = new Field[list.Count];
            int index = 0;
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[0].Trim();
                string name = entry[1].Trim();
                fieldList[index++] = new Field(id, name);
            }
            return fieldList;
        }
        public static string[] getFieldIDList()
        {
            int col = GetColumnID(_directory_path + "\\" + "Field.csv","ID");

            List<string> list = GetColumnData(_directory_path + "\\" + "Field.csv", col);
            string[] fieldIDList = new string[list.Count];
            int index = 0;
            foreach (string line in list)
            {
                fieldIDList[index++] = line.Trim();
            }
            return fieldIDList;
        }
    }
}
