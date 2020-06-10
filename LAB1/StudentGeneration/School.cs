using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1.StudentGeneration
{
    class School
    {
        private List<Student> students;
        public School(Student[] students)
        {
            this.students = new List<Student>(students);
        }
        public void save(string school_name)
        {
            String content = "ID, Fullname, Gender, Birthday\n";
            foreach (Student student in students)
            {
                content += student.ID + ", " + student.Name + "\n";
            }
            createDirectory(school_name);
            string filepath = getFilePath(school_name);
            File.WriteAllText(filepath, content);
            Console.WriteLine("Successful: You have created {0} with {1} student",
                school_name, students.Count);
        }

        public String createDirectory(String directory_name)
        {
            Directory.CreateDirectory(@"..\..\..\StudentGeneration\" + directory_name);
            return @"..\..\..\StudentGeneration\" + directory_name;
        }

        public String getFilePath(String directory)
        {
            string filename_csv = directory + ".csv";
            return @"..\..\..\StudentGeneration\" + directory + @"\" + filename_csv;

        }
    }
}
