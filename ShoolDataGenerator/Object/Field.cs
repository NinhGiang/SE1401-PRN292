using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LAB1
{
    class Field
    {
        public string UUID { get; set; }
        public string Name { get; set; }
        public Field()
        {
            UUID = Guid.NewGuid().ToString();
        }
        public static string[] GenerateFieldName(int fieldAmount, int length)
        {
            Random rd = new Random();
            string[] listField = new string[length];
            string[] fieldName = {"Toan", "Ngu Van", "Sinh Hoc", "Vat Ly", "Hoa Hoc", "Lich Su",
                "Dia Ly", "Ngoai Ngu", "GDCD", "The Duc"};
            if(fieldAmount >= 8 && fieldAmount <= 10)
            {
                for (int i = 0; i < length; i++)
                {
                    string name = fieldName[rd.Next(fieldName.Length)];
                    listField[i] = name;
                }
            }
            

            return listField;

        }
    }
}
