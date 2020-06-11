using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB1.Container
{
    class FieldContainer
    {
        private List<Field> _field_list;

        public FieldContainer (Field[] field)
        {
            _field_list = new List<Field>(field);
        }

        public void FieldSave (String filename)
        {
            String content = "ID, Field name\n";
            foreach (Field field in _field_list)
            {
                content += field.UUID + ", " + field.Name + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
