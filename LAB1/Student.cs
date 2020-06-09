using System;
using System.Collections.Generic;
using System.Text;

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


    }
}
