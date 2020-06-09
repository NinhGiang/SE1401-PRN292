
namespace LAB1_SE140056
{
    class SchoolConfigure
    {
        public NameConfig NameConfig { get; set; }
    }
    class NameConfig
    {
        public string[] LastNameSet { get; set; }
        public string[] MaleMiddleNameSet { get; set; }
        public string[] MaleFirstNameSet { get; set; }
        public string[] FemaleMiddleNameSet { get; set; }
        public string[] FemaleFirstNameSet { get; set; }
    }
}
