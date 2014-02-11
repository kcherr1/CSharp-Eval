using System;
using CSE;
using CSE.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class Assignment : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region CHAIN
		[TestMethod, Description("")]
		public void Assign_Chain_NewStruct() {
			string data = "testObj.AssignTest.vector3FieldTest = new Vector3(1, 2, 3)";
			CsEval.Eval(data);

			data = "testObj.AssignTest.vector3FieldTest.Z";
			object expected = 3f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_NewClass() {
			string data = "testObj.AssignTest.sbFieldTest = new StringBuilder(\"Hello World\")";
			CsEval.Eval(data);

			data = "testObj.AssignTest.sbFieldTest.ToString()";
			object expected = "Hello World";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_StaticObjStructFltField() {
			string data = "TestProj.staticTestObj.AssignTest.vector3FieldTest.X = 3";
			CsEval.Eval(data);

			data = "TestProj.staticTestObj.AssignTest.vector3FieldTest.X";
			object expected = 3f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_NonStaticObjStructFltField() {
			string data = "testObj.AssignTest.vector3FieldTest.X = 7";
			CsEval.Eval(data);

			data = "testObj.AssignTest.vector3FieldTest.X";
			object expected = 7f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_StrField() {
			string data = "testObj.AssignTest.stringFieldTest = \"Hello\"";
			CsEval.Eval(data);

			data = "testObj.AssignTest.stringFieldTest";
			object expected = "Hello";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_BPropertyToNewC() {
			string data = "testObj.AssignTest.bPropertyTest = new C()";
			CsEval.Eval(data);

			data = "testObj.AssignTest.bPropertyTest";
			object expected = 89;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, ((C)actual).GetI(), "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_BPropertyToNewB() {
			string data = "testObj.AssignTest.bPropertyTest = new B()";
			CsEval.Eval(data);

			data = "testObj.AssignTest.bPropertyTest.IAMeth3()";
			object expected = 3f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_BIntField() {
			string data = "testObj.AssignTest.bPropertyTest.i = 3";
			CsEval.Eval(data);

			data = "testObj.AssignTest.bPropertyTest.i";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_ArrayLitIndex() {
			string data = "testObj.ArrTest.assignTo[0] = 5";
			CsEval.Eval(data);

			data = "testObj.ArrTest.assignTo[0]";
			object expected = 5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_ArrayFieldIndex() {
			string data = "testObj.ArrTest.assignTo[x] = 5";
			CsEval.Eval(data);

			data = "testObj.ArrTest.assignTo[x]";
			object expected = 5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_IntProperty() {
			string data = "(testObj.AssignTest.intPropertyTest = 5)";
			CsEval.Eval(data);

			data = "testObj.AssignTest.intPropertyTest";
			object expected = 5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_StructArrayFieldToInt() {
			string data = "(testObj.AssignTest.vector3ArrayPropertyTest[0].Y = 4)";
			CsEval.Eval(data);

			data = "testObj.AssignTest.vector3ArrayPropertyTest[0].Y";
			object expected = 4f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Chain_DoubleArrayToDouble() {
			string data = "(testObj.AssignTest.doubleArrayPropertyTest[4] = 12.3)";
			CsEval.Eval(data);

			data = "testObj.AssignTest.doubleArrayPropertyTest[4]";
			object expected = 12.3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Assign_Chain_NestedStructArrayFieldToIntAsIndexToDoubleArrayToDouble() {
			string data = "(testObj.AssignTest.doubleArrayPropertyTest[(int)(testObj.AssignTest.vector3ArrayPropertyTest[0].Y = 4)] = 12.3)";
			CsEval.Eval(data);

			data = "testObj.AssignTest.doubleArrayPropertyTest[4]";
			object expected = 12.3;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		#endregion

		#region Operator Equals
		[TestMethod, Description("")]
		public void Assign_OpEq_AddSimple() {
			string data = "testObj.AssignTest.byteFieldTest += 3";
			object expected = (byte)5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.byteFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_SubSimple() {
			string data = "testObj.AssignTest.decimalFieldTest -= 3";
			object expected = -1m;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.decimalFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_MulSimple() {
			string data = "testObj.AssignTest.intFieldTest *= 3";
			object expected = 6;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.intFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_DivSimple() {
			string data = "testObj.AssignTest.floatFieldTest /= 3";
			object expected = (2f / 3.0f);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());

			data = "testObj.AssignTest.floatFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_ModSimple() {
			string data = "testObj.AssignTest.bytePropertyTest %= 3";
			object expected = (byte)2;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());

			data = "testObj.AssignTest.bytePropertyTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_PowSimple() {
			string data = "testObj.AssignTest.longFieldTest **= 3";
			object expected = 8L;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.longFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_AddCast() {
			string data = "testObj.AssignTest.sbyteFieldTest += (sbyte)3";
			object expected = (sbyte)5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.sbyteFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_SubCast() {
			string data = "testObj.AssignTest.shortFieldTest -= (short)3";
			object expected = (short)-1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.shortFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_MulCast() {
			string data = "testObj.AssignTest.uintFieldTest *= (uint)3";
			object expected = 6u;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.uintFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_DivCast() {
			string data = "testObj.AssignTest.doubleFieldTest /= (double)3";
			object expected = (2 / 3.0);
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());

			data = "testObj.AssignTest.doubleFieldTest";
			actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_ModCast() {
			string data = "testObj.AssignTest.longPropertyTest %= (long)4";
			object expected = 2L;
			object actual = CsEval.Eval(data);
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());

			data = "testObj.AssignTest.longPropertyTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_OpEq_PowCast() {
			string data = "testObj.AssignTest.ulongFieldTest **= (ulong)3";
			object expected = 8ul;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);

			data = "testObj.AssignTest.ulongFieldTest";
			actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region SIMPLE
		[TestMethod, Description("int field assignment")]
		public void Assign_Simple_IntFieldIntLit() {
			string data = "change = 3";
			CsEval.Eval(data);

			data = "change";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("string assigned to null")]
		public void Assign_Simple_StrToNull() {
			string data = "test = null";
			CsEval.Eval(data);

			data = "test";
			object expected = null;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("string assigned to string")]
		public void Assign_Simple_StrToStr() {
			string data = "test = \"Test\"";
			CsEval.Eval(data);

			data = "test";
			object expected = "Test";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Simple_IntChain() {
			string data = "x = y = z = 1";
			CsEval.Eval(data);

			data = "x * y * z";
			object expected = 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void Assign_Simple_IntChainAdd() {
			string data = "x = y = 2";
			CsEval.Eval(data);

			data = "x = y + 1";
			CsEval.Eval(data);

			data = "x ** y";
			object expected = Math.Pow(3, 2);
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
	}
}
