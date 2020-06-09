using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Lab_1
{
    class Student
    {
        protected string _id;
        protected string _fullname;
        protected bool _gender;
        protected DateTime _birthday;
        protected string _UUID;
        protected string _classUUID;
        public string ID { get { return _id; } }
        public string FullName { get { return _fullname; } }

        protected Student(string ID, string FullName, bool gender, DateTime birthday, string classUUID)
        {
            _id = ID;
            _fullname = FullName;
            _gender = gender;
            _birthday = birthday;
            _classUUID = classUUID;

        }

        public static Student[] Create(uint number_student)
        {
            Student[] result = new Student[number_student];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configured config = JsonSerializer.Deserialize<Configured>(content);
            bool gender;
            DateTime birthday = new DateTime(1999, 30, 10);
            Random rnd = new Random();
            
            for (uint i = 0; i < number_student; i++)
            {
                NameConfig _ = config.NameConfig;
                int FamilyNameSet_index = rnd.Next(_.FamilyNameSet.Length);
                if (rnd.NextDouble() > 0.5)
                {
                    gender = true;
                    int FemaleMiddleNameSet_index = rnd.Next(_.FemaleMiddleNameSet.Length);
                    int FemaleNameSet_index = rnd.Next(_.FemaleNameSet.Length);
                    string female_full_name = _.FamilyNameSet[FamilyNameSet_index] + " ";
                    female_full_name += _.FemaleMiddleNameSet[FemaleNameSet_index] + " ";
                    female_full_name += _.FemaleNameSet[FemaleNameSet_index];
                    result[i] = new Student(Guid.NewGuid().ToString(), female_full_name, gender, birthday, Guid.NewGuid().ToString());
                }
                else
                {
                    gender = false;
                    int MaleMiddleNameSet_index = rnd.Next(_.MaleMiddleNameSet.Length);
                    int MaleNameSet_index = rnd.Next(_.MaleNameSet.Length);
                    string male_full_name = _.FemaleNameSet[MaleNameSet_index] + " ";
                    male_full_name += _.MaleMiddleNameSet[MaleMiddleNameSet_index] + " ";
                    male_full_name += _.MaleNameSet[MaleNameSet_index];
                    result[i] = new Student(Guid.NewGuid().ToString(), male_full_name, gender, birthday, Guid.NewGuid().ToString());
                }
            }
            return result;
        }
        public void print()
        {
            Console.WriteLine(_id + 1 + " " + _fullname);
        }
    }
}
