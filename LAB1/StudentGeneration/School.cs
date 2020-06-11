using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.StudentGeneration
{
    class School
    {
        protected string _school_name;
        protected List<Student> _students;
        protected List<Level> _levels;
        protected List<Room> _rooms;
        protected List<SchoolClass> _classes;

        public School(string school_name, Student[] students, Level[] levels, 
            Room[] rooms, SchoolClass[] classes)
        {
            this._school_name = school_name;
            this._students = new List<Student>(students);
            this._levels = new List<Level>(levels);
            this._rooms = new List<Room>(rooms);
            this._classes = new List<SchoolClass>(classes);
        }

        public void save()
        {
            createDirectory(_school_name);
            saveStudents();
        }

        public void saveStudents()
        {
            String content = "ID, Fullname, Gender, Birthday, Class\n";
            foreach (Student student in _students)
            {
                content += student.ID + ", " + student.Name + ", " 
                    + student.Gender + ", " 
                    + student.Birthday.ToShortDateString() + ", "
                    + student.Current_class + "\n";
            }
            string filepath = getFilePath(_school_name);
            File.WriteAllText(filepath, content);
        }

        public String createDirectory(String directory_name)
        {
            Directory.CreateDirectory(@"..\..\..\" + directory_name);
            return @"..\..\..\" + directory_name;
        }

        public String getFilePath(String filename)
        {
            string filename_csv = filename + ".csv";
            return @"..\..\..\" + _school_name + @"\" + filename_csv;

        }
    }
}
