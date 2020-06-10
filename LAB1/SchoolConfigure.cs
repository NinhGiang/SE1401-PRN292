
namespace LAB1
{
    /// <summary>
    /// The main SchoolConfigure class.
    /// Contains all methods for getting/setting information related to Json's objects.
    /// </summary>
    class SchoolConfigure
    {
        /// <value>Gets the value of NameConfig.</value>
        /// <value>Sets the value of NameConfig.</value>
        public NameConfig NameConfig { get; set; }
        /// <value>Gets the value of LevelConfig.</value>
        /// <value>Sets the value of LevelConfig.</value>
        public LevelConfig LevelConfig { get; set; }
        /// <value>Gets the value of ClassConfig.</value>
        /// <value>Sets the value of ClassConfig.</value>
        public ClassConfig ClassConfig { get; set; }
    }
    /// <summary>
    /// The main NameConfig class.
    /// Contains all methods for getting/setting information related to people's name.
    /// </summary>
    class NameConfig
    {
        /// <value>Gets the value of LastNameSet.</value>
        /// <value>Sets the value of LastNameSet.</value>
        public string[] LastNameSet { get; set; }
        /// <value>Gets the value of MaleMiddleNameSet.</value>
        /// <value>Sets the value of MaleMiddleNameSet.</value>
        public string[] MaleMiddleNameSet { get; set; }
        /// <value>Gets the value of MaleFirstNameSet.</value>
        /// <value>Sets the value of MaleFirstNameSet.</value>
        public string[] MaleFirstNameSet { get; set; }
        /// <value>Gets the value of FemaleMiddleNameSet.</value>
        /// <value>Sets the value of FemaleMiddleNameSet.</value>
        public string[] FemaleMiddleNameSet { get; set; }
        /// <value>Gets the value of FemaleFirstNameSet.</value>
        /// <value>Sets the value of FemaleFirstNameSet.</value>
        public string[] FemaleFirstNameSet { get; set; }
    }
    class LevelConfig
    {
        /// <value>Gets the value of LevelNameSet.</value>
        /// <value>Sets the value of LevelNameSet.</value>
        public string[] LevelNameSet { get; set; }
    }
    class ClassConfig
    {
        /// <value>Gets the value of ClassNameSet.</value>
        /// <value>Sets the value of ClassNameSet.</value>
        public string[] ClassNameSet { get; set; }
    }
}
