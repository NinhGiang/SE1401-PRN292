using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class Attendance
    {
        protected string _teacher;
        protected string _classInfo;
        protected string _subject;

        public Attendance(string teacher, string classInfo, string subject)
        {
            _teacher = teacher;
            _classInfo = classInfo;
            _subject = subject;
        }
        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public string ClassInfo
        {
            get { return _classInfo; }
            set { _classInfo = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public static Attendance[] CreateAttendance()
        {
            Teacher[] teacherList = DatabaseHandler.GetTeacherList();
            Subject[] subjectList = DatabaseHandler.GetSubjectList();
            Class[] classList = DatabaseHandler.GetClassList();

            List<Attendance> list = new List<Attendance>();

            Random rand = new Random();
            foreach (Teacher teacher in teacherList)
            {
                int number = rand.Next(4, 11);
                for (int i = 0; i < number; i++)
                {
                    Class classToTeach = classList[rand.Next(classList.Length)];
                    foreach (Subject subject in subjectList)
                    {
                        if (subject.Field.Equals(teacher.Field) & subject.Level.Equals(classToTeach.Level))
                        {
                            list.Add(new Attendance(teacher.UUID, classToTeach.UUID, subject.UUID));
                        }
                    }
                }
            }
            return list.ToArray();
        }
    }
}
