using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;



namespace LAB1
{
    class Student
    {
        private String id { get; set; }
        private String fullname { get; set; }
        private String birthday { get; set; }
        private String gender { get; set; }
        private String _class { get; set; }
        public int MyProperty { get; set; }

        public Student(string id, string fullname, string birthday, string gender, string _class)
        {
            this.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.gender = gender;
            this._class = _class;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            String content = File.ReadAllText(@"..\..\..\StudentConfigure.json");
            
            return result;
        }
    }
}
