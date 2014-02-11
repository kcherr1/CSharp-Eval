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
	///		Used to parse xor expressions
	/// </summary>
	/// 
	internal class XorExp {
		///
		/// <summary>
		///		Parses xor expressions
		/// </summary>
		/// 
		/// <param name="leftOp">Left operand</param>
		/// <param name="rightOp">Right operand</param>
		/// 
		/// <returns>The result of applying the xor operator</returns>
		/// 
		public static CseObject Parse(CseObject leftOp, CseObject rightOp) {
			CseObject obj = new CseObject(null) { IsLiteral = leftOp.IsLiteral && rightOp.IsLiteral };
			obj.Value = leftOp.Value ^ rightOp.Value;
			return obj;
		}
	}
}
