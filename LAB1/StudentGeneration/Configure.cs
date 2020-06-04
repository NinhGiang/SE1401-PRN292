using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace StudentGeneration
{
	class Configure
	{
		public NameDataSet nameConfig { get; set; }
	}

	class NameDataSet
	{
		public String[] last_name_set { get; set; }
		public String[] middle_name_set { get; set; }
		public String[] first_name_set { get; set; }
	}

	class DateDataSet
	{
		public String[] day_set { get; set; }
		public String[] month_set { get; set; }
		public String[] year_set { get; set; }
	}

	class ClassDataSet
    {
		public String[] class_set { get; set; }
    }
}


