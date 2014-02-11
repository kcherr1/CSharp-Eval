using System;
using System.Drawing;
using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Identifiers : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region FIELDS
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_Bool() {
			const string data = "testObj.IdentTest.boolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolFirstHexX2() {
			const string data = "testObj.IdentTest.\x62oolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolFirstHexX3() {
			const string data = "testObj.IdentTest.\x062oolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolFirstHexX4() {
			const string data = "testObj.IdentTest.\x0062oolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolFirstHexu() {
			const string data = "testObj.IdentTest.\u0062oolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolFirstHexU() {
			const string data = "testObj.IdentTest.\U00000062oolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolMidHexX2() {
			const string data = "testObj.IdentTest.b\x6FolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolMidHexX3() {
			const string data = "testObj.IdentTest.b\x06FolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolMidHexX4() {
			const string data = "testObj.IdentTest.b\x006FolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolMidHexu() {
			const string data = "testObj.IdentTest.b\u006FolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_BoolMidHexU() {
			const string data = "testObj.IdentTest.b\U0000006FolFieldTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Byte Field test")]
		public void Ident_Field_Byte() {
			const string data = "testObj.IdentTest.byteFieldTest";
			object expected = (byte)50;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Char Field test")]
		public void Ident_Field_Char() {
			const string data = "testObj.IdentTest.charFieldTest";
			object expected = 'x';
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Decimal Field test")]
		public void Ident_Field_Decimal() {
			const string data = "testObj.IdentTest.decimalFieldTest";
			object expected = 3.14156m;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Double Field test")]
		public void Ident_Field_Double() {
			const string data = "testObj.IdentTest.doubleFieldTest";
			object expected = 5.12345;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Float Field test")]
		public void Ident_Field_Float() {
			const string data = "testObj.IdentTest.floatFieldTest";
			object expected = 2.345f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Int Field test")]
		public void Ident_Field_Int() {
			const string data = "testObj.IdentTest.intFieldTest";
			object expected = -2309;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Long Field test")]
		public void Ident_Field_Long() {
			const string data = "testObj.IdentTest.longFieldTest";
			object expected = (long)89302;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("SByte Field test")]
		public void Ident_Field_SByte() {
			const string data = "testObj.IdentTest.sbyteFieldTest";
			object expected = (sbyte)-100;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Short Field test")]
		public void Ident_Field_Short() {
			const string data = "testObj.IdentTest.shortFieldTest";
			object expected = (short)10;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("String Field test")]
		public void Ident_Field_String() {
			const string data = "testObj.IdentTest.stringFieldTest";
			const string expected = "Hello World";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("UInt Field test")]
		public void Ident_Field_UInt() {
			const string data = "testObj.IdentTest.uintFieldTest";
			object expected = 78u;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("ULong Field test")]
		public void Ident_Field_ULong() {
			const string data = "testObj.IdentTest.ulongFieldTest";
			object expected = 928ul;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("UShort Field test")]
		public void Ident_Field_UShort() {
			const string data = "testObj.IdentTest.ushortFieldTest";
			object expected = (ushort)23;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Color Field test")]
		public void Ident_Field_Color() {
			const string data = "testObj.IdentTest.colorFieldTest";
			object expected = Color.Blue;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Vector3 Field test")]
		public void Ident_Field_Vector3() {
			const string data = "testObj.IdentTest.vector3FieldTest";
			object expected = new Vector3(1f, 2f, 3f);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_Field_AtSignPrefix() {
			const string data = "testObj.IdentTest.@if";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixFirstHexX2() {
			const string data = "testObj.IdentTest.@\x74his";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixFirstHexX3() {
			const string data = "testObj.IdentTest.@\x074his";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixFirstHexX4() {
			const string data = "testObj.IdentTest.@\x0069f";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixFirstHexu() {
			const string data = "testObj.IdentTest.@\u0069f";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixFirstHexU() {
			const string data = "testObj.IdentTest.@\U00000069f";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixMidHexX2() {
			const string data = "testObj.IdentTest.@i\x66";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixMidHexX3() {
			const string data = "testObj.IdentTest.@i\x066";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixMidHexX4() {
			const string data = "testObj.IdentTest.@i\x0066";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixMidHexu() {
			const string data = "testObj.IdentTest.@i\u0066";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Boolean Field test")]
		public void Ident_Field_AtSignPrefixMidHexU() {
			const string data = "testObj.IdentTest.@i\U00000066";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region PROPERTIES
		[TestMethod, Description("Boolean Property test")]
		public void Ident_Property_Bool() {
			const string data = "testObj.IdentTest.boolPropertyTest";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Byte Property test")]
		public void Ident_Property_Byte() {
			const string data = "testObj.IdentTest.bytePropertyTest";
			object expected = (byte)50;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Char Property test")]
		public void Ident_Property_Char() {
			const string data = "testObj.IdentTest.charPropertyTest";
			object expected = 'x';
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Decimal Property test")]
		public void Ident_Property_Decimal() {
			const string data = "testObj.IdentTest.decimalPropertyTest";
			object expected = 3.14156m;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Double Property test")]
		public void Ident_Property_Double() {
			const string data = "testObj.IdentTest.doublePropertyTest";
			object expected = 5.12345;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Float Property test")]
		public void Ident_Property_Float() {
			const string data = "testObj.IdentTest.floatPropertyTest";
			object expected = 2.345f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Int Property test")]
		public void Ident_Property_Int() {
			const string data = "testObj.IdentTest.intPropertyTest";
			object expected = -2309;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Long Property test")]
		public void Ident_Property_Long() {
			const string data = "testObj.IdentTest.longPropertyTest";
			object expected = (long)89302;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("SByte Property test")]
		public void Ident_Property_SByte() {
			const string data = "testObj.IdentTest.sbytePropertyTest";
			object expected = (sbyte)-100;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Short Property test")]
		public void Ident_Property_Short() {
			const string data = "testObj.IdentTest.shortPropertyTest";
			object expected = (short)10;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("String Property test")]
		public void Ident_Property_String() {
			const string data = "testObj.IdentTest.stringPropertyTest";
			const string expected = "Hello World";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("UInt Property test")]
		public void Ident_Property_UInt() {
			const string data = "testObj.IdentTest.uintPropertyTest";
			object expected = 78u;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("ULong Property test")]
		public void Ident_Property_ULong() {
			const string data = "testObj.IdentTest.ulongPropertyTest";
			object expected = 928ul;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("UShort Property test")]
		public void Ident_Property_UShort() {
			const string data = "testObj.IdentTest.ushortPropertyTest";
			object expected = (ushort)23;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Color Property test")]
		public void Ident_Property_Color() {
			const string data = "testObj.IdentTest.colorPropertyTest";
			object expected = Color.Blue;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Vector3 Property test")]
		public void Ident_Property_Vector3() {
			const string data = "testObj.IdentTest.vector3PropertyTest";
			object expected = new Vector3(1f, 2f, 3f);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_Property_AtSignPrefix() {
			const string data = "testObj.IdentTest.@If";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region SUFFIX COLLISIONS
		[TestMethod, Description("")]
		public void Ident_SuffixCollision_f() {
			const string data = "testObj.Suffixes.f";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_F() {
			const string data = "testObj.Suffixes.F";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_m() {
			const string data = "testObj.Suffixes.m";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_M() {
			const string data = "testObj.Suffixes.M";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_d() {
			const string data = "testObj.Suffixes.d";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_D() {
			const string data = "testObj.Suffixes.D";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_u() {
			const string data = "testObj.Suffixes.u";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_U() {
			const string data = "testObj.Suffixes.U";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_l() {
			const string data = "testObj.Suffixes.l";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_L() {
			const string data = "testObj.Suffixes.L";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_ul() {
			const string data = "testObj.Suffixes.ul";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_Ul() {
			const string data = "testObj.Suffixes.Ul";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_uL() {
			const string data = "testObj.Suffixes.uL";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_SuffixCollision_UL() {
			const string data = "testObj.Suffixes.UL";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region TERM CONSTANT COLLISIONS
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_C() {
			const string data = "testObj.Constants.C";
			object expected = 39;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_E() {
			const string data = "testObj.Constants.E";
			object expected = 9;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_GAMMA() {
			const string data = "testObj.Constants.GAMMA";
			object expected = 92;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_G() {
			const string data = "testObj.Constants.G";
			object expected = 7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_GC() {
			const string data = "testObj.Constants.GC";
			object expected = 17;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_H() {
			const string data = "testObj.Constants.H";
			object expected = 73;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_PHI() {
			const string data = "testObj.Constants.PHI";
			object expected = 5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConstCollision_Math_PI() {
			const string data = "testObj.Constants.PI";
			object expected = 82;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region TERM CONSTANTS
		[TestMethod, Description("")]
		public void Ident_TermConsts_C() {
			const string data = "#C";
			object expected = 299792458;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConsts_E() {
			const string data = "#E";
			object expected = Math.E;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConsts_GAMMA() {
			const string data = "#GAMMA";
			object expected = 0.5772156649;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConsts_G() {
			const string data = "#G";
			object expected = 9.8;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConsts_GC() {
			const string data = "#GC";
			object expected = 6.673e-11;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConsts_H() {
			const string data = "#H";
			object expected = 6.62606893e-34;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConsts_PHI() {
			const string data = "#PHI";
			object expected = (Math.Sqrt(5) + 1.0) / 2.0;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Ident_TermConsts_PI() {
			const string data = "#PI";
			object expected = Math.PI;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}

		[TestMethod, Description("")]
		public void Ident_TermConsts_Sum() {
			const string data = "#C + #E + #GAMMA + #G + #GC + #H + #PHI + #PI";
			object expected = 299792458 + Math.E + 0.5772156649 + 9.8 + 6.673e-11 + 6.62606893e-34 + ((Math.Sqrt(5) + 1.0) / 2.0) + Math.PI;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion
	}
}
