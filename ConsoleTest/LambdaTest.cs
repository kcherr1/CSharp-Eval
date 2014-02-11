using System;
using CSE;
using CSE.Exps;

namespace ConsoleTest {
	class LambdaTest {
		public delegate int Del(int i);

		//public static int Foo(Del func) {
		//   return func(3);
		//}

		public static int Foo(Func<int, int> func) {
			return func(3);
		}

		public static void Main3(string[] comArgs) {
			/*
			MethResTest mrt = new MethResTest();
			CsEval.EvalEnvironment = mrt;
			dynamic lambda = CSE.Exps.LambdaExp.Parse(new string[] { "x" }, "x+x");
			//LambdaExpression
			//LambdaExpression.Assign(new UnaryExpression
			//dynamic func = Activator.CreateInstance((lambda.Data.GetType() as Type).MakeGenericType(typeof(int), typeof(int)), lambda.Data);
			Type pType = mrt.GetType().GetMethod("Foo", BindingFlags.Static | BindingFlags.Public).GetParameters()[0].ParameterType;
			MethodInfo mInfo = mrt.GetType().GetMethod("Foo", BindingFlags.Static | BindingFlags.Public);
			//MethodInfo mInfo = (lambda.Data as Delegate).Method;
			//dynamic func = System.Delegate.CreateDelegate(pType, mInfo);
			//dynamic func = pType as Delegate;
			dynamic func = Delegate.CreateDelegate(pType, mrt, "func");
			func += lambda.Data;
			Console.Out.WriteLine(Foo(func));
			//Console.Out.WriteLine(CSE.Exps.LambdaExp.Invoke(lambda, new object[] { 4, 7 }));
			*/
			CsEval.EvalEnvironment = new MethResTest();
			dynamic lambda = CSE.Exps.LambdaExp.Parse(new string[] { "x" }, "x+x");
			dynamic clambda = LambdaExp.Invoke(lambda, new object[] { 3 });
			Console.Out.WriteLine(clambda);
		}
	}
}
