using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Dynamic;
using System.Globalization;

namespace LAB1
{
    class Student
    {
        protected String _stuuid;
        protected String _stfullname;
        protected String _stbirthday;
        protected String _stgender;
        protected String _class_info;
   

        public String StUUID { get { return _stuuid; } }
        public String StFullName { get { return _stfullname; } }
        public String StBirthday { get { return _stbirthday; } }
        public String StGender { get { return _stgender; } }
        public String Class { get { return _class_info; } }

        public Student(String StUUID, String StFullName, String StBirthday, String StGender, String class_info)
        {
            _stuuid = StUUID;
            _stfullname = StFullName;
            _stbirthday = StBirthday;
            _stgender = StGender;
            _class_info = class_info;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                String uuid = Guid.NewGuid().ToString();

                NameConfig _ = config.NameConfig;
                int last_name_set = rnd.Next(_.last_name_set.Length);
                int middle_name_set = rnd.Next(_.middle_name_set.Length);
                int first_name_set = rnd.Next(_.first_name_set.Length);
                string full_name = _.last_name_set[last_name_set] + " ";
                full_name += _.middle_name_set[middle_name_set] + " ";
                full_name += _.first_name_set[first_name_set];

                DateTime dateAndTime = RandomBirthday();
                var date = dateAndTime.Date;
                String dateStr = date.ToString();
 
                int gender = rnd.Next(0, 2);
                String genderStr = "Female";
                if(gender == 1)
                {
                    genderStr = "Male";
                }

                String class_info = Guid.NewGuid().ToString();

                result[i] = new Student(uuid, full_name,dateStr ,genderStr,class_info);
            }
            return result;
        }

        public void print()
        {
            Console.WriteLine(_stuuid + " " + _stfullname + " " + _stbirthday + " " + _stgender + " " + _class_info);
        }

        public static DateTime RandomBirthday()
        {
            Random rnd = new Random();
            DateTime from = new DateTime(1999, 1, 1);
            DateTime to = new DateTime(2005, 12, 31);
            TimeSpan range = new TimeSpan(to.Ticks - from.Ticks);
            TimeSpan rndTimeSpan = TimeSpan.FromSeconds(range.TotalSeconds - rnd.Next(0, (int)range.TotalSeconds));
            DateTime birthday = from + rndTimeSpan;
            return birthday;
        }
        
    }
}
