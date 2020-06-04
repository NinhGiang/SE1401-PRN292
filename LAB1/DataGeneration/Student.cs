using System;
using System.Text.Json;
using System.IO;

namespace DataGeneration { 
public class Student
{
	protected string _uuid;
	protected string _name;
	protected string _birthday;
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
    public string Birthday
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
		get { return _class;}
		set { _class = value;}
	}
	public Student(string Uuid, string Name, string Birthday, string Gender, string Class)
	{
		_uuid = Uuid;
		_name = Name;
		_birthday = Birthday;
		_gender = Gender;
		_class = Class;
	}
	static public Student[] Create(uint number_student)
        {
		 Student[] result = new Student[number_student];
		 Configure config = JsonSerializer.Deserialize<Configure>(File.ReadAllText(@"../../../database.json"));
		 Random rnd = new Random(); 
		for (uint i = 0; i < number_student; i++)
            {
			NameDataSet nameDB = config.NameDataSet;
			GenderDataSet genderDB = config.GenderDataSet;
			ClassDataSet classDB = config.ClassDataSet;
			BirthdayDataSet birthdayDB =config.BirthdayDataSet;
			int gender_index = rnd.Next(genderDB.GenderSet.Length);
	     if(gender_index == 0)
			{
		    int firstname_index = rnd.Next(nameDB.MaleFirstNameSet.Length);
			int midlename_index = rnd.Next(nameDB.MiddleNameSet.Length);
			int lastname_index = rnd.Next(nameDB.LastNameSet.Length);
			string fullname = nameDB.LastNameSet[lastname_index] + " ";
                fullname += nameDB.MiddleNameSet[midlename_index] + " ";
                fullname += nameDB.MaleFirstNameSet[firstname_index] + " ";
			
			int class_index = rnd.Next(classDB.ClassSet.Length);
			
			int day_index = rnd.Next(birthdayDB.DaySet.Length);
			int month_index = rnd.Next(birthdayDB.MonthSet.Length);
			int year_index = rnd.Next(birthdayDB.YearSet.Length);
				string DOB = birthdayDB.DaySet[day_index] + "/";
                DOB += birthdayDB.MonthSet[month_index] + "/";
				DOB += birthdayDB.YearSet[year_index] + " ";
			result[i] = 
			new Student(i.ToString(), fullname, DOB, genderDB.GenderSet[gender_index], classDB.ClassSet[class_index]);
			}//create a male student
			else if (gender_index == 1)
			{
				int firstname_index = rnd.Next(nameDB.FeMaleFirstNameSet.Length);
				int midlename_index = rnd.Next(nameDB.MiddleNameSet.Length);
				int lastname_index = rnd.Next(nameDB.LastNameSet.Length);
				string fullname = nameDB.LastNameSet[lastname_index] + " ";
				fullname += nameDB.MiddleNameSet[midlename_index] + " ";
				fullname += nameDB.FeMaleFirstNameSet[firstname_index] + " ";

				int class_index = rnd.Next(classDB.ClassSet.Length);

				int day_index = rnd.Next(birthdayDB.DaySet.Length);
				int month_index = rnd.Next(birthdayDB.MonthSet.Length);
				int year_index = rnd.Next(birthdayDB.YearSet.Length);
				string DOB = birthdayDB.DaySet[day_index] + "/";
				DOB += birthdayDB.MonthSet[month_index] + "/";
				DOB += birthdayDB.YearSet[year_index] + " ";
				result[i] = 
				new Student(i.ToString(), fullname, DOB, genderDB.GenderSet[gender_index], classDB.ClassSet[class_index]);
			} //create a female student
		}
		return result;
	}
}
}
