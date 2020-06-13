using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    class GetData
    {

        private static string csv_Path;
        private static string ROOM_CSV;
        private static string ATTENDANCE_CSV;
        private static string CLASS_CSV;
        private static string LEVEL_CSV;
        private static string FIELD_CSV;
        private static string STUDENT_CSV;
        private static string SUBJECT_CSV;
        private static string TEACHER_CSV;

        public static void SetPath(string path)
        {
            ROOM_CSV = path + "\\" + "Room.csv";
            ATTENDANCE_CSV = path + "\\" + "Attendance.csv";
            CLASS_CSV = path + "\\" + "Class.csv";
            LEVEL_CSV = path + "\\" + "Level.csv";
            FIELD_CSV = path + "\\" + "Field.csv";
            STUDENT_CSV = path + "\\" + "Student.csv";
            SUBJECT_CSV = path + "\\" + "Subject.csv";
            TEACHER_CSV = path + "\\" + "Teacher.csv";
        }


        /// <summary>
        /// Get list of lines from a specific .csv file
        /// </summary>
        /// <param name="path">A string hold directory path value</param>
        /// <returns>List of string from input filepath</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static List<string> GetCsvData(string path)
        {
            List<string> data = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(path);

                sr.ReadLine();  //skip first line
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    data.Add(line);
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("GetData GetCsvData _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("GetData GetCsvData _ IOException: " + ex.Message);
            }

            return data;
        }

        /// <summary>
        /// Search for line from a specific .csv file by primary key
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="pKey">A string hold pimarykey value</param>
        /// <returns>A string from a specific .csv file</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static string GetDataByPrimaryKey(string path, string pKey)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                sr.ReadLine();  //skip first line
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');
                    if (split[0].Trim().Equals(pKey.Trim()))
                    {
                        return line;
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("GetData GetDataByPrimaryKey _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("GetData GetDataByPrimaryKey _ IOException: " + ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Search for list of lines from a specific .csv file that foreign key contains search info
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="fKey">A string hold foreignKey value</param>
        /// <param name="column">An integer value</param>
        /// <returns>List of strings from a specific .csv file that contains search info</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the Json file is not exist.
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static List<string> GetDataByForeignKey(string path, string fKey, int column)
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
                    if (split[column].Trim().Equals(fKey.Trim()))
                    {
                        list.Add(line);
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("GetData GetDataByForeignKey _ FileNotFoundException: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("GetData GetDataByForeignKey _ IOException: " + ex.Message);
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
            string path = ROOM_CSV;
            return GetDataByPrimaryKey(path, roomId);
        }

        /// <summary>
        /// Get list of subject by field id
        /// </summary>
        /// <param name="fieldId">A string value</param>
        /// <returns>List of subject contains field id</returns>
        public static List<string> GetListOfSubjectByField(string fieldId)
        {
            string path = SUBJECT_CSV;
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
            string path = CLASS_CSV;
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
            string path = ATTENDANCE_CSV;
            int column = GetColumn(path, "Class");
            return GetDataByForeignKey(path, classId, column);
        }

        /// <summary>
        /// Get all classes from Class.csv file
        /// </summary>
        /// <returns>List of classes</returns>
        public static List<string> GetListOfClass
        {
            get { return GetCsvData(CLASS_CSV); }
        }

        /// <summary>
        /// Get all fields from Field.csv file
        /// </summary>
        /// <returns>List of fields</returns>
        public static List<string> GetListOfField
        {
            get { return GetCsvData(FIELD_CSV); }
        }

        /// <summary>
        /// Get all rooms from Room.csv file
        /// </summary>
        /// <returns>List of rooms</returns>
        public static List<string> GetListOfRoom
        {
            get { return GetCsvData(ROOM_CSV); }
        }

        /// <summary>
        /// Get all levels from Level.csv file
        /// </summary>
        /// <returns>List of levels</returns>
        public static List<string> GetListOfLevel
        {
            get { return GetCsvData(LEVEL_CSV); }
        }

        /// <summary>
        /// Get all students from Student.csv file
        /// </summary>
        /// <returns>List of students</returns>
        public static List<string> GetListOfStudent
        {
            get { return GetCsvData(STUDENT_CSV); }
        }

        /// <summary>
        /// Get all teachers from Teacher.csv file
        /// </summary>
        /// <returns>List of teachers</returns>

        public static List<string> GetListofTeacher
        {
            get { return GetCsvData(TEACHER_CSV); }

        }

        /// <summary>
        /// Create Id for both Room and Class
        /// </summary>
        /// <param name="size">A positive integer number</param>
        /// <returns>A dictionary which roomId is key and classId is value</returns>
        public static Dictionary<string, string> CreateIdForClassAndRoom(int size)
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
