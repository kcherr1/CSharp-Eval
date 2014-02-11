
#pragma warning disable 1591

namespace CSE.Content {
	internal class C : B {
		public C() {
			i = 89;
		}

		public override void IAMeth1() {
		}
		public new string IAMeth2(int x) {
			return "IAMETH2 overridden by C";
		}

		public void CMeth1() {
		}
		public char CMeth2(int x) {
			return 'C';
		}
	}
}
