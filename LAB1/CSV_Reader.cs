using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class CSV_Reader
    {
        private static string directory;

        private static List<string> ReadCSVFile(string path)
        {
            List<string> list = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(path);
                sr.ReadLine();
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ReadCSVFile FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("ReadCSVFile IOException: " + ex.Message);
            }
            return list;
        }

        private static int ReadHeaderOfColumn(string path, string column)
        {
            int id = -1;
            try
            {
                StreamReader sr = new StreamReader(path);
                string headerLine = sr.ReadLine();
                string[] headerData = headerLine.Split(", ");
                for (int i = 0; i < headerLine.Length; i++)
                {
                    if (headerData.Equals(column))
                    {
                        id = i;
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ReadHeaderOfColumn FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("ReadHeaderOfColumn IOException: " + ex.Message);
            }
            return id;
        }

        private static List<string> ReadDataOfColumn(string path, int column)
        {
            List<string> list = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(path);
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineData = line.Split(", ");
                    list.Add(lineData[column]);
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ReadHeaderOfColumn FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("ReadHeaderOfColumn IOException: " + ex.Message);
            }
            return list;
        }


    }
}
