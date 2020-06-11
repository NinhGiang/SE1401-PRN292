using System;
using System.Collections.Generic;
using System.IO;

namespace LAB1
{
    /// <summary>
    /// The main Grade class.
    /// Contains all methods for generating a grade.
    /// </summary>
    public class Grade
    {
        private string subjectUUID;
        private string studentUUID;
        private double grade;
        private static List<Grade> gradesList;

        /// <value>Gets the value of subjectUUID.</value>
        public string SubjectUUID
        {
            get
            {
                return subjectUUID;
            }
        }

        /// <value>Gets the value of studentUUID.</value>
        public string StudentUUID
        {
            get
            {
                return studentUUID;
            }
        }

        /// <value>Gets the value of grade.</value>
        public double GradeProp
        {
            get
            {
                return grade;
            }
        }

        /// <value>Gets the value of gradesList.</value>
        public List<Grade> GradesList
        {
            get
            {
                return gradesList;
            }
        }

        public Grade(string newSubjectUUID, string newStudentUUID, double newGrade)
        {
            subjectUUID = newSubjectUUID;
            studentUUID = newStudentUUID;
            grade = newGrade;
        }

        /// <summary>
        /// Generate a random grade for a specific student.
        /// </summary>
        /// <param name="subject">A Subject object.</param>
        /// <param name="student">A Student object.</param>
        public static void Create(Subject subject, Student student)
        {
            if (gradesList == null)
            {
                gradesList = new List<Grade>();
            }
            Random rnd = new Random();
            double grade = Math.Round(rnd.NextDouble() * 10, 1);
            Grade newGrade = new Grade(subject.UUID, student.UUID, grade);
            gradesList.Add(newGrade);
        }

        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveGrades(string filename)
        {
            try
            {
                String content = "SubjectUUID, StudentUUID, Grade\n";
                foreach (Grade grade in gradesList)
                {
                    content += grade.StudentUUID + ", " + grade.StudentUUID + ", " + grade.GradeProp + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Grade _ DirectoryNotFound: " + ex.Message);
            }
        }
    }
}
