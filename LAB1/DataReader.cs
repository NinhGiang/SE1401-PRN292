using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class DataReader
    {
        private static List<String> fileReader (String path)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)// read until the end
                    {
                        sr.ReadLine(); //skip header
                        String currLine = sr.ReadLine(); // read current line
                        list.Add(currLine); //add current line
                    }
                    sr.Close();
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Reading failed : " + path + " / " + ex.Message);
            }
            return list;
        }
        private static int getColumn(string path, string col)
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
                return -1;
            }
        }
        private static List<string> getDataInColumn(string path,string data, string col)
        {

        }
    }
}
