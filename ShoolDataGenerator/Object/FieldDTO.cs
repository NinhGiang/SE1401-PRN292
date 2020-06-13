using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LAB1
{
    class FieldDTO
    {
        public static readonly string[] listFieldName= new string[] { "Toan", "Ngu Van", "Sinh Hoc", "Vat Ly", "Hoa Hoc", "Lich Su", "Dia Ly", "Ngoai Ngu", "GDCD", "The Duc" };
        public static string[] ListFieldName { get { return listFieldName; } }
        public string UUID { get; set; }
        public string Name { get; set; }
        public FieldDTO()
        {
            UUID = Guid.NewGuid().ToString();
        }
        /*public static string[] GenerateFieldName(int fieldAmount, int length)
        {
            Random rd = new Random();
            string[] listField = new string[length];
            string[] fieldName = {"Toan", "Ngu Van", "Sinh Hoc", "Vat Ly", "Hoa Hoc", "Lich Su",
                "Dia Ly", "Ngoai Ngu", "GDCD", "The Duc"};
            if (fieldAmount >= 8 && fieldAmount <= 10)
            {
                for (int i = 0; i < length; i++)
                {
                    string name = fieldName[rd.Next(fieldName.Length)];
                    listField[i] = name;
                }
            }


            return listField;

        }*/
    }
}
