using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.StudentGeneration
{
    class FileDataManagement
    {
        public static String createDirectory(String directory_name)
        {
            Directory.CreateDirectory(@"..\..\..\StudentGeneration\" + directory_name);
            return @"..\..\..\StudentGeneration\" + directory_name;
        }

        public static void saveStudents(string school_name, List<Student> students)
        {
            String content = "ID, Fullname, Gender, Birthday, Class\n";
            foreach (Student student in students)
            {
                content += student.ID + ", " + student.Name + ", "
                    + student.Gender + ", "
                    + student.Birthday.ToShortDateString() + ", "
                    + student.Current_class + "\n";
            }
            string filepath = @"..\..\..\StudentGeneration\" + school_name + @"\Students.csv";
            File.WriteAllText(filepath, content);
        }

        public static void saveLevels(string school_name, List<Level> levels)
        {
            String content = "ID, Name\n";
            foreach (Level level in levels)
            {
                content += level.ID + ", " + level.Name + "\n";
            }
            string filepath = @"..\..\..\StudentGeneration\" + school_name + @"\Levels.csv";
            File.WriteAllText(filepath, content);
        }

        public static void saveFields(string school_name, List<Field> fields)
        {
            String content = "ID, Name\n";
            foreach (Field field in fields)
            {
                content += field.ID + ", " + field.Name + "\n";
            }
            string filepath = @"..\..\..\StudentGeneration\" + school_name + @"\Fields.csv";
            File.WriteAllText(filepath, content);
        }

        public static void saveSubjects(string school_name, List<Subject> subjects)
        {
            String content = "ID, Level, Field, Name\n";
            foreach (Subject subject in subjects)
            {
                content += subject.ID + ", " + subject.Level + ", " + subject.Field + ", " +
                    subject.Name + "\n";
            }
            string filepath = @"..\..\..\StudentGeneration\" + school_name + @"\Subjects.csv";
            File.WriteAllText(filepath, content);
        }

        public static void saveRooms(string school_name, List<Room> rooms)
        {
            String content = "ID, Class, No.\n";
            foreach (Room room in rooms)
            {
                content += room.Id + ", " + room.Class_using + ", " + room.No + "\n";
            }
            string filepath = @"..\..\..\StudentGeneration\" + school_name + @"\Rooms.csv";
            File.WriteAllText(filepath, content);
        }

        public static void saveClass(string school_name, List<SchoolClass> classes)
        {
            String content = "ID, Level, Room, Name\n";
            foreach (SchoolClass school_class in classes)
            {
                content += school_class.ID + ", " + school_class.Level + ", " +school_class.Room + ", "
                    + school_class.Name + "\n";
            }
            string filepath = @"..\..\..\StudentGeneration\" + school_name + @"\Classes.csv";
            File.WriteAllText(filepath, content);
        }

        public static List<string> CsvReader(string path)
        {
            List<string> curr_list = new List<string>();
            StreamReader sr = new StreamReader(path);

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                curr_list.Add(line);
            }
            sr.Close();
            return curr_list;
        }
        public static int GetColumn(string path, string col_name)
        {
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            string[] split = line.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Trim().Equals(col_name.Trim()))
                {
                    return i;
                }
            }
            sr.Close();
            return -1;
        }
        public static List<string> GetDataInColumn(string path, string data, int column)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);
            try
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');
                    if (split[column].Trim().Equals(data.Trim()))
                    {
                        list.Add(line);
                    }
                }
                sr.Close();
                return list;
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine("Error in GetDataInColumn : " + ex.Message);
            }
            return null;
        }

        public static List<string> GetDataInColumn(string path, int column)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);
            try
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',');
                    list.Add(split[column]);
                }
                sr.Close();
                return list;
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine("Error in GetDataInColumn : " + ex.Message);
            }
            return null;
        }
    }
}
