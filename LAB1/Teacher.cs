using System;
using System.Collections.Generic;
using System.Text;

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
        /// Generate random birthday for a teacher.
        /// </summary>
        /// <returns>
        /// A random date in range 1/1/1960 - 12/12/1995.
        /// </returns>
        private static DateTime GenerateRandomBirthday()
        {
            Random rnd = new Random();
            DateTime start = new DateTime(1960, 1, 1);
            DateTime end = new DateTime(1995, 12, 12);
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}
