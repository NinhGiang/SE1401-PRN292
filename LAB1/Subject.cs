using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace LAB1
{
    /// <summary>
    /// The main Subject class.
    /// Contains all methods for generating a subject information.
    /// </summary>
    public class Subject
    {
        private string levelUUID;
        private string fieldUUID;
        private static List<Subject> subjectsList;
        /// <value>Gets the value of levelUUID.</value>
        public string LevelUUID
        {
            get
            {
                return levelUUID;
            }
        }
        /// <value>Gets the value of fieldUUID.</value>
        public string FieldUUID
        {
            get
            {
                return fieldUUID;
            }
        }
        /// <value>Gets the value of subjectsList.</value>
        public static List<Subject> SubjectsList
        {
            get
            {
                return subjectsList;
            }
        }
        public Subject(string newLevelUUID, string newFieldUUID)
        {
            levelUUID = newLevelUUID;
            fieldUUID = newFieldUUID;
        }

        /// <summary>
        /// Generate a random subject for a specific level.
        /// </summary>
        /// <param name="level">A Level object.</param>
        /// <param name="field">A Field object.</param>
        public static void Create(Level level, Field field)
        {
            if (subjectsList == null)
            {
                subjectsList = new List<Subject>();
            }
            Subject newSubject = new Subject(level.UUID, field.UUID);
            subjectsList.Add(newSubject);
        }

        /// <summary>
        /// Used to write data into file.
        /// </summary>
        /// <exception cref="System.IO.DirectoryNotFoundException">
        /// Thrown when part of a file or directory cannot be found.
        /// </exception>
        /// <param name="filename">A file used to store data.</param>
        public static void SaveSubjects(string filename)
        {
            try
            {
                String content = "LevelUUID, FieldUUID\n";
                foreach (Subject subject in subjectsList)
                {
                    content += subject.LevelUUID + ", " + subject.FieldUUID + "\n";
                }
                File.WriteAllText(filename, content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Subject _ DirectoryNotFound: " + ex.Message);
            }
        }
    }  
}
