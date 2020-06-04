using System;
namespace DataGeneration
{
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
                     + student.Birthday + ", " + student.Gender + ", " + studentClass +"\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
