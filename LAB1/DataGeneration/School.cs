using System;
using System.Collections.Generic;
using System.IO;

	 class School
	{
        protected List<Student> _student_list;
        public School()
        {
            _student_list = new List<Student>();
        }
        public School(Student[] student_list)
        {
            _student_list = new List<Student>(student_list);
        }
        public void save(string filename)
        {
            String content = "ID, Name, DOB, Gender, Class\n";
            foreach (Student student in _student_list)
            {
                content += student.Uuid + ", " + student.Name + ", " 
                     + student.Birthday + ", " + student.Gender + ", " + student.Class +"\n";
            }
            File.WriteAllText(filename, content);
        }
        public void load(String filename)
        {
            Student curr_stu = null;
            String content = File.ReadAllText(filename);
            foreach (string line in content.Split('\n', StringSplitOptions.RemoveEmptyEntries))
            {
                string[] cells = line.Split(',');
                for (uint i = 0; i < cells.Length; i += 5){
                    //curr_stu = new Student(cells[i].Trim(), cells[i+1].Trim(), cells[i+2].Trim(), cells[i+3].Trim(), cells[i + 4].Trim());
                }
            }

        }
    }

