using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The FileHelper class.
    /// Contains all methods related to .csv file
    /// </summary>
    class FileHelper
    {
        private static string _directoryPath;
        private static string ROOM_FILE;
        private static string ATTENDANCE_FILE;
        private static string CLASS_FILE;
        private static string LEVEL_FILE;
        private static string FIELD_FILE;
        private static string STUDENT_FILE;
        private static string SUBJECT_FILE;
        private static string TEACHER_FILE;

        public static void SetDirectoryPath(string value)
        {
            _directoryPath = value;
            SetFilePath();
        }

        private static void SetFilePath()
        {
            ROOM_FILE = _directoryPath + "\\" + "Room.csv";
            ATTENDANCE_FILE = _directoryPath + "\\" + "Attendance.csv";
            CLASS_FILE = _directoryPath + "\\" + "Class.csv";
            LEVEL_FILE = _directoryPath + "\\" + "Level.csv";
            FIELD_FILE = _directoryPath + "\\" + "Field.csv";
            STUDENT_FILE = _directoryPath + "\\" + "Student.csv";
            SUBJECT_FILE = _directoryPath + "\\" + "Subject.csv";
            TEACHER_FILE = _directoryPath + "\\" + "Teacher.csv";
        }

        /// <summary>
        /// Get list of lines from a specific .csv file
        /// </summary>
        /// <param name="path">A string value</param>
        /// <returns>List of string from input filepath</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static List<string> GetCsvData(string path)
        {
            List<string> list = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(path);

                sr.ReadLine();  //skip first line
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileHelper GetCsvData _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("FileHelper GetCsvData _ IOException: " + ex.Message);
            }

            return list;
        }

        /// <summary>
        /// Search for line from a specific .csv file by primary key
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="primaryKey">A string value</param>
        /// <returns>A string from a specific .csv file</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static string GetDataByPrimaryKey(string path, string primaryKey)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                sr.ReadLine();  //skip first line
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');
                    if (split[0].Trim().Equals(primaryKey.Trim()))
                    {
                        return line;
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileHelper GetDataByPrimaryKey _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("FileHelper GetDataByPrimaryKey _ IOException: " + ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Search for list of lines from a specific .csv file that foreign key contains search info
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="foreignKey">A string value</param>
        /// <param name="column">An integer value</param>
        /// <returns>List of strings from a specific .csv file that contains search info</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static List<string> GetDataByForeignKey(string path, string foreignKey, int column)
        {
            List<string> list = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(path);
                sr.ReadLine();  //skip first line
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');
                    if (split[column].Trim().Equals(foreignKey.Trim()))
                    {
                        list.Add(line);
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileHelper GetDataByForeignKey _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("FileHelper GetDataByForeignKey _ IOException: " + ex.Message);
            }
            return list;
        }

        /// <summary>
        /// Search for column index from a specific .csv file by column name
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="info">A string value</param>
        /// <returns>The column index or -1 if not found</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static int GetColumn(string path, string info)
        {
            try
            {
                StreamReader sr = new StreamReader(path);

                string line = sr.ReadLine();
                string[] split = line.Split(',');
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].Trim().Equals(info.Trim()))
                    {
                        return i;
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileHelper GetColumn _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("FileHelper GetColumn _ IOException: " + ex.Message);
            }
            return -1;
        }

        /// <summary>
        /// Get room info by id
        /// </summary>
        /// <param name="roomId">A string value</param>
        /// <returns>Room info</returns>
        public static string GetRoomByPrimaryKey(string roomId)
        {
            string path = ROOM_FILE;
            return GetDataByPrimaryKey(path, roomId);
        }

        /// <summary>
        /// Get list of subject by field id
        /// </summary>
        /// <param name="fieldId">A string value</param>
        /// <returns>List of subject contains field id</returns>
        public static List<string> GetListOfSubjectByField(string fieldId)
        {
            string path = SUBJECT_FILE;
            int column = GetColumn(path, "Field");
            return GetDataByForeignKey(path, fieldId, column);
        }

        /// <summary>
        /// Get list of class by level id
        /// </summary>
        /// <param name="levelId">A string value</param>
        /// <returns>List of class contains level id</returns>
        public static List<string> GetListOfClassByLevel(string levelId)
        {
            string path = CLASS_FILE;
            int column = GetColumn(path, "Level");
            return GetDataByForeignKey(path, levelId, column);
        }

        /// <summary>
        /// Get list of subject by class id
        /// </summary>
        /// <param name="classId">A string value</param>
        /// <returns>List of subject contains class id</returns>
        public static List<string> GetListOfSubjectByClass(string classId)
        {
            string path = ATTENDANCE_FILE;
            int column = GetColumn(path, "Class");
            return GetDataByForeignKey(path, classId, column);
        }

        /// <summary>
        /// Get all classes from Class.csv file
        /// </summary>
        /// <returns>List of classes</returns>
        public static List<string> GetListOfClass()
        {
            return GetCsvData(CLASS_FILE);
        }

        /// <summary>
        /// Get all fields from Field.csv file
        /// </summary>
        /// <returns>List of fields</returns>
        public static List<string> GetListOfField()
        {
            return GetCsvData(FIELD_FILE);
        }

        /// <summary>
        /// Get all rooms from Room.csv file
        /// </summary>
        /// <returns>List of rooms</returns>
        public static List<string> GetListOfRoom()
        {
            return GetCsvData(ROOM_FILE);
        }

        /// <summary>
        /// Get all levels from Level.csv file
        /// </summary>
        /// <returns>List of levels</returns>
        public static List<string> GetListOfLevel()
        {
            return GetCsvData(LEVEL_FILE);
        }

        /// <summary>
        /// Get all students from Student.csv file
        /// </summary>
        /// <returns>List of students</returns>
        public static List<string> GetListOfStudent()
        {
            return GetCsvData(STUDENT_FILE);
        }

        /// <summary>
        /// Get all teachers from Teacher.csv file
        /// </summary>
        /// <returns>List of teachers</returns>
        public static List<string> GetListOfTeacher()
        {
            return GetCsvData(TEACHER_FILE);
        }

        /// <summary>
        /// Create Id for both Room and Class
        /// </summary>
        /// <param name="size">A positive integer number</param>
        /// <returns>A dictionary which roomId is key and classId is value</returns>
        public static Dictionary<string, string> CreateIdForRoomAndClass(int size)
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
    }
}
