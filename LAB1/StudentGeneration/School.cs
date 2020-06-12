using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using LAB1.StudentGeneration;
using Newtonsoft.Json;

namespace StudentGeneration
{
    class School
    {
        private List<Student> _students_list;
        private List<Field> _field_list;
        public List<Student> Schools {get{return _students_list;} }
        public List<Field>  Schoolss { get { return _field_list; } }
        public School(Student[] students,Field[] fields)
        {
            _students_list = new List<Student>(students);
            _field_list = new List<Field>(fields);
        }
        public void save(string filename)
        {
            String content = " ";
            if (Path.GetExtension(filename) == ".csv")
            {
                content+=" ID,Fullname\n";
                foreach (Student student in _students_list)
                {
                    content += student.ID + ", " + student.FullName + "\n";
                }
                
            }
            else if (Path.GetExtension(filename) == ".json")
            {
                //path to .json JsonConvert.SerializeObject(this)
                content = JsonConvert.SerializeObject(this);
            }
                File.WriteAllText(filename, content);
        }
        public void saveField(string filename)
        {
            String content = " ";
            if (Path.GetExtension(filename) == ".csv")
            {
                content += " ID,Name\n";
                foreach (Student student in _students_list)
                {
                    content += student.ID + ", " + student.FullName + "\n";
                }

            }
            else if (Path.GetExtension(filename) == ".json")
            {
                //path to .json JsonConvert.SerializeObject(this)
                content = JsonConvert.SerializeObject(this);
            }
            File.WriteAllText(filename, content);
        }
    }
}
