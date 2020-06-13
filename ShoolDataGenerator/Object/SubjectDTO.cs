using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class SubjectDTO
    {
        public string UUID { get; set; }
        public LevelDTO Level { get; set; }
        public FieldDTO Field { get; set; }
        public static string[] GenerateSubject(int length)
        {
            string[] fieldNames = Field.ListFieldName;

            Random rd = new Random();
            string[] listSubject = new string[length];
            for (int i = 0; i < listSubject.Length; i++)
            {
                string subject = Field.GenerateFieldName(rd.Next(field), rd.Next(length)) + " ";
                subject += Level.GenerateLevelName(rd.Next(length)) + " ";
                listSubject[i] = subject;
            }
            return listSubject;
        }




    }
}
