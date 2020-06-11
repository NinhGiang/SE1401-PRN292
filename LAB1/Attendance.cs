using System;
using System.Collections.Generic;
using System.IO;

namespace LAB1
{
    /// <summary>
    /// The main Attendance class.
    /// Contains all methods for generating attendance information of a teacher.
    /// </summary>
    public class Attendance
    {
        private string teacherUUID;
        private string classUUID;
        private string subjectUUID;
        private static List<Attendance> attendancesList;

        /// <value>Gets the value of TeacherUUID.</value>
        public string TeacherUUID
        {
            get
            {
                return teacherUUID;
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

        /// <value>Gets the value of SubjectUUID.</value>
        public string SubjectUUID
        {
            get
            {
                return subjectUUID;
            }
        }

        /// <value>Gets the value of AttendancesList.</value>
        public static List<Attendance> AttendancesList
        {
            get
            {
                return attendancesList;
            }
        }

        public Attendance(string newTeacherUUID, string newClassUUID, string newSubjectUUID)
        {
            teacherUUID = newTeacherUUID;
            classUUID = newClassUUID;
            subjectUUID = newSubjectUUID;
        }

        /// <summary>
        /// Generate a random attendance for a teacher.
        /// </summary>
        /// <param name="teacher">A Teacher object.</param>
        /// <param name="classObject">A Class object.</param>
        /// <param name="subject">A Subject object.</param>
        public static void Create(Teacher teacher, Class classObject, Subject subject)
        {
            if (attendancesList == null)
            {
                attendancesList = new List<Attendance>();
            }
            Attendance newAttendance = new Attendance(teacher.UUID, classObject.UUID, subject.UUID);
            attendancesList.Add(newAttendance);
        }

        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveAttendances(string filename)
        {
            try
            {
                String content = "TeacherUUID, ClassUUID, SubjectUUID\n";
                foreach (Attendance attendance in attendancesList)
                {
                    content += attendance.TeacherUUID + ", " + attendance.ClassUUID + ", " + attendance.SubjectUUID + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Attendance _ DirectoryNotFound: " + ex.Message);
            }
        }
    }
}
