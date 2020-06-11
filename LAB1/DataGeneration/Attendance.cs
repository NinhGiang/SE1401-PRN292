using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.DataGeneration
{
    class Attendance
    {
        protected string _teacher;
        protected string _class;
        protected string _subject;
        protected static Random rnd = new Random();
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
        public Attendance()
        {

        }
        public Attendance(string teacher, string classes, string subject)
        {
            _teacher = teacher;
            _class = classes;
            _subject = subject;
        }
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
