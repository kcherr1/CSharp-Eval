using System;
using CSE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Casts : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Non Numeric
		[TestMethod, Description("Casts true as boolean")]
		public void Cast_NonNum_BoolTrue() {
			const string data = "(bool)true";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts false as boolean")]
		public void Cast_NonNum_BoolFalse() {
			const string data = "(bool)false";
			object expected = false;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as char")]
		public void Cast_NonNum_Char() {
			const string data = "(char)68";
			object expected = (char)68;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Int Lits
		[TestMethod, Description("Casts numerical value as byte")]
		public void Cast_IntLit_Byte() {
			const string data = "(byte)3";
			object expected = (byte)3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as decimal")]
		public void Cast_IntLit_Decimal() {
			const string data = "(decimal)3";
			object expected = (decimal)3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as double")]
		public void Cast_IntLit_Double() {
			const string data = "(double)987";
			object expected = (double)987;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as float")]
		public void Cast_IntLit_Float() {
			const string data = "(float)83";
			object expected = (float)83;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_IntLit_Int() {
			const string data = "(int)7";
			object expected = 7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_IntLit_Int16() {
			const string data = "(Int16)7";
			object expected = (Int16)7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_IntLit_Int32() {
			const string data = "(Int32)7";
			object expected = (Int32)7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_IntLit_Int64() {
			const string data = "(Int64)7";
			object expected = (Int64)7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as long")]
		public void Cast_IntLit_Long() {
			const string data = "(long)28";
			object expected = (long)28;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as sbyte")]
		public void Cast_IntLit_SByte() {
			const string data = "(sbyte)-90";
			object expected = (sbyte)-90;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as short")]
		public void Cast_IntLit_Short() {
			const string data = "(short)2";
			object expected = (short)2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as short")]
		public void Cast_IntLit_Single() {
			const string data = "(Single)2";
			object expected = (Single)2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_IntLit_UInt() {
			const string data = "(uint)38";
			object expected = (uint)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_IntLit_UInt16() {
			const string data = "(UInt16)38";
			object expected = (UInt16)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_IntLit_UInt32() {
			const string data = "(UInt32)38";
			object expected = (UInt32)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_IntLit_UInt64() {
			const string data = "(UInt64)38";
			object expected = (UInt64)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as ulong")]
		public void Cast_IntLit_ULong() {
			const string data = "(ulong)293";
			object expected = (ulong)293;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as ushort")]
		public void Cast_IntLit_UShort() {
			const string data = "(ushort)72";
			object expected = (ushort)72;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Float Lits
		[TestMethod, Description("Casts numerical value as byte")]
		public void Cast_FltLit_Byte() {
			const string data = "(byte)3.8";
			object expected = (byte)3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as decimal")]
		public void Cast_FltLit_Decimal() {
			const string data = "(decimal)3.5";
			object expected = (decimal)3.5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as double")]
		public void Cast_FltLit_Double() {
			const string data = "(double)987.456";
			object expected = 987.456;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as float")]
		public void Cast_FltLit_Float() {
			const string data = "(float)83.23";
			object expected = (float)83.23;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_FltLit_Int() {
			const string data = "(int)7.9";
			object expected = 7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_FltLit_Int16() {
			const string data = "(Int16)7.9";
			object expected = (Int16)7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_FltLit_Int32() {
			const string data = "(Int32)7.9";
			object expected = (Int32)7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as int")]
		public void Cast_FltLit_Int64() {
			const string data = "(Int64)7.9";
			object expected = (Int64)7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as long")]
		public void Cast_FltLit_Long() {
			const string data = "(long)28.7";
			object expected = (long)28;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as sbyte")]
		public void Cast_FltLit_SByte() {
			const string data = "(sbyte)-90.9";
			object expected = (sbyte)-90;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as short")]
		public void Cast_FltLit_Short() {
			const string data = "(short)2.6";
			object expected = (short)2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as short")]
		public void Cast_FltLit_Single() {
			const string data = "(Single)2.6";
			object expected = (Single)2.6;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_FltLit_UInt() {
			const string data = "(uint)38.8";
			object expected = (uint)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_FltLit_UInt16() {
			const string data = "(UInt16)38.8";
			object expected = (UInt16)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_FltLit_UInt32() {
			const string data = "(UInt32)38.8";
			object expected = (UInt32)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as uint")]
		public void Cast_FltLit_UInt64() {
			const string data = "(UInt64)38.8";
			object expected = (UInt64)38;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as ulong")]
		public void Cast_FltLit_ULong() {
			const string data = "(ulong)293.9";
			object expected = (ulong)293;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Casts numerical value as ushort")]
		public void Cast_FltLit_UShort() {
			const string data = "(ushort)72.6";
			object expected = (ushort)72;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Suffix
		[TestMethod, Description("")]
		public void Cast_Suffix_U() {
			const string data = "(double)5u";
			object expected = (double)5u;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Cast_Suffix_L() {
			const string data = "(double)5L";
			object expected = (double)5L;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Cast_Suffix_UL() {
			const string data = "(double)5UL";
			object expected = (double)5UL;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Cast_Suffix_F() {
			const string data = "(double)5f";
			object expected = (double)5f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Cast_Suffix_M() {
			const string data = "(double)5m";
			object expected = (double)5m;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Cast_Suffix_D() {
			const string data = "(decimal)5d";
			object expected = (decimal)5d;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Cast_Suffix_DecToDouPowOp() {
			const string data = "(double)5m ** (double)3m";
			object expected = Math.Pow((double)5m, (double)3m);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
	}
}
