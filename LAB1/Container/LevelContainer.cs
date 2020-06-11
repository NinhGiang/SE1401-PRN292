using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB1.Container
{
    class LevelContainer
    {
        private List<Level> _level_list;

        public LevelContainer(Level[] level)
        {
            _level_list = new List<Level>(level);
        }

        public void LevelSave(String filename)
        {
            String content = "ID, Level name\n";
            foreach (Level level in _level_list)
            {
                content += level.UUID + ", " + level.Level_name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
