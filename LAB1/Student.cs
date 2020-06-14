using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;


namespace StudentGeneration
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        protected DateTime _birth;
        protected bool _gender;
        protected string _class;
        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }
        public string Class { get { return _class; } }
        public DateTime Birth { get { return _birth; } }
        public bool Gender { get { return _gender; } }

        protected Student(string ID, string FullName, DateTime Birth, bool Gender, string Class)
        {
            _id = ID;
            _fullname = FullName;
            _birth = Birth;
            _gender = Gender;
            _class = Class;
        }

        public static Student[] Create(uint number_student)
        {
            try
            {
                List<Student> studentList = new List<Student>();
                string content = File.ReadAllText(@"..\..\..\Configure.json");
                Configure config = JsonSerializer.Deserialize<Configure>(content);

                //generate rnd for random purpose
                Random rnd = new Random();

                // a flag unit for counting how much student have been generated
                int totalstudentamount = 0;

                //get Class's list for takeing classinfo
                List<string> classList = Readcsvjsonhelper.GetClassList();

                for (int i = 0; i < classList.Count; i++)
                {
                    //a variable for counting how much student should have in a single class
                    int studentAmount = 0;
                    
                    //splitting a string into an array
                    string[] classinfo = classList[i].Split(',');
                    string classid = classinfo[0].Trim();
                    //use readcsvjsonhelper class to get level name by using level id as parameter
                    string level = Readcsvjsonhelper.GetLevelName(classinfo[1].Trim());

                    // if i == (classList.Count - 1) means if a loop reach a last class, number of student will be total student subtracts with totalstudentamount
                    if (i == (classList.Count - 1))
                    {
                        studentAmount = number_student - totalstudentamount;
                    }
                    else
                    {
                        studentAmount = rnd.Next(30, 51);
                    }

                    for (int j = 0; j < studentAmount; j++)
                    {
                        //id
                        String uuid = Guid.NewGuid().ToString();

                        //birthday
                        DateTime birthday = Readcsvjsonhelper.GetRandomBirthday(level);

                        //gender
                        bool gender = !(rnd.Next(2) == 2);

                        //name
                        string fullname = Readcsvjsonhelper.GetNameforGender(gender);

                        studentList.Add(new Student(uuid, fullname, birthday, gender, classid));

                        totalstudentamount++;
                    }


                    result[i] = new Student(uuid,null,null,false,null);
                }
                return result;
            }
            catch( FileNotFoundException ex)
            {
                Console.WriteLine("Student _ FileNotFoundException" + ex.Message);
            }
            
        }
        public void print()
        {
            Console.WriteLine(_id+1 + " " + _fullname);
        }
    }
}
