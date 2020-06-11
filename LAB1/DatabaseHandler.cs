using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class DatabaseHandler
    {

        //File reader

        private static string _directory_path;
        public string DirectoryPath
        {
            set { _directory_path = value; }
        }
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

        public static Field[] getFieldList()
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
        public static string[] getFieldIDList()
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
        public static string GetClassLevelByID(String id)
        {
            int col = GetColumnID(_directory_path + "\\" + "Class.csv", "ID");
            string result = GetSingleRowByData(_directory_path + "\\" + "Class.csv", id, col);
            int levelCol = GetColumnID(_directory_path + "\\" + "Class.csv", "Level");
            string[] entry = result.Split(",");    
            return entry[levelCol];
        }

        //Subject
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
                subjectList[index++] = new Subject();
            }
            return subjectList;
        }
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

        public static Student[] getStudentIDClassList()
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
