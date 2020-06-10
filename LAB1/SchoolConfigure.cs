
namespace LAB1
{
    /// <summary>
    /// The main SchoolConfigure class.
    /// Contains all methods for getting/setting information related to Json's objects.
    /// </summary>
    public class SchoolConfigure
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
        /// <value>Gets the value of FieldConfig.</value>
        /// <value>Sets the value of FieldConfig.</value>
        public FieldConfig FieldConfig { get; set; }
    }
    /// <summary>
    /// The main NameConfig class.
    /// Contains all methods for getting/setting information related to people's name.
    /// </summary>
    public class NameConfig
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
    /// <summary>
    /// The main LevelConfig class.
    /// Contains all methods for getting/setting information related to level.
    /// </summary>
    public class LevelConfig
    {
        /// <value>Gets the value of LevelNameSet.</value>
        /// <value>Sets the value of LevelNameSet.</value>
        public string[] LevelNameSet { get; set; }
    }
    /// <summary>
    /// The main ClassConfig class.
    /// Contains all methods for getting/setting information related to class.
    /// </summary>
    public class ClassConfig
    {
        /// <value>Gets the value of ClassNameSet.</value>
        /// <value>Sets the value of ClassNameSet.</value>
        public string[] ClassNameSet { get; set; }
    }
    /// <summary>
    /// The main FieldConfig class.
    /// Contains all methods for getting/setting information related to field.
    /// </summary>
    public class FieldConfig
    {
        /// <value>Gets the value of FieldSet.</value>
        /// <value>Sets the value of FieldSet.</value>
        public string[] FieldSet { get; set; }
    }
}
