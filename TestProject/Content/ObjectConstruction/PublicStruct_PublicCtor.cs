using System;
using System.Drawing;



#pragma warning disable 1591

namespace CSE.Content.ObjectConstruction {
	public struct PublicStruct_PublicCtor {
		int i;
		float f;
		Color color;
		Random random;

		public PublicStruct_PublicCtor(int i, float f, Color color, Random random) {
			this.i = i;
			this.f = f;
			this.color = color;
			this.random = random;
		}
	}
}