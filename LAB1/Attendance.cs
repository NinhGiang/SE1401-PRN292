﻿using System;
using System.Collections.Generic;

namespace LAB1
{
    public class Attendance
    {
        protected String _teacher;
        protected String _class;
        protected String _subject;

        public string GetTeacher()
        { return _teacher; }

        public void SetTeacher(string value)
        { _teacher = value; }

        public string GetClassInfo()
        { return _class; }

        public void SetClassInfo(string value)
        { _class = value; }

        public string GetSubject()
        { return _subject; }

        public void SetSubject(string value)
        { _subject = value; }

        public Attendance() { }

        public Attendance(String teacher, String classInfo, String subject)
        {
            _teacher = teacher;
            _class = classInfo;
            _subject = subject;
        }

        public static Attendance[] Create()
        {
            Random rnd = new Random();
            List<string> listOfTeacher = DataHelper.GetListOfTeacher();
            int numberOfTeacher = listOfTeacher.Count;
            //Attendance[] result = new Attendance[numberOfTeacher];
            List<Attendance> list = new List<Attendance>();
            int index;

            for(int i = 0; i < listOfTeacher.Count; i++)
            {
                //int count = 0;
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

                    list.Add(new Attendance(teacher + " (" + teacherInfo[1] + ")"
                        , classInfo + " (" + classes[2] + ")"
                        , subject + " (" + subjectInfo[3] + ")"
                        ));
                }

            }
            return list.ToArray();
        }
    }
}