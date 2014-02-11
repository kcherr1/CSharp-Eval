using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Logical : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region And
		[TestMethod, Description("")]
		public void Logical_And_FF() {
			const string data = "false && false";
			object expected = false && false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_And_FT() {
			const string data = "false && true";
			object expected = false && true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_And_TF() {
			const string data = "true && false";
			object expected = true && false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_And_TT() {
			const string data = "true && true";
			object expected = true && true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Not
		[TestMethod, Description("")]
		public void Logical_Not_F() {
			const string data = "!false";
			object expected = !false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Not_T() {
			const string data = "!true";
			object expected = !true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Not_Dbl() {
			const string data = "!!true";
			object expected = !!true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Or
		[TestMethod, Description("")]
		public void Logical_Or_FF() {
			const string data = "false || false";
			object expected = false || false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Or_FT() {
			const string data = "false || true";
			object expected = false || true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Or_TF() {
			const string data = "true || false";
			object expected = true || false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Or_TT() {
			const string data = "true || true";
			object expected = true || true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Xor
		[TestMethod, Description("")]
		public void Logical_Xor_FF() {
			const string data = "false ^ false";
			object expected = false ^ false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Xor_FT() {
			const string data = "false ^ true";
			object expected = false ^ true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Xor_TF() {
			const string data = "true ^ false";
			object expected = true ^ false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Logical_Xor_TT() {
			const string data = "true ^ true";
			object expected = true ^ true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Precedence
		[TestMethod, Description("")]
		public void Logical_Precedence_1() {
			const string data = "true && true || false ^ false && !false && !true || !false ^ !true";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
	}
}
