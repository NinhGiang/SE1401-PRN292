using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list = Student.Create(52);
            Field[] field_list = Field.Create();
            Teacher[] teacher_list = Teacher.Create(10, field_list);
            Level[] level_list = Level.Create();
            Subject[] subject_list = Subject.Create(level_list, field_list);
            Grade[] grade_list = Grade.GradeCreate(student_list, subject_list);

            Container.StudentContainer stCon = new Container.StudentContainer(student_list);
            stCon.StudentSave(@"..\..\..\CSVPackage\Student.csv");
            Container.FieldContainer fldCon = new Container.FieldContainer(field_list);
            fldCon.FieldSave(@"..\..\..\CSVPackage\Field.csv");
            Container.TeacherContainer tcCon = new Container.TeacherContainer(teacher_list);
            tcCon.TeacherSave(@"..\..\..\CSVPackage\Teacher.csv");
            Container.LevelContainer lvlCon = new Container.LevelContainer(level_list);
            lvlCon.LevelSave(@"..\..\..\CSVPackage\Level.csv");
            Container.SubjectContainer subCon = new Container.SubjectContainer(subject_list);
            subCon.SubjectSave(@"..\..\..\CSVPackage\Subject.csv");
            Container.GradeContainer grdCon = new Container.GradeContainer(grade_list);
            grdCon.GradeSave(@"..\..\..\CSVPackage\Grade.csv");
            Console.ReadLine();
        }
    }
}
