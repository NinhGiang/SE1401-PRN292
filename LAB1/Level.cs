using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Level
    {
        protected string levelID;
        protected string levelName;

        public string LevelID { get { return levelID; } }
        public string LevelName { get { return levelName; } set { levelName = value; } }

        public Level(string LevelID, string LevelName)
        {
            levelID = LevelID;
            levelName = LevelName;
        }
        public Level() { }


    }
}
