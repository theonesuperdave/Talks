using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace UnitTests
{
	public class BusinessLogicStuffFake
	{
		private List<string> chuckNorrisFacts = LoadAllItemsWithEmbeddedFile("ChuckNorrisFacts.txt");

		private Random randomizerForChuckNorrisFacts = new Random(DateTime.Now.Millisecond);

		private static List<string> LoadAllItemsWithEmbeddedFile(string fileName)
		{
			string filePath = string.Concat("UnitTests.Data.", fileName);
			List<string> content = new List<string>();

			using (StreamReader fileStream = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(filePath)))
			{
				while (fileStream.EndOfStream == false)
				{
					content.Add(fileStream.ReadLine());
				}
			}

			return content;
		}

		public string GetChuckNorrisFact(int? value)
		{
			int randomIndex = 0;

			if (value == null)
			{
				randomIndex = randomizerForChuckNorrisFacts.Next(0, chuckNorrisFacts.Count - 1);
			}
			else
			{
				randomIndex = value.Value;
			}

			return chuckNorrisFacts[randomIndex];
		}
	}
}
