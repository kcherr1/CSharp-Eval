using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class OpOverloads : ParserTestBase {
		OpOverload opOver;
		OpOverload opOver2;

		public OpOverloads() {
			opOver = new OpOverload();
			opOver2 = new OpOverload();
		}

		[ClassInitialize]
		public static void Init(TestContext testContext) {
			BaseInit(testContext);
		}

		#region Unary
		[TestMethod, Description("")]
		public void OpOverloads_Unary_UPLUS() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "+opOver";
			OpOverloadType expected = OpOverloadType.UPLUS;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_UMINUS() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "-opOver";
			OpOverloadType expected = OpOverloadType.UMINUS;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_BANG() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "!opOver";
			OpOverloadType expected = OpOverloadType.BANG;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_BIT_NOT() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "~opOver";
			OpOverloadType expected = OpOverloadType.BIT_NOT;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_INC_Pre() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "++opOver";
			OpOverloadType expected = OpOverloadType.INC;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_INC_Post() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver++";
			OpOverloadType expected = OpOverloadType.INC;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_DEC_Pre() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "--opOver";
			OpOverloadType expected = OpOverloadType.DEC;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_DEC_Post() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver--";
			OpOverloadType expected = OpOverloadType.DEC;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_True() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "(opOver) ? true : false";
			OpOverloadType expected = OpOverloadType.TRUE;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Unary_False() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "(!opOver) ? true : false";
			OpOverloadType expected = OpOverloadType.FALSE;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		#endregion

		#region Binary
		[TestMethod, Description("")]
		public void OpOverloads_Binary_ADD() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver + opOver2";
			OpOverloadType expected = OpOverloadType.ADD;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_SUB() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver - opOver2";
			OpOverloadType expected = OpOverloadType.SUB;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_MUL() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver * opOver2";
			OpOverloadType expected = OpOverloadType.MUL;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_DIV() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver / opOver2";
			OpOverloadType expected = OpOverloadType.DIV;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_MOD() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver % opOver2";
			OpOverloadType expected = OpOverloadType.MOD;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_BIT_AND() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver & opOver2";
			OpOverloadType expected = OpOverloadType.BIT_AND;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_BIT_OR() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver | opOver2";
			OpOverloadType expected = OpOverloadType.BIT_OR;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_BIT_XOR() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver ^ opOver2";
			OpOverloadType expected = OpOverloadType.BIT_XOR;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_BIT_LSHIFT() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver << 3";
			OpOverloadType expected = OpOverloadType.BIT_LSHIFT;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Binary_BIT_RSHIFT() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver >> 3";
			OpOverloadType expected = OpOverloadType.BIT_RSHIFT;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}
		#endregion

		#region Comparison

		[TestMethod, Description("")]
		public void OpOverloads_Comparison_Eq() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver == opOver2";
			OpOverloadType expected = OpOverloadType.EQ;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Comparison_Neq() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver != opOver2";
			OpOverloadType expected = OpOverloadType.NEQ;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Comparison_Lt() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver < opOver2";
			OpOverloadType expected = OpOverloadType.LT;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Comparison_Gt() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver > opOver2";
			OpOverloadType expected = OpOverloadType.GT;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Comparison_Lte() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver <= opOver2";
			OpOverloadType expected = OpOverloadType.LTE;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}

		[TestMethod, Description("")]
		public void OpOverloads_Comparison_Gte() {
			OpOverloads opOvers = new OpOverloads();
			const string data = "opOver >= opOver2";
			OpOverloadType expected = OpOverloadType.GTE;
			object actual = CsEval.Eval(opOvers, data);
			Assert.IsTrue(expected == opOvers.opOver.LastOp);
		}
		#endregion
	}
}