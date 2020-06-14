using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;


namespace LAB1
{
    class Attendance
    {
        protected string _teacher;
        protected string _class;
        protected string _subject;
        public string Teacher { get { return _teacher; } }
        public string Class { get { return _class; } }
        public string Subject { get { return _subject; } }

        protected Attendance(string Teacher, string Class, string Subject)
        {
            _teacher = Teacher;
            _class = Class;
            _subject = Subject;
        }

        public static Attendance[] Create()
        {
            Random rd = new Random();

            List<Attendance> attendanceList = new List<Attendance>();

            List<string> teacherList = Readcsvjsonhelper.GetTeacherList();


            int index;
            bool flag = false;
            string classInfo;
            string subject;
            List<string> unique = new List<string>();

            for (int i = 0; i < teacherList.Count; i++)
            {

                //teacher
                string[] teacherInfo = teacherList[i].Split(',');
                string teacher = teacherInfo[0].Trim();
                string field = teacherInfo[3].Trim();
                int numberOfClass = rd.Next(4, 10);

                for (int j = 0; j < numberOfClass; j++)
                {
                    do
                    {
                        flag = false;
                        //subject
                        List<string> listOfSubject = Readcsvjsonhelper.GetFieldSubject(field);
                        index = rd.Next(listOfSubject.Count);
                        string[] subjectInfo = listOfSubject[index].Split(',');
                        subject = subjectInfo[0];
                        string level = subjectInfo[1];

                        //class
                        List<string> listOfClass = Readcsvjsonhelper.GetLevelClass(level);
                        index = rd.Next(listOfClass.Count);
                        string[] classes = listOfClass[index].Split(',');
                        classInfo = classes[0];

                        string uniqueatt = subject + classInfo;

                        for(int k = 0; k < unique.Count; k++)
                        {
                            if(unique[k].Equals(uniqueatt))
                            {
                                flag = true;
                            }
                        }

                        if(flag == false)
                        {
                            unique.Add(uniqueatt);
                        }
                    } while (flag);
                    attendanceList.Add(new Attendance(teacher, classInfo, subject));
                }
            }

            return attendanceList;



        }
    }
}
