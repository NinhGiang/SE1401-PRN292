using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    class Class
    {
        protected string _uuid;
        protected string _level;
        protected string _room;
        protected string _name;

        public Class(string uuid, string level, string room, string name)
        {
            _uuid = uuid;
            _level = level;
            _room = room;
            _name = name;
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public static Class[] createClass(Dictionary<String,String> ids)
        {
            Level[] levelList = DataReader.getLevelList();
            Class[] list = new Class[ids.Count];
            int count = 0;
            int numberOfClass = ids.Count / levelList.Length;
            int leftover = ids.Count - numberOfClass * levelList.Length;
            int levelIndex = 0;
            Random rand = new Random();
            int classLevelCount = 1;
            foreach (KeyValuePair<string,string> entry in ids)
            {
                String id = entry.Value;
                Level currLevel = levelList[levelIndex];
                String level = currLevel.UUID;
                String room = entry.Key;
                
                String name = currLevel.Name + "A" + classLevelCount;
                
                list[count] = new Class(id,level,room,name);
                count++;

                if (classLevelCount < numberOfClass)
                {
                    classLevelCount++;
                }
                else if (levelIndex == 0 & classLevelCount < numberOfClass + leftover)
                {
                        classLevelCount++;
                }
                else
                {
                    if (levelIndex < levelList.Length - 1)
                    {
                        levelIndex++;
                        classLevelCount = 1;
                    }
                    /*                   
                    else
                    {
                        levelIndex = 0;
                        classLevelCount = numberOfClass + 1;
                        numberOfClass += leftover;
                    } 
                    */
                }
            }
            return list;
        }
        public static void print(Dictionary<String, String> ids, Level[] levelList)
        {
            int idCount = ids.Count;
            int count = levelList.Length;

            Console.WriteLine(idCount);
            Console.WriteLine(count);

            Console.WriteLine(idCount/=count);
            Console.WriteLine(idCount % count);
        }
    }
}
