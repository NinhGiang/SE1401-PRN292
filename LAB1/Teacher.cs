using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;


namespace StudentGeneration
{
    class Teacher
    {
        protected string _id;
        protected string _fullname;
        protected bool _gender;
        protected string _field;
        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }
        public string Field { get { return _field; } }
        public bool Gender { get { return _gender; } }

        protected Teacher(string ID, string FullName, bool Gender, string Field)
        {
            _id = ID;
            _fullname = FullName;
            _gender = Gender;
            _field = Field;
        }

        public static Teacher[] Create(int number_teacher)
        {
            Random rd = new Random();

            List<Teacher> teacherList = new List<Teacher>();

            List<string> fieldList = Readcsvjsonhelper.GetFieldList();


            for (int i = 0; i < number_teacher; i++)
            {
                //id
                String uuid = Guid.NewGuid().ToString();

                //gender
                bool gender = !(rnd.Next(2) == 2);

                //name
                string fullName = Readcsvjsonhelper.GetNameforGender(gender);

                //Field
                int index = rd.Next(fieldList.Count);
                string[] fields = fieldList[index].Split(',');
                string field = fields[0].Trim();

                teacherList.Add(new Teacher(uuid, fullName, gender, field));
            }

            return teacherList;



        }
    }
}
