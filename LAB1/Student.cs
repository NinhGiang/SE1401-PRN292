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

        /// <summary>
        /// Gets Id of student
        /// </summary>
        /// <returns>
        /// The Id of student
        /// </returns>
        public string GetId()
        { return _id; }

        /// <summary>
        /// Sets Id of student
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetId(string value)
        { _id = value; }

        /// <summary>
        /// Gets name of student
        /// </summary>
        /// <returns>
        /// The name of student
        /// </returns>
        public string GetName()
        { return _name; }

        /// <summary>
        /// Sets name of student
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetName(string value)
        { _name = value; }

        /// <summary>
        /// Gets birthday of student
        /// </summary>
        /// <returns>
        /// The birthdate of student
        /// </returns>
        public DateTime GetBirthdate()
        { return _birthdate; }

        /// <summary>
        /// Sets birthday of student
        /// </summary>
        /// <param name="value">A Datetime value</param>
        public void SetBirthdate(DateTime value)
        { _birthdate = value; }

        /// <summary>
        /// Gets gender of student
        /// </summary>
        /// <returns>The gender of student</returns>
        public bool GetGender()
        { return _gender; }

        /// <summary>
        /// Sets gender of student
        /// </summary>
        /// <param name="value">A boolean value</param>
        public void SetGender(bool value)
        { _gender = value; }

        /// <summary>
        /// Gets class student attend
        /// </summary>
        /// <returns>The class student attend</returns>
        public string GetClassInfo()
        { return _class; }

        /// <summary>
        /// Sets class student attend
        /// </summary>
        /// <param name="value">The class student attend</param>
        public void SetClassInfo(string value)
        { _class = value; }

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
            int index;

            for (int i = 0; i < numberOfStudent; i++)
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

                result.Add(new Student(uuid, fullName, birthdate, gender, classInfo));
            }
            return result.ToArray();
        }

    }
}
