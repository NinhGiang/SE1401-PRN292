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

	class ClassDataSet
    {
		public String[] Class_set { get; set; }
    }
}


