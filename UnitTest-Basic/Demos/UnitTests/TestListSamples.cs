using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class TestListSamples
	{
		private const int timeoutValue = 1500;
		private const string integrationCategory = "Integration Test";
		private const string unitTestCategory = "Unit Test";
		private const string nonDeterministicTest = "Do not add this to any ordered test; it is non-deterministic.";

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod1()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod2()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod3()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod4()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod5()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod6()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod7()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod8()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod9()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void TestMethod10()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(integrationCategory)]
		public void TestMethod11()
		{
		}

		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(integrationCategory)]
		public void TestMethod12()
		{
		}
	}
}
