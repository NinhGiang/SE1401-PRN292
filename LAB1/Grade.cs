using System;
using System.Collections.Generic;
using System.Text;

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
            double grade = rnd.NextDouble() * 10;
            Grade newGrade = new Grade(subject.UUID, student.UUID, grade);
            gradesList.Add(newGrade);
        }
    }
}
