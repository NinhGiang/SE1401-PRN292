using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace StudentGeneration
{
	class Configure
	{
		public NameDataSet NameDataSet { get; set; }
		public GenderDataSet GenderDataSet { get; set; }
		public LevelDataSet LevelDataSet { get; set; }
		public CLassDataSet CLassDataSet { get; set; }
	}

	class NameDataSet
	{
		public String[] LastNameSet { get; set; }
		public String[] MiddleNameSet { get; set; }
		public String[] FirstNameSet { get; set; }
	}

	class GenderDataSet
	{
		public String[] GenderSet { get; set; }
	}

	class LevelDataSet
	{
		public String[] LevelSet { get; set; }
	}
	class CLassDataSet
	{
		public String[] ClassSet { get; set; }
    }
}


