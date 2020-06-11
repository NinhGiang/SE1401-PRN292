using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Classes
    {
        protected string _uuid;
        protected string _level;
        protected string _room;
        protected string _name;

        public string Uuid
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
        public Classes(string uuid, string level, string room, string name)
        {
            _uuid = uuid;
            _level = level;
            _room = room;
            _name = name;
        }
        public static Classes[] createClasses(uint nummber_classes)
        {
            List<Classes> result = new List<Classes>();
            List<string> roomList = ListStorage.GetRoomList();
            
            for (int i = 0; i < roomList.Count; i++)
            {
                string uuid = Guid.NewGuid().ToString(); //generate random uuid
                string levelID = DataGenerator.GetLevelData()[0].Trim();
                string roomID = DataGenerator.GetRoomData()[0].Trim();

                string levelName = DataGenerator.GetLevelData()[1].Trim();
                string roomNo = DataGenerator.GetRoomData()[2].Trim();
                string className = levelName + "A" + roomNo;
                result.Add(new Classes(uuid, levelID, roomID, className));              
            }
            return result.ToArray();
        }
    }
}
