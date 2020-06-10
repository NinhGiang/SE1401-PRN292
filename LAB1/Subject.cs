using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Subject
    {
        protected string _uuid;
        protected string _name;
        protected string _level;
        protected string _field;

        public Subject(string uuid, string name, string level, string field)
        {
            _uuid = uuid ?? throw new ArgumentNullException(nameof(uuid));
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _level = level ?? throw new ArgumentNullException(nameof(level));
            _field = field ?? throw new ArgumentNullException(nameof(field));
        }

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }
        public static Subject[] createSubject(Field[] fieldList, Level[] levelList)
        {
            Subject[] list = new Subject[fieldList.Length*levelList.Length];
            int size = 0;
            for (int i = 0; i < fieldList.Length; i++)
            {
                for (int j = 0; j < levelList.Length; j++)
                {
                    string id = Guid.NewGuid().ToString();
                    string name = fieldList[i].Name + " " + levelList[j].Name;
                    Subject subject = new Subject(id, name, levelList[j].UUID, fieldList[i].UUID);
                    list[size] = subject;
                    size++;
                }
            }
            return list;
            
        }
    }
}
