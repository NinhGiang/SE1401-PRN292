using System;
using System.Collections.Generic;

namespace LAB1
{
    /// <summary>
    /// The Attendance class
    /// Contains create method and properties of Attendance. 
    /// </summary>
    public class Attendance
    {
        /// <summary>
        /// Id of teacher
        /// </summary>
        protected String _teacher;

        /// <summary>
        /// Id of class
        /// </summary>
        protected String _class;

        /// <summary>
        /// Id of subject
        /// </summary>
        protected String _subject;

        /// <summary>
        /// Get teacher's Id
        /// </summary>
        /// <returns>The Id of teacher</returns>
        public string GetTeacher()
        { return _teacher; }

        /// <summary>
        /// Set teacher's Id
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetTeacher(string value)
        { _teacher = value; }

        /// <summary>
        /// Get class's Id
        /// </summary>
        /// <returns>The Id of class</returns>
        public string GetClassInfo()
        { return _class; }

        /// <summary>
        /// Set class's Id
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetClassInfo(string value)
        { _class = value; }

        /// <summary>
        /// Get subject's Id
        /// </summary>
        /// <returns>The Id of subject</returns>
        public string GetSubject()
        { return _subject; }

        /// <summary>
        /// Set subject's Id
        /// </summary>
        /// <param name="value">A string value</param>
        public void SetSubject(string value)
        { _subject = value; }

        /// <summary>
        /// An empty constructor for attendance
        /// </summary>
        public Attendance() { }

        /// <summary>
        /// A constructor for attendance
        /// </summary>
        /// <param name="teacher">A string value</param>
        /// <param name="classInfo">A string value</param>
        /// <param name="subject">A string value</param>
        public Attendance(String teacher, String classInfo, String subject)
        {
            _teacher = teacher;
            _class = classInfo;
            _subject = subject;
        }

        /// <summary>
        /// Creates a list of data teachers teach which classes and which subjects; and return the result
        /// </summary>
        /// <returns>An array of Attendance</returns>
        public static Attendance[] Create()
        {
            Random rnd = new Random();
            List<string> listOfTeacher = DataHelper.GetListOfTeacher();
            List<Attendance> list = new List<Attendance>();
            int index;

            for (int i = 0; i < listOfTeacher.Count; i++)
            {
                //teacher
                string[] teacherInfo = listOfTeacher[i].Split(',');
                string teacher = teacherInfo[0].Trim();
                string field = teacherInfo[3].Trim();
                int numberOfClass = rnd.Next(4, 10);

                for (int j = 0; j < numberOfClass; j++)
                {
                    //subject
                    List<string> listOfSubject = DataHelper.GetListOfSubjectByField(field);
                    index = rnd.Next(listOfSubject.Count);
                    string[] subjectInfo = listOfSubject[index].Split(',');
                    string subject = subjectInfo[0];
                    string level = subjectInfo[1];

                    //class
                    List<string> listOfClass = DataHelper.GetListOfClassByLevel(level);
                    index = rnd.Next(listOfClass.Count);
                    string[] classes = listOfClass[index].Split(',');
                    string classInfo = classes[0];

                    list.Add(new Attendance(teacher, classInfo, subject));
                }
            }
            return list.ToArray();
        }
    }
}