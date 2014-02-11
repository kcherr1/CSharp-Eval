
namespace CSE.Content {
	class OverrideDerived : OverrideBase {
		public override string Foo(int x) {
			return "Derived.Foo(int)";
		}

		public string Foo(object o) {
			return "Derived.Foo(object)";
		}
	}
}
