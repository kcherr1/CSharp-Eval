
namespace CSE.Content {
	class UnaryOp {
		public int I { get; private set; }

		public UnaryOp() {
			I = 3;
		}

		public static UnaryOp operator -(UnaryOp um) {
			um.I = -um.I;
			return um;
		}

		public static UnaryOp operator +(UnaryOp um) {
			return um;
		}
	}
}
