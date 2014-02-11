using CSE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Tests {
	[TestClass]
	public class StressTests : ParserTestBase {
		[ClassInitialize]
		public static void Init(TestContext testContext) { BaseInit(testContext); }

		/// <summary>
		///		Tests:
		///		<para>literals (with and without suffix)</para>
		///		<para>
		///			primitive value-type casts on fields, properties, 
		///			return values of method calls, and literals
		///		</para>
		///		<para>stacked casts (cast then cast resulting expression)</para>
		///		<para>identifiers (fields and properties)</para>
		///		<para>static properties</para>
		///		<para>void and single return method calls</para>
		///		<para>object chains</para>
		///		<para>arguments</para>
		///		<para>type lookups</para>
		///		<para>object constructions</para>
		///		<para>calling inherited methods</para>
		///		<para>
		///			calling inherited methods implemented by base class 
		///			satisfying interface requirements
		///		</para>
		///		<para>excessive white spaces (including tabs and newlines)</para>
		/// </summary>
		[TestMethod, Description("Lits, casts, stacked casts, idents, meth calls, obj chains, args, types, obj constructs, extra ws")]
		public void StressTest_1() {
			const string data = @"
				testObj.MethTest.ArgTestRefTypes(
					Color.FromArgb(
						(byte)new Vector3(1f, (float)2+2 , (float)(double)(float)(int)4.5).   X,
						Color.Cyan.B,
						( byte  )testObj . IdentTest.		ushortFieldTest + 1
					),
					new Vector3(
						(float)new Random((int)DateTime.UtcNow.AddDays(new Random().NextDouble()).Millisecond).Next(5000),
						(float)new Rectangle(
							testObj.MethTest.NumericDiscreteReturn(), 
							new C().i, 
							(int)new C().CMeth2(new Random().Next()), 
							90 % 9
						).Location.X,
						new C().IAMeth3()
					)
				)";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.ArgTestRefTypesRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Lit chains and array exps")]
		public void StressTest_2() {
			const string data = @"
				testObj.MethTest.ArgTestRefTypes(
					Color.FromArgb(
						byte.Parse(""23.098"".Substring(0, ""23.098"".IndexOf('.'))),
						testObj.ArrTest.i[testObj.ArrTest.a + testObj.ArrTest.x * 2],
						byte.Parse(
							(testObj.IdentTest.decimalFieldTest.ToString().Substring
								(0,testObj.IdentTest.decimalFieldTest.ToString().IndexOf('.')))
						)
					),
					new Vector3(
						float.Parse(3.ToString()) + float.Parse(2.3.ToString()),
						float.Parse(
							(('3'.ToString() + true.ToString()).Substring
								(0,('3'.ToString() + true.ToString()).IndexOf('T')))
						),
						(int)testObj.ArrTest.v[2].Y + (float)testObj.ArrTest.i[0] + int.Parse((-2).ToString()) * -(3).ToString().Length
					)
				)";
			CsEval.Eval(data);
			if ((bool)CsEval.Eval("testObj.MethTest.ArgTestRefTypesRan") != true)
				Assert.Fail(data);
		}
		[TestMethod, Description("Stress arithmetic test")]
		public void StressTest_3() {
			const string data = @"
				testObj.MethTest.ReturnParam(
					+testObj.MethTest.ReturnParam(
						testObj.IdentTest.ushortFieldTest 
						+ 1.34
						- testObj.MethTest.NumericDiscreteReturn()
						* +new Vector3((float)new Random(new Random().Next()).Next(), (float)3.29 * 89, (float)4.34 + 5).Z
					)
					/
					-testObj.MethTest.ReturnParam(
						-testObj.MethTest.NumericRealReturn()
					)
				)
				% +11";
			object actual = CsEval.Eval(data);
			object expected = -1.0514287022181921;
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("Stress assignment test")]
		public void StressTest_4() {
			const string data = @"
				testObj.AssignTest.doubleFieldTest =
					(testObj.AssignTest.intPropertyTest = 5) +
					(testObj.AssignTest.vector3FieldTest = new Vector3(1, 2, 3)).X -
					(testObj.AssignTest.sbFieldTest = new StringBuilder(""Hello World"")).ToString().Length %
					(int)(testObj.AssignTest.bPropertyTest = new B()).IAMeth3() *
					(testObj.AssignTest.intArrayFieldTest[1] = 18) /
					(testObj.AssignTest.doubleArrayPropertyTest[(int)(testObj.AssignTest.vector3ArrayPropertyTest[0].Y = 4)] = 12.3) *

					testObj.AssignTest.intPropertyTest -
					testObj.AssignTest.vector3FieldTest.Z *
					testObj.AssignTest.sbFieldTest.Length %
					testObj.AssignTest.bPropertyTest.IAMeth3() /
					testObj.AssignTest.intArrayFieldTest[1] /
					testObj.AssignTest.vector3ArrayPropertyTest[0].Y /
					testObj.AssignTest.doubleArrayPropertyTest[4]
				";
			object actual = CsEval.Eval(data);
			object expected = -8.6341463414634134;
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void StressTest_5a() {
			const string data = @"o.result += o.func3(o.array[(int)(o.j = (float)(o.k += 5))].Item /= (
								-(o.a -= (short)-2)) + (int)(o.b **= (sbyte)1 / (sbyte)-2) +
								(int)(o.a += (short)(o.b -= (sbyte)(o.c *= o.d /= o.e **= (int)o.f))) *
								(int)o.i - (int)o.j / 3.0 + (o.g /= (byte)o.g) -
								(double)(o.aa -= (float)(o.bb += -(o.cc *= +(o.dd /= -(long)(o.ee ** o.ff))))));
								";
			object actual = CsEval.Eval(data);
			object expected = 32.375566790411916;
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void StressTest_5b() {
			const string data = @"o.result2 += 1 + 2 - 3 * 4 / 5 + 
								 (o.bb2 -= 5 / 4 * 3 - 2 + 1 % 
								 (o.b2 %= (sbyte)(1.1 * 2.2 + 3.3 / 4.4 - 5.5)) 
								 * -1.2 + -2.3 * +3.4 / -4.5 % +5.5 + (o.c2 *= o.d2 = 3.14f));
								";
			object actual = CsEval.Eval(data);
			object expected = -6.0177779875861273;
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("")]
		public void StressTest_5c() {
			const string data = @"o.result += 
									o.func3(
										o.array[(int)(o.j = (float)(o.k += 5))].Item /= 
										o.func(
											o.k /= o.func2(
												-(o.a -= -2))[
													(int)(o.b **= (sbyte)1 / (sbyte)-2), 
													(int)(o.a += (sbyte)(o.b -= (sbyte)(o.c *= o.d /= o.e **= (int)o.f)))
												][o.array2[(int)o.i, (int)o.j] / 3], 
											o.g /= o.g) -
										(double)(o.aa -= (decimal)(o.bb += -(o.cc *= +(o.dd /= -(o.ee ** o.ff)))))
									)
								";
			object actual = CsEval.Eval(data);
			object expected = 28.134543259475947;
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
		[TestMethod, Description("bitwise, logical, conditional, ternary, pow op, multi-line comments")]
		public void StressTest_6() {
			const string data = @"(
											(7 & (0 | (-1 & 2) | (4 & 7)) & ~~(~6 ^ ~2) & (~(0 ^ 1 & 2 | 3) | 31)) == /* 4 */ 
											((int)(((-(int.MaxValue ^ int.MinValue) << ~2) >> ~10) / 2 ** 7) << 1) /* 4 */
										 )
										 &&
										 (
											(0 ^ 1 ^ 2 << 0 ^ 3 ^ 2 << 1 | 5 | 6 & 7 & 4 >> 1) /* 7 */ ==
											((2 << (128 >> 1 >> 1 >> 2 >> 2)) - 1) /* 7 */
										 )
										 ?
											(2 > 1 && 45 < -1 || 2 <= 2 && 5 >= 3 ^ true != false || !!false ^ false || ((-2.0) > (-10.0))) /* true */
											?
											23 
											: 
											-1
										 :
										 -2;
										";
			object actual = CsEval.Eval(data);
			object expected = 23;
			Assert.IsTrue(WithinEpsilonRange(expected, actual), "EXPECTED:" + expected.ToString() + " ACTUAL:" + actual.ToString());
		}
	}
}
