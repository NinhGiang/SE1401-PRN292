using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;

namespace LAB1
{
    class School
    {
        private static List<Student> _students_list;
        private static List<Level> _levels_list;
        public List<Student> Schools { get { return _students_list; } }
        public List<Level> Level { get { return _levels_list; } }


        //public School(Student[] student)
        //{
        //    _students_list = new List<Student>(student);
        //    
        //}
        public static void SetLevelList(Level[] levels)
        {
            _levels_list = new List<Level>(levels);
        }
        public static void SetStudentList(Student[] students)
        {
            _students_list = new List<Student>(students);
        }
        public static void SaveStudent(string filename)
        {
            String content = "";
         //   if (Path.GetExtension(filename) == ".csv")
           // {
                content += "ID, Fullname,Birthday,Gender\n";
                foreach (Student student in _students_list)
                {
                    content += student.ID + ", " + student.FullName + ", " + student.Birthday+ ", " + student.Gender +"\n" ;
                }
            
            //   }
            //else if (Path.GetExtension(filename) == ".json")
            //{
            //    content = JsonConvert.SerializeObject(this, Formantting Indented);
            //}
            File.WriteAllText(filename, content);

        }
        public static void SaveLevel(string filename)
        {
            String content1 = "";
            content1 += "ID, Fullname,Levle\n";
            foreach (Level level in _levels_list)
            {
                content1 += level.ID + ", " + level.Name + "\n";
            }
            File
                .WriteAllText(filename, content1);
        }

    }
}
