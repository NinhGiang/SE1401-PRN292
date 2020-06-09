using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace StudentGeneration
{
	class Configure
	{
		public NameDataSet NameDataSet { get; set; }
	}

	class NameDataSet
	{
		public String[] LastNameSet { get; set; }
		public String[] MiddleNameSet { get; set; }
		public String[] FirstNameSet { get; set; }
	}

	class DateDataSet
	{
		public String[] Day_set { get; set; }
		public String[] Month_set { get; set; }
		public String[] Year_set { get; set; }
	}

	class ClassDataSet
    {
		public String[] Class_set { get; set; }
    }
}


