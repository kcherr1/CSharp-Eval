using System;
using System.Collections.Generic;

namespace ConsoleTest {
	public class MethOverloadsBase {
		public virtual void Foo(string s) {
		}

		public static void Bar(int i) {
		}
	}

	public class MethOverloads : MethOverloadsBase {
		private List<char> data;

		public char this[int i] {
			get {
				return data[i];
			}
		}


		public int Bar(ref char c, out int i) {
			i = 3;
			return 2;
		}

		public int Bar(params int[] args) {
			return 0;
		}

		public int Baz() {
			Console.Out.WriteLine(1);
			return 1;
		}

		//public int Bar(params string[] args) {
		//   return 3;
		//}

		//public char Bar(out char c, int i = 2) {
		//   c = 'x';
		//   return 'x';
		//}

		//public double Bar(char c, ref int i) {
		//   return 3.2;
		//}

		//public void Bar(char c, int i = 3, params object[] args) {

		//}

		public void Bar() {
		}

		//private void Foo(object o) {
		//}
		/*
		public virtual void Foo(object o) {
		}*/

		public override void Foo(string s) {
		}

		/*
		public void Foo(char c) {
		}*/

		public void Foo(Array i) {
		}

		//internal void Foo(int i, double d) {
		//}

		//protected void Foo(byte b, double d) {
		//}

		//protected internal void Foo<T>(T t) {
		//}

		//void Foo(int i, params object[] args) {
		//}

		//void Foo(int i, double d = 3.4, float f = 1.2f, char c = 'c') {
		//}

		//void Foo(ref string s, out sbyte sb) {
		//   sb = 3;
		//}
	}
}
