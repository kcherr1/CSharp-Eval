using CSE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class AccessModifiers : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Internal
		[TestMethod, Description("Internal test")]
		public void AccMod_Internal() {
			const string data = "testObj.AccModTest.internalTest";
			object expected = 4;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Internal const test")]
		public void AccMod_Internal_Const() {
			const string data = "testObj.AccModTest.internalConstTest";
			object expected = 12;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Internal readonly test")]
		public void AccMod_Internal_Readonly() {
			const string data = "testObj.AccModTest.internalReadonlyTest";
			object expected = 16;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Internal static test")]
		public void AccMod_Internal_Static() {
			const string data = "AccessModifierTest.internalStaticTest";
			object expected = 8;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Internal static readonly test")]
		public void AccMod_Internal_StaticReadonly() {
			const string data = "AccessModifierTest.internalStaticReadonlyTest";
			object expected = 20;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Internal static volatile test")]
		public void AccMod_Internal_StaticVolatile() {
			const string data = "AccessModifierTest.internalStaticVolatileTest";
			object expected = 28;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Internal volatile test")]
		public void AccMod_Internal_Volatile() {
			const string data = "testObj.AccModTest.internalVolatileTest";
			object expected = 24;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Private
		[TestMethod, Description("Private test")]
		public void AccMod_Private() {
			const string data = "testObj.AccModTest.privateTest";
			object expected = 3;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Private const test")]
		public void AccMod_Private_Const() {
			const string data = "testObj.AccModTest.privateConstTest";
			object expected = 11;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Private readonly test")]
		public void AccMod_Private_Readonly() {
			const string data = "testObj.AccModTest.privateReadonlyTest";
			object expected = 15;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Private static test")]
		public void AccMod_Private_Static() {
			const string data = "AccessModifierTest.privateStaticTest";
			object expected = 7;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Private static readonly test")]
		public void AccMod_Private_StaticReadonly() {
			const string data = "AccessModifierTest.privateStaticReadonlyTest";
			object expected = 19;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Private static volatile test")]
		public void AccMod_Private_StaticVolatile() {
			const string data = "AccessModifierTest.privateStaticVolatileTest";
			object expected = 27;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Private volatile test")]
		public void AccMod_Private_Volatile() {
			const string data = "testObj.AccModTest.privateVolatileTest";
			object expected = 23;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Protected
		[TestMethod, Description("Protected test")]
		public void AccMod_Protected() {
			const string data = "testObj.AccModTest.protectedTest";
			object expected = 2;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Protected const test")]
		public void AccMod_Protected_Const() {
			const string data = "testObj.AccModTest.protectedConstTest";
			object expected = 10;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Protected readonly test")]
		public void AccMod_Protected_Readonly() {
			const string data = "testObj.AccModTest.protectedReadonlyTest";
			object expected = 14;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Protected static test")]
		public void AccMod_Protected_Static() {
			const string data = "AccessModifierTest.protectedStaticTest";
			object expected = 6;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Protected static readonly test")]
		public void AccMod_Protected_StaticReadonly() {
			const string data = "AccessModifierTest.protectedStaticReadonlyTest";
			object expected = 18;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Protected static volatile test")]
		public void AccMod_Protected_StaticVolatile() {
			const string data = "AccessModifierTest.protectedStaticVolatileTest";
			object expected = 26;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Protected volatile test")]
		public void AccMod_Protected_Volatile() {
			const string data = "testObj.AccModTest.protectedVolatileTest";
			object expected = 22;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion

		#region Public
		[TestMethod, Description("Public test")]
		public void AccMod_Public() {
			const string data = "testObj.AccModTest.publicTest";
			object expected = 1;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Public const test")]
		public void AccMod_Public_Const() {
			const string data = "testObj.AccModTest.publicConstTest";
			object expected = 9;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Public readonly test")]
		public void AccMod_Public_Readonly() {
			const string data = "testObj.AccModTest.publicReadonlyTest";
			object expected = 13;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Public static test")]
		public void AccMod_Public_Static() {
			const string data = "AccessModifierTest.publicStaticTest";
			object expected = 5;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Public static readonly test")]
		public void AccMod_Public_StaticReadonly() {
			const string data = "AccessModifierTest.publicStaticReadonlyTest";
			object expected = 17;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Public static volatile test")]
		public void AccMod_Public_StaticVolatile() {
			const string data = "AccessModifierTest.publicStaticVolatileTest";
			object expected = 25;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		[TestMethod, Description("Public volatile test")]
		public void AccMod_Public_Volatile() {
			const string data = "testObj.AccModTest.publicVolatileTest";
			object expected = 21;
			object actual = CsEval.Eval(data);
			Assert.AreEqual(expected, actual, "DATA: " + data);
		}
		#endregion
	}
}
