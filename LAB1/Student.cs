using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    class Student
    {
        protected string _uuid;
        protected string _name;
        protected DateTime _birthday;
        protected bool _gender;
        protected string _class;

        public Student()
        {
        }

        public Student(string uuid, string name, DateTime birthday, bool gender, string Class)
        {
            _uuid = uuid;
            _name = name;
            _birthday = birthday;
            _gender = gender;
            _class = Class;
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
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public static Student[] createStudent(int numberOfStudent)
        {
            Student[] list = new Student[numberOfStudent];
            Level[] levelList = DatabaseHandler.GetLevelList();
            Random rand = new Random();

            Class[] classList = DatabaseHandler.GetClassList();

            int studentNumPerClass = (int) Math.Floor((double)numberOfStudent / classList.Length);
            int leftover = numberOfStudent - studentNumPerClass * classList.Length;
            int count = 0;

            foreach (Level level in levelList)
            {
                string levelID = level.UUID;
                int levelNum = Int32.Parse(level.Name);
                string[] classIDList = DatabaseHandler.GetClassIDByLevelList(levelID);
                foreach (string classID in classIDList)
                {
                    int additionalStudent = 0;
                    if (leftover > 0 && studentNumPerClass < 50)
                    {
                        while (studentNumPerClass + additionalStudent < 50 && leftover > 0 )
                        {
                            additionalStudent++;
                            leftover--;
                        }
                    }

                    for (int i = 0; i < studentNumPerClass + additionalStudent ; i++)
                    {
                        String id = Guid.NewGuid().ToString();
                        bool gender = Utils.GenerateRandomGender();
                        String name = Utils.GenerateRandomFullName(gender);

                        int age = Utils.GerateRandomAge(levelNum);
                        DateTime birth = Utils.GenerateRandomDateTime(2020 - age);
                        list[count++] = new Student(id, name, birth, gender, classID);
                    }
                }
            }
            

/*            for (int i = 0; i < numberOfStudent; i++)
            {
                String id = Guid.NewGuid().ToString();
                bool gender = Utils.GenerateRandomGender();
                String name = Utils.GenerateRandomFullName(gender);
                
                int age = Utils.GerateRandomAge(level);
                DateTime birth = Utils.GenerateRandomDateTime(2020 - age);
                String levelID = level.ToString();
                foreach (Level lev in levelList)
                {
                    if(lev.Name.Equals(level.ToString()))
                    {
                        levelID = lev.UUID;
                    }
                }
                string[] classIDList = DatabaseHandler.GetClassIDByLevelList(levelID);
                string classID = classIDList[rand.Next(classIDList.Length)];
                list[i] = new Student(id, name, birth, gender,classID);
            }*/
            return list;
        }
    }
}
