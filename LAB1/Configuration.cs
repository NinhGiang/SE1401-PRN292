using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    /// <summary>
    /// Configuration class
    /// Store properties for configuration from Configuration.json file
    /// </summary>
    class Configuration
    {
        /// <summary>
        /// Properties and getter setter for NameConfig 
        /// </summary>
        public NameConfig NameConfig { get; set; }
        /// <summary>
        /// Properties and getter setter for LevelConfig
        /// </summary>
        public LevelConfig LevelConfig { get; set; }
        /// <summary>
        /// Properties and getter setter for FieldConfig
        /// </summary>
        public FieldConfig FieldConfig { get; set; }
        
    }
    /// <summary>
    /// NameConfig class
    /// Get properties for NameConfig from Configuration.json file
    /// </summary>
    class NameConfig
    {
        /// <summary>
        /// Properties of first_male_name_set
        /// </summary>
        public string[] first_male_name_set { get; set; }
        /// <summary>
        /// Properties of first_female_name_set
        /// </summary>
        public string[] first_female_name_set { get; set; }
        /// <summary>
        /// Properties of middle_name_set
        /// </summary>
        public string[] middle_name_set { get; set; }
        /// <summary>
        /// Properties of last_name_set
        /// </summary>
        public string[] last_name_set { get; set; }
    }
    /// <summary>
    /// LevelConfig class
    /// Get properties for LevelConfig from Configuration.json file
    /// </summary>
    class LevelConfig
    {
        /// <summary>
        /// Properties of level_set
        /// </summary>
        public string[] level_set { get; set; }
    }
    /// <summary>
    /// FieldConfig class
    /// Get properties for FieldConfig from Configuration.json file
    /// </summary>
    class FieldConfig
    {
        /// <summary>
        /// Properties of field_set
        /// </summary>
        public string[] field_set { get; set; }
    }
}
