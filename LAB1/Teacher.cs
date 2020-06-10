using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Teacher class.
    /// Contains all methods for generating a teacher information.
    /// </summary>
    public class Teacher
    {
        private string uuid;
        private string name;
        private bool gender;
        private string fieldUUID;
        private static List<Teacher> teacherList;

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
        /// <value>Gets the value of Gender.</value>
        public bool Gender
        {
            get
            {
                return gender;
            }
        }
        /// <value>Gets the value of FieldUUID.</value>
        public string FieldUUID
        {
            get
            {
                return fieldUUID;
            }
        }
        /// <value>Gets the value of TeacherList.</value>
        public static List<Teacher> TeacherList
        {
            get
            {
                return teacherList;
            }
        }
        public Teacher(string newUUID, string newName, bool newGender, string newFieldUUID)
        {
            uuid = newUUID;
            name = newName;
            gender = newGender;
            fieldUUID = newFieldUUID;
        }

        /// <summary>
        /// Generate random information of a teacher.
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
        /// <param name="field">A Field object.</param>
        public static void Create(Field field)
        {
            try
            {
                if (teacherList == null)
                {
                    teacherList = new List<Teacher>();
                }
                string content = File.ReadAllText(@"..\..\..\SchoolConfigure.json");
                SchoolConfigure config = JsonSerializer.Deserialize<SchoolConfigure>(content);
                Random rnd = new Random();
                NameConfig randomName = config.NameConfig;
                int lastNameIndex = rnd.Next(randomName.LastNameSet.Length);
                int noOfMiddleName = rnd.Next(3);
                string fullName = randomName.LastNameSet[lastNameIndex] + " ";
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
                Teacher newTeacher = new Teacher(Guid.NewGuid().ToString(), fullName, gender, field.UUID);
                teacherList.Add(newTeacher);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Teacher _ NullReference: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Teacher _ FileNotFound: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Teacher _ Json: " + ex.Message);
            }
        }

        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveTeachers(string filename)
        {
            String content = "UUID, Name, Gender, FieldUUID\n";
            foreach (Teacher teacher in teacherList)
            {
                content += teacher.UUID + ", " + teacher.Name + ", " + teacher.Gender + ", " + teacher.FieldUUID + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
