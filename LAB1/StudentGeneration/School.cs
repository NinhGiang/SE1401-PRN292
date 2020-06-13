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

        public School(string school_name) 
        {
            _school_name = school_name;
        }

        public string School_Name
        {
            get { return _school_name; }
            set { _school_name = value; }
        }
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public List<Level> Levels
        {
            get { return _levels; }
            set { _levels = value; }
        }

        public List<SchoolClass> Classes
        {
            get { return _classes; }
            set { _classes = value; }
        }

        public List<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }
        public void saveAll()
        {
            FileDataManagement.createDirectory(_school_name);
            FileDataManagement.saveLevels(_school_name, _levels);
            FileDataManagement.saveStudents(_school_name, _students);
            
        }
    }
}
