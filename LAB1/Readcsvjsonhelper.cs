using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// Help u with csv
    /// </summary>
    class Readcsvjsonhelper
    {
        
        private static string _room;
        private static string _attendance;
        private static string _class;
        private static string _level;
        private static string _field;
        private static string _student;
        private static string _subject;
        private static string _teacher;


        private static void SetFilePath(string _path)
        {
            _teacher = _path + "\\" + "Teacher.csv";
            _attendance = _path + "\\" + "Attendance.csv";
            _level = _path + "\\" + "Level.csv";
            _field = _path + "\\" + "Field.csv";
            _class = _path + "\\" + "Class.csv";
            student = _path + "\\" + "Student.csv";
            _subject = _path + "\\" + "Subject.csv";
            _room = _path + "\\" + "Room.csv";
        }

        /// <summary>
        /// Get list of lines from a specific .csv file
        /// </summary>
        private static List<string> GetCsvData(string path)
        {
            List<string> list = new List<string>();
            try
            {
                using(var sr = new StreamReader(path))
                {
                    sr.ReadLine();  
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        list.Add(line);
                    }
                }

                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Readcsvjsonhelper _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Readcsvjsonhelper _ IOException: " + ex.Message);
            }

            return list;
        }

        

        /// <summary>
        /// Room and Class generation
        /// </summary>
        /// <returns>A dictionary which roomId is key and classId is value</returns>
        public static Dictionary<string, string> GetClassRoomlist(int size)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            for (int i = 0; i < size; i++)
            {
                string room = Guid.NewGuid().ToString();

                string classinfo = Guid.NewGuid().ToString();

                result.Add(room, classinfo);
            }
            return result;
        }

        public static string GetRoomNumber(string roomId)
        {
            // set room path
            string path = _room;

            return GetDataByPrimaryKey(path, roomId);
        }

        private static string GetDataByPrimaryKey(string path, string primaryKey)
        {
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine();  

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] split = line.Split(',');
                        if (split[0].Trim().Equals(primaryKey.Trim()))
                        {
                            return line;
                        }
                    }
                }
                
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Readcsvjsonhelper _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Readcsvjsonhelper _ IOException: " + ex.Message);
            }

            return null;
        }

        public static List<string> GetLevelList()
        {
            return GetCsvData(_level);
        }
    }
}