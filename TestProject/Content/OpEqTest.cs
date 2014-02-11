using System;

namespace CSE.Content {
	internal class OpEqTest {
		public byte g;
		public sbyte b, b2;
		public short a;
		public ushort ff;
		public int e;
		public uint f;
		public long i;
		public ulong ee;
		public float aa, j, d, d2, c, c2;
		public double k, cc, dd, bb, bb2, result, result2;
		public OpEqTestItem[] array;
		public int[,] array2;

		public OpEqTest() {
			a = 0;
			b = b2 = -1;
			c = c2 = 2;
			d = d2 = 5;
			e = -2;
			f = 2;
			g = 1;
			i = 1;
			j = 2.275f;
			k = -2.21;
			aa = -0.8f;
			bb = bb2 = 2;
			cc = 1.45;
			dd = 3;
			ee = 12;
			ff = 2;
			result = result2 = 0;

			array = new OpEqTestItem[] {
				new OpEqTestItem(-2.5), new OpEqTestItem(38e-1), new OpEqTestItem(6),
				new OpEqTestItem(3.141592653), new OpEqTestItem(2.818), new OpEqTestItem(16e3)
			};
			array2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

		}

		public double func(double arg1, double arg2) {
			return Math.Sqrt(Math.Pow(arg1, arg2) * Math.Pow(arg2, arg1));
		}

		public double[,][] func2(double arg) {
			return new double[,][] {
				{ 
					new double[] { 1.1, 2.2, 3.3 }, 
					new double[] { 4.4, 5.5, 6.6 }, 
					new double[] { 7.7, 8.8, 9.9 } 
				},
				{ 
					new double[] { 0.1, 0.2, 0.3 }, 
					new double[] { 0.4, 0.5, 0.6 }, 
					new double[] { 0.7, 0.8, 0.9 } 
				}
			};
		}

		public double func3(double arg) {
			return (arg + a + b + c + d + e + f + g + i + j + k +
					(double)aa + bb + cc + dd + ee + ff);
		}
	}
}