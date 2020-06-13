using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The Student class
    /// Contains create method and properties of Student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Id of student
        /// </summary>
        protected string _id;

        /// <summary>
        /// Full name of student
        /// </summary>
        protected string _name;

        /// <summary>
        /// Birthday of student
        /// </summary>
        protected DateTime _birthdate;

        /// <summary>
        /// Gender of student
        /// </summary>
        protected bool _gender;

        /// <summary>
        /// Class student attend
        /// </summary>
        protected string _class;

        /// <value>
        /// The id of student
        /// </value>
        public string UUID { get { return _id; } }

        /// <value>
        /// The name of student
        /// </value>
        public string Name { get { return _name; } }

        /// <value>
        /// The birthday of student
        /// </value>
        public DateTime Birthday { get { return _birthdate; } }

        /// <value>
        /// The gender of student
        /// </value>
        public bool Gender { get { return _gender; } }

        /// <value>
        /// The class of student
        /// </value>
        public string Class { get { return _class; } }

        /// <summary>
        /// An empty contrustor for student
        /// </summary>
        public Student() { }

        /// <summary>
        /// A constructor for student
        /// </summary>
        /// <param name="id">A string value</param>
        /// <param name="name">A string value</param>
        /// <param name="birthdate">A DateTime value</param>
        /// <param name="gender">A boolean value</param>
        /// <param name="classInfo">A string value</param>
        public Student(string id, string name, DateTime birthdate, bool gender, string classInfo)
        {
            _id = id;
            _name = name;
            _birthdate = birthdate;
            _gender = gender;
            _class = classInfo;
        }

        /// <summary>
        /// Creates a random list of students and returns the result
        /// </summary>
        /// <param name="numberOfStudent">An integer value</param>
        /// <returns>An array of students</returns>
        public static Student[] Create(int numberOfStudent)
        {
            List<Student> result = new List<Student>();

            Random rnd = new Random();

            List<string> listOfClasses = FileHelper.GetListOfClass();
            int currentTotal = 0;
            int quantity;
            for (int i = 0; i < listOfClasses.Count; i++)
            {
                if (i == listOfClasses.Count)
                {
                    quantity = numberOfStudent - currentTotal;
                }
                else
                {
                    quantity = rnd.Next(30, 51);
                }

                string[] classs = listOfClasses[i].Split(',');
                string classInfo = classs[0].Trim();
                string levelId = classs[1].Trim();
                string level = FileHelper.GetLevelByPrimaryKey(levelId).Split(',')[1];

                for (int j = 0; j < quantity; j++)
                {
                    //id
                    string uuid = Guid.NewGuid().ToString();

                    //gender
                    bool gender = rnd.Next(2) == 1;

                    //name
                    string fullName = GenerateDataHelper.GetRandomNameByGender(gender);

                    //birthdate
                    DateTime birthdate = GenerateDataHelper.GetRandomBirthdayByLevel(level);

                    result.Add(new Student(uuid, fullName, birthdate, gender, classInfo));
                    currentTotal++;
                }
            }
            return result.ToArray();
        }

    }
}
