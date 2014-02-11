using System.Collections.Generic;
using oot = CSE.Content.OpOverloadType;

namespace CSE.Content {
	public class OpOverload {
		private List<OpOverloadType> OpName { get; set; }

		public oot LastOp {
			get {
				if (OpName.Count == 0)
					return oot.NONE;
				else
					return OpName[OpName.Count - 1];
			}
		}

		public OpOverload() {
			this.OpName = new List<oot>();
		}


		#region UNARY
		// unary plus
		public static OpOverload operator +(OpOverload o) {
			o.OpName.Add(oot.UPLUS);
			return o;
		}

		// unary minus
		public static OpOverload operator -(OpOverload o) {
			o.OpName.Add(oot.UMINUS);
			return o;
		}

		// logical not
		public static OpOverload operator !(OpOverload o) {
			o.OpName.Add(oot.BANG);
			return o;
		}

		// bitwise not
		public static OpOverload operator ~(OpOverload o) {
			o.OpName.Add(oot.BIT_NOT);
			return o;
		}

		// inc
		public static OpOverload operator ++(OpOverload o) {
			o.OpName.Add(oot.INC);
			return o;
		}

		// dec
		public static OpOverload operator --(OpOverload o) {
			o.OpName.Add(oot.DEC);
			return o;
		}

		// true
		public static bool operator true(OpOverload o) {
			o.OpName.Add(oot.TRUE);
			return true;
		}

		// false
		public static bool operator false(OpOverload o) {
			o.OpName.Add(oot.FALSE);
			return false;
		}
		#endregion

		#region BINARY
		// plus
		public static OpOverload operator +(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.ADD);
			o2.OpName.Add(oot.ADD);

			return o1;
		}

		// minus
		public static OpOverload operator -(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.SUB);
			o2.OpName.Add(oot.SUB);

			return o1;
		}

		// mult
		public static OpOverload operator *(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.MUL);
			o2.OpName.Add(oot.MUL);

			return o1;
		}

		// div
		public static OpOverload operator /(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.DIV);
			o2.OpName.Add(oot.DIV);

			return o1;
		}

		// mod
		public static OpOverload operator %(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.MOD);
			o2.OpName.Add(oot.MOD);

			return o1;
		}

		// bitwise and
		public static OpOverload operator &(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.BIT_AND);
			o2.OpName.Add(oot.BIT_AND);

			return o1;
		}

		// bitwise or
		public static OpOverload operator |(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.BIT_OR);
			o2.OpName.Add(oot.BIT_OR);

			return o1;
		}

		// bitwise xor
		public static OpOverload operator ^(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.BIT_XOR);
			o2.OpName.Add(oot.BIT_XOR);

			return o1;
		}

		// left shift
		public static OpOverload operator <<(OpOverload o1, int i) {
			o1.OpName.Add(oot.BIT_LSHIFT);

			return o1;
		}

		// right shift
		public static OpOverload operator >>(OpOverload o1, int i) {
			o1.OpName.Add(oot.BIT_RSHIFT);

			return o1;
		}
		#endregion

		#region COMPARISON
		// eq
		public static OpOverload operator ==(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.EQ);
			o2.OpName.Add(oot.EQ);

			return o1;
		}

		// neq
		public static OpOverload operator !=(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.NEQ);
			o2.OpName.Add(oot.NEQ);

			return o1;
		}

		// lt
		public static OpOverload operator <(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.LT);
			o2.OpName.Add(oot.LT);

			return o1;
		}

		// gt
		public static OpOverload operator >(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.GT);
			o2.OpName.Add(oot.GT);

			return o1;
		}

		// lte
		public static OpOverload operator <=(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.LTE);
			o2.OpName.Add(oot.LTE);

			return o1;
		}

		// gte
		public static OpOverload operator >=(OpOverload o1, OpOverload o2) {
			o1.OpName.Add(oot.GTE);
			o2.OpName.Add(oot.GTE);

			return o1;
		}

		#endregion
	}
}
