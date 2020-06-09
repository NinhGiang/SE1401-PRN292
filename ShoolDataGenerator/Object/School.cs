using LAB1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLab1.Object
{
    class School
    {
        public string Name { get; set; }
        public IList<Student> ListStudent{ get; set; }
        public IList<Class> ListClass { get; set; }
        public IList<Teacher> ListTeacher { get; set; }
        public IList<Subject> ListSubject{ get; set; }
    }
}
