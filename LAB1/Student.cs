using System;

namespace LAB1
{
    public class Student
    {
        protected String _UUID;
        protected String _name;
        protected String _birthday;
        protected Boolean _gender;
        protected String _class;

        public Student(String UUID, String name, String birthday, Boolean gender, String currentClass)
        {
            this._UUID = UUID;
            this._name = name;
            this._birthday = birthday;
            this._gender = gender;
            this._class = currentClass;
        }

        public String ID
        {
            get{ return _UUID; }
        }

        public String Name 
        {
            get{ return _name; }
            set{ _name = value; }
        }

        public String Birthday 
        {
            get{ return _birthday; }
            set{ _birthday = value; }
        }

        public Boolean Gender  
        {
            get{ return _gender; }
            set{ _gender = value; }
        }

        public String Class 
        {
            get{ return _class; }
            set{ _class = value; }
        }
    }
}
