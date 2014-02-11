
// TODO: Change CSE.Content to TestProject.Content
namespace CSE.Content {
	internal class TestClass {
		public AccessModifierTest AccModTest { get; set; }
		public ArrayTest ArrTest { get; set; }
		public AssignmentTest AssignTest { get; set; }
		public EnumTest ETest { get; set; }
		public IdentifierTest IdentTest { get; set; }
		public MethodTest MethTest { get; set; }
		public SpecialExpressionsTest SpecExpTest { get; set; }
		public OpEqTest OpEqTest { get; set; }
		public Suffixes Suffixes { get; set; }
		public TermConstants Constants { get; set; }
		public OverrideTest Override { get; set; }
		public OpOverload OpOver1 { get; set; }
		public OpOverload OpOver2 { get; set; }

		public TestClass() {
			AccModTest = new AccessModifierTest();
			ArrTest = new ArrayTest();
			ETest = new EnumTest();
			IdentTest = new IdentifierTest();
			MethTest = new MethodTest();
			SpecExpTest = new SpecialExpressionsTest();
			AssignTest = new AssignmentTest();
			OpEqTest = new OpEqTest();
			Suffixes = new Suffixes();
			Constants = new TermConstants();
			Override = new OverrideTest();
			OpOver1 = new OpOverload();
			OpOver2 = new OpOverload();
		}
	}
}
