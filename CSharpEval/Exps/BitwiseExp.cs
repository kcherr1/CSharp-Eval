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
	///		Used to parse bitwise expressions
	/// </summary>
	/// 
	internal class BitwiseExp {
		///
		/// <summary>
		///		Parses bitwise expressions
		/// </summary>
		/// 
		/// <param name="leftOp">Left operand</param>
		/// <param name="rightOp">Right operand</param>
		/// <param name="type">Bitwise expression type</param>
		/// 
		/// <returns>The result of applying the given bitwise operand</returns>
		/// 
		public static CseObject Parse(CseObject leftOp, CseObject rightOp, BitwiseType type) {
			CseObject obj = null;

			if (type == BitwiseType.NOT) {
				obj = new CseObject(null) { IsLiteral = leftOp.IsLiteral };
			}
			else {
				obj = new CseObject(null) { IsLiteral = leftOp.IsLiteral && rightOp.IsLiteral };
			}

			try {
				switch (type) {
					case BitwiseType.AND:
						obj.Value = leftOp.Value & rightOp.Value;
						break;
					case BitwiseType.OR:
						obj.Value = leftOp.Value | rightOp.Value;
						break;
					case BitwiseType.NOT:
						obj.Value = ~leftOp.Value;
						break;
					case BitwiseType.SHL:
						obj.Value = leftOp.Value << rightOp.Value;
						break;
					case BitwiseType.SHR:
						obj.Value = leftOp.Value >> rightOp.Value;
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
