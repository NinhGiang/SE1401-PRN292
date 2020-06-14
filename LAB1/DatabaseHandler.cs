using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// DatabaseHandler class
    /// Contains methods that handles data from .csv file
    /// </summary>
    class DatabaseHandler
    {

        //File reader

        /// <summary>
        /// The path to the folder of school data
        /// </summary>
        private static string _directory_path;
        /// <summary>
        /// setter for _directory_path
        /// </summary>
        public string DirectoryPath
        {
            set { _directory_path = value; }
        }
        /// <summary>
        /// Read a .csv file and return a list of lines
        /// </summary>
        /// <param name="path">A string value</param>
        /// <returns>A list of string that contains data read from file</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the file is not found
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
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
        /// <summary>
        /// Get a column index from .csv file
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="col">A string value</param>
        /// <returns>An integer that is column index</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the file is not found
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static int GetColumnID(string path, string col)
        {
            bool found = false;
            int id = -1;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string headerLine = sr.ReadLine();
                    string[] entry = headerLine.Split(",");
                    for (int i = 0; i < entry.Length & found == false; i++)
                    {
                        if (entry[i].Trim().Equals(col.Trim()))
                        {
                            id = i;
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
            return id;
        }
        /// <summary>
        /// Get all data from 1 column in a .csv file
        /// </summary>
        /// <param name="path">A string value</param>
        /// <param name="col">A string value</param>
        /// <returns>A list of string that contains data read from file</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the file is not found
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
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

        /// <summary>
        /// Get data with a condition for 1 column from a .csv file
        /// </summary>
        /// <param name="path">a string value</param>
        /// <param name="data">a string value</param>
        /// <param name="col">a string value</param>
        /// <returns>A list of string that contains data read from file</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the file is not found
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>

        private static List<string> GetRowByData(string path,string data, int col)
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
        /// <summary>
        /// Get a single line of data
        /// </summary>
        /// <param name="path">a string value</param>
        /// <param name="data">a string value</param>
        /// <param name="col">a string value</param>
        /// <returns>A single string value that contains data read from file</returns>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the file is not found
        /// </exception>
        /// <exception cref="System.IO.IOException">
        /// Thrown when I/O error occurs
        /// </exception>
        private static string GetSingleRowByData(string path, string data, int col)
        {
            bool found = false;
            String result = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    sr.ReadLine(); //skip header
                    while (!sr.EndOfStream & found == false)
                    {
                        string currLine = sr.ReadLine();
                        string[] entry = currLine.Split(",");
                        if (entry[col].Trim().Equals(data.Trim()))
                        {
                            result = currLine;
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
            return result;
        }


        //Level

        /// <summary>
        /// Get a list of Level from Level.csv
        /// </summary>
        /// <returns>return an array of Level</returns>
        public static Level[] GetLevelList()
        {
            List<string> list = CsvFileReader(_directory_path + "\\" + "Level.csv");
            Level[] levelList = new Level[list.Count];
            int index = 0;
            int idCol = GetColumnID(_directory_path + "\\" + "Level.csv", "ID");
            int nameCol = GetColumnID(_directory_path + "\\" + "Level.csv", "Name");
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[idCol].Trim();
                string name = entry[nameCol].Trim();
                levelList[index++] = new Level(id, name);
            }
            return levelList;
        }

        //Field
        /// <summary>
        /// Get a list of Field from Field.csv
        /// </summary>
        /// <returns>return an array of Field</returns>
        public static Field[] GetFieldList()
        {
            List<string> list = CsvFileReader(_directory_path + "\\" + "Field.csv");
            Field[] fieldList = new Field[list.Count];
            int index = 0;
            int idCol = GetColumnID(_directory_path + "\\" + "Field.csv", "ID");
            int nameCol = GetColumnID(_directory_path + "\\" + "Field.csv", "Name");
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[idCol].Trim();
                string name = entry[nameCol].Trim();
                fieldList[index++] = new Field(id, name);
            }
            return fieldList;
        }
        /// <summary>
        /// Get a list of Field ID from Field.csv
        /// </summary>
        /// <returns>Return an array of string (Field ID)</returns>
        public static string[] GetFieldIDList()
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
        // Class

        /// <summary>
        /// Get a list of Class from Class.csv
        /// </summary>
        /// <returns>An array of Class</returns>
        public static Class[] GetClassList()
        {

            List<string> list = CsvFileReader(_directory_path + "\\" + "Class.csv");
            Class[] classList = new Class[list.Count];
            int idCol = GetColumnID(_directory_path + "\\" + "Class.csv", "ID");
            int levelCol = GetColumnID(_directory_path + "\\" + "Class.csv", "Level");
            int index = 0;
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[idCol].Trim();
                string level = entry[levelCol].Trim();
                Class classInfo = new Class();
                classInfo.UUID = id;
                classInfo.Level = level;
                classList[index++] = classInfo;
            }
            return classList;
        }
        /// <summary>
        /// Get a list of Class ID by Level from Class.csv
        /// </summary>
        /// <param name="level">A string value</param>
        /// <returns>Return an array of string (Class ID)</returns>

        public static string[] GetClassIDByLevelList(String level)
        {
            int col = GetColumnID(_directory_path + "\\" + "Class.csv", "Level");

            List<string> list = GetRowByData(_directory_path + "\\" + "Class.csv", level, col);

            int idCol = GetColumnID(_directory_path + "\\" + "Class.csv", "ID");
            string[] classIDList = new string[list.Count];
            int index = 0;
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                
                classIDList[index++] = entry[idCol];
            }
            return classIDList;
        }
        /// <summary>
        /// Get Level for a Class by Class ID
        /// </summary>
        /// <param name="id">A string value</param>
        /// <returns>Return a string (class level)</returns>
        public static string GetClassLevelByID(String id)
        {
            int col = GetColumnID(_directory_path + "\\" + "Class.csv", "ID");
            string result = GetSingleRowByData(_directory_path + "\\" + "Class.csv", id, col);
            int levelCol = GetColumnID(_directory_path + "\\" + "Class.csv", "Level");
            string[] entry = result.Split(",");    
            return entry[levelCol];
        }

        //Subject

        /// <summary>
        /// Get a list of Subject from Subject.csv
        /// </summary>
        /// <returns>An array of Subject</returns>
        public static Subject[] GetSubjectList()
        {

            List<string> list = CsvFileReader(_directory_path + "\\" + "Subject.csv");
            Subject[] subjectList = new Subject[list.Count];
            int idCol = GetColumnID(_directory_path + "\\" + "Subject.csv", "ID");
            int levelCol = GetColumnID(_directory_path + "\\" + "Subject.csv", "Level");
            int fieldCol = GetColumnID(_directory_path + "\\" + "Subject.csv", "Field");
            int index = 0;
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[idCol].Trim();
                string level = entry[levelCol].Trim();
                string field = entry[fieldCol].Trim();
                Subject subject = new Subject();
                subject.UUID = id;
                subject.Level = level;
                subject.Field = field;
                subjectList[index++] = subject;
            }
            return subjectList;
        }
        /// <summary>
        /// Get a list of Subject ID by Level from Subject.csv
        /// </summary>
        /// <param name="level">a string value</param>
        /// <returns>An array of string (Subject ID)</returns>
        public static string[] GetSubjectIDByLevelList(String level)
        {
            int col = GetColumnID(_directory_path + "\\" + "Subject.csv", "Level");

            List<string> list = GetRowByData(_directory_path + "\\" + "Subject.csv", level, col);

            int idCol = GetColumnID(_directory_path + "\\" + "Subject.csv", "ID");
            string[] classIDList = new string[list.Count];
            int index = 0;
            foreach (string line in list)
            {
                string[] entry = line.Split(",");

                classIDList[index++] = entry[idCol];
            }
            return classIDList;
        }

        //Student

        /// <summary>
        /// Get a list of Student ID and CLass from Student.csv
        /// </summary>
        /// <returns>Return an array of Student</returns>
        public static Student[] GetStudentIDClassList()
        {
            List<string> list = CsvFileReader(_directory_path + "\\" + "Student.csv");
            int idCol = GetColumnID(_directory_path + "\\" + "Student.csv", "ID");
            int classCol = GetColumnID(_directory_path + "\\" + "Student.csv", "Class");
            Student[] studentList = new Student[list.Count];
            int index = 0;
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[idCol].Trim();
                string classInfo = entry[classCol].Trim();
                Student student = new Student();
                student.UUID = id;
                student.Class = classInfo;
                studentList[index++] = student;
            }
            return studentList;
        }

        //Teacher

        /// <summary>
        /// Get a list of Teacher from Teacher.csv
        /// </summary>
        /// <returns>Return an array of Teacher</returns>
        public static Teacher[] GetTeacherList()
        {
            List<string> list = CsvFileReader(_directory_path + "\\" + "Teacher.csv");
            Teacher[] teacherList = new Teacher[list.Count];
            int index = 0;
            int idCol = GetColumnID(_directory_path + "\\" + "Teacher.csv", "ID");
            int fieldCol = GetColumnID(_directory_path + "\\" + "Teacher.csv", "Field");
            foreach (string line in list)
            {
                string[] entry = line.Split(",");
                string id = entry[idCol].Trim();
                string field = entry[fieldCol].Trim();
                Teacher teacher = new Teacher();
                teacher.UUID = id;
                teacher.Field = field;
                teacherList[index++] = teacher;
            }
            return teacherList;
        }
    }
}
