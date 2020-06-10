 using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class ClassInfo
    {
        private string _uuid;
        private string _level;
        private string _room;
        private string _name;

        public string UUID { get { return _uuid;  } set { _uuid = value;  } }
        public string Level { get { return _level; } set { _level = value; } }
        public string Room { get { return _room; } set { _room = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        public ClassInfo(string UUID, string Level, string Room, string Name)
        {
            _uuid = UUID;
            _level = Level;
            _room = Room;
            _name = Name;
        }
        
        // Create a Class
        public static ClassInfo[] Create(uint _noOfClasses)
        {
            List<ClassInfo> classList = new List<ClassInfo>();
            List<string> roomList = ListControl.GetRoomList();
            for (int i = 0; i < roomList.Count; i++)
            {
                string uuid = Guid.NewGuid().ToString();
                string levelID = DataConnection.getLevelInfo()[0].Trim();
                string roomID = DataConnection.getRoomInfo()[0].Trim();

                string levelName = DataConnection.getLevelInfo()[1].Trim();
                string roomNo = DataConnection.getRoomInfo()[2].Trim();
                string className = levelName + "A" + roomNo;
                classList.Add(new ClassInfo(uuid, levelID, roomID, className));
            }
            return classList.ToArray(); ;
        }
    }
}
