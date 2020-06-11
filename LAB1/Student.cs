using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Student class.
    /// Contains all methods for generating a student information.
    /// </summary>
    public class Student
    {
        private string uuid;
        private string name;
        private DateTime birthday;
        private bool gender;
        private string classUUID;
        private static List<Student> studentsList;

        /// <value>Gets the value of uuid.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of name.</value>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <value>Gets the value of birthday.</value>
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
        }
        /// <value>Gets the value of gender.</value>
        public bool Gender
        {
            get
            {
                return gender;
            }
        }
        /// <value>Gets the value of classUUID.</value>
        public string ClassUUID
        {
            get
            {
                return classUUID;
            }
        }
        /// <value>Gets the value of studentsList.</value>
        public static List<Student> StudentList
        {
            get
            {
                return studentsList;
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
        /// Generate random birthday for a student.
        /// </summary>
        /// <returns>
        /// A random date in range depends on student's level.
        /// </returns>
        /// <param name="start">A Datatime date.</param>
        /// <param name="end">A Datetime date.</param>
        private static DateTime GenerateRandomBirthday(DateTime start, DateTime end)
        {
            Random rnd = new Random();
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        /// <summary>
        /// Generate random information of a student.
        /// </summary>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when an object does not exist but it is used.
        /// </exception>
        /// <exception cref="System.IO.FileNotFoundException">
        /// Thrown when the file is not found (wrong path, wrong filename or file is not existed).
        /// </exception>
        /// <exception cref="System.Text.Json.JsonException">
        /// Thrown when cannot parse a value in Json file into an instance.
        /// </exception>
        /// <param name="classObject">A Class object.</param>
        public static void Create(Class classObject)
        {
            try
            {
                if (studentsList == null)
                {
                    studentsList = new List<Student>();
                }
                string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
                SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
                Random rnd = new Random();
                //for (int i = 0; i < noOfStudents; i++)
                //{
                NameConfig randomName = config.NameConfig;
                int lastNameIndex = rnd.Next(randomName.LastNameSet.Length);
                int noOfMiddleName = rnd.Next(3);
                string fullName = randomName.LastNameSet[lastNameIndex] + " ";
                DateTime start;
                DateTime end;
                if (classObject.Name.Contains("10"))
                {
                    start = new DateTime(2001, 1, 1);
                    end = new DateTime(2005, 12, 12);
                }
                else if (classObject.Name.Contains("11"))
                {
                    start = new DateTime(2000, 1, 1);
                    end = new DateTime(2004, 12, 12);
                }
                else
                {
                    start = new DateTime(1999, 1, 1);
                    end = new DateTime(2003, 12, 12);
                }
                DateTime birthday = GenerateRandomBirthday(start, end);
                bool gender;

                if (rnd.NextDouble() > 0.5)
                {
                    gender = false;
                    int femaleFirstNameIndex = rnd.Next(randomName.FemaleFirstNameSet.Length);
                    if (noOfMiddleName > 0)
                    {
                        for (int j = 0; j < noOfMiddleName; j++)
                        {
                            int femaleMiddleNameIndex = rnd.Next(randomName.FemaleMiddleNameSet.Length);
                            fullName += randomName.FemaleMiddleNameSet[femaleMiddleNameIndex] + " ";
                        }
                    }
                    fullName += randomName.FemaleFirstNameSet[femaleFirstNameIndex];                   
                } //end if gender is false
                else
                {
                    gender = true;
                    int maleFirstNameIndex = rnd.Next(randomName.MaleFirstNameSet.Length);
                    if (noOfMiddleName > 0)
                    {
                        for (int j = 0; j < noOfMiddleName; j++)
                        {
                            int maleMiddleNameIndex = rnd.Next(randomName.MaleMiddleNameSet.Length);
                            fullName += randomName.MaleMiddleNameSet[maleMiddleNameIndex] + " ";
                        }
                    }
                    fullName += randomName.MaleFirstNameSet[maleFirstNameIndex];
                } //end if gender is true
                Student newStudent = new Student(Guid.NewGuid().ToString(), fullName, birthday, gender, classObject.UUID);
                studentsList.Add(newStudent);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Student _ NullReference: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Student _ FileNotFound: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Student _ Json: " + ex.Message);
            }
        }

        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveStudents(string filename)
        {
            try
            {
                String content = "UUID, Name, Birthday, Gender, ClassUUID\n";
                foreach (Student student in studentsList)
                {
                    content += student.UUID + ", " + student.Name + ", " + student.Birthday + ", " + student.Gender + ", " + student.ClassUUID + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Student _ DirectoryNotFound: " + ex.Message);
            }           
        }
    }
}
