using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Array : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		[TestMethod, Description("")]
		public void Array_Lit() {
			const string data = "testObj.ArrTest.i[2]";
			object expected = 91;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_ParenLit() {
			const string data = "testObj.ArrTest.i[(1)]";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_Arith() {
			const string data = "testObj.ArrTest.i[ 1 + 1 + (2) - 1 % 2 ]";
			object expected = 34;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_Ident() {
			const string data = "testObj.ArrTest.i[testObj.ArrTest.x]";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_NegIdent() {
			const string data = "testObj.ArrTest.i[-testObj.ArrTest.a]";
			object expected = 91;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_MethodCall() {
			const string data = "testObj.ArrTest.i[ testObj.MethTest.NumericDiscreteReturn() ]";
			object expected = 34;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_ArrayElem() {
			const string data = "testObj.ArrTest.i[ testObj.ArrTest.j[0] ]";
			object expected = 91;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_ArrayElemArith() {
			const string data = "testObj.ArrTest.i[ testObj.ArrTest.j[2] * testObj.ArrTest.k[3] ]";
			object expected = 52;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_LitObj() {
			const string data = "testObj.ArrTest.v[2]";
			object expected = new Vector2(-90, 120);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_LitObjField() {
			const string data = "testObj.ArrTest.v[2].X";
			object expected = (float)-90;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Array_LitObjFieldLitArith() {
			const string data = "testObj.ArrTest.v[2].Y + testObj.ArrTest.i[0]";
			object expected = (float)165;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
	}
}
