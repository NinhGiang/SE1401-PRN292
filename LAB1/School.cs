﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private string _school_name;
        private List<Level> _level_list;

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
    }
}