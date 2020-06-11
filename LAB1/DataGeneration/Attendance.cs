using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    /// <summary>
    /// The Attendance class
    /// Contains method to create Attendance and its getter/setter/ctor.
    /// </summary>
    class Attendance
    {
        /// <summary>
        /// The 3 values of Attendance
        /// </summary>
        protected string _teacher;
        protected string _class;
        protected string _subject;
        protected static Random rnd = new Random();

        /// <summary>
        /// The getter/setter method of Attendance values
        /// </summary>
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        /// <summary>
        /// The ctor of Teacher 
        /// Has one blank ctor
        /// </summary>
        /// <param name="teacher">A string value</param>
        /// <param name="classes">A string value</param>
        /// <param name="subject">A string value</param>
        public Attendance(){ }
        public Attendance(string teacher, string classes, string subject)
        {
            _teacher = teacher;
            _class = classes;
            _subject = subject;
        }

        /// <summary>
        /// Creates a random list of attendance and returns the result
        /// </summary>
        /// <returns>An array of attendance</returns>
        public Attendance[] createAttendance()
        {
            List<Attendance> result = new List<Attendance>();
            List<string> teacherList = ListStorage.GetTeacherList();
            for (int i = 0; i < teacherList.Count; i++)
            {
                string teacher = DataGenerator.GetTeacherData(i)[0].Trim();
                string field = DataGenerator.GetTeacherData(i)[3].Trim();
                int numbOfClass = rnd.Next(4, 10);
                for (int j = 0; j < numbOfClass; j++)
                {
                    string subject = ListStorage.GetSubjectListByField(field)[0];
                    string level = ListStorage.GetSubjectListByField(field)[1];

                    string classInfo = ListStorage.GetListOfClassByLevel(level)[0];

                    result.Add(new Attendance(teacher, classInfo, subject));
                }
            }
            return result.ToArray(); 
        }

    }
}
