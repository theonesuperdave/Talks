using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheGoods;

namespace WhereTheMagicHappens
{
	public class BusinessLogicStuff
	{
		/// <summary>
		/// We will create a brand new unit test from this one
		/// </summary>
		/// <returns></returns>
		public static string MyWushu()
		{
			return "I Kung Fu You!!";
		}

		public string GetChuckNorrisFact(int? value)
		{
			ServiceReference.ChuckNorrisServiceClient client = new ServiceReference.ChuckNorrisServiceClient();

			return client.GetChuckNorrisFact(value);
		}

		public string CreateParagraph(List<string> sentences)
		{
			string paragraph = string.Empty;
			string title = string.Concat("Chuck Norris facts everyone should know:", Environment.NewLine);

			sentences.Insert(0, title);

			var sentencesAsParagraph = (from sentence in sentences
									   select string.Concat(sentence, Environment.NewLine)).ToList();

			// For the LINQ statement above, we could have also done it this way:
			//sentences.ForEach(c => string.Concat(c, Environment.NewLine));

			sentencesAsParagraph.ForEach(c => paragraph += c);

			return paragraph;
		}

		public bool InterrogatetheStuff(ChuckNorrisStuff stuff)
		{
			return stuff.IsChuckNorris();
		}
	}
}
