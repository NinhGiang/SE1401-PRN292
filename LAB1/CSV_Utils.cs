using System;
using System.Collections.Generic;
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

        private static void setPath()
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
        
        public static void setDirectory(string path)
        {
            directory = path;
            setPath();
        }
    }
}
