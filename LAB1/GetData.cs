using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class GetData
    {
        private static Random rnd = new Random();
        private static string content = File.ReadAllText(@"..\..\..\Configure.json");
        private static config config = JsonSerializer.Deserialize<config>(content);

        private static List<string> GetCsvData(string path)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);

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
