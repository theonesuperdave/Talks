using WhereTheMagicHappens;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TheGoods;
using System.IO;
using System.Reflection;

namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for BusinessLogicStuffTest and is intended
    ///to contain all BusinessLogicStuffTest Unit Tests
    ///</summary>
	[TestClass()]
	public class BusinessLogicStuffTest
	{
		private const int timeoutValue = 1500;
		private const string integrationCategory = "Integration Test";
		private const string unitTestCategory = "Unit Test";
		private const string nonDeterministicTest = "Do not add this to any ordered test; it is non-deterministic.";

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion

		private static string LoadFirstItemWithEmbeddedFile(string fileName)
		{
			string filePath = string.Concat("UnitTests.Data.", fileName);
			string content = string.Empty;

			using (StreamReader fileStream = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(filePath)))
			{
				content = fileStream.ReadLine();
			}

			return content;
		}

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

		/// <summary>
		///A test for CreateParagraph
		///</summary>
		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void CreateParagraphBasicTest()
		{
			// Arrange
			string expected = "If a tree falls in the forest when no one is around, does Chuck Norris hear it?";
			string expectedMore = "You betcha he does...";
			string actual;
			BusinessLogicStuff target = new BusinessLogicStuff();
			List<string> sentences = new List<string>()
			{
				expected,
				expectedMore
			};

			// Act
			actual = target.CreateParagraph(sentences);

			// Assert
			Assert.IsTrue(actual.Contains(expected));
			Assert.IsTrue(actual.Contains(expectedMore));
		}

		/// <summary>
		///A test for GetChuckNorrisFact. THIS IS REALLY AN INTEGRATION TEST!!
		///</summary>
		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(integrationCategory)]
		public void GetChuckNorrisFactTest()
		{
			// Arrange
			BusinessLogicStuff target = new BusinessLogicStuff();
			////Nullable<int> value = new Nullable<int>();

			// Act
			string actual = target.GetChuckNorrisFact(null);

			// Assert
			Assert.IsNotNull(actual);
			Assert.Inconclusive(nonDeterministicTest);
		}

		/// <summary>
		///A test for GetChuckNorrisFact. THIS IS REALLY AN INTEGRATION TEST!!
		///</summary>
		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(integrationCategory)]
		[ExpectedException(typeof(InvalidOperationException))]
		public void GetChuckNorrisFactForExpectedExceptionTest()
		{
			// Arrange
			BusinessLogicStuff target = new BusinessLogicStuff();
			////Nullable<int> value = new Nullable<int>();

			// Act
			string actual = target.GetChuckNorrisFact(30000);

			// Assert
			Assert.IsNotNull(actual);
			Assert.Inconclusive(nonDeterministicTest);
		}

		/// <summary>
		///A test for InterrogatetheStuff
		///</summary>
		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void InterrogatetheStuffIsChuckNorrisTest()
		{
			// Arrange
			BusinessLogicStuff target = new BusinessLogicStuff();
			ChuckNorrisStuff stuff = new ChuckNorrisStuff() { Name = "Chuck Norris" }; // Here is my mock
			bool actual;

			// Act
			actual = target.InterrogatetheStuff(stuff);

			// Assert
			Assert.IsTrue(actual);
		}

		/// <summary>
		///A test for InterrogatetheStuff
		///</summary>
		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void InterrogatetheStuffIsNotChuckNorrisTest()
		{
			// Arrange
			BusinessLogicStuff target = new BusinessLogicStuff();
			ChuckNorrisStuff stuff = new ChuckNorrisStuff() { Name = "Sylvester Stalone" }; // Here is my mock
			bool actual;

			// Act
			actual = target.InterrogatetheStuff(stuff);

			// Assert
			Assert.IsFalse(actual);
		}

		/// <summary>
		/// A test for GetChuckNorrisFact which uses a fake object to break the dependency of the web service
		/// </summary>
		[TestMethod()]
		[Timeout(timeoutValue)]
		[TestCategory(unitTestCategory)]
		public void GetChuckNorrisFactUsingFakeObjectTest()
		{
			// Arrange
			BusinessLogicStuffFake target = new BusinessLogicStuffFake();

			// Act
			string actual = target.GetChuckNorrisFact(null);

			// Assert
			Assert.IsNotNull(actual);
		}
	}
}
