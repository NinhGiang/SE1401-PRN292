using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Student class
    /// Contains methods and properties for Student
    /// </summary>
    class Student
    {
        /// <summary>
        /// Student ID
        /// </summary>
        protected string _uuid;
        /// <summary>
        /// Student Name
        /// </summary>
        protected string _name;
        /// <summary>
        /// Student birthday
        /// </summary>
        protected DateTime _birthday;
        /// <summary>
        /// Student gender
        /// </summary>
        protected bool _gender;
        /// <summary>
        /// Class ID
        /// </summary>
        protected string _class;

        /// <summary>
        /// Empty constructor for Student
        /// </summary>
        public Student()
        {
        }

        /// <summary>
        /// Constructor for Student
        /// </summary>
        /// <param name="uuid">string value</param>
        /// <param name="name">string value</param>
        /// <param name="birthday">DateTime value</param>
        /// <param name="gender">boolean value</param>
        /// <param name="Class">string value</param>
        public Student(string uuid, string name, DateTime birthday, bool gender, string Class)
        {
            _uuid = uuid;
            _name = name;
            _birthday = birthday;
            _gender = gender;
            _class = Class;
        }

        /// <summary>
        /// getter setter for Student ID
        /// </summary>
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        /// <summary>
        /// getter setter for Student Name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// getter setter for Student Birthday
        /// </summary>
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        /// <summary>
        /// getter setter for Student Gender
        /// </summary>
        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        /// <summary>
        /// getter setter for Class ID
        /// </summary>
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        /// <summary>
        /// Create a list of Student and return result
        /// </summary>
        /// <param name="numberOfStudent">integer value</param>
        /// <returns>Return an array of Student</returns>
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
                        DateTime birth = Utils.GenerateRandomBirthday(2020 - age);
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
