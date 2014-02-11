using System;
using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class ParserTestBase {
		protected static object instance;

		/// <summary>
		///		Gets or sets the test context which provides information about and 
		///		functionality for the current test run.
		///</summary>
		public TestContext TestContext { get; set; }

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		[ClassInitialize]
		protected static void BaseInit(TestContext testContext) {
			instance = new TestProj();
			CsEval.EvalEnvironment = instance;
		}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup() {
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize() {
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup() {
		//}
		//
		#endregion

		protected static bool WithinEpsilonRange(object expectedObj, object actualObj) {
			const double epsilon = 0.00000013;

			double expected = double.Parse(expectedObj.ToString());
			double actual = double.Parse(actualObj.ToString());
			double diff = Math.Abs(expected - actual);
			double acceptableDiff = Math.Abs(actual * epsilon);

			return diff <= acceptableDiff;
		}
	}
}
