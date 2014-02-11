/*
	CSharp Eval, a library for arbitrary execution of C# code
	Copyright 2012 Kevin A. Cherry and Timothy W. Wright

	This program is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse type expressions
	/// </summary>
	/// 
	internal static class TypeExp {
		///
		/// <summary>
		///		Holds all types that have been given to it (in CacheCommonTypes method) or 
		///		successfully parsed from cse expressions
		/// </summary>
		/// 
		private static Dictionary<string, Type> cachedTypes = new Dictionary<string, Type>();

		///
		/// <summary>
		///		Holds all failed attempts at evaluating an expression into a type.
		/// </summary>
		/// 
		private static Dictionary<string, bool> failedTypes = new Dictionary<string, bool>();

		///
		/// <summary>
		///		True if CacheCommonTypes has been called, false otherwise
		/// </summary>
		/// 
		public static bool HasCachedCommonTypes { get; set; }

		///
		/// <summary>
		///		Caches common types for fast lookup
		/// </summary>
		///
		public static void CacheCommonTypes() {
			cachedTypes["bool"] = typeof(bool);
			cachedTypes["byte"] = typeof(byte);
			cachedTypes["char"] = typeof(char);
			cachedTypes["decimal"] = typeof(decimal);
			cachedTypes["double"] = typeof(double);
			cachedTypes["float"] = typeof(float);
			cachedTypes["int"] = typeof(int);
			cachedTypes["int16"] = typeof(Int16);
			cachedTypes["int32"] = typeof(Int32);
			cachedTypes["int64"] = typeof(Int64);
			cachedTypes["long"] = typeof(long);
			cachedTypes["sbyte"] = typeof(sbyte);
			cachedTypes["short"] = typeof(short);
			cachedTypes["single"] = typeof(Single);
			cachedTypes["string"] = typeof(string);
			cachedTypes["uint"] = typeof(uint);
			cachedTypes["uint16"] = typeof(UInt16);
			cachedTypes["uint32"] = typeof(UInt32);
			cachedTypes["uint64"] = typeof(UInt64);
			cachedTypes["ulong"] = typeof(ulong);
			cachedTypes["ushort"] = typeof(ushort);

			cachedTypes["Color"] = typeof(System.Drawing.Color);
			cachedTypes["Rectangle"] = typeof(System.Drawing.Rectangle);
			cachedTypes["RectangleF"] = typeof(System.Drawing.RectangleF);

			cachedTypes["Random"] = typeof(System.Random);

			HasCachedCommonTypes = true;
		}

		///
		/// <summary>
		///		Converts string parameter containing type into an actual type
		/// </summary>
		/// 
		/// <param name="typeData">String containing type</param>
		/// 
		/// <returns>Found type or null if type is not found</returns>
		///
		public static Type GetType(string typeData) {
			if (!HasCachedCommonTypes)
				CacheCommonTypes();

			LiteralExp.ParseEscSeqs(ref typeData, false);

			Type returnedType = null;

			Regex typeRegex = new Regex(@"^[\w][\w\d]*$");
			if (typeRegex.IsMatch(typeData)) {
				bool isFailedtype;
				if (!cachedTypes.TryGetValue(typeData, out returnedType) && !failedTypes.TryGetValue(typeData, out isFailedtype)) {
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					foreach (Assembly assembly in assemblies) {
						try {
							foreach (Type type in assembly.GetTypes()) {
								if (type.Name == typeData) {
									returnedType = type;
									cachedTypes[typeData] = returnedType;
									break;
								}
							}
							if (returnedType != null) {
								cachedTypes[typeData] = returnedType;
								break;
							}
						}
						catch (System.Reflection.ReflectionTypeLoadException) {
							continue;
						}
					}
				}
				if (returnedType == null)
					failedTypes[typeData] = true;
			}

			return returnedType;
		}

		///
		/// <summary>
		///		Gets type information from object. If object is already a type, object is
		///		casted as a type and returned, if not, GetType is called.
		/// </summary>
		/// 
		/// <param name="typeData">Object to get the type of</param>
		/// 
		/// <returns>Type of object</returns>
		///
		public static Type GetTypeObj(object typeData) {
			Type type;

			if (typeData.GetType().FullName == "System.RuntimeType")
				type = (Type)typeData;
			else
				type = typeData.GetType();

			return type;
		}

		///
		/// <summary>
		///		Heuristic attempt to ensure value given can be coerced into type given.
		///		Useful for temporary variable assignments.
		/// </summary>
		/// 
		/// <param name="type">Type to attempt to coerce value to</param>
		/// <param name="value">Value to coerce</param>
		/// 
		/// <returns>True if value can be coerced to type given, false otherwise</returns>
		/// 
		/// <remarks>Doesn't work for most cases. Needs more work</remarks>
		/// 
		public static bool TypeAssignMatch(Type type, dynamic value) {
			try {
				var typeTestVar = Activator.CreateInstance(type);
				typeTestVar = Activator.CreateInstance(value.GetType());
				return true;
			}
			catch {
				return false;
			}
		}
	}
}