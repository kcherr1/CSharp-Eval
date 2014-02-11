using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Conditional : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Eq Neq
		[TestMethod, Description("")]
		public void Conditional_EqNeq_EqTrueStruct() {
			const string data = "2 == 2";
			bool expected = 2 == 2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_EqTrueStructDiffTypes() {
			const string data = "2 == 2.0";
			bool expected = 2 == 2.0;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_EqTrueClass() {
			const string data = "\"str\" == \"str\"";
			bool expected = "str" == "str";
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_EqTrueNullNull() {
			const string data = "null == null";
			bool expected = null == null;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		public void Conditional_EqNeq_EqFalseStruct() {
			const string data = "7 == 2";
			bool expected = 7 == 2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_EqFalseStructDiffTypes() {
			const string data = "2 == 2.01";
			bool expected = 2 == 2.01;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_EqFalseClass() {
			const string data = "\"str\" == \"str2\"";
			bool expected = "str" == "str2";
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_EqFalseClassNull() {
			const string data = "new Random() == null";
			bool expected = new System.Random() == null;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_NeqTrueStruct() {
			const string data = "2 != 2";
			bool expected = 2 != 2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_NeqTrueStructDiffTypes() {
			const string data = "2 != 2.0";
			bool expected = 2 != 2.0;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_NeqTrueClass() {
			const string data = "\"str\" != \"str\"";
			bool expected = "str" != "str";
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_NeqTrueNullNull() {
			const string data = "null != null";
			bool expected = null != null;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		public void Conditional_EqNeq_NeqFalseStruct() {
			const string data = "7 != 2";
			bool expected = 7 != 2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_NeqFalseStructDiffTypes() {
			const string data = "2 != 2.01";
			bool expected = 2 != 2.01;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_NeqFalseClass() {
			const string data = "\"str\" != \"str2\"";
			bool expected = "str" != "str2";
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		[TestMethod, Description("")]
		public void Conditional_EqNeq_NeqFalseClassNull() {
			const string data = "new Random() != null";
			bool expected = new System.Random() != null;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		#endregion

		#region Gt Gte
		[TestMethod, Description("")]
		public void Conditional_Gt_Int_Int() {
			const string data = "2 > 2";
			bool expected = 2 > 2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Gt_Flt_Flt() {
			const string data = "2.7 > 7.2";
			bool expected = 2.7 > 7.2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Gt_Int_Flt() {
			const string data = "7.2 > 5";
			bool expected = 7.2 > 5;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Gte_Int_Int() {
			const string data = "82 >= 92";
			bool expected = 82 > 92;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Gte_Flt_Flt() {
			const string data = "2.7 >= 7.2";
			bool expected = 2.7 >= 7.2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Gte_Int_Flt() {
			const string data = "7.2 >= 5";
			bool expected = 7.2 >= 5;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		#endregion

		#region Lt Lte
		[TestMethod, Description("")]
		public void Conditional_Lt_Int_Int() {
			const string data = "2 < 2";
			bool expected = 2 < 2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Lt_Flt_Flt() {
			const string data = "2.7 < 7.2";
			bool expected = 2.7 < 7.2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Lt_Int_Flt() {
			const string data = "7.2 < 5";
			bool expected = 7.2 < 5;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Lte_Int_Int() {
			const string data = "82 <= 92";
			bool expected = 82 <= 92;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Lte_Flt_Flt() {
			const string data = "2.7 <= 7.2";
			bool expected = 2.7 <= 7.2;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		[TestMethod, Description("")]
		public void Conditional_Lte_Int_Flt() {
			const string data = "7.2 <= 5";
			bool expected = 7.2 <= 5;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}

		#endregion

		#region Precedence
		[TestMethod, Description("")]
		public void Conditional_Precedence1() {
			const string data = "7 > 8 == 9 < 2 != 8.1 <= 1 == 0.1 > 0.02";
			bool expected = true;
			bool actual = (bool)CsEval.Eval(this, data);
			Assert.IsTrue(expected == actual);
		}
		#endregion
	}
}
