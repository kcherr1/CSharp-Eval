using System;
using System.Reflection;
using CSE.Exps;

namespace ConsoleTest {
	class A {
		public void Foo<T>(T data) where T : Random {
		}
	}
	class MethResTest {
		public static void Main2(string[] comArgs) {
			MethOverloads mo = new MethOverloads();
			A a = new A();
			//var t = a.GetType().GetMethod("Foo", BindingFlags.Public | BindingFlags.Instance).GetGenericArguments()[0].GetGenericParameterConstraints();//.GenericParameterAttributes;
			//mo.Baz(3);
			//mo.Foo( new int[] { 3, 1} );

			int? nullableint = null;

			CseObject from = new CseObject(new String[,] { { "1" } });
			Type to = a.GetType().GetMethod("Foo", BindingFlags.Public | BindingFlags.Instance).GetParameters()[0].ParameterType;
			//Console.Out.WriteLine(MethRes.CanConvertType(from, to));

			MethRes.GetBestInvocableMember(new MethResSettings(new A(), "Foo", new CseObject[] { new CseObject(3) }, false));

			Console.Out.WriteLine(MethRes.ImpRefConv(from, to));
			return;

			Console.WindowHeight = 20;
			Console.WindowWidth = 80;

			object env = new MethOverloads();
			string name = "Bar";
			CseObject[] args = new CseObject[] { 
				/*new CseObject('x') { 
					CallMod = CallArgMod.REF
				},
				new CseObject(3) {
					CallMod = CallArgMod.OUT
				}*/
				new CseObject(3)
			};

			MethResObject bestMember = MethRes.GetBestInvocableMember(new MethResSettings(env, name, args, false));


			Console.ForegroundColor = ConsoleColor.White;
			Console.Out.WriteLine("CALL");
			Console.Out.Write("\t{0}: {1}(", env.GetType().FullName, name);
			foreach (object arg in args)
				if (arg == null)
					Console.Out.Write("null, ");
				else
					Console.Out.Write(arg.GetType().Name + ", ");
			Console.Out.WriteLine("\b\b)\n", env.GetType().Name);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.Out.WriteLine("MATCH ");
			//foreach (MethodInfo appMember in appMembers)
			if (bestMember.MethInfo == null)
				Console.Out.WriteLine("\tNo matches found!");
			else
				Console.Out.WriteLine("\t" + bestMember.MethInfo.ReflectedType.ToString() + ": " + bestMember.MethInfo.ToString());
			Console.Out.WriteLine("");

			Console.ForegroundColor = ConsoleColor.Black;
		}
	}
}
