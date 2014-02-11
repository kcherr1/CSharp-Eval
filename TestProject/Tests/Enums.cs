using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Enums : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		[TestMethod, Description("Referencing an enum value")]
		public void Enum_Basic() {
			const string data = "TestEnumType.TEST_ZERO";
			object expected = TestEnumType.TEST_ZERO;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Using an enum value as an argument to a method")]
		public void Enum_MethCall() {
			const string data = "testObj.ETest.ReturnEnumIntCast(TestEnumType.TEST_ONE)";
			object expected = 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casting enum value to its corresponding int value")]
		public void Enum_Cast() {
			const string data = "(int)TestEnumType.TEST_TWO";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
	}
}
