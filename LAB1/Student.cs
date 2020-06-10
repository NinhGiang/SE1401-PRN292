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
    class Student
    {
        private string uuid;
        private string name;
        private DateTime birthday;
        private bool gender;
        private string classUUID;
        private static List<Student> studentList;

        /// <value>Gets the value of UUID.</value>
        public string UUID
        {
            get
            {
                return uuid;
            }
        }
        /// <value>Gets the value of Name.</value>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <value>Gets the value of Birthday.</value>
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
        }
        /// <value>Gets the value of Gender.</value>
        public bool Gender
        {
            get
            {
                return gender;
            }
        }
        /// <value>Gets the value of ClassUUID.</value>
        public string ClassUUID
        {
            get
            {
                return classUUID;
            }
        }
        /// <value>Gets the value of StudentList.</value>
        public static List<Student> StudentList
        {
            get
            {
                return studentList;
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
        /// <returns>
        /// A random date in range 1/1/2003-12/12/2005.
        /// </returns>
        private static DateTime GenerateRandomBirthday()
        {
            Random rnd = new Random();
            DateTime start = new DateTime(2003, 1, 1);
            DateTime end = new DateTime(2005, 12, 12);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        /// <summary>
        /// Generate random number of students.
        /// </summary>
        /// <param name="noOfStudents">A positive integer number.</param>
        /// <returns>
        /// A list of Student objects
        /// </returns>
        /// <exception cref="System.NullReferenceException">
        /// Thrown when the object in Json file does not exist or has no data.
        /// </exception>
        public static void Create(int noOfStudents, Class classObject)
        {
            try
            {
                //if (noOfStudents >= 500 && noOfStudents <= 3000)
                //{
                if (studentList == null)
                {
                    studentList = new List<Student>();
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
                    DateTime birthday = GenerateRandomBirthday();
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
                        Student newStudent = new Student(Guid.NewGuid().ToString(), fullName, birthday, gender, classObject.UUID);
                        studentList.Add(newStudent);
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
                        Student newStudent = new Student(Guid.NewGuid().ToString(), fullName, birthday, gender, classObject.UUID);
                        studentList.Add(newStudent);
                    } //end if gender is true
                //} //end for each index in result array

                //} //end if noOfStudents in range 500-3000
                /*else
                {
                    return null;
                } //end if noOfStudents is out-of-range*/
                //}
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Student _ NullReference: " + ex.Message);
            }
        }
        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveStudents(string filename)
        {
            String content = "UUID, Name, Birthday, Gender, ClassUUID\n";
            foreach (Student student in studentList)
            {
                content += student.UUID + ", " + student.Name + ", " + student.Birthday + ", " + student.Gender + ", " + student.ClassUUID + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
