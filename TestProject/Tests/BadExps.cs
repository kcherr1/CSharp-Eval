using CSE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class BadExps : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Logic Errors
		[TestMethod, Description("")]
		public void BadExp_LogicErr_UnknownIdent() {
			const string data = "unknownIdent";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_UnknownCastType() {
			const string data = "(unknownType)3";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_CantCastToType() {
			const string data = "(Vector2)3";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_UnknownArrayIdent() {
			const string data = "unknownArrayIdent[0]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NotAnArray() {
			const string data = "testObj[0]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_UnderflowWithLit() {
			const string data = "-5uL";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NegNonNumericLitChain() {
			const string data = "-3.ToString()";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_DecimalFirstOperandToPowOp() {
			const string data = "3m ** 5";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_DecimalSecondOperandToPowOp() {
			const string data = "3 ** 5m";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_PosNonNumericLitChain() {
			const string data = "+3.ToString()";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NegNonNumericBoolLit() {
			const string data = "-true";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_PosNonNumericBoolLit() {
			const string data = "+false";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_PosNonNumericCharLit() {
			const string data = "+'c'";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NegNonNumericStrLit() {
			const string data = "-\"Hello World\"";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NegNonNumericNullLit() {
			const string data = "-null";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_PosNonNumericNullLit() {
			const string data = "+null";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NullObjChain() {
			const string data = "null.ToString()";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_FloatArrayIndex() {
			const string data = "testObj.ArrTest.i[3.2]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NonNumBoolLitTrueArrayIndex() {
			const string data = "testObj.ArrTest.i[true]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NonNumBoolLitFalseArrayIndex() {
			const string data = "testObj.ArrTest.i[false]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NonNumCharLitArrayIndex() {
			const string data = "testObj.ArrTest.i['x']";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NonNumStrLitArrayIndex() {
			const string data = "testObj.ArrTest.i[\"Hello\"]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_NonNumNullLitArrayIndex() {
			const string data = "testObj.ArrTest.i[null]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_CantCoerceIdentArgs() {
			const string data = "testObj.MethTest.ByteMeth(testObj.IdentTest.intPropertyTest)";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_LogicErr_AmbiguousMethCall() {
			const string data = "testObj.MethTest.OverloadedMeth(3, 4)";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		#endregion

		#region Parse Errors
		[TestMethod, Description("")]
		public void BadExp_ParseErr_IncorrectNumSuffix() {
			const string data = "1k";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_InvalidNumSuffixL() {
			const string data = "1.1L";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_InvalidNumSuffixU() {
			const string data = "1.1U";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_InvalidNumSuffixUL() {
			const string data = "1.1UL";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_InvalidExpNumSuffixL() {
			const string data = "1e3L";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_InvalidExpNumSuffixU() {
			const string data = "1e3U";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_InvalidExpNumSuffixUL() {
			const string data = "1e3UL";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_LHSLitOpEq() {
			const string data = "3 += 5";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NumTrailingDot() {
			const string data = "1.2.";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NumTooManyDots() {
			const string data = "1.2.3";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NumIntLitAsRHSDotOperand() {
			const string data = "a.4";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NumFloatAsRHSDotOperand() {
			const string data = "a.4.3";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NonNumBoolTrueLitAsRHSDotOperand() {
			const string data = "a.true";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NonNumBoolFalseLitAsRHSDotOperand() {
			const string data = "a.false";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NonNumCharLitAsRHSDotOperand() {
			const string data = "a.'c'";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NonNumStrLitAsRHSDotOperand() {
			const string data = "a.\"Hello\"";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_NonNumNullLitAsRHSDotOperand() {
			const string data = "a.null";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_ObjChainTrailingDot() {
			const string data = "a.b.";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_LitPostInc() {
			const string data = "1++";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_LitPreInc() {
			const string data = "++1";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_UnclosedParen() {
			const string data = "foo(";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_MissingArg() {
			const string data = "foo(1,)";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_UnclosedBrack() {
			const string data = "i[";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_UnmatchedClosedBrack() {
			const string data = "i[0]]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void BadExp_ParseErr_EmptyArrayIndex() {
			const string data = "i[]";
			bool errDetected = false;
			try { CsEval.Eval(data); }
			catch { errDetected = true; }
			Assert.AreEqual(true, errDetected, "DATA: " + data);
		}
		#endregion
	}
}
