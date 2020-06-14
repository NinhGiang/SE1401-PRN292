using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB1.Container
{
    class GradeContainer
    {
        private List<Grade> _grade_list;

        public GradeContainer(Grade[] grade)
        {
            _grade_list = new List<Grade>(grade);
        }

        public void GradeSave(String filename)
        {
            String content = "Subject name, Student name, Grade\n";
            foreach (Grade grade in _grade_list)
            {
                content += grade.Subject_info + ", " + grade.Student_info + ", " + grade.Grade_info + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
