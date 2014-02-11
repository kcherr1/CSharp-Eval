
#pragma warning disable 0414

namespace CSE.Content {
	internal class ArrayTest {
		int[] i, j, k, assignTo;
		Vector2[] v;
		int a = -2;
		int x = 1;

		public ArrayTest() {
			i = new int[] { 45, 2, 91, 34, 52, 564, 78 };
			j = new int[] { 2, 83, 1 };
			k = new int[] { 54, 2, 0, 4 };
			assignTo = new int[3];
			v = new Vector2[] {
					new Vector2(  5,  55),
					new Vector2( 27, 390),
					new Vector2(-90, 120)
			};
		}
	}
}
