using System;
using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Arithmetic : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Addition
		[TestMethod, Description("Addition with 2 int operands")]
		public void Arith_Add_IntBinary() {
			const string data = "2 + 3";
			object expected = 5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Addition with multiple int operands")]
		public void Arith_Add_IntChain() {
			const string data = "2 + 3 + 4 + 10";
			object expected = 19;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Addition with 2 float operands")]
		public void Arith_Add_FloatBinary() {
			const string data = "2.34 + 3.78";
			object expected = 6.12;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Addition with multiple float operands")]
		public void Arith_Add_FloatChain() {
			const string data = "2.7 + 3.0 + 4.918 + 10.12387";
			object expected = 20.74187;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Addition with 2 operands; 1 int, 1 float")]
		public void Arith_Add_IFMixedBinary() {
			const string data = "2 + 3.78";
			object expected = 5.78;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Addition with multiple operands; some int, some float")]
		public void Arith_Add_IFMixedChain() {
			const string data = "2 + 3.0 + 4.918 + 10";
			object expected = 19.918;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Addition with multiple operands of different numeric types")]
		public void Arith_Add_NumTypeMixedChain() {
			const string data = "2 + 3.02 + 4.918d + 10f + 70100 + 9281L + 100 + 300 + 78u + 234UL + 550";
			object expected = 80662.938;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Add_ExpBinaryExpFirst() {
			const string data = "3E2 + 5";
			object expected = 3E2 + 5;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Add_ExpBinaryExpLast() {
			const string data = "7 + 4e3";
			object expected = 7 + 4e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Add_ExpBinaryBothExp() {
			const string data = "3e3 + 7e3";
			object expected = 3e3 + 7e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Add_ExpChain() {
			const string data = "2e7 + 2e3 + 4e1";
			object expected = 2e7 + 2e3 + 4e1;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Addition with 2 string operands")]
		public void Arith_Add_StringBinary() {
			const string data = "\"Hello\" + \" World\"";
			const string expected = "Hello World";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Addition with multiple string operands")]
		public void Arith_Add_StringChain() {
			const string data = "\"A,B,C,\" + \"D,E,F,\" + \"G,H,I,\" + \"J,K,L\"";
			const string expected = "A,B,C,D,E,F,G,H,I,J,K,L";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Subtraction
		[TestMethod, Description("Subtraction with 2 int operands")]
		public void Arith_Sub_IntBinary() {
			const string data = "2 - 3";
			object expected = -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Subtraction with multiple int operands")]
		public void Arith_Sub_IntChain() {
			const string data = "2 - 3 - 4 - 10";
			object expected = -15;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Subtraction with 2 float operands")]
		public void Arith_Sub_FloatBinary() {
			const string data = "2.34 - 3.78";
			object expected = -1.44;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Subtraction with multiple float operands")]
		public void Arith_Sub_FloatChain() {
			const string data = "2.7 - 3.0 - 4.918 - 10.12387";
			object expected = -15.34187;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Subtraction with 2 operands; 1 int, 1 float")]
		public void Arith_Sub_IFMixedBinary() {
			const string data = "2 - 3.78";
			object expected = -1.78;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Subtraction with multiple operands; some int, some float")]
		public void Arith_Sub_IFMixedChain() {
			const string data = "2 - 3.0 - 4.918 - 10";
			object expected = -15.918;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Subtraction with multiple operands of different numeric types")]
		public void Arith_Sub_NumTypeMixedChain() {
			const string data = "2 - 3.02 - 4.918d - 10f - 70100 - 9281L - 100 - 300 - 78u - 234UL - 550";
			object expected = -80658.938;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Sub_ExpBinaryExpFirst() {
			const string data = "3E2 - 5";
			object expected = 3E2 - 5;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Sub_ExpBinaryExpLast() {
			const string data = "7 - 4e3";
			object expected = 7 - 4e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Sub_ExpBinaryBothExp() {
			const string data = "3e3 - 7e3";
			object expected = 3e3 - 7e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Sub_ExpChain() {
			const string data = "2e7 - 2e3 - 4e1";
			object expected = 2e7 - 2e3 - 4e1;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Multiplication
		[TestMethod, Description("Multiplication with 2 int operands")]
		public void Arith_Mul_IntBinary() {
			const string data = "2 * 3";
			object expected = 6;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Multiplication with multiple int operands")]
		public void Arith_Mul_IntChain() {
			const string data = "2 * 3 * 4 * 10";
			object expected = 240;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Multiplication with 2 float operands")]
		public void Arith_Mul_FloatBinary() {
			const string data = "2.34 * 3.78";
			object expected = 8.8452;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Multiplication with multiple float operands")]
		public void Arith_Mul_FloatChain() {
			const string data = "2.7 * 3.0 * 4.918 * 10.12387";
			object expected = 2.7 * 3.0 * 4.918 * 10.12387;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Multiplication with 2 operands; 1 int, 1 float")]
		public void Arith_Mul_IFMixedBinary() {
			const string data = "2 * 3.78";
			object expected = 7.56;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Multiplication with multiple operands; some int, some float")]
		public void Arith_Mul_IFMixedChain() {
			const string data = "2 * 3.0 * 4.918 * 10";
			object expected = 295.08;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Multiplication with multiple operands of different numeric types")]
		public void Arith_Mul_NumTypeMixedChain() {
			const string data = "2 * 0.02 * 4.918d * 10f * 40100 * 21L * 100 * 90 * 78u * 24UL * 550";
			object expected = 1.5350524757568E+16;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mul_ExpBinaryExpFirst() {
			const string data = "3E2 * 5";
			object expected = 3E2 * 5;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mul_ExpBinaryExpLast() {
			const string data = "7 * 4e3";
			object expected = 7 * 4e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mul_ExpBinaryBothExp() {
			const string data = "3e3 * 7e3";
			object expected = 3e3 * 7e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mul_ExpChain() {
			const string data = "2e7 * 2e3 * 4e1";
			object expected = 2e7 * 2e3 * 4e1;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Division
		[TestMethod, Description("Division with 2 int operands")]
		public void Arith_Div_IntBinary() {
			const string data = "46 / 3";
			object expected = 15;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Division with multiple int operands")]
		public void Arith_Div_IntChain() {
			const string data = "9821 / 773 / 91 / 7";
			object expected = 0;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Division with 2 float operands")]
		public void Arith_Div_FloatBinary() {
			const string data = "8.342 / 3.781";
			object expected = 2.20629463;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Division with multiple float operands")]
		public void Arith_Div_FloatChain() {
			const string data = "7263.162 / 128.32941 / 18.918 / 8.12387";
			object expected = 0.36826576;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Division with 2 operands; 1 int, 1 float")]
		public void Arith_Div_IFMixedBinary() {
			const string data = "27 / 3.78";
			object expected = 7.14285714;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Division with multiple operands; some int, some float")]
		public void Arith_Div_IFMixedChain() {
			const string data = "1354 / 291.02 / 19.918 / 3";
			object expected = 0.07786258;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Division with multiple operands of different numeric types")]
		public void Arith_Div_NumTypeMixedChain() {
			const string data = "1028 / 19.10 / 11.98d / 92f / 52 / 10L / 81 / 12 / 75u / 19UL / 78";
			object expected = 0.00000000000086923264109492425;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Div_ExpBinaryExpFirst() {
			const string data = "3E2 / 5";
			object expected = 3E2 / 5;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Div_ExpBinaryExpLast() {
			const string data = "7 / 4e3";
			object expected = 7 / 4e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Div_ExpBinaryBothExp() {
			const string data = "3e3 / 7e3";
			object expected = 3e3 / 7e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Div_ExpChain() {
			const string data = "2e7 / 2e3 / 4e1";
			object expected = 2e7 / 2e3 / 4e1;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Modulus
		[TestMethod, Description("Modulus with 2 int operands")]
		public void Arith_Mod_IntBinary() {
			const string data = "46 % 3";
			object expected = 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Modulus with multiple int operands")]
		public void Arith_Mod_IntChain() {
			const string data = "9821 % 773 % 91 % 7";
			object expected = 6;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Modulus with 2 float operands")]
		public void Arith_Mod_FloatBinary() {
			const string data = "8.342 % 3.781";
			object expected = 0.78;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Modulus with multiple float operands")]
		public void Arith_Mod_FloatChain() {
			const string data = "7263.162 % 128.3294";
			object expected = 7263.162 % 128.3294;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Modulus with 2 operands; 1 int, 1 float")]
		public void Arith_Mod_IFMixedBinary() {
			const string data = "27 % 3.78";
			object expected = 0.54;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Modulus with multiple operands; some int, some float")]
		public void Arith_Mod_IFMixedChain() {
			const string data = "1354 % 291.02 % 19.918 % 3";
			object expected = 1.658;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Modulus with multiple operands of different numeric types")]
		public void Arith_Mod_NumTypeMixedChain() {
			const string data = "102831345 % 19127360.1021973 % 1120839.91178d % 928371f % 52600 % 10374L % 8164 % 1204 % 756u % 199UL % 78";
			object expected = 35.018333496991545;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mod_ExpBinaryExpFirst() {
			const string data = "3E2 % 5";
			object expected = 3E2 % 5;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mod_ExpBinaryExpLast() {
			const string data = "7 % 4e3";
			object expected = 7 % 4e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mod_ExpBinaryBothExp() {
			const string data = "3e3 % 7e3";
			object expected = 3e3 % 7e3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Mod_ExpChain() {
			const string data = "2e7 % 2e3 % 4e1";
			object expected = 2e7 % 2e3 % 4e1;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Power
		[TestMethod, Description("")]
		public void Arith_Pow_IntBinary() {
			const string data = "2 ** 3";
			object expected = Math.Pow(2, 3);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Arith_Pow_IntChain() {
			const string data = "2 ** 3 ** 4";
			object expected = Math.Pow(2, Math.Pow(3, 4));
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Arith_Pow_FloatBinary() {
			const string data = "2.34 ** 3.78";
			object expected = Math.Pow(2.34, 3.78);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_FloatChain() {
			const string data = "2.7 ** 2.01 ** 2.918 ** 1.12387";
			object expected = Math.Pow(2.7, Math.Pow(2.01, Math.Pow(2.918, 1.12387)));
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_IFMixedBinary() {
			const string data = "2 ** 3.78";
			object expected = Math.Pow(2, 3.78);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_IFMixedChain() {
			const string data = "2 ** 3.0 ** 1.918 ** 2";
			object expected = Math.Pow(2, Math.Pow(3.0, Math.Pow(1.918, 2)));
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_NumTypeMixedChain() {
			const string data = "2 ** 1.918d ** 0.3f ** 3 ** 2L ** 2 ** 1.1 ** 2u ** 2UL ** 1.3";
			object expected = Math.Pow(2, Math.Pow(1.918d, Math.Pow(0.3f, Math.Pow(3, Math.Pow(2L, Math.Pow(2, Math.Pow(1.1, Math.Pow(2u, Math.Pow(2UL, 1.3)))))))));
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_ExpBinaryExpFirst() {
			const string data = "3E2 ** 5";
			object expected = Math.Pow(3E2, 5);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_ExpBinaryExpLast() {
			const string data = "3 ** 2e2";
			object expected = Math.Pow(3, 2e2);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_ExpBinaryBothExp() {
			const string data = "1e2 ** 2e1";
			object expected = Math.Pow(1e2, 2e1);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_ExpChain() {
			const string data = "1.02e1 ** 1.05e1 ** 1.1e0";
			object expected = Math.Pow(1.02e1, Math.Pow(1.05e1, 1.1e0));
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}


		[TestMethod, Description("")]
		public void Arith_Pow_FloatChainFirstNeg() {
			const string data = "-1.02 ** 2.05 ** 3.1";
			object expected = -1.201173346767316;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_FloatChainSecondNeg() {
			const string data = "1.02 ** -2.05 ** 3.1";
			object expected = 0.83251930513715755;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_FloatChainThirdNeg() {
			const string data = "1.02 ** 2.05 ** -3.1";
			object expected = 1.0021416598032971;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_FloatChainAllNeg() {
			const string data = "-1.02 ** -2.05 ** -3.1";
			object expected = -0.99786291710124364;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}

		[TestMethod, Description("")]
		public void Arith_Pow_IntChainFirstNeg() {
			const string data = "-2 ** 3 ** 4";
			object expected = -2417851639229258349412352.0;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_IntChainSecondNeg() {
			const string data = "2 ** -3 ** 4";
			object expected = 4.1359030627651384e-25;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_IntChainThirdNeg() {
			const string data = "2 ** 3 ** -4";
			object expected = 1.0085940915769991;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Pow_IntChainAllNeg() {
			const string data = "-2 ** -3 ** -4";
			object expected = -0.99147913749567806;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Precision
		[TestMethod, Description("Tests ability to keep precision")]
		public void Arith_Precision_1() {
			const string data = "172357.012834756219834612734891 % 19234.3294128174912 / 23847.213412349238472 / 3 % 0.329173";
			object expected = 172357.012834756219834612734891 % 19234.3294128174912 / 23847.213412349238472 / 3 % 0.329173;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Tests ability to keep precision")]
		public void Arith_Precision_2() {
			const string data = "0196297.918623856123 * 1297.018234097325 - 1209375.5719236589 / 981263497.523916407 + 0.1";
			object expected = 0196297.918623856123 * 1297.018234097325 - 1209375.5719236589 / 981263497.523916407 + 0.1;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Tests ability to keep precision")]
		public void Arith_Precision_3() {
			const string data = "(int)5 + 1f + (int)11 + 3f + (int)18 + 12.3d + (int)5 + 3f + (int)11 + 3f + (int)18 + 4f + 12.3d";
			object expected = (int)5 + 1f + (int)11 + 3f + (int)18 + 12.3d + (int)5 + 3f + (int)11 + 3f + (int)18 + 4f + 12.3d;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Unary Op
		[TestMethod, Description("Unary minus with single int operand")]
		public void Arith_UOp_MinusIntUnary() {
			const string data = "-4";
			object expected = -4;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with single float operand")]
		public void Arith_UOp_MinusFloatUnary() {
			const string data = "-4.56";
			object expected = -4.56;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with 2 int operands; first negative, second positive")]
		public void Arith_UOp_MinusIntBinaryNegFirst() {
			const string data = "-7 + 9";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with 2 int operands; first positive, second negative")]
		public void Arith_UOp_MinusIntBinaryNegLast() {
			const string data = "7 + -9";
			object expected = -2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with 2 int operands; both negative")]
		public void Arith_UOp_MinusIntBinaryNegBoth() {
			const string data = "-7 + -9";
			object expected = -16;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with 2 float operands; first negative, second positive")]
		public void Arith_UOp_MinusFloatBinaryNegFirst() {
			const string data = "-7.8 + 9.12";
			object expected = 1.32;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with 2 float operands; first positive, second negative")]
		public void Arith_UOp_MinusFloatBinaryNegLast() {
			const string data = "7.8 + -9.12";
			object expected = -1.32;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with 2 float operands; both negative")]
		public void Arith_UOp_MinusFloatBinaryNegBoth() {
			const string data = "-7.8 + -9.12";
			object expected = -16.92;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with multiple int operands; first negative, rest positive")]
		public void Arith_UOp_MinusIntChainNegFirst() {
			const string data = "-5 + 8 + 9 + 10";
			object expected = 22;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with multiple int operands; first positive, rest negative")]
		public void Arith_UOp_MinusIntChainNegRest() {
			const string data = "5 + -8 + -9 + -10";
			object expected = -22;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with multiple int operands; all negative")]
		public void Arith_UOp_MinusIntChainNegAll() {
			const string data = "-5 + -8 + -9 + -10";
			object expected = -32;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Unary minus with multiple float operands; first negative, rest positive")]
		public void Arith_UOp_MinusFloatChainNegFirst() {
			const string data = "-5.23 + 8.15 + 9.9 + 10.34";
			object expected = 23.16;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with multiple int operands; first positive, rest negative")]
		public void Arith_UOp_MinusFloatChainNegRest() {
			const string data = "5.23 + -8.15 + -9.9 + -10.34";
			object expected = -23.16;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with multiple int operands; all negative")]
		public void Arith_UOp_MinusFloatChainNegAll() {
			const string data = "-5.23 + -8.15 + -9.9 + -10.34";
			object expected = -33.62;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with 2 operands; first negative, second positive; using subtraction as arithmetic operator")]
		public void Arith_UOp_MinusBinaryNegFirstUsingSub() {
			const string data = "-3.45 - 6";
			object expected = -9.45;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with 2 operands; first positive, second negative; using subtraction as arithmetic operator")]
		public void Arith_UOp_MinusBinaryNegLastUsingSub() {
			const string data = "3.45 - -6";
			object expected = 9.45;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with 2 operands; both negative; using subtraction as arithmetic operator")]
		public void Arith_UOp_MinusBinaryNegBothUsingSub() {
			const string data = "-3.45 - -6";
			object expected = 2.55;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with multiple operands; first negative, rest positive; using subtraction as arithmetic operator")]
		public void Arith_UOp_MinusChainNegFirstUsingSub() {
			const string data = "-3.45 - 6 - 20 - 34.54";
			object expected = -63.99;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with multiple operands; first positive, rest negative; using subtraction as arithmetic operator")]
		public void Arith_UOp_MinusChainNegRestUsingSub() {
			const string data = "3.45 - -6 - -20 - -34.54";
			object expected = 63.99;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Unary minus with multiple operands; all negative; using subtraction as arithmetic operator")]
		public void Arith_UOp_MinusChainNegAllUsingSub() {
			const string data = "-3.45 - -6 - -20 - -34.54";
			object expected = 57.09;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_UOp_MinusObjCon() {
			const string data = "-new UnaryOp();";
			object expected = -new UnaryOp();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(((UnaryOp)expected).I, ((UnaryOp)actual).I, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Arith_UOp_PlusObjCon() {
			const string data = "+new UnaryOp();";
			object expected = +new UnaryOp();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(((UnaryOp)expected).I, ((UnaryOp)actual).I, "DATA: " + data);
		}
		#endregion

		#region Parens
		[TestMethod, Description("")]
		public void Arith_Parens_1() {
			const string data = "3 - (1 + 2)";
			object expected = 3 - (1 + 2);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_2() {
			const string data = "3 + -(1 + 2)";
			object expected = 3 + -(1 + 2);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_3() {
			const string data = "3 + +(1 + 2)";
			object expected = 3 + +(1 + 2);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_4() {
			const string data = "-(1)";
			object expected = -(1);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_5() {
			const string data = "+(1)";
			object expected = +(1);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_6() {
			const string data = "-(-1)";
			object expected = -(-1);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_7() {
			const string data = "+(+1)";
			object expected = +(+1);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_8() {
			const string data = "((1))";
			object expected = 1;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_9() {
			const string data = "((1)+2)";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Arith_Parens_10() {
			const string data = "((((1) + (2)) + (3-5)) / (52))";
			object expected = ((((1) + (2)) + (3 - 5)) / (52));
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Precedence
		[TestMethod, Description("Precedence test #1")]
		public void Arith_Precedence_1() {
			const string data = "2 + 3 * 5";
			object expected = 17;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #2")]
		public void Arith_Precedence_2() {
			const string data = "7 * 8 - 3 / 2";
			object expected = 55;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #3")]
		public void Arith_Precedence_3() {
			const string data = "90 - 46 + 77 / 7 / 2.0 % 7 + 8";
			object expected = 57.5;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Precedence test #4")]
		public void Arith_Precedence_4() {
			const string data = "923 + 789 * 23 - 14 % 17 / 2";
			object expected = 19063;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #5")]
		public void Arith_Precedence_5() {
			const string data = "7 * (8 - 3 / 2)";
			object expected = 49;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #6")]
		public void Arith_Precedence_6() {
			const string data = "90 - (46 + 77) / 7 / 2.0 % 7 + 8";
			object expected = 96.5;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Precedence test #7")]
		public void Arith_Precedence_7() {
			const string data = "(923 + 789) * ((23 - 14) % 17 / 2)";
			object expected = 6848;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #8")]
		public void Arith_Precedence_8() {
			const string data = "923 + 3 ** 4";
			object expected = 923 + Math.Pow(3, 4);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #9")]
		public void Arith_Precedence_9() {
			const string data = "28 * 61 ** 2";
			object expected = 28 * Math.Pow(61, 2);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #10")]
		public void Arith_Precedence_10() {
			const string data = "39 + 25 ** 3 * 8";
			object expected = 39 + Math.Pow(25, 3) * 8;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

		}
		[TestMethod, Description("Precedence test #11")]
		public void Arith_Precedence_11() {
			const string data = "39 + 25 ** (4 * 3)";
			object expected = 39 + Math.Pow(25, 4 * 3);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());

		}
		[TestMethod, Description("Precedence test #12")]
		public void Arith_Precedence_12() {
			const string data = "11 * (39 + 25) ** 4 * 3";
			object expected = 11 * Math.Pow(39 + 25, 4) * 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

		}
		[TestMethod, Description("Precedence test #13")]
		public void Arith_Precedence_13() {
			const string data = "90 ** 4 + 77 / 7 ** 2.3 % 7 * 8";
			object expected = Math.Pow(90, 4) + 77 / Math.Pow(7, 2.3) % 7 * 8;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Precedence test #14")]
		public void Arith_Precedence_14() {
			const string data = "-1 ** 2";
			object expected = -1.0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
	}
}
