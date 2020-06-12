using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ProgramManagerStudent
{
    class Class
    {
        private string uuid;
        private string levelUUID;
        private string roomUUID;
        private string name;

        public Class(string uuid, string levelUUID, string roomUUID, string name)
        {
            this.uuid = uuid;
            this.levelUUID = levelUUID;
            this.roomUUID = roomUUID;
            this.name = name;
        }

        public string Uuid { get { return uuid; } set { uuid = value; } }
        public string LevelUUID { get { return levelUUID; } set { levelUUID = value; } }
        public string RoomUUID { get { return roomUUID; } set { roomUUID = value; } }
        public string Name { get { return name; } set { name = value; } }

        //public static Class Create(Level level, string roomUUID, int index)
        //{
        //    List<Class> classList = new List<Class>();
        //    string configContent = File.ReadAllText(@"..\..\..\Configure.json");
        //    Configure config = JsonSerializer.Deserialize<Configure>(configContent);
        //    ClassConfig className = config.ClassConfig;
        //    int classNameIndex = index;
        //    string uuid = Guid.NewGuid().ToString();
        //    string classname = level.Name + className.class_name_set[classNameIndex];
        //    Class newClass = new Class(uuid, level, roomUUID, classname);
        //    classList.Add(newClass);
        //    return newClass;
        //}

        //public static void SaveClasses(string filename)
        //{
        //    String content = "UUID, LevelUUID, RoomUUID, Name\n";
        //    foreach (Class classObject in classList)
        //    {
        //        content += classObject.UUID + ", " + classObject.LevelUUID + ", " + classObject.RoomUUID + ", " + classObject.Name + "\n";
        //    }
        //    File.WriteAllText(filename, content);
        //}
    }
}
