using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private string _school_name;
        private List<Level> _level_list;
        private List<Field> _field_list;
        private List<Subject> _subject_list;
        private List<Teacher> _teacher_list;

        public School()
        {
        }
        public string SchoolName
        {
            get { return _school_name; }
            set { _school_name = value; }
        }
        public Level[] LevelList
        {
            set { _level_list = new List<Level>(value); }
        }
        public Field[] FieldList
        {
            set { _field_list = new List<Field>(value); }
        }
        public Subject[] SubjectList
        {
            set { _subject_list = new List<Subject>(value); }
        }
        public Teacher[] TeacherList
        {
            set { _teacher_list = new List<Teacher>(value); }
        }

        public void saveLevel(String filename)
        {
            String content = "ID, Name\n";
            try
            {
                if (_level_list == null)
                {
                    _level_list = new List<Level>();
                }
                foreach (Level level in _level_list)
                {
                    content += level.UUID + ", ";
                    content += level.Name + "\n";
                }
                File.WriteAllText(filename, content);
            } catch (NullReferenceException ex)
            {
                Console.WriteLine("saveLevel : " + ex.Message);
            }
        }
        public void saveField(String filename)
        {
            String content = "ID, Name\n";
            try
            {
                if (_field_list == null)
                {
                    _field_list = new List<Field>();
                }
                foreach (Field field in _field_list)
                {
                    content += field.UUID + ", ";
                    content += field.Name + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("saveField : " + ex.Message);
            }
        }
        public void saveSubject(String filename)
        {
            String content = "ID, Name, Level, Field\n";
            try
            {
                if (_subject_list == null)
                {
                    _subject_list = new List<Subject>();
                }
                foreach (Subject subject in _subject_list)
                {
                    content += subject.UUID + ", ";
                    content += subject.Name + ", ";
                    content += subject.Level + ", ";
                    content += subject.Field + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("saveSubject : " + ex.Message);
            }
        }
        public void saveTeacher(String filename)
        {
            String content = "ID, Name, Gender, Field\n";
            if (_teacher_list == null)
            {
                _teacher_list = new List<Teacher>();
            }
            try
            {
                foreach (Teacher teacher in _teacher_list)
                {
                    content += teacher.UUID + ", ";
                    content += teacher.Name + ", ";
                    if (teacher.Gender)
                    {
                        content += "M" + ", ";
                    }
                    else content += "F" + ", ";
                    content += teacher.Field + "\n";
                }
                File.WriteAllText(filename, content);
            }
            
            catch (NullReferenceException ex)
            {
                Console.WriteLine("saveTeacher : " + ex.Message);
            }
        }
    }
}
