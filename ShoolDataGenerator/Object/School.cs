using LAB1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyLab1.Object
{
    class School
    {
        public string Name { get; set; }
        public IList<Student> ListStudent { get; }
        public IList<Class> ListClass { get; }
        public IList<Teacher> ListTeacher { get; }
        public IList<Subject> ListSubject { get; }
        public IList<Level> ListLevel { get; }
        public IList<Grade> ListGrade { get; }
        public IList<Room> ListRoom { get; }
        public IList<Attendence> ListAttendence { get; }
        public IList<Field> ListFeild { get; }

        public School(string name)
        {
            Name = name;
            ListStudent = new List<Student>();
            ListClass = new List<Class>();
            ListTeacher = new List<Teacher>();
            ListSubject = new List<Subject>();
            ListLevel = new List<Level>();
            ListGrade = new List<Grade>();
            ListRoom = new List<Room>();
            ListAttendence = new List<Attendence>();
            ListFeild = new List<Field>();
        }
    }
}
