using System;
using System.Collections.Generic;
using System.IO;

class School
{
    private List<Student> _student_list;

    public School()
    {
        _student_list = new List<Student>();
    }
    public School(Student[] student_list)
    {
        _student_list = new List<Student>(student_list);
    }
    public List<Student> GetStudents()
    {
        return _student_list;
    }
    public void setStudents(Student[] students)
    {
        _student_list = new List<Student>(students);
    }
    public void saveStudent(string filename)
    {
        String content = "ID, Name, DOB, Gender, Class\n";
        foreach (Student student in _student_list)
        {
            content += student.Uuid + ", ";
            content += student.Name + ", ";
            content += student.Birthday.ToString("dd/mm/yyyy") + ", ";
            content += student.Gender + ", ";
            content += student.Class + "\n";
        }
        File.WriteAllText(filename, content);
    }
    public void load(String filename)
    {

        String content = File.ReadAllText(filename);
        foreach (string line in content.Split('\n', StringSplitOptions.RemoveEmptyEntries))
        {
            string[] cells = line.Split(',');
            for (uint i = 0; i < cells.Length; i += 5)
            {
                //curr_stu = new Student(cells[i].Trim(), cells[i+1].Trim(), cells[i+2].Trim(), cells[i+3].Trim(), cells[i + 4].Trim());
            }
        }

    }
}

