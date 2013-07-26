using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGoods
{
	public class ChuckNorrisStuff
	{
		private const string ChuckNorrisName = "Chuck Norris";
		public string Name { get; set; }
		
		public bool IsChuckNorris()
		{
			return Name.Equals(ChuckNorrisName, StringComparison.CurrentCultureIgnoreCase);
		}

		public bool CanStopTime { get; set; }

		public bool MakesHappyMealsCry { get; set; }
	}
}
