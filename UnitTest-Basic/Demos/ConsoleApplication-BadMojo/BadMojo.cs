using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_BadMojo
{
	public class BadMojo
	{
		public static void Main(string[] args)
		{
			new BadMojo().ProcessSomethingStupid();

			new BadMojo().ProcessSomethingElseStupid();
			Console.Read();
		}

		public void ProcessSomethingStupid()
		{
			Console.WriteLine("Let's see if this is stupid or no: " + DoSomethingStupid());
		}

		public string DoSomethingStupid()
		{
			var ayDosMios = new AyDiosMio();

			return ayDosMios.AmIStupid().ToString();
		}

		public void ProcessSomethingElseStupid()
		{
			ServiceReference.ChuckNorrisServiceClient client = new ServiceReference.ChuckNorrisServiceClient();

			Console.WriteLine(client.GetChuckNorrisFact(null));
		}
	}
}
