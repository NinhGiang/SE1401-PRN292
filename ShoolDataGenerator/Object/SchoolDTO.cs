using LAB1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MyLab1.Object
{
    class SchoolDTO
    {
        public string Name { get; set; }
        public IList<StudentDTO> ListStudent { get; }
        public IList<ClassDTO> ListClass { get; }
        public IList<TeacherDTO> ListTeacher { get; }
        public IList<SubjectDTO> ListSubject { get; }
        public IList<LevelDTO> ListLevel { get; }
        public IList<GradeDTO> ListGrade { get; }
        public IList<RoomDTO> ListRoom { get; }
        public IList<AttendenceDTO> ListAttendence { get; }
        public IList<FieldDTO> ListFeild { get; }

        public SchoolDTO(string name)
        {
            Name = name;
            ListStudent = new List<StudentDTO>();
            ListClass = new List<ClassDTO>();
            ListTeacher = new List<TeacherDTO>();
            ListSubject = new List<SubjectDTO>();
            ListLevel = new List<LevelDTO>();
            ListGrade = new List<GradeDTO>();
            ListRoom = new List<RoomDTO>();
            ListAttendence = new List<AttendenceDTO>();
            ListFeild = new List<FieldDTO>();
        }
    }
}
