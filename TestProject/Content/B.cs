
#pragma warning disable 1591

namespace CSE.Content {
	internal class B : IA {
		protected int i;

		public B() {
		}

		public virtual void IAMeth1() {
		}

		public string IAMeth2(int x) {
			return "IAMETH2 implemented by B";
		}

		public float IAMeth3() {
			return 3f;
		}

		public void BMeth1() {
		}

		public char BMeth2(int x) {
			return 'B';
		}

		public int GetI() {
			return i;
		}
	}
}
