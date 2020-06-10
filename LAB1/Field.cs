using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Field
    {
        protected string _uuid;
        protected string _name;

        public Field(string uuid, string name)
        {
            _uuid = uuid ?? throw new ArgumentNullException(nameof(uuid));
            _name = name ?? throw new ArgumentNullException(nameof(name));
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
        public static Field[] CreateField()
        {
            String[] data = Utils.getFieldData();
            Field[] list = new Field[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                String uuid = Guid.NewGuid().ToString();
                String name = data[i];
                Field field = new Field(uuid, name);
                list[i] = field;
            }
            return list;
        }
    }
}
