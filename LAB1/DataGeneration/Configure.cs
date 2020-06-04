using System; 
 class Configure
{
	public NameDataSet NameDataSet {get; set;}
    public GenderDataSet GenderDataSet { get; set; }
    public ClassDataSet ClassDataSet { get; set; }
    public BirthdayDataSet BirthdayDataSet { get; set; }
}
class NameDataSet
{
    public string[] MaleFirstNameSet { get; set; }

    public string[] FeMaleFirstNameSet { get; set; }
    public string[] MiddleNameSet { get; set; }

    public string[] LastNameSet { get; set; }
}
class GenderDataSet
{
    public string[] GenderSet { get; set; }
}
class ClassDataSet
{
    public string[] ClassSet { get; set; }
}
class BirthdayDataSet
{
    public string[] DaySet { get; set; }
    public string[] MonthSet { get; set; }
    public string[] YearSet { get; set; }
}
