using System;
using System.Drawing;



namespace CSE.Content.ObjectConstruction {
	internal struct InternalStruct_InternalCtor {
		int i;
		float f;
		Color color;
		Random random;

		internal InternalStruct_InternalCtor(int i, float f, Color color, Random random) {
			this.i = i;
			this.f = f;
			this.color = color;
			this.random = random;
		}
	}
}