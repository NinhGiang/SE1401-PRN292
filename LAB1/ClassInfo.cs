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
        private static List<Class> _classList;

        public string UUID { get { return _uuid;  } set { _uuid = value;  } }
        public string Level { get { return _level; } set { _level = value; } }
        public string Room { get { return _room; } set { _room = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string ClassList { get { return _classList; } set { _classList = value; } }

        public Class(string UUID, string Level, string Room, string Name)
        {
            _uuid = UUID;
            _level = Level;
            _room = Room;
            _name = Name;
        }
        
        // Create a Class
        public static Class Create()
        {
            if (classList == null)
            {
                classList = new List<Class>();
            }
            Level newLevel = Level.Create();
            Class newClass = new Class(Guid.NewGuid().ToString(), Level.UUID, Guid.NewGuid().ToString(), "Classname");
            classList.Add(newClass);
            return newClass;
        }

        public static void SaveClasses(string filename)
        {
            String content = "UUID, Level, Room, Name\n";
            foreach (Class classObject in classList)
            {
                content += classObject.UUID + ", " + classObject.LevelUUID + ", " + classObject.RoomUUID + ", " + classObject.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
}
