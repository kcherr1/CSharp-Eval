using System;
using System.Drawing;

namespace CSE.Content {
	public class TestProj {
		TestClass testObj;
		static TestClass staticTestObj;
		OpEqTest o;
		Color Color;
		int[] iArr;
		int change = 5;
		int x = 2, y = 3, z = 4;
		int bgImageIndex;
		bool mouseLock;
		string test = "Hello";
		string str = "test";
		ushort ScreenWidth { get; set; }
		ushort ScreenHeight { get; set; }
		B b, c;
		C c2;
		double M = 6;
		int f = 5;
		short st = 3;

		public TestProj() {
			double d = Math.Pow(-1.02, Math.Pow(-2.05, -3.1));
			testObj = new TestClass();
			o = testObj.OpEqTest;
			iArr = new int[5] { 2, 4, 6, 8, 10 };
			test = "new Random(new Random(new Random(DateTime.Now.Millisecond).Next()).Next()).Next()";
			int i = 75;
			b = new B();
			c = new C();
			c2 = new C();
			TestProj.staticTestObj = new TestClass();
		}
	}
}
