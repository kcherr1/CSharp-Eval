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

using System;
using System.Collections.Generic;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse assignment expressions
	/// </summary>
	/// 
	internal static class AssignExp {
		///
		/// <summary>
		///		Parses assignment expressions. This method basically just prepares
		///		the parameters for a call to IdentifierExp.Assign(). Reference that
		///		method for more information on this method's parameters.
		/// </summary>
		/// 
		/// <param name="envChain">
		///		List of CseObjects from the chain expression of the lhs.
		///		This makes up the list of environment objects.
		///	</param>
		/// <param name="envNames">List of field/property names in the lhs chain expression.</param>
		/// <param name="envIndices">
		///		List of array indices for each array in the lhs chain expression.
		///		For each non-array, the envIndices at that index is null.
		///	</param>
		/// <param name="rhs">Rhs expression</param>
		/// 
		/// <returns>The rhs parameter</returns>
		/// 
		public static CseObject Parse(List<CseObject> envChain, List<string> envNames, List<CseObject> envIndices, CseObject rhs) {
			Type envType;

			while (envChain.Count > 1) {
				envType = envChain[1].Value.GetType();
				if (!envType.IsValueType) {
					envChain.RemoveAt(0);
					envNames.RemoveAt(0);
					envIndices.RemoveAt(0);
				}
				else {
					break;
				}
			}

			IdentifierExp.Assign(envChain, envNames, envIndices, rhs);
			return rhs;
		}
	}
}
