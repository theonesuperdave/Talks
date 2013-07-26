using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class IntegrationTests
	{
		private const int timeoutValue = 1500;
		private const string integrationCategory = "Integration Test";
		private const string unitTestCategory = "Unit Test";
		private const string nonDeterministicTest = "Do not add this to any ordered test; it is non-deterministic.";

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(integrationCategory)]
		public void IntegrationSampleTest()
		{
		}
	}
}
