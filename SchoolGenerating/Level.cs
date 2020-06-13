using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolGenerating
{
    class Level
    {
        private String _levelID;
        private String _levelName;

        public String LevelID
        {
            get { return _levelName; }
           
        }

        public String LevelName { get { return _levelName; } }
        public Level() { }

        public Level(String lvID, String lvName) { _levelID = lvID;
            _levelName = lvName;
        }
        public static Level[] Create()
        {
            int lvName_number = 9;
            Level[] result = new Level[3];
            for (int i = 0; i < 3; i++)
            {
                String ID = Guid.NewGuid().ToString();
                lvName_number += 1;
                String lvName = lvName_number.ToString();
                result[i] = new Level(ID, lvName);
            }
            return result;
        }
        public void print()
        {
            Console.WriteLine(_levelID +","+ _levelName);
        }



    }
}
