using System;
using System.Drawing;



namespace CSE.Content.ObjectConstruction {
	internal struct InternalStruct_PrivateCtor {
		int i;
		float f;
		Color color;
		Random random;

		private InternalStruct_PrivateCtor(int i, float f, Color color, Random random) {
			this.i = i;
			this.f = f;
			this.color = color;
			this.random = random;
		}
	}
}