using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Bitwise : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region And
		[TestMethod, Description("")]
		public void Bitwise_And_00() {
			const string data = "0 & 0";
			object expected = 0 & 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_And_01() {
			const string data = "0 & 1";
			object expected = 0 & 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_And_10() {
			const string data = "1 & 0";
			object expected = 1 & 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_And_11() {
			const string data = "1 & 1";
			object expected = 1 & 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_And_ByteLong() {
			const string data = "(byte)2 & 4L";
			object expected = (byte)2 & 4L;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Not
		[TestMethod, Description("")]
		public void Bitwise_Not_0() {
			const string data = "~0";
			object expected = ~0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Not_1() {
			const string data = "~1";
			object expected = ~1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Not_Dbl() {
			const string data = "~~1";
			object expected = ~~1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Not_Byte() {
			const string data = "~(byte)2";
			object expected = ~(byte)2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Not_Long() {
			const string data = "~4L";
			object expected = ~4L;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Or
		[TestMethod, Description("")]
		public void Bitwise_Or_00() {
			const string data = "0 | 0";
			object expected = 0 | 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Or_01() {
			const string data = "0 | 1";
			object expected = 0 | 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Or_10() {
			const string data = "1 | 0";
			object expected = 1 | 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Or_11() {
			const string data = "1 | 1";
			object expected = 1 | 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Or_ByteLong() {
			const string data = "(byte)2 | 4L";
			object expected = (byte)2 | 4L;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Xor
		[TestMethod, Description("")]
		public void Bitwise_Xor_00() {
			const string data = "0 ^ 0";
			object expected = 0 ^ 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Xor_01() {
			const string data = "0 ^ 1";
			object expected = 0 ^ 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Xor_10() {
			const string data = "1 ^ 0";
			object expected = 1 ^ 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Xor_11() {
			const string data = "1 ^ 1";
			object expected = 1 ^ 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Xor_ByteLong() {
			const string data = "(byte)2 ^ 4L";
			object expected = (byte)2 ^ 4L;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Precedence
		[TestMethod, Description("")]
		public void Bitwise_Precedence_AndNotOrXor() {
			const string data = "127 & 65 | 7 ^ 1 & ~89 | ~12 ^ ~6";
			object expected = 127 & 65 | 7 ^ 1 & ~89 | ~12 ^ ~6;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_Precedence_Shift() {
			const string data = "-1023 >> 1 << -255 << 6 >> -511 >> 4 >> 1 << 5";
			object expected = -1023 >> 1 << -255 << 6 >> -511 >> 4 >> 1 << 5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Shift Left
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_ZeroBase() {
			const string data = "0 <<  1";
			object expected = 0 << 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_NoShift() {
			const string data = "1 <<  0";
			object expected = 1 << 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_NormalPosPos() {
			const string data = "1 <<  1";
			object expected = 1 << 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_NormalPosNeg() {
			const string data = "2 <<  -1";
			object expected = 2 << -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_Underflow() {
			const string data = "1 << -1";
			object expected = 1 << -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_Overflow() {
			const string data = "-1 <<  1";
			object expected = -1 << 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_NormalNegNeg() {
			const string data = "-1 << -1";
			object expected = -1 << -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftLeft_NormalNegPos() {
			const string data = "-2 << 1";
			object expected = -2 << 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Shift Right
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_ZeroBase() {
			const string data = "0 >>  1";
			object expected = 0 >> 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_NoShift() {
			const string data = "1 >>  0";
			object expected = 1 >> 0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_Underflow() {
			const string data = "1 >>  1";
			object expected = 1 >> 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_NormalPosPos() {
			const string data = "2 >> 1";
			object expected = 2 >> 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_NormalPosNeg() {
			const string data = "1 >> -1";
			object expected = 1 >> -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_NormalNegPos() {
			const string data = "-1 >>  1";
			object expected = -1 >> 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_NormalNegNeg() {
			const string data = "-2 >>  -1";
			object expected = -2 >> -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Bitwise_ShiftRight_Overflow() {
			const string data = "-1 >> -1";
			object expected = -1 >> -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
	}
}
