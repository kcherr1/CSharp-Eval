using CSE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Literals : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Simple
		#region Exponential
		[TestMethod, Description("Exponential Integer")]
		public void Lit_Simple_Exp_Int() {
			const string data = "2E5";
			object expected = 2E5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Exponential integer with plus sign in input")]
		public void Lit_Simple_Exp_NegIntPlus() {
			const string data = "312E+17";
			object expected = 312E+17;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Negative exponential integer")]
		public void Lit_Simple_Exp_NegInt() {
			const string data = "-327E4";
			object expected = -327E4;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Exponential float")]
		public void Lit_Simple_Exp_Flt() {
			const string data = "23.4E-12";
			object expected = 23.4E-12;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Negative exponential float")]
		public void Lit_Simple_Exp_NegFlt() {
			const string data = "-12788E-16";
			object expected = -12788E-16;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Negative exponential float with decimal point in input")]
		public void Lit_Simple_Exp_NegFlt2() {
			const string data = "-3821.62E-139";
			object expected = -3821.62E-139;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Mult Signs
		[TestMethod, Description("")]
		public void Lit_Simple_MultSigns_1() {
			const string data = "-+-+-+4";
			const int expected = -+-+-+4;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Negative
		[TestMethod, Description("Negative short test")]
		public void Lit_Simple_Neg_Short() {
			const string data = "-300";
			object expected = -300;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Negative int test")]
		public void Lit_Simple_Neg_Int() {
			const string data = "-40000";
			object expected = -40000;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Negative long test")]
		public void Lit_Simple_Neg_Long() {
			const string data = "-9382736458";
			object expected = -9382736458;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Negative float test")]
		public void Lit_Simple_Neg_Float() {
			const string data = "-10.8345";
			object expected = -10.8345;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Negative double test")]
		public void Lit_Simple_Neg_Double() {
			const string data = "-429304873459827409983785736519304728304.9234";
			object expected = -429304873459827409983785736519304728304.9234;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region NonNumeric
		[TestMethod, Description("Boolean true test")]
		public void Lit_Simple_NonNum_BoolTrue() {
			const string data = "true";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean false test")]
		public void Lit_Simple_NonNum_BoolFalse() {
			const string data = "false";
			object expected = false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Char test")]
		public void Lit_Simple_NonNum_Char() {
			const string data = "'x'";
			object expected = 'x';
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("String test")]
		public void Lit_Simple_NonNum_String() {
			const string data = "\"Hello World\"";
			const string expected = "Hello World";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Null test")]
		public void Lit_Simple_NonNum_Null() {
			const string data = "null";
			object expected = null;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Multiple Escaped String Separated With Spaces")]
		public void Lit_Simple_NonNum_StringSpacedEscape() {
			const string data = @" "" \a \b \f \n \r \t \v \0 \"" \' \\ "" ";
			object expected = " \a \b \f \n \r \t \v \0 \" \' \\ "; // Last character is an escaped backslash
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Verbatim Escaped String")]
		public void Lit_Simple_NonNum_VerbatimEscapedString() {
			const string data = @" @"" \a \b \f \n \r \t \v \0 \' \"""" \\ "" ";
			object expected = @" \a \b \f \n \r \t \v \0 \' \"" \\ ";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Multiple Escaped String")]
		public void Lit_Simple_NonNum_StringEscape() {
			const string data = @" ""\a\b\f\n\r\t\v\0\""\'\\ "" ";
			object expected = "\a\b\f\n\r\t\v\0\"\'\\ ";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Simple_NonNum_StringHexEscape() {
			const string data = @" ""\x3 \xB \xc \x12 \x123 \x1234 \uAaBb \U00000020"" ";
			object expected = "\x3 \xB \xc \x12 \x123 \x1234 \uAaBb \U00000020";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Simple_NonNum_CharEscape() {
			const string data = @"
					'\a'.ToString() + 
					'\b'.ToString() +  
					'\f'.ToString() +
					'\n'.ToString() +
					'\r'.ToString() +
					'\t'.ToString() +
					'\v'.ToString() +
					'\0'.ToString() +
					'\''.ToString() +
					'\""'.ToString() +
					'\\'.ToString()
				";
			object expected = "\a\b\f\n\r\t\v\0\'\"\\";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Simple_NonNum_CharHexEscape() {
			const string data = @"       
					'\x3'.ToString() + 
					'\xB'.ToString() +  
					'\xc'.ToString() +
					'\x12'.ToString() +
					'\x123'.ToString() +
					'\x1234'.ToString() +
					'\uAaBb'.ToString() +
					'\U00000020'.ToString()
				";
			object expected = "\x3\xB\xc\x12\x123\x1234\uAaBb\U00000020";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Positive
		[TestMethod, Description("Int with + prefix")]
		public void Lit_Simple_Pos_IntWithPosSign() {
			const string data = "+50";
			object expected = 50;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Float with + prefix")]
		public void Lit_Simple_Pos_FloatWithPosSign() {
			const string data = "+50.89";
			object expected = 50.89;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		public void Lit_Simple_Pos_Byte() {
			const string data = "100";
			object expected = 100;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Positive short test")]
		public void Lit_Simple_Pos_Short() {
			const string data = "300";
			object expected = 300;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Positive int test")]
		public void Lit_Simple_Pos_Int() {
			const string data = "40000";
			object expected = 40000;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Positive long test")]
		public void Lit_Simple_Pos_Long() {
			const string data = "9382736458";
			object expected = 9382736458;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Positive float test")]
		public void Lit_Simple_Pos_Float() {
			const string data = ".8345";
			object expected = .8345;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Positive double test")]
		public void Lit_Simple_Pos_Double() {
			const string data = "429304873459827409983785736519304728304.9234";
			object expected = 429304873459827409983785736519304728304.9234;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Suffix
		[TestMethod, Description("Float conversion test")]
		public void Lit_Simple_Suffix_Float() {
			const string data = "3.5f";
			object expected = 3.5f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Decimal conversion test")]
		public void Lit_Simple_Suffix_Decimal() {
			const string data = "37.9283m";
			object expected = 37.9283m;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Double conversion test")]
		public void Lit_Simple_Suffix_Double() {
			const string data = "829.2374d";
			object expected = 829.2374d;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("ULong conversion test")]
		public void Lit_Simple_Suffix_ULong() {
			const string data = "429304873ul";
			object expected = 429304873ul;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("UInt conversion test")]
		public void Lit_Simple_Suffix_UInt() {
			const string data = "429u";
			object expected = 429u;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Long conversion test")]
		public void Lit_Simple_Suffix_Long() {
			const string data = "429304873459L";
			object expected = 429304873459L;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Simple_Suffix_ExpFloat() {
			const string data = "3.5e2f";
			object expected = 3.5e2f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Simple_Suffix_ExpDecimal() {
			const string data = "37.9283e2m";
			object expected = 37.9283e2m;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Simple_Suffix_ExpDouble() {
			const string data = "829.2374e2d";
			object expected = 829.2374e2d;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
		#endregion

		#region Chain
		#region NoParen
		#region NonNum
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_NonNum_BoolTrue() {
			const string data = "true.ToString()";
			const string expected = "True";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_NonNum_BoolFalse() {
			const string data = "false.ToString()";
			const string expected = "False";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_NonNum_Char() {
			const string data = "'x'.ToString()";
			const string expected = "x";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_NonNum_Str() {
			const string data = "\"Hello World\".Length";
			object expected = 11;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Num
		#region Exp
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValuePosInt() {
			const string data = "3e2.ToString()";
			object expected = 3e2.ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValuePosDbl() {
			const string data = "2.3E8.ToString().Length";
			object expected = 2.3E8.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValuePosIntWithSign() {
			const string data = "+3E15.ToString().Length";
			object expected = +3E15.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValuePosDblWithSign() {
			const string data = "+3.2E12.ToString().Length";
			object expected = +3.2E12.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueNegInt() {
			const string data = "-3E23.ToString().Length";
			object expected = -3E23.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueNegDbl() {
			const string data = "-3.2E07.ToString().Length";
			object expected = -3.2E07.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueWithSignPosInt() {
			const string data = "3e+2.ToString()";
			object expected = 3e+2.ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueWithSignPosDbl() {
			const string data = "2.3E+8.ToString().Length";
			object expected = 2.3E+8.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueWithSignPosIntWithSign() {
			const string data = "+3E+15.ToString().Length";
			object expected = +3E+15.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueWithSignPosDblWithSign() {
			const string data = "+1.6E+6.ToString().Length";
			object expected = +1.6E+6.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueWithSignNegInt() {
			const string data = "-3E+23.ToString().Length";
			object expected = -3E+23.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_PosValueWithSignNegDbl() {
			const string data = "-1.4E+18.ToString().Length";
			object expected = -1.4E+18.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_NegValuePosInt() {
			const string data = "3e-2.ToString()";
			object expected = 3e-2.ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_NegValuePosDbl() {
			const string data = "2.3E-8.ToString().Length";
			object expected = 2.3E-8.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_NegValuePosIntWithSign() {
			const string data = "+3E-15.ToString().Length";
			object expected = +3E-15.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_NegValuePosDblWithSign() {
			const string data = "+3.2E-12.ToString().Length";
			object expected = +3.2E-12.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_NegValueNegInt() {
			const string data = "-3E-23.ToString().Length";
			object expected = -3E-23.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Exp_NegValueNegDbl() {
			const string data = "-8.4E-9.ToString().Length";
			object expected = -8.4E-9.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Simple
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Simple_PosInt() {
			const string data = "3.ToString()";
			const string expected = "3";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Simple_PosIntWithSign() {
			const string data = "+3.ToString().Length";
			object expected = 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Simple_NegInt() {
			const string data = "-5.ToString().Length";
			object expected = -1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Simple_PosDbl() {
			const string data = "1.2.ToString()";
			const string expected = "1.2";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Simple_PosDblWithSign() {
			const string data = "+1.2.ToString().Length";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Simple_NegDbl() {
			const string data = "-3.2.ToString().Length";
			object expected = -3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Suffix
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_PosInt() {
			const string data = "3m.ToString()";
			const string expected = "3";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_PosDbl() {
			const string data = "1.2d.ToString()";
			const string expected = "1.2";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_PosIntWithSign() {
			const string data = "+3u.ToString().Length";
			object expected = +3u.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_PosDblWithSign() {
			const string data = "+1.2F.ToString().Length";
			object expected = +1.2F.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_NegInt() {
			const string data = "-5uL.ToString().Length";
			object expected = -5uL.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_NegDbl() {
			const string data = "-3.2f.ToString().Length";
			object expected = -3.2f.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_ExpPosInt() {
			const string data = "3e2m.ToString()";
			string expected = 3e2m.ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_ExpPosDbl() {
			const string data = "1.2e2d.ToString()";
			string expected = 1.2e2d.ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_ExpPosIntWithSign() {
			const string data = "+3e2M.ToString().Length";
			object expected = +3e2M.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_ExpPosDblWithSign() {
			const string data = "+1.2e2F.ToString().Length";
			object expected = +1.2e2F.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_ExpNegInt() {
			const string data = "-5e2D.ToString().Length";
			object expected = -5e2D.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_NoParen_Num_Suffix_ExpNegDbl() {
			const string data = "-3.2e2f.ToString().Length";
			object expected = -3.2e2f.ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
		#endregion
		#endregion

		#region Paren
		#region NonNum
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_NonNum_BoolTrue() {
			const string data = "(true).ToString()";
			const string expected = "True";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_NonNum_BoolFalse() {
			const string data = "(false).ToString()";
			const string expected = "False";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_NonNum_Char() {
			const string data = "('x').ToString()";
			const string expected = "x";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_NonNum_Str() {
			const string data = "(\"Hello World\").Length";
			object expected = 11;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Num
		#region Exp
		#region No Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValuePosInt() {
			const string data = "(3e2).ToString()";
			object expected = (3e2).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValuePosDbl() {
			const string data = "(2.3E8).ToString().Length";
			object expected = (2.3E8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValuePosIntWithSign() {
			const string data = "(+3E15).ToString().Length";
			object expected = (+3E15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValuePosDblWithSign() {
			const string data = "(+3.2E12).ToString().Length";
			object expected = (+3.2E12).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueNegInt() {
			const string data = "(-3E23).ToString().Length";
			object expected = (-3E23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueNegDbl() {
			const string data = "(-3.2E07).ToString().Length";
			object expected = (-3.2E07).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueWithSignPosInt() {
			const string data = "(3e+2).ToString()";
			object expected = (3e+2).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueWithSignPosDbl() {
			const string data = "(2.3E+8).ToString().Length";
			object expected = (2.3E+8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueWithSignPosIntWithSign() {
			const string data = "(+3E+15).ToString().Length";
			object expected = (+3E+15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueWithSignPosDblWithSign() {
			const string data = "(+1.6E+6).ToString().Length";
			object expected = (+1.6E+6).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueWithSignNegInt() {
			const string data = "(-3E+23).ToString().Length";
			object expected = (-3E+23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_PosValueWithSignNegDbl() {
			const string data = "(-1.4E+18).ToString().Length";
			object expected = (-1.4E+18).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_NegValuePosInt() {
			const string data = "(3e-2).ToString()";
			object expected = (3e-2).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_NegValuePosDbl() {
			const string data = "(2.3E-8).ToString().Length";
			object expected = (2.3E-8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_NegValuePosIntWithSign() {
			const string data = "(+3E-15).ToString().Length";
			object expected = (+3E-15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_NegValuePosDblWithSign() {
			const string data = "(+3.2E-12).ToString().Length";
			object expected = (+3.2E-12).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_NegValueNegInt() {
			const string data = "(-3E-23).ToString().Length";
			object expected = (-3E-23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NoOuterSign_NegValueNegDbl() {
			const string data = "(-8.4E-9).ToString().Length";
			object expected = (-8.4E-9).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Pos Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValuePosInt() {
			const string data = "+(3e2).ToString().Length";
			object expected = +(3e2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValuePosDbl() {
			const string data = "+(2.3E8).ToString().Length";
			object expected = +(2.3E8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValuePosIntWithSign() {
			const string data = "+(+3E15).ToString().Length";
			object expected = +(+3E15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValuePosDblWithSign() {
			const string data = "+(+3.2E12).ToString().Length";
			object expected = +(+3.2E12).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueNegInt() {
			const string data = "+(-3E23).ToString().Length";
			object expected = +(-3E23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueNegDbl() {
			const string data = "+(-3.2E07).ToString().Length";
			object expected = +(-3.2E07).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueWithSignPosInt() {
			const string data = "+(3e+2).ToString().Length";
			object expected = +(3e+2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueWithSignPosDbl() {
			const string data = "+(2.3E+8).ToString().Length";
			object expected = +(2.3E+8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueWithSignPosIntWithSign() {
			const string data = "+(+3E+15).ToString().Length";
			object expected = +(+3E+15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueWithSignPosDblWithSign() {
			const string data = "+(+1.6E+6).ToString().Length";
			object expected = +(+1.6E+6).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueWithSignNegInt() {
			const string data = "+(-3E+23).ToString().Length";
			object expected = +(-3E+23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_PosValueWithSignNegDbl() {
			const string data = "+(-1.4E+18).ToString().Length";
			object expected = +(-1.4E+18).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_NegValuePosInt() {
			const string data = "+(3e-2).ToString().Length";
			object expected = +(3e-2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_NegValuePosDbl() {
			const string data = "+(2.3E-8).ToString().Length";
			object expected = +(2.3E-8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_NegValuePosIntWithSign() {
			const string data = "+(+3E-15).ToString().Length";
			object expected = +(+3E-15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_NegValuePosDblWithSign() {
			const string data = "+(+3.2E-12).ToString().Length";
			object expected = +(+3.2E-12).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_NegValueNegInt() {
			const string data = "+(-3E-23).ToString().Length";
			object expected = +(-3E-23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_PosOuterSign_NegValueNegDbl() {
			const string data = "+(-8.4E-9).ToString().Length";
			object expected = +(-8.4E-9).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Neg Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValuePosInt() {
			const string data = "-(3e2).ToString().Length";
			object expected = -(3e2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValuePosDbl() {
			const string data = "-(2.3E8).ToString().Length";
			object expected = -(2.3E8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValuePosIntWithSign() {
			const string data = "-(+3E15).ToString().Length";
			object expected = -(+3E15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValuePosDblWithSign() {
			const string data = "-(+3.2E12).ToString().Length";
			object expected = -(+3.2E12).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueNegInt() {
			const string data = "-(-3E23).ToString().Length";
			object expected = -(-3E23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueNegDbl() {
			const string data = "-(-3.2E07).ToString().Length";
			object expected = -(-3.2E07).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueWithSignPosInt() {
			const string data = "-(3e+2).ToString().Length";
			object expected = -(3e+2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueWithSignPosDbl() {
			const string data = "-(2.3E+8).ToString().Length";
			object expected = -(2.3E+8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueWithSignPosIntWithSign() {
			const string data = "-(+3E+15).ToString().Length";
			object expected = -(+3E+15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueWithSignPosDblWithSign() {
			const string data = "-(+1.6E+6).ToString().Length";
			object expected = -(+1.6E+6).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueWithSignNegInt() {
			const string data = "-(-3E+23).ToString().Length";
			object expected = -(-3E+23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_PosValueWithSignNegDbl() {
			const string data = "-(-1.4E+18).ToString().Length";
			object expected = -(-1.4E+18).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_NegValuePosInt() {
			const string data = "-(3e-2).ToString().Length";
			object expected = -(3e-2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_NegValuePosDbl() {
			const string data = "-(2.3E-8).ToString().Length";
			object expected = -(2.3E-8).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_NegValuePosIntWithSign() {
			const string data = "-(+3E-15).ToString().Length";
			object expected = -(+3E-15).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_NegValuePosDblWithSign() {
			const string data = "-(+3.2E-12).ToString().Length";
			object expected = -(+3.2E-12).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_NegValueNegInt() {
			const string data = "-(-3E-23).ToString().Length";
			object expected = -(-3E-23).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Exp_NegOuterSign_NegValueNegDbl() {
			const string data = "-(-8.4E-9).ToString().Length";
			object expected = -(-8.4E-9).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
		#endregion

		#region Simple
		#region No Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NoOuterSign_PosInt() {
			const string data = "(3).ToString()";
			object expected = (3).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NoOuterSign_PosIntWithSign() {
			const string data = "(+3).ToString().Length";
			object expected = (+3).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NoOuterSign_NegInt() {
			const string data = "(-5).ToString().Length";
			object expected = (-5).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NoOuterSign_PosDbl() {
			const string data = "(1.2).ToString()";
			object expected = (1.2).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NoOuterSign_PosDblWithSign() {
			const string data = "(+1.2).ToString().Length";
			object expected = (+1.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NoOuterSign_NegDbl() {
			const string data = "(-3.2).ToString().Length";
			object expected = (-3.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Pos Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_PosOuterSign_PosInt() {
			const string data = "+(3).ToString().Length";
			object expected = +(3).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_PosOuterSign_PosIntWithSign() {
			const string data = "+(+3).ToString().Length";
			object expected = +(+3).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_PosOuterSign_NegInt() {
			const string data = "+(-5).ToString().Length";
			object expected = +(-5).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_PosOuterSign_PosDbl() {
			const string data = "+(1.2).ToString().Length";
			object expected = +(1.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_PosOuterSign_PosDblWithSign() {
			const string data = "+(+1.2).ToString().Length";
			object expected = +(+1.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_PosOuterSign_NegDbl() {
			const string data = "+(-3.2).ToString().Length";
			object expected = +(-3.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Neg Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NegOuterSign_PosInt() {
			const string data = "-(3).ToString().Length";
			object expected = -(3).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NegOuterSign_PosIntWithSign() {
			const string data = "-(+3).ToString().Length";
			object expected = -(+3).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NegOuterSign_NegInt() {
			const string data = "-(-5).ToString().Length";
			object expected = -(-5).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NegOuterSign_PosDbl() {
			const string data = "-(1.2).ToString().Length";
			object expected = -(1.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NegOuterSign_PosDblWithSign() {
			const string data = "-(+1.2).ToString().Length";
			object expected = -(+1.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Simple_NegOuterSign_NegDbl() {
			const string data = "-(-3.2).ToString().Length";
			object expected = -(-3.2).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
		#endregion

		#region Suffix
		#region No Exp
		#region No Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NoOuterSign_PosInt() {
			const string data = "(3m).ToString()";
			object expected = (3m).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NoOuterSign_PosDbl() {
			const string data = "(1.2d).ToString()";
			object expected = (1.2d).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NoOuterSign_PosIntWithSign() {
			const string data = "(+3u).ToString().Length";
			object expected = (+3u).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NoOuterSign_PosDblWithSign() {
			const string data = "(+1.2F).ToString().Length";
			object expected = (+1.2F).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NoOuterSign_NegInt() {
			const string data = "(-5L).ToString().Length";
			object expected = (-5L).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NoOuterSign_NegDbl() {
			const string data = "(-3.2f).ToString().Length";
			object expected = (-3.2f).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Pos Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_PosOuterSign_PosInt() {
			const string data = "+(3m).ToString().Length";
			object expected = +(3m).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_PosOuterSign_PosDbl() {
			const string data = "+(1.2d).ToString().Length";
			object expected = +(1.2d).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_PosOuterSign_PosIntWithSign() {
			const string data = "+(+3u).ToString().Length";
			object expected = +(+3u).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_PosOuterSign_PosDblWithSign() {
			const string data = "+(+1.2F).ToString().Length";
			object expected = +(+1.2F).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_PosOuterSign_NegInt() {
			const string data = "+(-5L).ToString().Length";
			object expected = +(-5L).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_PosOuterSign_NegDbl() {
			const string data = "+(-3.2f).ToString().Length";
			object expected = +(-3.2f).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Neg Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NegOuterSign_PosInt() {
			const string data = "-(3m).ToString().Length";
			object expected = -(3m).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NegOuterSign_PosDbl() {
			const string data = "-(1.2d).ToString().Length";
			object expected = -(1.2d).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NegOuterSign_PosIntWithSign() {
			const string data = "-(+3u).ToString().Length";
			object expected = -(+3u).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NegOuterSign_PosDblWithSign() {
			const string data = "-(+1.2F).ToString().Length";
			object expected = -(+1.2F).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NegOuterSign_NegInt() {
			const string data = "-(-5L).ToString().Length";
			object expected = -(-5L).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_NoExp_NegOuterSign_NegDbl() {
			const string data = "-(-3.2f).ToString().Length";
			object expected = -(-3.2f).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
		#endregion

		#region Exp
		#region No Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NoOuterSign_PosInt() {
			const string data = "(3e2m).ToString()";
			object expected = (3e2m).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NoOuterSign_PosDbl() {
			const string data = "(1.2e2d).ToString()";
			object expected = (1.2e2d).ToString();
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NoOuterSign_PosIntWithSign() {
			const string data = "(+3e2f).ToString().Length";
			object expected = (+3e2f).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NoOuterSign_PosDblWithSign() {
			const string data = "(+1.2e2F).ToString().Length";
			object expected = (+1.2e2F).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NoOuterSign_NegInt() {
			const string data = "(-5e2D).ToString().Length";
			object expected = (-5e2D).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NoOuterSign_NegDbl() {
			const string data = "(-3.2e2M).ToString().Length";
			object expected = (-3.2e2M).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Pos Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_PosOuterSign_PosInt() {
			const string data = "+(3e2m).ToString().Length";
			object expected = +(3e2m).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_PosOuterSign_PosDbl() {
			const string data = "+(1.2e2d).ToString().Length";
			object expected = +(1.2e2d).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_PosOuterSign_PosIntWithSign() {
			const string data = "+(+3e2M).ToString().Length";
			object expected = +(+3e2M).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_PosOuterSign_PosDblWithSign() {
			const string data = "+(+1.2e2F).ToString().Length";
			object expected = +(+1.2e2F).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_PosOuterSign_NegInt() {
			const string data = "+(-5e2D).ToString().Length";
			object expected = +(-5e2D).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_PosOuterSign_NegDbl() {
			const string data = "+(-3.2e2f).ToString().Length";
			object expected = +(-3.2e2f).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Neg Outer Sign
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NegOuterSign_PosInt() {
			const string data = "-(3e2m).ToString().Length";
			object expected = -(3e2m).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NegOuterSign_PosDbl() {
			const string data = "-(1.2e2d).ToString().Length";
			object expected = -(1.2e2d).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NegOuterSign_PosIntWithSign() {
			const string data = "-(+3e2M).ToString().Length";
			object expected = -(+3e2M).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NegOuterSign_PosDblWithSign() {
			const string data = "-(+1.2e2F).ToString().Length";
			object expected = -(+1.2e2F).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NegOuterSign_NegInt() {
			const string data = "-(-5e2D).ToString().Length";
			object expected = -(-5e2D).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Lit_Chain_Paren_Num_Suffix_Exp_NegOuterSign_NegDbl() {
			const string data = "-(-3.2e2f).ToString().Length";
			object expected = -(-3.2e2f).ToString().Length;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
		#endregion
		#endregion
		#endregion
		#endregion
		#endregion
	}
}
