using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    public class Student
    {
        protected string _id;
        protected string _name;
        protected DateTime _birthdate;
        protected bool _gender;
        protected string _class;

        public string GetId()
        { return _id; }

        public void SetId(string value)
        { _id = value; }

        public string GetName()
        { return _name; }

        public void SetName(string value)
        { _name = value; }

        public DateTime GetBirthdate()
        { return _birthdate; }

        public void SetBirthdate(DateTime value)
        { _birthdate = value; }

        public bool GetGender()
        { return _gender; }

        public void SetGender(bool value)
        { _gender = value; }

        public string GetClassInfo()
        { return _class; }

        public void SetClassInfo(string value)
        { _class = value; }

        public Student() { }

        public Student(string id, string name, DateTime birthdate, bool gender, string classInfo)
        {
            _id = id;
            _name = name;
            _birthdate = birthdate;
            _gender = gender;
            _class = classInfo;
        }

        public static Student[] Create(uint numberOfStudent)
        {
            Student[] result = new Student[numberOfStudent];

            Random rnd = new Random();
            int index;

            for (uint i = 0; i < numberOfStudent; i++)
            {
                //id
                String uuid = Guid.NewGuid().ToString();

                //gender
                bool gender = rnd.Next(2) == 1;

                //name
                string fullName = DataHelper.GetRandomNameByGender(gender);

                //grade
                List<string> levelList = DataHelper.GetListOfLevel();
                index = rnd.Next(levelList.Count);
                string[] levelInfo = levelList[index].Split(',');
                string level = levelInfo[1].Trim();
                string levelId = levelInfo[0].Trim();

                //birthdate
                DateTime birthdate = DataHelper.GetRandomBirthdayByLevel(level);

                //Class
                List<string> listOfClasses = DataHelper.GetListOfClassByLevel(levelId);
                index = rnd.Next(listOfClasses.Count);
                string[] classes = listOfClasses[index].Split(',');
                string classInfo = classes[0].Trim();

                result[i] = new Student();
                result[i].SetId(uuid);
                result[i].SetName(fullName);
                result[i].SetGender(gender);
                result[i].SetBirthdate(birthdate);
                result[i].SetClassInfo(classInfo + " (" + classes[3].Trim() +")");
            }
            return result;
        }

    }
}
