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
using CSE.Exceptions;

namespace CSE.Exps {
	///
	/// <summary>
	///		Wrapper for values passed around the cse expression
	///		Parse methods. This allows the values to have metadata 
	///		attached to them for better decision making in some cases
	/// </summary>
	/// 
	internal class CseObject : ICloneable {
		///
		/// <summary>
		///		The actual value being held
		/// </summary>
		/// 
		public dynamic Value { get; set; }

		///
		/// <summary>
		///		List of CseObjects that make up the environments the identifier chain is composed of
		/// </summary>
		/// 
		/// <example>
		///		a.b[0].c.d[e]
		///		// EnvChain would be {the value of a, value of b (at 0) on a, value of c on b (at 0), and value of d (at e) on c}
		///	</example>
		/// 
		public List<CseObject> EnvChain { get; set; }

		///
		/// <summary>
		///		List of strings that make up the identifier names the identifier chain is composed of
		/// </summary>
		/// 
		/// <example>
		///		a.b[0].c.d[e]  
		///		// EnvNames would be {"a", "b", "c", "d"}
		///	</example>
		/// 
		public List<string> EnvNames { get; set; }

		///
		/// <summary>
		///		List of CseObjects that make up the indices of each array found in the identifier chain (or null if not an array)
		/// </summary>
		/// 
		/// <example>
		///		a.b[0].c.d[e]
		///		// EnvIndices would be {null, 0, null, value of e}
		///	</example>
		/// 
		public List<CseObject> EnvIndices { get; set; }

		///
		/// <summary>
		///		Returns the compile-time type of the identifier or, if that is null, the type of its current value.
		///		If both are null, null is returned
		/// </summary>
		/// 
		public Type ValueType {
			get {
				if (this.CompileTimeType == null) {
					if (this.Value == null) {
						return null;
					}
					else {
						return this.Value.GetType();
					}
				}
				else {
					return this.CompileTimeType;
				}
			}
		}

		///
		/// <summary>
		///		The type the Value had during compilation. This can
		///		help in cases where inheritance is used and the compile-time
		///		type of a field is not the same as its run-time type.
		///		<para>-</para>
		///		<para>E.g.</para>
		///		<para>/* field declaration */</para>
		///		<para>private BaseClass bc;</para>
		///		<para>/* in constructor or another method */</para>
		///		<para>bc = new DerivedClass();</para>
		///		<para>//</para>
		///		<para>
		///			This property would have the BaseClass type. This is
		///			helpful when determining which overloaded method to
		///			call since C# is single dispatch.
		///		</para>
		/// </summary>
		/// 
		public System.Type CompileTimeType { get; set; }

		///
		/// <summary>
		///		True if value is a literal, false otherwise.
		///		If value is not a literal, its type is not implicitly
		///		coerced to match method signatures during a call
		/// </summary>
		/// 
		public bool IsLiteral { get; set; }

		///
		/// <summary>
		///		Indicates what kind of method call argument modifier
		///		this value has in case it is used as an argument.
		/// </summary>
		/// 
		private CallArgMod callMod;

		///
		/// <summary>
		///		Gets or sets the callMod value. During a set, value is
		///		checked to see if it is a literal or not. If it is, only
		///		CallArgMod.NONE is a valid value and an exception is thrown
		///		if any other modifier is used.
		/// </summary>
		/// 
		public CallArgMod CallMod {
			get {
				return callMod;
			}
			set {
				if (IsLiteral && value != CallArgMod.VAL)
					throw new CseLogicException(CseLogicExceptionType.OUT_OR_REF_USED_WITH_LIT);
				else
					callMod = value;
			}
		}

		///
		/// <summary>
		///		Constructor
		/// </summary>
		/// 
		/// <param name="value">Object for it to hold</param>
		/// 
		public CseObject(dynamic value) {
			if (value is CseObject) {
				Value = ((CseObject)value).Value;
			}
			else {
				Value = value;
			}

			CompileTimeType = null;
			CallMod = CallArgMod.VAL;

			EnvChain = new List<CseObject>();
			EnvNames = new List<string>();
			EnvIndices = new List<CseObject>();

		}

		///
		/// <summary>
		///		Negates the value property
		/// </summary>
		/// 
		/// <param name="obj">CseObject to change</param>
		/// 
		/// <returns>The CseObject with its value property negated</returns>
		/// 
		public static CseObject operator -(CseObject obj) {
			return ArithExp.Negate(obj);
		}

		///
		/// <summary>
		///		Creates a shallow copy of this object
		/// </summary>
		/// 
		/// <returns>A shallow copy of the object</returns>
		/// 
		public object Clone() {
			return new CseObject(this.Value) {
				CallMod = this.CallMod,
				CompileTimeType = this.CompileTimeType,
				IsLiteral = this.IsLiteral,
				EnvChain = this.EnvChain,
				EnvNames = this.EnvNames,
				EnvIndices = this.EnvIndices
			};
		}

		///
		/// <summary>
		///		Creates a shallow copy of this object with a new value
		/// </summary>
		/// 
		/// <param name="newValue">Value to give the cloned object</param>
		/// 
		/// <returns>A shallow copy of the object with the given newValue</returns>
		/// 
		public CseObject Clone(dynamic newValue) {
			return new CseObject(newValue) {
				CallMod = this.CallMod,
				CompileTimeType = this.CompileTimeType,
				IsLiteral = this.IsLiteral,
				EnvChain = this.EnvChain,
				EnvNames = this.EnvNames,
				EnvIndices = this.EnvIndices
			};
		}
	}
}
