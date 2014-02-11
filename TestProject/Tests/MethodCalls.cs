using CSE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class MethodCalls : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Overloaded
		[TestMethod, Description("")]
		public void MethCall_Overloaded_SingleDispatch() {
			const string data = "testObj.MethTest.OverloadedMeth(testObj.MethTest.bc)";
			object expected = "B";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_SingleDispatch2() {
			const string data = "testObj.MethTest.OverloadedMeth(testObj.MethTest.BCMeth())";
			object expected = "B";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_1() {
			const string data = "testObj.MethTest.OverloadedMeth(testObj.MethTest.bb)";
			object expected = "B";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_2() {
			const string data = "testObj.MethTest.OverloadedMeth(2)";
			object expected = "int";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_3() {
			const string data = "testObj.MethTest.OverloadedMeth(300)";
			object expected = "int";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_4() {
			const string data = "testObj.MethTest.OverloadedMeth(50000)";
			object expected = "int";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_5() {
			const string data = "testObj.MethTest.OverloadedMeth(1234567898765432)";
			object expected = "long";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_6() {
			const string data = "testObj.MethTest.OverloadedMeth(3.4)";
			object expected = "double";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_7() {
			const string data = "testObj.MethTest.OverloadedMeth(1234567369874612387478901234567890.0)";
			object expected = "double";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_8() {
			const string data = "testObj.MethTest.OverloadedMeth(3, (byte)4)";
			object expected = "int,byte";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_9() {
			const string data = "testObj.MethTest.OverloadedMeth((byte)3, (byte)5)";
			object expected = "byte,byte";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_10() {
			const string data = "testObj.MethTest.OverloadedIntMeth(75)";
			object expected = "byte";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_11() {
			const string data = "testObj.MethTest.OverloadedIntMeth(750)";
			object expected = "short";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("")]
		public void MethCall_Overloaded_12() {
			const string data = "testObj.MethTest.OverloadedIntMeth(testObj.IdentTest.intFieldTest)";
			object expected = "long";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Overridden
		[TestMethod, Description("")]
		public void MethCall_Overridden_1() {
			const string data = "testObj.Override.d.Foo(testObj.Override.i)";
			object expected = "Derived.Foo(object)";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Return
		[TestMethod, Description("Discrete numeric return value test")]
		public void MethCall_Return_NumericDiscrete() {
			const string data = "testObj.MethTest.NumericDiscreteReturn()";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Real numeric return value test")]
		public void MethCall_Return_NumericReal() {
			const string data = "testObj.MethTest.NumericRealReturn()";
			object expected = 3.5f;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Bool return value test")]
		public void MethCall_Return_Bool() {
			const string data = "testObj.MethTest.BoolReturn()";
			object expected = true;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Char return value test")]
		public void MethCall_Return_Char() {
			const string data = "testObj.MethTest.CharReturn()";
			object expected = 'x';
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("String return value test")]
		public void MethCall_Return_String() {
			const string data = "testObj.MethTest.StringReturn()";
			const string expected = "Hello World";
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Static return value test")]
		public void MethCall_Return_Static() {
			const string data = "MethodTest.StaticReturn()";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Virtual return test")]
		public void MethCall_Return_Virtual() {
			const string data = "testObj.MethTest.VirtualReturn()";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Void
		[TestMethod, Description("Public void test")]
		public void MethCall_Void_Public() {
			const string data = "testObj.MethTest.PublicVoid()";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.publicVoidRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Protected void test")]
		public void MethCall_Void_Protected() {
			const string data = "testObj.MethTest.ProtectedVoid()";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.protectedVoidRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Private void test")]
		public void MethCall_Void_Private() {
			const string data = "testObj.MethTest.PrivateVoid()";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.privateVoidRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Internal void test")]
		public void MethCall_Void_Internal() {
			const string data = "testObj.MethTest.InternalVoid()";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.internalVoidRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Parameters of literal value types test")]
		public void MethCall_Void_ArgTestValueTypes_LitArgs() {
			const string data = "testObj.MethTest.ArgTestValueTypes(\"true, 2, x, 3.5, 4.5, 2.2, 8, 92, -90, 3, 23, 56, 9\"," +
								"true, 2, 'x', 3.5m, 4.5, 2.2f, 8, 92, (sbyte)-90, 3, 23, 56, 9)";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.ArgTestValueTypesRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Parameters of identifier property value types test")]
		public void MethCall_Void_ArgTestValueTypes_IdentFieldArgs() {
			const string data = "testObj.MethTest.ArgTestValueTypes(\"true, 50, x, 3.14156, 5.12345, 2.345, -2309, 89302, -100, 10, 78, 928, 23\"," +
								 "testObj.IdentTest.boolFieldTest, testObj.IdentTest.byteFieldTest, testObj.IdentTest.charFieldTest," +
								 "testObj.IdentTest.decimalFieldTest, testObj.IdentTest.doubleFieldTest, testObj.IdentTest.floatFieldTest," +
								 "testObj.IdentTest.intFieldTest, testObj.IdentTest.longFieldTest, testObj.IdentTest.sbyteFieldTest," +
								 "testObj.IdentTest.shortFieldTest, testObj.IdentTest.uintFieldTest, testObj.IdentTest.ulongFieldTest," +
								 "testObj.IdentTest.ushortFieldTest)";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.ArgTestValueTypesRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Parameters of identifier field value types test")]
		public void MethCall_Void_ArgTestValueTypes_IdentPropertyArgs() {
			const string data = "testObj.MethTest.ArgTestValueTypes(\"true, 50, x, 3.14156, 5.12345, 2.345, -2309, 89302, -100, 10, 78, 928, 23\"," +
																 "testObj.IdentTest.boolPropertyTest, testObj.IdentTest.bytePropertyTest, testObj.IdentTest.charPropertyTest," +
																 "testObj.IdentTest.decimalPropertyTest, testObj.IdentTest.doublePropertyTest, testObj.IdentTest.floatPropertyTest," +
																 "testObj.IdentTest.intPropertyTest, testObj.IdentTest.longPropertyTest, testObj.IdentTest.sbytePropertyTest," +
																 "testObj.IdentTest.shortPropertyTest, testObj.IdentTest.uintPropertyTest, testObj.IdentTest.ulongPropertyTest," +
																 "testObj.IdentTest.ushortPropertyTest)";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.ArgTestValueTypesRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Parameters of reference types test")]
		public void MethCall_Void_ArgTestRefTypes() {
			const string data = "testObj.MethTest.ArgTestRefTypes(Color.Blue, new Vector3(1f,2f,3f))";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.ArgTestRefTypesRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Static void test")]
		public void MethCall_Void_Static() {
			const string data = "testObj.MethTest.StaticVoid()";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.staticVoidRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Virtual void test")]
		public void MethCall_Void_Virtual() {
			const string data = "testObj.MethTest.VirtualVoid()";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.virtualVoidRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("")]
		public void MethCall_Void_SBytePosParam() {
			const string data = "testObj.MethTest.SByteMeth(3)";
			CsEval.Eval(data);
		}
		[TestMethod, Description("")]
		public void MethCall_Void_SByteNegParam() {
			const string data = "testObj.MethTest.SByteMeth(-3)";
			CsEval.Eval(data);
		}
		[TestMethod, Description("")]
		public void MethCall_Void_ByteParam() {
			const string data = "testObj.MethTest.ByteMeth(3)";
			CsEval.Eval(data);
		}
		[TestMethod, Description("")]
		public void MethCall_Void_ShortParam() {
			const string data = "testObj.MethTest.ShortMeth(3)";
			CsEval.Eval(data);
		}
		[TestMethod, Description("")]
		public void MethCall_Void_IntParam() {
			const string data = "testObj.MethTest.IntMeth(3)";
			CsEval.Eval(data);
		}
		[TestMethod, Description("")]
		public void MethCall_Void_LongParam() {
			const string data = "testObj.MethTest.LongMeth(3)";
			CsEval.Eval(data);
		}
		#endregion
	}
}
