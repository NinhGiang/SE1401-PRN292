﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace StudentGeneration
{
    /// <summary>
    /// Main Config
    /// Contains all class config and method for get/set 
    /// </summary>
    class Configure
    {
        public NameConfig NameConfig { get; set; }
        public LevelConfig LevelConfig { get; set; }
        public ClassConfig ClassConfig { get; set; }
        public FieldConfig FieldConfig { get; set; }
    }

    /// <summary>
    /// FieldConfig class
    /// Contains all method for get/set in FieldConfig class
    /// </summary>
    public class FieldConfig
    {
        public string[] field_set { get; set; }
    }

    /// <summary>
    /// ClassConfig class
    /// Contains all method for get/set in ClassConfig class
    /// </summary>
    public class ClassConfig
    {
        /// <value>
        /// set and get class_name_set,semester_set
        /// </value>
        public string[] class_name_set { get; set; }
         
        public string[] semester_set { get; set; }
    }

    /// <summary>
    /// LevelConfig class
    /// Contains all method for get/set in LevelConfig class
    /// </summary>
    public class LevelConfig
    {
        /// <value>
        /// get and set level_name_set
        /// </value>
        public string[] level_name_set { get; set; }
    }

    /// <summary>
    /// NameConfig class
    /// Contains all method for get/set in NameConfig class
    /// </summary>
    class NameConfig
    {

        /// <value>
        /// set and get male_last_name_set,male_middle_name_set,male_first_name_set
        /// </value>
        public string[] male_last_name_set { get; set; }
        public string[] male_middle_name_set { get; set; }
        public string[] male_first_name_set { get; set; }

        /// <value>
        /// set and get female_last_name_set,female_middle_name_set,female_first_name_set
        /// </value>
        public string[] female_last_name_set { get; set; }
        public string[] female_middle_name_set { get; set; }
        public string[] female_first_name_set { get; set; }

    }
}
