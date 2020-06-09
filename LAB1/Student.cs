using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Dynamic;

namespace LAB1
{
    class Student
    {
        protected String _stuuid;
        protected String _stfullname;
        protected DateTime _stbirthday;
        protected Boolean _stgender;

        public String StUUID { get { return _stuuid; } }
        public String StFullName { get { return _stfullname; } }
        public DateTime StBirthday { get { return _stbirthday; } }
        public Boolean StGender { get { return _stgender; } }

        protected Student(String StUUID, String StFullName, DateTime StBirthday, Boolean StGender)
        {
            _stuuid = StUUID;
            _stfullname = StFullName;
            _stbirthday = StBirthday;
            _stgender = StGender;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for (uint i = 0; i < number_student; i++)
            {
                NameConfig _ = config.NameConfig;
                int last_name_set = rnd.Next(_.last_name_set.Length);
                int middle_name_set = rnd.Next(_.middle_name_set.Length);
                int first_name_set = rnd.Next(_.first_name_set.Length);
                string full_name = _.last_name_set[last_name_set] + " ";
                full_name += _.middle_name_set[middle_name_set] + " ";
                full_name += _.first_name_set[first_name_set];
            }
        }

        public void print()
        {
            Console.WriteLine(_stuuid + " " + _stfullname + " " + _stbirthday);
        }
    }
}
