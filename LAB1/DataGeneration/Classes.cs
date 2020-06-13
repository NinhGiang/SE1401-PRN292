using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    /// <summary>
    /// The Classes class
    /// Contains method to create Classes and its getter/setter/ctor.
    /// </summary>
    class Classes
    {
        /// <summary>
        /// The 4 values of Classes
        /// </summary>
        protected string _uuid;
        protected string _level;
        protected string _room;
        protected string _name;
        
        /// <summary>
        /// The getter/setter method of Classes values
        /// </summary>
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

        /// <summary>
        /// The ctor of Classes 
        /// Has one blank ctor
        /// </summary>
        /// <param name="uuid">A string value</param>
        /// <param name="level">A string value</param>
        /// <param name="room">A string value</param>
        /// <param name="name">A string value</param>
        public Classes(){     }
        public Classes(string uuid, string level, string room, string name)
        {
            _uuid = uuid;
            _level = level;
            _room = room;
            _name = name;
        }

        /// <summary>
        /// Creates a random list of classes and returns the result
        /// </summary>
        /// <param name="number_classes">An integer value</param>
        /// <returns>An array of classes</returns>
        public static Classes[] createClasses(uint nummber_classes)
        {
            List<Classes> result = new List<Classes>();

            List<string> listClassID = ListStorage.GetClassesIDByRoom();
            List<string> listRoomID = ListStorage.GetRoomIDByRoom();
            List<string> listLevelName = ListStorage.GetLevelNameByLevel();
            List<string> listLevelID = ListStorage.GetLevelIDByLevel();

            int class_no = 0;
            int level_no = 0;
            for (int i = 0; i < nummber_classes; i++)
            {
                string uuid = listClassID[i];
                string room = listRoomID[i];

                if (class_no < nummber_classes / 3 + 1)
                {
                    class_no++;
                }
                else
                {
                    class_no = 1;
                    level_no++;
                }
                string name = listLevelName[level_no] + "A" + class_no;
                result.Add(new Classes(uuid, listLevelID[level_no], room, name));
            }
            return result.ToArray();
        }
    }
}
