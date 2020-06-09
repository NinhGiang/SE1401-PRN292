using System;
using System.Text.Json;
using System.IO;
using LAB1.DataGeneration;
using System.Collections.Generic;

public class Student
{
    protected string _uuid;
    protected string _name;
    protected DateTime _birthday;
    protected string _gender;
    protected string _class;

    public string Uuid
    {
        get
        {
            return _uuid;
        }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public DateTime Birthday
    {
        get { return _birthday; }
        set { _birthday = value; }
    }
    public string Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
    public string Class
    {
        get { return _class; }
        set { _class = value; }
    }
    public Student(string Uuid, string Name, DateTime Birthday, string Gender, string Class)
    {
        _uuid = Uuid;
        _name = Name;
        _birthday = Birthday;
        _gender = Gender;
        _class = Class;
    }
    public Student()
    {

    }

    static public Student[] createStudent(uint number_student)
    {

        Student[] result = new Student[number_student];
        Random rnd = new Random();
        for (uint i = 0; i < number_student; i++)
        {
            String uuID = Guid.NewGuid().ToString(); //generate random uuid
            String gender = RandomGenerator.GetRandomGender(); //generate random gender

            if (gender.Equals("Male"))
            {
                String fullname = RandomGenerator.GetRadomFullName(); //generate random name
                string classInfo = DataGenerator.getClass(DataGenerator.getLevel());
                //String classInfo = RandomGenerator.GetRandomClass();//generate random class
                
                int year = rnd.Next(2003, 2005);
                DateTime birthdate = RandomGenerator.GetRandomDate(year);//generate random DOB
                result[i] = new Student(uuID, fullname, birthdate, gender, classInfo);
            }//generate a male student
            else if (gender.Equals("Female"))
            {
                String fullname = RandomGenerator.GetRadomFullName();//generate random name
                string classInfo = DataGenerator.getClass(DataGenerator.getLevel());
                //String classInfo = RandomGenerator.GetRandomClass();//generate random class
                
                int year = rnd.Next(2003, 2005);
                DateTime birthdate = RandomGenerator.GetRandomDate(year); //generate random DOB
                result[i] = new Student(uuID, fullname, birthdate, gender, classInfo);
            } //create a female student
        }
        return result;
    }
}

