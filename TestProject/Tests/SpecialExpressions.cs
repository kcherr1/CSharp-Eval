using System.Drawing;
using CSE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class SpecialExpressions : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		/// <summary>
		///		Standard 'Color Color' problem. Tests ability to tell the difference between a type
		///		and an identifier of the same name.
		///		<para>__</para>
		///		<para>For more information on the 'Color Color' problem, visit:</para>
		///		<para>http://blogs.msdn.com/ericlippert/archive/2009/07/06/color-color.aspx</para>
		///</summary>
		[TestMethod, Description("Color Color problem")]
		public void SpecExp_ColorColorProblem() {
			const string data = "(Color)testObj.SpecExpTest.Color(Color.Blue)";
			object expected = Color.Blue;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void SpecExp_GetTypeDotName() {
			const string data = "3.GetType().Name";
			object expected = 3.GetType().Name;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
	}
}
