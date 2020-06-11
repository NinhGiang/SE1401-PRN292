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
        private Boolean  gender { get; set; }
        private String classID { get; set; }
        public int MyProperty { get; set; }
        

        //constructor to Student
        public Student(string id, string fullname, string birthday, Boolean gender, string classID)
        {
            this.id = id;
            this.fullname = fullname;
            this.birthday = birthday;
            this.gender = gender;
            this.classID = classID;
        }

        //generate random fullName base on date in json file
        public static String generateName()
        {

            Random rdn = new Random();

            String content = File.ReadAllText(@"D:\FPTedu\Summer 2020\C# & .NET\SE1401-PRN292\SchoolGenerating\StudentConfigure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            NameConfig domainName = config.NameConfig;
            int last_name_index = rdn.Next(domainName.Last_name_set.Length);
            int middle_name_index = rdn.Next(domainName.Middle_name_set.Length);
            int first_name_index = rdn.Next(domainName.First_name_set.Length);
            String fullName = domainName.Last_name_set[last_name_index] + " " 
                                 + domainName.Middle_name_set[middle_name_index]+ " "
                                 + domainName.First_name_set[first_name_index];

            return fullName;
        }

        //generate random date of birth
        private static DateTime RandomDay(String classID)
        {
            Random rdn = new Random();
            DateTime start;
            DateTime end;
            int range;
            DateTime result = new DateTime(1000,1,1);
            if (classID.Equals("10"))
            {
                start = new DateTime(2005, 1, 1);
                end = new DateTime(2001, 1, 1);
                range = (end - start).Days;
                result = start.AddDays(rdn.Next(range)); 
            } else if (classID.Equals("11"))
            {
                start = new DateTime(2004, 1, 1);
                end = new DateTime(2000, 1, 1);
                range = (end - start).Days;
                result = start.AddDays(rdn.Next(range));

            } else if (classID.Equals("12"))
            {
                start = new DateTime(2003, 1, 1);
                end = new DateTime(1999, 1, 1);
                range = (end - start).Days;
                result = start.AddDays(rdn.Next(range));
                

            }
            
            return result;

        }

        //generate random class 


        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            

            

            for (int i = 0; i < number_student; i++)
            {
                String fullname = generateName();
                String UUID = Guid.NewGuid().ToString();
                result[i] = new Student(UUID, fullname, "20", false, "10A");
            }
            return result;
        }

        public void print()
        {
            Console.WriteLine(id +  " , " + fullname);
        }
    }
}
