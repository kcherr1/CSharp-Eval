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
using System.Reflection;
using CSE.Exceptions;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse object construction expressions
	/// </summary>
	/// 
	internal static class ObjectConstructionExp {
		///
		/// <summary>
		///		Parses object construction expression (expressions using "new")
		/// </summary>
		/// 
		/// <param name="instance">The root object</param>
		/// <param name="typeName">Name of the type to create</param>
		/// <param name="constructorParams">
		///		CseObject array containing arguments to be sent to the constructor. 
		///		Each CseObject is one argument
		/// </param>
		/// 
		/// <returns>CseObject containing the new object</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.UNKNOWN_TYPE" />
		///
		internal static CseObject Parse(CseObject instance, string typeName, List<CseObject> constructorParams) {
			BindingFlags flags = BindingFlags.CreateInstance |
								 BindingFlags.Instance |
								 BindingFlags.NonPublic |
								 BindingFlags.Public;

			Type typeFound = TypeExp.GetType(typeName);
			CseObject result = null;

			if (typeFound != null) {
				if (constructorParams != null && constructorParams.Count > 0) {
					object[] objArgs = new object[constructorParams.Count];
					for (int i = 0; i < constructorParams.Count; i++)
						objArgs[i] = constructorParams[i].Value;

					result = new CseObject(Activator.CreateInstance(typeFound, flags, null, objArgs, null));
				}
				else {
					result = new CseObject(Activator.CreateInstance(typeFound, flags, null, null, null));
				}
			}
			else {
				throw new CseLogicException(CseLogicExceptionType.UNKNOWN_TYPE, typeName);
			}

			return result;
		}
	}
}