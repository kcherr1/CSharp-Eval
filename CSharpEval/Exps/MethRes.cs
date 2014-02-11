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

namespace CSE.Exps {
	///
	/// <summary>
	///		A set of static methods and members for use in method resolution.
	/// </summary>
	/// 
	internal static class MethRes {
		///
		/// <summary>
		///		The allowed transitions for numerical types. A given type maps to a list of valid conversions type objects for that type.
		/// </summary>
		/// 
		private static Dictionary<Type, List<Type>> NumConv = new Dictionary<Type, List<Type>> {
			{typeof(sbyte), new List<Type> { typeof(short), typeof(int), typeof(long), typeof(float), typeof(double), typeof(decimal) }},
			{typeof(byte), new List<Type> { typeof(short) ,typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double) ,typeof(decimal)}},
			{typeof(short), new List<Type> { typeof(int) ,typeof(long), typeof(float), typeof(double), typeof(decimal)}},
			{typeof(ushort), new List<Type> {typeof(int), typeof(uint), typeof(long), typeof(ulong),typeof(float), typeof(double), typeof(decimal)}},
			{typeof(int), new List<Type> { typeof(long), typeof(float), typeof(double), typeof(decimal) }},
			{typeof(uint), new List<Type> { typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal) }},
			{typeof(long), new List<Type> { typeof(float), typeof(double), typeof(decimal)}},
			{typeof(ulong), new List<Type> { typeof(float), typeof(double), typeof(decimal)}},
			{typeof(char), new List<Type> { typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal)}},
			{typeof(float), new List<Type> { typeof(double)}}
		};

		///
		/// <summary>
		///		The default set of binding flags that is used when attempting to look up methods and members.
		/// </summary>
		/// 
		private static BindingFlags findFlags = BindingFlags.NonPublic |
																					  BindingFlags.Public |
																					  BindingFlags.Static |
																					  BindingFlags.Instance |
																					  BindingFlags.InvokeMethod |
																					  BindingFlags.OptionalParamBinding |
																					  BindingFlags.DeclaredOnly;

		///
		/// <summary>
		///		Returns the best applicable and invokable member for a given MethResSettings object.
		/// </summary>
		/// 
		/// <param name="mrSettings">The object to match when invoking</param>
		/// 
		/// <returns>The specific best invokable member that matches the passed MethResSettings object</returns>
		/// 
		public static MethResObject GetBestInvocableMember(MethResSettings mrSettings) {
			MethResObject mrObj = GetBestMember(mrSettings);

			// check if member is invocable (return it if it is, otherwise return null)
			return mrObj;
		}

		///
		/// <summary>
		///		Returns the best matching member for a given MethResSettings object.
		/// </summary>
		/// 
		/// <param name="mrSettings">The object to match when invoking</param>
		/// 
		/// <returns>The specific best member that matches the passed MethResSettings object</returns>
		///
		public static MethResObject GetBestMember(MethResSettings mrSettings) {
			List<MethResObject> mrObjs = GetApplicableMembers(mrSettings);

			if (mrObjs.Count == 1) {
				// TODO: Should we go through steps anyway? Return null if it doesn't pass?
				return mrObjs[0];
			}
			else {
				// do work here

				return new MethResObject();	// <- change this
			}
		}

		///
		/// <summary>
		///		Returns all matching members, according to the C# specification, for a given MethResSettings object.
		/// </summary>
		/// 
		/// <param name="mrSettings">The object to match when invoking</param>
		/// 
		/// <returns>The list of applicable members that match the passed MethResSettings object</returns>
		///
		public static List<MethResObject> GetApplicableMembers(MethResSettings mrSettings) {
			List<MethResObject> mrObjs = GetCandidateMembers(mrSettings);

			//if (mrObjs.Count == 1) {
			//   // TODO: Should we go through steps anyway? Return null if it doesn't pass?
			//   return mrObjs;
			//}
			//else {
			// paramater matching && ref C# lang spec section 7.5.1.1
			List<MethResObject> appMembers = new List<MethResObject>();

			// match each param with an arg. 
			List<CallArgMod> paramMods;
			foreach (MethResObject mrObj in mrObjs) {
				bool isMatch = true;
				paramMods = new List<CallArgMod>();
				int argCount = 0;
				foreach (ParameterInfo pInfo in mrObj.MethInfo.GetParameters()) {
					bool haveArg = argCount < mrSettings.Args.Length;

					if (pInfo.IsOut || pInfo.ParameterType.IsByRef) {
						if (!haveArg) {
							isMatch = false;
						}
						else if (pInfo.IsOut) {
							if (mrSettings.Args[argCount].CallMod != CallArgMod.OUT) {
								isMatch = false;
							}
						}
						else if (pInfo.ParameterType.IsByRef) {
							if (mrSettings.Args[argCount].CallMod != CallArgMod.REF) {
								isMatch = false;
							}
						}

						// Step 4 (technically)
						// Check types if either are a ref type. Must match exactly
						String argTypeStr   = mrSettings.Args[argCount].Value.GetType().FullName;
						Type paramType      = mrObj.MethInfo.GetParameters()[argCount].ParameterType;
						String paramTypeStr = paramType.ToString().Substring(0, paramType.ToString().Length - 1);

						if (argTypeStr != paramTypeStr) {
							isMatch = false;
						}

					}
					else {
						if (pInfo.IsOptional) {
							// If an argument for this parameter position was specified, check its type
							if (haveArg && !CanConvertType(mrSettings.Args[argCount], pInfo.ParameterType)) {
								isMatch = false;
							}
						}
						else if (pInfo.GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0) { // Check ParamArray arguments
							// TODO: set OnlyAppInExpForm here
							for (int j = pInfo.Position; j < mrSettings.Args.Length; j++) {
								if (!CanConvertType(mrSettings.Args[j], pInfo.ParameterType.GetElementType())) {
									isMatch = false;
								}
								argCount++;
							}
							break;
						}
						else { // Checking non-optional, non-ParamArray arguments
							if (!haveArg || !CanConvertType(mrSettings.Args[argCount], pInfo.ParameterType)) {
								isMatch = false;
							}
						}
					}

					if (!isMatch) {
						break;
					}

					argCount++;
				}

				if (isMatch && argCount < mrSettings.Args.Length)
					isMatch = false;

				if (isMatch)
					appMembers.Add(mrObj);
			}

			return appMembers;
			//}
		}

		///
		/// <summary>
		///		Returns all members that match the name (candidates) of the given MethResSettings object.
		/// </summary>
		/// 
		/// <param name="mrSettings">The object to match when invoking</param>
		/// 
		/// <returns>The list of candidate members, as defined in the C# specification, that matches the passed 
		/// MethResSettings object</returns>
		///
		public static List<MethResObject> GetCandidateMembers(MethResSettings mrSettings) {
			// Find members that match on name
			Type t = TypeExp.GetTypeObj(mrSettings.Env);
			List<MethResObject> matchMeths = GetMethodInfos(t, mrSettings);

			// Traverse through class hierarchy
			while (matchMeths.Count == 0 && t != typeof(object)) {
				t = t.BaseType;
				matchMeths = GetMethodInfos(t, mrSettings);
			}

			return matchMeths;
		}

		///
		/// <summary>
		///		Returns a list of MethResObject objects, within the given environment and MethResSettings object, according to the C# 
		///		specification.
		/// </summary>
		/// 
		/// <param name="env">The environment to use when locating the desired MethResObject objects.</param>
		/// <param name="mrSettings">The object to match when invoking</param>
		/// 
		/// <returns>The list of MethResObjects which match the given MethResSettings object and environment.</returns>
		///
		public static List<MethResObject> GetMethodInfos(Type env, MethResSettings mrSettings) {
			List<MethResObject> result = new List<MethResObject>();

			foreach (MethodInfo mi in env.GetMethods(findFlags)) {
				Func<bool> IsVirtual = () => (mi.Attributes & MethodAttributes.Virtual) != 0;
				Func<bool> HasVTable = () => (mi.Attributes & MethodAttributes.VtableLayoutMask) != 0;

				if (mi.Name == mrSettings.Name && (mrSettings.IsExtInvocation || !IsVirtual() || HasVTable()))
					result.Add(new MethResObject(mi, null, mrSettings.Args));
			}

			return result;
		}

		///
		/// <summary>
		///		Tests for an implicit enum conversion, given a CseObject and a type.
		/// </summary>
		/// 
		/// <param name="data">The object to test converting</param>
		/// <param name="t">The type to attempt to convert the object to</param>
		/// 
		/// <returns>True if an implicit enum conversion is valid, false otherwise</returns>
		/// 
		public static bool ImpEnumConv(CseObject data, Type t) {
			long num = -1;

			if (data.IsLiteral && t.IsEnum && long.TryParse(data.Value.ToString(), out num))
				if (num == 0)
					return true;

			return false;
		}

		///
		/// <summary>
		///		A holistic method to use for testing coercion of objects
		/// </summary>
		/// 
		/// <param name="fromArg">The object to be coerced</param>
		/// 
		/// <param name="to">The type to convert the object to.</param>
		/// 
		/// <returns>True if the coercion is valid, false otherwise</returns>
		///
		public static bool CanConvertType(CseObject fromArg, Type to) {

			CseObject fromData = (CseObject)fromArg.Clone();


			if (fromData == null || to == null) {
				throw new ArgumentException("Param '" + (fromData == null ? "fromData" : "to") + "' must not be null");
			}

			Type from = fromData.ValueType;

			// null literal conversion 6.1.5
			if (fromArg.Value == null) {
				return IsNullableType(to);
			}

			// identity conversion 6.1.1
			if (from.GetHashCode().Equals(to.GetHashCode()))
				return true;

			// implicit constant expressions 6.1.9
			if (fromData.IsLiteral) {
				bool canConv = false;

				dynamic num = fromData.Value;
				if (from == typeof(int)) {
					switch (Type.GetTypeCode(to)) {
						case TypeCode.SByte:
							if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
								canConv = true;
							break;
						case TypeCode.Byte:
							if (num >= byte.MinValue && num <= byte.MaxValue)
								canConv = true;
							break;
						case TypeCode.Int16:
							if (num >= short.MinValue && num <= short.MaxValue)
								canConv = true;
							break;
						case TypeCode.UInt16:
							if (num >= ushort.MinValue && num <= ushort.MaxValue)
								canConv = true;
							break;
						case TypeCode.UInt32:
							if (num >= uint.MinValue && num <= uint.MaxValue)
								canConv = true;
							break;
						case TypeCode.UInt64:
							if (num >= 0)
								canConv = true;
							break;
					}
				}
				else if (from == typeof(long)) {
					if (to == typeof(ulong)) {
						if (num >= 0)
							canConv = true;
					}
				}

				if (canConv)
					return true;
			}

			// string conversion
			// TODO: check if this is necessary
			if (from == typeof(string)) {
				if (to == typeof(object))
					return true;
				else
					return false;
			}


			// implicit nullable conversion 6.1.4
			if (IsNullableType(to)) {

				if (IsNullableType(fromData.ValueType)) {

					// If the source value is null, then just return successfully (because the target value is a nullable type)
					if (fromData.Value == null) {
						return true;
					}

					fromData.CompileTimeType = Nullable.GetUnderlyingType(fromData.ValueType);
				}

				return CanConvertType(fromData, Nullable.GetUnderlyingType(to));

			}

			// implicit enumeration conversion 6.1.3
			long longTest = -1;

			if (fromData.IsLiteral && to.IsEnum && long.TryParse(fromData.Value.ToString(), out longTest)) {
				if (longTest == 0)
					return true;
			}

			// implicit reference conversion 6.1.5
			if (!from.IsValueType && !to.IsValueType) {
				bool? irc = ImpRefConv(fromData, to);
				if (irc.HasValue)
					return irc.Value;
			}

			// implicit numeric conversion 6.1.2
			try {
				object fromObj = null;
				double dblTemp;
				decimal decTemp;
				char chrTemp;
				fromObj = Activator.CreateInstance(from);

				if (char.TryParse(fromObj.ToString(), out chrTemp) || double.TryParse(fromObj.ToString(), out dblTemp) || decimal.TryParse(fromObj.ToString(), out decTemp)) {
					if (NumConv.ContainsKey(from) && NumConv[from].Contains(to))
						return true;
					else
						return CrawlThatShit(to.GetHashCode(), from, new List<int>());
				}
				//else {
				//   return CrawlThatShit(to.GetHashCode(), from, new List<int>());
				//}
			}
			catch {
				//return CrawlThatShit(to.GetHashCode(), from, new List<int>());
			}

			return false;
		}

		// Implicit reference conversions 6.1.6 
		// TODO: check if both ref, throw exc if not
		///
		/// <summary>
		///		Tests for an implicit reference conversion, given a CseObject and a type.
		/// </summary>
		/// 
		/// <param name="data">The object to test converting</param>
		/// <param name="t">The type to attempt to convert the object to</param>
		/// 
		/// <returns>True if an implicit reference conversion is valid, false otherwise</returns>
		/// 
		public static bool? ImpRefConv(CseObject fromArg, Type to) {
			bool? success = null;

			Type from = fromArg.ValueType;

			if (from == to)
				// identity
				success = true;

			else if (to == typeof(object))
				// ref -> object
				success = true;

			else if (fromArg.Value == null)
				// null literal -> Ref-type
				success = !to.IsValueType;

			else if (false)
				// ref -> dynamic (6.1.8)
				// figure out how to do this
				;

			else if (from.IsArray && to.IsArray) {
				// Array-type -> Array-type
				bool sameRank = (from.GetArrayRank() == to.GetArrayRank());
				bool bothRef = (!from.GetElementType().IsValueType && !to.GetElementType().IsValueType);
				bool? impConv = ImpRefConv(new CseObject(-1) { CompileTimeType = from.GetElementType() }, to.GetElementType());

				success = (sameRank && bothRef && impConv.GetValueOrDefault(false));
			}

			// Conversion involving type parameters (6.1.10)
			else if (to.IsGenericParameter) {

				//if ( fromArg.GetType().Name.Equals(to.Name)) {
				if (to.GenericParameterAttributes != GenericParameterAttributes.None) {

					if ((int)(to.GenericParameterAttributes & GenericParameterAttributes.ReferenceTypeConstraint) != 0) {
						;
					}
				}
				else {
				}


				/*genArg.GetGenericParameterConstraints();
				genArg.GenericParameterAttributes;*/
				//if( mi.GetGenericArguments()[?]
				//var t = a.GetType().GetMethod("Foo", BindingFlags.Public | BindingFlags.Instance).GetGenericArguments()[0].GetGenericParameterConstraints();//.GenericParameterAttributes;
			}

			// Boxing Conversions (6.1.7)
			else if (from.IsValueType && !to.IsValueType) {
				return IsBoxingConversion(fromArg, to);
			}

			else if ((from.IsClass && to.IsClass) || (from.IsClass && to.IsInterface) || (from.IsInterface && to.IsInterface))
				// class -> class  OR  class -> interface  OR  interface -> interface
				success = CrawlThatShit(to.GetHashCode(), from, new List<int>());

			else if (from.IsArray && CrawlThatShit(to.GetHashCode(), typeof(Array), new List<int>())) {
				// Array-type -> System.array
				return true;
			}

			else if (from.IsArray && from.GetArrayRank() == 1 && to.IsGenericType && CrawlThatShit(to.GetHashCode(), typeof(IList<>), new List<int>()))
				// Single dim array -> IList<>
				success = ImpRefConv(new CseObject(-1) { CompileTimeType = from.GetElementType() }, to.GetGenericTypeDefinition());



			return success;
		}

		// TODO: Rename this method
		///
		/// <summary>
		///		Recursive method to traverse through the class hierarchy in an attempt to determine if the current object may be converted
		///		to the target type, based on it's hash code.
		/// </summary>
		/// 
		/// <param name="target">The hashCode value of the target object</param>
		/// <param name="current">The object to be converted.</param>
		/// <param name="visitedTypes">The list of visited types. This is an optimization parameter.</param>
		/// 
		/// <returns>True if the object can be converted to an object matching the hashCode property of target, false otherwise</returns>
		/// 
		public static bool CrawlThatShit(int target, Type current, List<int> visitedTypes) {
			int curHashCode = current.GetHashCode();

			// Optimization
			if (visitedTypes.Contains(curHashCode)) {
				return false;
			}

			bool found = (curHashCode == target);
			visitedTypes.Add(curHashCode);

			if (!found && current.BaseType != null) {
				found = CrawlThatShit(target, current.BaseType, visitedTypes);
			}

			if (!found) {
				if (current.GetInterfaces() != null) {
					foreach (Type iface in current.GetInterfaces()) {
						if (CrawlThatShit(target, iface, visitedTypes)) {
							found = true;
							break;
						}

					}
				}
			}

			return found;
		}

		///
		/// <summary>
		///		Determines if the passed type is a nullable type
		/// </summary>
		/// 
		/// <param name="t">The type to check</param>
		/// 
		/// <returns>True if the type is a nullable type, false otherwise</returns>
		///
		public static bool IsNullableType(Type t) {
			return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		///
		/// <summary>
		///		Determines if a boxing conversion exists between the passed object and the type
		/// </summary>
		/// 
		/// <param name="fromArg">The object to convert</param>
		/// <param name="to">The type to attempt to convert the object to.</param>
		/// 
		/// <returns>True if a boxing conversion exists between the object and the type, false otherwise</returns>
		/// 
		public static bool IsBoxingConversion(CseObject fromArg, Type to) {

			Type unwrappedBox = fromArg.ValueType;

			if (IsNullableType(unwrappedBox)) {
				unwrappedBox = Nullable.GetUnderlyingType(unwrappedBox);
			}

			if (to.Equals(typeof(System.ValueType)) || to.Equals(typeof(object))) {
				return true;
			}
			else if (CrawlThatShit(to.GetHashCode(), unwrappedBox, new List<int>())) {
				return true;
			}
			else if (unwrappedBox.IsEnum && to.Equals(typeof(System.Enum))) {
				return true;
			}
			else {
				return false;
			}
		}
	}
}
