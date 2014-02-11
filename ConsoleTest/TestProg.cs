using System;
using CSE;
using System.Collections;

namespace CSharpEval {
	class A {
		int i;
		string s;

		public A() {
			i = 3;
			s = "hello";
		}

		public static A operator +(A a, int x) {
			a.i += x;
			return a;
		}

		public static bool operator true(A a) {
			return true;
		}

		public static bool operator false(A a) {
			return false;
		}
	}

	class B {
		public int c = 65;
	}

	class A2 {
		public B[] b;

		public A2() {
			b = new B[] { new B() };
		}
	}

	class TestProg {
		A2 a;
    static Hashtable h;

		public TestProg() {
			a = new A2();
		}

		public void Bar(int i) {
		}

		public void Foo(out int i) {
			i = 5;
		}

		static void Main(string[] args) {
      h = new Hashtable();
      h.Add("hello", "world");
			//Console.Out.WriteLine(CSE.CsEval.Eval(null, "3 + 4"));
			//Test(typeof(byte), 300);

			CsEval.EvalEnvironment = new TestProg();

			Console.Out.Write(">> ");
			string exp = Console.In.ReadLine();

			while (exp != "") {
				try {
					CsEvaluator evaluator = CsEval.GetEvaluator(exp);
					object result = CsEval.Eval(evaluator);

					if (result == null)
						Console.Out.WriteLine(Environment.NewLine + "Returned: null");
					else
						Console.Out.WriteLine(Environment.NewLine + result.ToString());
				}
				catch (Exception e) {
					Console.Out.WriteLine(Environment.NewLine + e.Message);
				}

				Console.Out.Write(Environment.NewLine + ">> ");
				exp = Console.In.ReadLine();
			}
		}
	}
}
