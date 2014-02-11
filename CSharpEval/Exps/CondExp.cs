/*
	CSharp Eval, a library for arbitrary execution of C# code
	Copyright 2012 Kevin A. Cherry and Timothy W. Wright

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

		http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
*/

using System.Reflection;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse conditional expressions
	/// </summary>
	/// 
	internal class CondExp {
		///
		/// <summary>
		///		Parses conditional expressions
		/// </summary>
		/// 
		/// <param name="leftOp">Left operand</param>
		/// <param name="rightOp">Right operand</param>
		/// <param name="type">Conditional operator type</param>
		/// 
		/// <returns>The result of applying the conditional operator</returns>
		/// 
		public static CseObject Parse(CseObject leftOp, CseObject rightOp, CondType type) {
			CseObject obj = new CseObject(null) { IsLiteral = leftOp.IsLiteral && rightOp.IsLiteral };

			try {
				switch (type) {
					case CondType.EQ:
						obj.Value = leftOp.Value == rightOp.Value;
						break;
					case CondType.NEQ:
						obj.Value = leftOp.Value != rightOp.Value;
						break;
					case CondType.GT:
						obj.Value = leftOp.Value > rightOp.Value;
						break;
					case CondType.GTE:
						obj.Value = leftOp.Value >= rightOp.Value;
						break;
					case CondType.LT:
						obj.Value = leftOp.Value < rightOp.Value;
						break;
					case CondType.LTE:
						obj.Value = leftOp.Value <= rightOp.Value;
						break;
					default:
						throw new System.NotImplementedException("Not implemented.");
				}
			}
			catch {
				// TODO: Fill this out!
			}

			return obj;
		}

		///
		/// <summary>
		///		Parses ternary expressions
		/// </summary>
		/// 
		/// <param name="cond">Conditional to test</param>
		/// <param name="truePart">Expression to return if condition is true</param>
		/// <param name="falsePart">Expression to return if condition is false</param>
		/// 
		/// <returns>truePart if cond is true, falsePart otherwise</returns>
		/// 
		public static CseObject Ternary(CseObject cond, CseObject truePart, CseObject falsePart) {
			bool? condBool = cond.Value as bool?;

			if (condBool != null)
				return condBool.Value ? truePart : falsePart;
			else {
				MethodInfo mi = cond.Value.GetType().GetMethod(OpOverloadNames.TRUE);
				if (mi != null)
					return new CseObject(cond.Value.GetType().InvokeMember(OpOverloadNames.TRUE, OpOverloadNames.Flags, null, CsEval.evalEnvironment, new object[] { cond.Value }));
				else
					return null;
				//TODO: throw new logic exception for this 
			}
		}
	}
}
