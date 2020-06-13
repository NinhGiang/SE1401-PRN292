using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class CSV_Utils
    {
        private static string attendanceCSV;
        private static string classCSV;
        private static string fieldCSV;
        private static string levelCSV;
        private static string roomCSV;
        private static string studentCSV;
        private static string subjectCSV;
        private static string teacherCSV;

        private static string directory;

        private static void SetPath()
        {
            attendanceCSV = directory + "\\" + "Attendance.CSV";
            classCSV = directory + "\\" + "Class.CSV";
            fieldCSV = directory + "\\" + "Field.CSV";
            levelCSV = directory + "\\" + "Level.CSV";
            roomCSV = directory + "\\" + "Room.CSV";
            studentCSV = directory + "\\" + "Student.CSV";
            subjectCSV = directory + "\\" + "Subject.CSV";
            teacherCSV = directory + "\\" + "Teacher.CSV";
        }
        
        public static void SetDirectory(string path)
        {
            directory = path;
            SetPath();
        }

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
            catch (IOException ex)
            {
                Console.WriteLine("ReadCSVFile IOException: " + ex.Message);
            }
            return list;
        }


    }
}
