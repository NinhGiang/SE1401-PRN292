using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    class Class
    {
        private string id;
        private string level;//khoa ngoai
        private string room; //khoa ngoai
        private string name; //10A1, 10A2, 10A3

        public string Id { get => id; set => id = value; }
        public string Level { get => level; set => level = value; }
        public string Room { get => room; set => room = value; }
        public string Name { get => name; set => name = value; }

        
        public Class(string id, string level, string room, string name)
        {
            this.Id = id;
            this.Level = level;
            this.Room = room;
            this.Name = name;
        }

        public static Class[] Create(Dictionary<string,string> list)
        {
            List<Class> result = new List<Class>();

            List<string> levelList = GetData.GetListOfLevel;

            int levelAmount = (int)Math.Ceiling((double)list.Count / levelList.Count);
            int count = 0;
            int levelIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                count++;
                //id
                string uuid = list.ElementAt((int)i).Value;

                //level
                string[] level = levelList[levelIndex].Split(',');
                string levelId = level[0].Trim();

                //room
                string roomId = list.ElementAt((int)i).Key;

                //name
                string levelName = level[1].Trim();
                string name = levelName + "D" + count;

                result.Add(new Class(uuid, levelId, roomId, name));

                if (count == levelAmount)
                {
                    levelIndex++;
                    count = 0;
                }
            }

            return result.ToArray();
        }
        
    }
}
