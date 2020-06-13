using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SchoolGenerating
{
    class ListManager
    {
        private List<Level> _level_list;
        public List<Level> LevelList { get { return _level_list; } }

        public ListManager(Level[] levels) {
            _level_list = new List<Level>(levels);
        }
        
        public void save(String filename)
        {
            

            String content = "";
            if (Path.GetExtension(filename) == ".csv")
            {
                content += "LevelID, LevelName\n";
                foreach (Level level in _level_list)
                {
                    content += level.LevelID + ", " + level.LevelName + "\n";
                }
            }
            else if (Path.GetExtension(filename) == ".json")
            {
                content = JsonConvert.SerializeObject(this, Formatting.Indented);
            }
            File.WriteAllText(filename, content);
            
        }
    }
}
