using System; 
 class Configure
{
	public NameDataSet NameDataSet {get; set;}
    public GenderDataSet GenderDataSet { get; set; }
    public ClassDataSet ClassDataSet { get; set; }
}
class NameDataSet
{
    public string[] MaleFirstNameSet { get; set; }

    public string[] FemaleFirstNameSet { get; set; }
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
