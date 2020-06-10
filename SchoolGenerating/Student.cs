using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.IO;
using System.Text.Json;



namespace SchoolGenerating
{
    class Student
    {
        private String id { get; set; }
        private String fullname { get; set; }
        private String birthday { get; set; }
        private String gender { get; set; }
        private String _class { get; set; }
        public int MyProperty { get; set; }

        public Student(string id, string fullname, string birthday, string gender, string _class)
        {
            this.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.gender = gender;
            this._class = _class;
        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            String content = File.ReadAllText(@"D:\FPTedu\Summer 2020\C# & .NET\SE1401-PRN292\SchoolGenerating\StudentConfigure.json");
            StudentConfigure config = JsonSerializer.Deserialize<StudentConfigure>(content);

            Random rdn = new Random();

            for (int i = 0; i < number_student; i++)
            {
                NameConfig domainName = config.NameCongfig;
                int last_name_index = rdn.Next(domainName.Last_name_set.Length);
                int middle_name_index = rdn.Next(domainName.Middle_name_set.Length);
                int first_name_index = rdn.Next(domainName.First_name_set.Length);
                String fullname = domainName.Last_name_set[last_name_index];
                fullname += domainName.Middle_name_set[middle_name_index];
                fullname += domainName.First_name_set[first_name_index];
                String UUID = Guid.NewGuid().ToString();
                result[i] = new Student(UUID, fullname, "20", "male", "10A");
            }
            return result;
        }

        public void print()
        {
            Console.WriteLine(id +  " , " + fullname);
        }
    }
}
