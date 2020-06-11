using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student_list = Student.Create(10);
            Field[] field_list = Field.Create();
            Teacher[] teacher_list = Teacher.Create(10, field_list);
            Level[] level_list = Level.Create();

            Container.StudentContainer stCon = new Container.StudentContainer(student_list);
            stCon.StudentSave(@"..\..\..\CSVPackage\Student.csv");
            Container.FieldContainer fldCon = new Container.FieldContainer(field_list);
            fldCon.FieldSave(@"..\..\..\CSVPackage\Field.csv");
            Container.TeacherContainer tcCon = new Container.TeacherContainer(teacher_list);
            tcCon.TeacherSave(@"..\..\..\CSVPackage\Teacher.csv");
            Container.LevelContainer lvlCon = new Container.LevelContainer(level_list);
            lvlCon.LevelSave(@"..\..\..\CSVPackage\Level.csv");
            Console.ReadLine();
        }
    }
}
