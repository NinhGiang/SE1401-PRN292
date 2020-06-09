using System;
using System.IO;
using System.Text.Json;

namespace LAB1_SE140056
{
    /// <summary>
    /// The main Student class.
    /// Contains all methods for generating a student information.
    /// </summary>
    class Student
    {
        private string uuid;
        private string name;
        private DateTime birthday;
        private bool gender;
        private string classUUID;
        public string UUID { 
            get 
            { 
                return uuid; 
            } 
        }
        public string Name { 
            get 
            { 
                return name; 
            } 
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
        }
        public bool Gender
        {
            get
            {
                return gender;
            }
        }
        public string ClassUUID
        {
            get
            {
                return classUUID;
            }
        }
        public Student(string newUUID, string newName, DateTime newBirthday, bool newGender, string newClassUUID)
        {
            uuid = newUUID;
            name = newName;
            birthday = newBirthday;
            gender = newGender;
            classUUID = newClassUUID;
        }
        /// <summary>
        /// Generate random birthday of students.
        /// </summary>
        public static DateTime RandomBirthday()
        {
            Random rnd = new Random();
            DateTime start = new DateTime(2002, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        /// <summary>
        /// Generate random amount of students.
        /// </summary>
        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
            SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                NameConfig randomName = config.NameConfig;
                int lastNameIndex = rnd.Next(randomName.LastNameSet.Length);
                string fullName = randomName.LastNameSet[lastNameIndex] + " ";
                DateTime birthday = RandomBirthday();
                bool gender;
                if (rnd.NextDouble() > 0.5)
                {
                    gender = false;
                    int femaleFirstNameIndex = rnd.Next(randomName.FemaleFirstNameSet.Length);
                    int femaleMiddleNameIndex = rnd.Next(randomName.FemaleMiddleNameSet.Length);
                    fullName += randomName.FemaleMiddleNameSet[femaleMiddleNameIndex] + " ";
                    fullName += randomName.FemaleFirstNameSet[femaleFirstNameIndex];
                    result[i] = new Student(Guid.NewGuid().ToString(), fullName, birthday, gender, Guid.NewGuid().ToString());
                }
                else
                {
                    gender = true;
                    int maleFirstNameIndex = rnd.Next(randomName.MaleFirstNameSet.Length);
                    int maleMiddleNameIndex = rnd.Next(randomName.MaleMiddleNameSet.Length);
                    fullName += randomName.FemaleMiddleNameSet[maleMiddleNameIndex] + " ";
                    fullName += randomName.FemaleFirstNameSet[maleFirstNameIndex];
                    result[i] = new Student(Guid.NewGuid().ToString(), fullName, birthday, gender, Guid.NewGuid().ToString());
                }                
            }
            return result;
        }
    }
}
