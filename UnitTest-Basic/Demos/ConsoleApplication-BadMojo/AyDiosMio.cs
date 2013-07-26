using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_BadMojo
{
	public class AyDiosMio
	{
		public string name = string.Empty;
		public bool isStupid = true;

		public bool AmIStupid()
		{
			return false;
		}

		public bool GetStupidityValue()
		{
			return isStupid == AmIStupid();
		}
	}
}
