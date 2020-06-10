using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LAB1
{
    class School
    {
        private List<Level> _level_list;

        public School()
        {
        }
        public List<Level> LevelList
        {
            get { return _level_list; }
            set { _level_list = value; }
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
