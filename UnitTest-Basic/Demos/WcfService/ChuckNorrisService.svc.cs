using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	public class ChuckNorrisService : IChuckNorrisService
	{
		private List<string> chuckNorrisFacts = new List<string>()
		{
			"Chuck Norris doesn't have life insurance; the insurance companies pay him to spare their lives.",
			"Chuck Norris leaves teeth under his pillow for the tooth fairy, just never his own.",
			"Chuck Norris knows what he did...tomorrow.",
			"Chuck Norris is so persuasive that he convinced a mirror he wasn't there.",
			"Oxygen needs Chuck Norris to survive.",
			"Chuck Norris can light a fire by rubbing two ice-cubes together.",
			"The sun got Chuckburned.",
			"Chuck Norris can win a game of Connect Four in only three moves.",
			"When Chuck Norris does a pushup, he isn't lifting himself up; he's pushing the Earth down.",
			"Chuck Norris will never have a heart attack. His heart isn't nearly foolish enough to attack him.",
			"Chuck Norris can cut through a hot knife with butter.",
			"Chuck Norris once threw a grenade, it killed 50 people. THEN it blew up."
		};

		private Random randomizerForChuckNorrisFacts = new Random(DateTime.Now.Millisecond);

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
