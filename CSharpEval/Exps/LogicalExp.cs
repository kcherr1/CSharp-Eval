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

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse logical expressions
	/// </summary>
	/// 
	internal class LogicalExp {
		///
		/// <summary>
		///		Parses logical expressions
		/// </summary>
		/// 
		/// <param name="leftOp">Left operand</param>
		/// <param name="rightOp">Right operand</param>
		/// <param name="type">Logical expression type</param>
		/// 
		/// <returns>The result of applying the given logical expression operator</returns>
		/// 
		public static CseObject Parse(CseObject leftOp, CseObject rightOp, LogicalType type) {
			CseObject obj = null;

			if (type == LogicalType.NOT) {
				obj = new CseObject(null) { IsLiteral = leftOp.IsLiteral };
			}
			else {
				obj = new CseObject(null) { IsLiteral = leftOp.IsLiteral && rightOp.IsLiteral };
			}

			try {
				switch (type) {
					case LogicalType.AND:
						// TODO: lazy eval if exception thrown
						obj.Value = leftOp.Value && rightOp.Value;
						break;
					case LogicalType.OR:
						// TODO: lazy eval if exception thrown
						obj.Value = leftOp.Value || rightOp.Value;
						break;
					case LogicalType.NOT: {
							//try {
							obj.Value = !leftOp.Value;
							/*}
							catch {
								MethodInfo mi = obj.Value.GetType().GetMethod(OpOverloadNames.FALSE);
								if (mi != null)
									obj.Value = obj.Value.GetType().InvokeMember(OpOverloadNames.FALSE, OpOverloadNames.Flags, null, CsEval.evalEnvironment, new object[] { obj.Value });
								else
									obj.Value = null;
							}*/
						}
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
	}
}
