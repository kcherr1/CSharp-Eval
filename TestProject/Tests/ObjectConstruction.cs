using CSE;
using CSE.Content.ObjectConstruction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class ObjectConstruction : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		#region Class
		#region Internal
		#region NoParams
		[TestMethod, Description("Internal class with internal, no parameters constructor")]
		public void ObjCon_Class_Internal_NoParams_InternalCtor() {
			const string data = "new InternalClass_InternalNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_InternalNoParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Internal class with private, no parameters constructor")]
		public void ObjCon_Class_Internal_NoParams_PrivateCtor() {
			const string data = "new InternalClass_PrivateNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_PrivateNoParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Internal class with protected, no parameters constructor")]
		public void ObjCon_Class_Internal_NoParams_ProtectedCtor() {
			const string data = "new InternalClass_ProtectedNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_ProtectedNoParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Internal class with public, no parameters constructor")]
		public void ObjCon_Class_Internal_NoParams_PublicCtor() {
			const string data = "new InternalClass_PublicNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_PublicNoParamCtor))
				Assert.Fail(data);
		}
		#endregion

		#region Params
		[TestMethod, Description("Internal class with internal, explicit parameters constructor")]
		public void ObjCon_Class_Internal_Params_InternalCtor() {
			const string data = "new InternalClass_InternalParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_InternalParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Internal class with private, explicit parameters constructor")]
		public void ObjCon_Class_Internal_Params_PrivateCtor() {
			const string data = "new InternalClass_PrivateParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_PrivateParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Internal class with protected, explicit parameters constructor")]
		public void ObjCon_Class_Internal_Params_ProtectedCtor() {
			const string data = "new InternalClass_ProtectedParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_ProtectedParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Internal class with public, explicit parameters constructor")]
		public void ObjCon_Class_Internal_Params_PublicCtor() {
			const string data = "new InternalClass_PublicParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalClass_PublicParamCtor))
				Assert.Fail(data);
		}
		#endregion
		#endregion

		#region Public
		#region NoParams
		[TestMethod, Description("Public class with internal, no parameters constructor")]
		public void ObjCon_Class_Public_NoParams_InternalCtor() {
			const string data = "new PublicClass_InternalNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_InternalNoParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Public class with private, no parameters constructor")]
		public void ObjCon_Class_Public_NoParams_PrivateCtor() {
			const string data = "new PublicClass_PrivateNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_PrivateNoParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Public class with protected, no parameters constructor")]
		public void ObjCon_Class_Public_NoParams_ProtectedCtor() {
			const string data = "new PublicClass_ProtectedNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_ProtectedNoParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Public class with public, no parameters constructor")]
		public void ObjCon_Class_Public_NoParams_PublicCtor() {
			const string data = "new PublicClass_PublicNoParamCtor()";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_PublicNoParamCtor))
				Assert.Fail(data);
		}
		#endregion

		#region Params
		[TestMethod, Description("Public class with internal, explicit parameters constructor")]
		public void ObjCon_Class_Public_Params_InternalCtor() {
			const string data = "new PublicClass_InternalParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_InternalParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Public class with private, explicit parameters constructor")]
		public void ObjCon_Class_Public_Params_PrivateCtor() {
			const string data = "new PublicClass_PrivateParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_PrivateParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Public class with protected, explicit parameters constructor")]
		public void ObjCon_Class_Public_Params_ProtectedCtor() {
			const string data = "new PublicClass_ProtectedParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_ProtectedParamCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("Public class with public, explicit parameters constructor")]
		public void ObjCon_Class_Public_Params_PublicCtor() {
			const string data = "new PublicClass_PublicParamCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicClass_PublicParamCtor))
				Assert.Fail(data);
		}
		#endregion
		#endregion
		#endregion

		#region Struct
		#region Internal
		[TestMethod, Description("")]
		public void ObjCon_Struct_Internal_InternalCtor() {
			const string data = "new InternalStruct_InternalCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalStruct_InternalCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("")]
		public void ObjCon_Struct_Internal_PrivateCtor() {
			const string data = "new InternalStruct_PrivateCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalStruct_PrivateCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("")]
		public void ObjCon_Struct_Internal_PublicCtor() {
			const string data = "new InternalStruct_PublicCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is InternalStruct_PublicCtor))
				Assert.Fail(data);
		}
		#endregion

		#region Public
		[TestMethod, Description("")]
		public void ObjCon_Struct_Public_InternalCtor() {
			const string data = "new PublicStruct_InternalCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicStruct_InternalCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("")]
		public void ObjCon_Struct_Public_PrivateCtor() {
			const string data = "new PublicStruct_PrivateCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicStruct_PrivateCtor))
				Assert.Fail(data);
		}
		[TestMethod, Description("")]
		public void ObjCon_Struct_Public_PublicCtor() {
			const string data = "new PublicStruct_PublicCtor(5, 7.8f, Color.Blue, new Random())";
			object actual = CsEval.Eval(data);
			if (!(actual is PublicStruct_PublicCtor))
				Assert.Fail(data);
		}
		#endregion
		#endregion
	}
}
