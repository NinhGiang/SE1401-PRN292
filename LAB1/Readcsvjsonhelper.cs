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
        private static readonly string CONFIG = @"..\..\..\Configure.json";
        private static Random rd = new Random();
        private static string subject = File.ReadAllText(CONFIG);
        private static Configure config = JsonSerializer.Deserialize<Configure>(subject);


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

        public static string GetLevelName(string id)
        {
            return GetDataByPrimaryKey(_level, id).Split('s')[1];
        }

        public static List<string> GetLevelList()
        {
            return GetCsvData(_level);
        }

        public static List<string> GetFieldList()
        {
            return GetCsvData(_field);
        }

        public static List<string> GetClassList()
        {
            return GetCsvData(_class);
        }

        private static DateTime GetRandomDate(int year)
        {
            DateTime begin = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);
            int range = (end - begin).Days;
            return start.AddDays(rd.Next(range));
        }

        public static DateTime GetRandomBirthday(string level)
        {
            try
            {
                int level1 = Int32.Parse(level);

                int nowYear = DateTime.Now.Year;

                int minAge = 15 + (level1 - 10);

                int maxAge = 19 + (level1 - 10);

                int maxYear = currentYear - minAge;

                int minYear = currentYear - maxAge;

                int year = rd.Next(minYear, maxYear + 1);

                return GetRandomDate(year);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("LoadData _ FormatException: " + ex.Message);
            }
            return new DateTime(1900, 1, 1);
        }

        public static string GetNameforGender(bool gen)
        {
            string LongName;
            int lastNameNumber;
            int firstNameNumber;
            int middleNameNumber;
            string firstname;
            try
            {
                NameConfig genconfig = config.NameConfig;

                int lastNameNumber = rd.Next(genconfig.last_name_set.Length);

                if (gen == true)
                {
                    firstNameNumber = rd.Next(genconfig.male_first_name_set.Length);
                    firstname = genconfig.male_first_name_set[firstNameNumber];
                }
                else
                {
                    firstNameNumber = rd.Next(genconfig.female_first_name_set.Length);
                    firstname = genconfig.female_first_name_set[firstNameNumber];
                }

                middleNameNumber = rd.Next(genconfig.middle_name_set.Length);

                LongName = genconfig.last_name_set[lastNameNumber];
                LongName += " " + genconfig.middle_name_set[middleNameNumber];
                LongName += " " + firstname;

                LongName = LongName.Trim();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Loaddata _ FileNotFoundException: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Loaddata _ NullReferenceException: " + ex.Message);
            }
            return LongName;
        }


    }
}