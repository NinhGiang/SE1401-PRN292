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

        /// <value>
        /// The teacher id
        /// </value>
        public string Teacher { get { return _teacher; } }

        /// <value>
        /// The class id which the teacher teaches
        /// </value>
        public string Class { get { return _class; } }

        /// <value>
        /// The subject id which the teacher teaches
        /// </value>
        public string Subject { get { return _subject; } }

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
            List<string> listOfTeacher = FileHelper.GetListOfTeacher();
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
                    List<string> listOfSubject = FileHelper.GetListOfSubjectByField(field);
                    index = rnd.Next(listOfSubject.Count);
                    string[] subjectInfo = listOfSubject[index].Split(',');
                    string subject = subjectInfo[0];
                    string level = subjectInfo[1];

                    //class
                    List<string> listOfClass = FileHelper.GetListOfClassByLevel(level);
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