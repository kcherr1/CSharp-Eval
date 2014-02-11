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
	///		Used for storing temporary identifiers declared in the given expression
	/// </summary>
	/// 
	/// <remarks>Not fully supported yet!</remarks>
	/// 
	internal static class TempIdentifierExp {
		//TODO: Make stack of dictionaries for scope. Have PushScope and PopScope as public methods.
		//		  Only add idents to top of stack.

		///
		/// <summary>
		///		List of temporary identifiers that have been declared
		/// </summary>
		/// 
		private static Dictionary<string, CseObject> tempIdents = new Dictionary<string, CseObject>();

		///
		/// <summary>
		///		Adds a temporary identifier of the given type and name
		/// </summary>
		/// 
		/// <param name="type">Type of identifier</param>
		/// <param name="name">Name of identifier</param>
		/// 
		public static void AddIdent(Type type, string name) {
			AddIdent(type, name, type.IsValueType ? Activator.CreateInstance(type) : null);
		}

		///
		/// <summary>
		///		Adds a temporary identifier of the given type and name and initializes
		///		it to the given initValue
		/// </summary>
		/// 
		/// <param name="type">Type of identifier</param>
		/// <param name="name">Name of identifier</param>
		/// <param name="initValue">Initial value of identifer</param>
		/// 
		public static void AddIdent(Type type, string name, dynamic initValue) {
			dynamic value = (initValue is CseObject ? initValue.Value : initValue);

			// TODO: Make CseExceptionType for type assign mismatch
			if (!TypeExp.TypeAssignMatch(type, value))
				throw new Exception(String.Format("Cannot assign {0} to variable of type {1}", value, type.ToString()));

			CseObject ident = new CseObject(value) {
				CompileTimeType = type,
				IsLiteral = false,
				CallMod = CallArgMod.VAL
			};

			/* TODO: Add custom error type and message for duplicate ident names
			 * if (tempIdents.ContainsKey(name))
			 *	throw new CseLogicException(CseLogicExceptionType.??, name);
			 * 
			 * TODO: Add keyword (maybe with a prefix) that returns a list of all 
			 * currently stored temp vars along with their type and value
			 */

			tempIdents.Add(name, ident);
		}

		///
		/// <summary>
		///		Looks up temporary identifier of the given name and returns it
		/// </summary>
		/// 
		/// <param name="name">Identifier name to look up</param>
		/// 
		/// <returns>The temporary identifier of the given name if found, null otherwise</returns>
		/// 
		public static CseObject Lookup(string name) {
			CseObject result;
			tempIdents.TryGetValue(name, out result);

			return result;
		}

		///
		/// <summary>
		///		Assigns the given value to the temporary identifier of the given name
		/// </summary>
		/// 
		/// <param name="name">Identifier name</param>
		/// <param name="value">Value to assign identifier</param>
		/// 
		public static void Assign(string name, object value) {
			// TODO: Check value type against stored type (type checking)
			// maybe make method in TypeExp for this operation, along with typeof keyword?
			if (tempIdents.ContainsKey(name))
				tempIdents[name].Value = value;
		}
	}
}
