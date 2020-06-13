using StudentGeneration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1.StudentGeneration
{
    class SchoolClass
    {
        protected string _uuid;
        protected string _level;
        protected string _room;
        protected string _name;

        public SchoolClass(string id, string level, string room, string name)
        {
            _uuid = id;
            _level = level;
            _room = room;
            _name = name;
        }

        public string ID
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

        public static List<SchoolClass> createClasses(string school_name, uint number_of_class)
        {
            List<SchoolClass> school_classes = new List<SchoolClass>();          
            //Get a list of ClassID of all rooms
            int classes_collumn = FileDataManagement.GetColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Rooms.csv", "Class");
            List<string> classes_id = FileDataManagement.GetDataInColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Rooms.csv", classes_collumn);
            
            //get a list of RoomID
            int rooms_collumn = FileDataManagement.GetColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Rooms.csv", "ID");
            List<string> rooms_id = FileDataManagement.GetDataInColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Rooms.csv", rooms_collumn);
            
            //get Level Names (10, 11, 12)
            int level_name_collumn = FileDataManagement.GetColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Levels.csv", "Name");
            List<string> levels_name = FileDataManagement.GetDataInColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Levels.csv", level_name_collumn);
            
            //get Levels ID
            int level_id_collumn = FileDataManagement.GetColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Levels.csv", "ID");
            List<string> levels_id = FileDataManagement.GetDataInColumn(@"..\..\..\StudentGeneration\" + school_name + @"\Levels.csv", level_id_collumn);
            
            int class_no = 0; 
            int level_no = 0;
            for (int i = 0; i < number_of_class; i++)
            {
                string uuid = classes_id[i];
                string room = rooms_id[i];

                if (class_no < number_of_class / 3 + 1)
                {
                    class_no++;
                } else
                {
                    class_no = 1;
                    level_no++;
                }
                string name = levels_name[level_no] + "A" + class_no;
                school_classes.Add(new SchoolClass(uuid, levels_id[level_no], room, name));
            }
            return school_classes;
        }
    }
}

