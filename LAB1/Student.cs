using System;

public class Student
{
	protected string _id;
	protected string _name;
	public string ID
	{
		get
		{
			return _id;
		}
	}
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
	public Student(string id, string Name)
	{
		_id = ID;
		_name = Name;
	}
}
