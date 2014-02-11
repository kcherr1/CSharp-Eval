
#pragma warning disable 0414

namespace CSE.Content {
	internal class AccessModifierTest {
		public int publicTest;
		protected int protectedTest;
		private int privateTest;
		internal int internalTest;

		public static int publicStaticTest;
		protected static int protectedStaticTest;
		private static int privateStaticTest;
		internal static int internalStaticTest;

		public const int publicConstTest = 9;
		protected const int protectedConstTest = 10;
		private const int privateConstTest = 11;
		internal const int internalConstTest = 12;

		public readonly int publicReadonlyTest;
		protected readonly int protectedReadonlyTest;
		private readonly int privateReadonlyTest;
		internal readonly int internalReadonlyTest;

		public static readonly int publicStaticReadonlyTest = 17;
		protected static readonly int protectedStaticReadonlyTest = 18;
		private static readonly int privateStaticReadonlyTest = 19;
		internal static readonly int internalStaticReadonlyTest = 20;

		public volatile int publicVolatileTest;
		protected volatile int protectedVolatileTest;
		private volatile int privateVolatileTest;
		internal volatile int internalVolatileTest;

		public static volatile int publicStaticVolatileTest;
		protected static volatile int protectedStaticVolatileTest;
		private static volatile int privateStaticVolatileTest;
		internal static volatile int internalStaticVolatileTest;

		public AccessModifierTest() {
			publicTest = 1;
			protectedTest = 2;
			privateTest = 3;
			internalTest = 4;

			publicStaticTest = 5;
			protectedStaticTest = 6;
			privateStaticTest = 7;
			internalStaticTest = 8;

			publicReadonlyTest = 13;
			protectedReadonlyTest = 14;
			privateReadonlyTest = 15;
			internalReadonlyTest = 16;

			publicVolatileTest = 21;
			protectedVolatileTest = 22;
			privateVolatileTest = 23;
			internalVolatileTest = 24;

			publicStaticVolatileTest = 25;
			protectedStaticVolatileTest = 26;
			privateStaticVolatileTest = 27;
			internalStaticVolatileTest = 28;
		}
	}
}
