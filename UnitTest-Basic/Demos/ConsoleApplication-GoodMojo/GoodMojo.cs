using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication_GoodMojo
{
	public class GoodMojo
	{
		public static void Main(string[] args)
		{
			//new GoodMojo().Process();
			//Console.ReadKey();

			//new GoodMojo().Process();
			//Console.ReadKey();

			ConsoleKeyInfo keyInfo;

			do
			{
				new GoodMojo().Process();
				keyInfo = Console.ReadKey();
			}
			while (keyInfo.Key != ConsoleKey.Q);
		}

		public void Process()
		{
			GetChuckNorrisFactAndDisplay();
		}

		public void GetChuckNorrisFactAndDisplay()
		{
			ServiceReference.ChuckNorrisServiceClient client = new ServiceReference.ChuckNorrisServiceClient();

			Console.WriteLine();
			Console.WriteLine(client.GetChuckNorrisFact(null));
		}
	}
}
