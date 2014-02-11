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
using System.Globalization;
using System.Text.RegularExpressions;
using CSE.Exceptions;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse literal expressions
	/// </summary>
	/// 
	internal static class LiteralExp {
		///
		/// <summary>
		///		Parses integral-type literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// <param name="suffix">Optional type suffix</param>
		/// 
		/// <returns>An integral-type value or float-type if float-type suffix is supplied</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.NOT_A_NUM" />
		/// <exception cref="CseLogicExceptionType.CANT_CONVERT_TO_INT_TYPE" />
		///
		internal static CseObject ParseIntType(string data, string suffix) {
			CseObject result = null;

			if (suffix != null && suffix != "") {
				switch (suffix.ToLower()) {
					case "f":
						result = new CseObject(float.Parse(data));
						break;
					case "m":
						result = new CseObject(decimal.Parse(data));
						break;
					case "d":
						result = new CseObject(double.Parse(data));
						break;
					case "ul":
						result = new CseObject(ulong.Parse(data));
						break;
					case "u":
						result = new CseObject(uint.Parse(data));
						break;
					case "l":
						result = new CseObject(long.Parse(data));
						break;
				}
			}
			else {
				// TODO: if long cannot parse number, it may mean an overflow/underflow not a NaN problem
				int intAttempt;
				long longAttempt;
				if (int.TryParse(data, out intAttempt))
					result = new CseObject(intAttempt);
				else if (long.TryParse(data, out longAttempt))
					result = new CseObject(longAttempt);
				else
					throw new CseLogicException(CseLogicExceptionType.NOT_A_NUM, data);
			}

			if (result == null)
				throw new CseLogicException(CseLogicExceptionType.CANT_CONVERT_TO_INT_TYPE, data);

			result.IsLiteral = true;
			return result;
		}

		///
		/// <summary>
		///		Parses integral-type literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// <param name="hasSuffix">Indicates whether a suffix is present or not</param>
		/// 
		/// <returns>An integral-type value or float-type if float-type suffix is supplied</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_CONVERT_TO_INT_TYPE" />
		/// <exception cref="CseLogicExceptionType.NOT_A_NUM" />
		///
		internal static CseObject ParseIntType(string data, bool hasSuffix) {
			CseObject result = null;

			if (hasSuffix) {
				// Determine the suffix
				Regex r = new Regex(@"((?:\d|\.)+)([A-Za-z]{1,2})$");

				Match m = r.Match(data);

				data = m.Groups[1].Value;
				string suffix = m.Groups[2].Value;

				switch (suffix.ToLower()) {
					case "f":
						result = new CseObject(float.Parse(data));
						break;
					case "m":
						result = new CseObject(decimal.Parse(data));
						break;
					case "d":
						result = new CseObject(double.Parse(data));
						break;
					case "ul":
						result = new CseObject(ulong.Parse(data));
						break;
					case "u":
						result = new CseObject(uint.Parse(data));
						break;
					case "l":
						result = new CseObject(long.Parse(data));
						break;
				}
			}
			else {
				int intAttempt;
				long longAttempt;
				if (int.TryParse(data, out intAttempt))
					result = new CseObject(intAttempt);
				else if (long.TryParse(data, out longAttempt))
					result = new CseObject(longAttempt);
				else
					throw new CseLogicException(CseLogicExceptionType.NOT_A_NUM, data);
			}

			if (result == null)
				throw new CseLogicException(CseLogicExceptionType.CANT_CONVERT_TO_INT_TYPE, data);

			result.IsLiteral = true;
			return result;
		}

		///
		/// <summary>
		///		Parses float-type literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// <param name="suffix">Optional type suffix</param>
		/// 
		/// <returns>A float-type value</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_CONVERT_TO_FLT_TYPE" />
		/// <exception cref="CseLogicExceptionType.NOT_A_NUM" />
		///
		internal static CseObject ParseFloatType(string data, string suffix) {
			CseObject result = null;

			if (suffix != null && suffix != "") {
				switch (suffix.ToLower()) {
					case "f":
						result = new CseObject(float.Parse(data));
						break;
					case "m":
						result = new CseObject(decimal.Parse(data));
						break;
					case "d":
						result = new CseObject(double.Parse(data));
						break;
				}
			}
			else {
				double doubleAttempt;
				if (double.TryParse(data, out doubleAttempt))
					result = new CseObject(doubleAttempt);
				else
					throw new CseLogicException(CseLogicExceptionType.NOT_A_NUM, data);
			}

			if (result == null)
				throw new CseLogicException(CseLogicExceptionType.CANT_CONVERT_TO_FLT_TYPE, data);

			result.IsLiteral = true;
			return result;
		}

		///
		/// <summary>
		///		Parses float-type literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// <param name="hasSuffix">Indicates whether a suffix is present or not</param>
		/// 
		/// <returns>A float-type value</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_CONVERT_TO_FLT_TYPE" />
		/// <exception cref="CseLogicExceptionType.NOT_A_NUM" />
		///
		internal static CseObject ParseFloatType(string data, bool hasSuffix) {
			CseObject result = null;

			if (hasSuffix) {
				// Determine the suffix
				Regex r = new Regex(@"((?:\d|\.)+)([A-Za-z]{1,2})$");

				Match m = r.Match(data);

				data = m.Groups[1].Value;
				string suffix = m.Groups[2].Value;

				switch (suffix.ToLower()) {
					case "f":
						result = new CseObject(float.Parse(data));
						break;
					case "m":
						result = new CseObject(decimal.Parse(data));
						break;
					case "d":
						result = new CseObject(double.Parse(data));
						break;
				}
			}
			else {
				double doubleAttempt;
				if (double.TryParse(data, out doubleAttempt))
					result = new CseObject(doubleAttempt);
				else
					throw new CseLogicException(CseLogicExceptionType.NOT_A_NUM, data);
			}

			if (result == null)
				throw new CseLogicException(CseLogicExceptionType.CANT_CONVERT_TO_FLT_TYPE, data);

			result.IsLiteral = true;
			return result;
		}

		///
		/// <summary>
		///		Parses literals that contain the exponential 'e' character
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// 
		/// <returns>A double value</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_CONVERT_TO_DBL" />
		///
		internal static CseObject ParseEType(string data) {
			double value;

			Regex r = new Regex(@"(f|m|d)$", RegexOptions.IgnoreCase);

			Match m = r.Match(data);
			string suffix = m.Groups[1].Value;
			string number = data.Substring(0, data.Length - suffix.Length);

			if (!double.TryParse(number, out value))
				throw new CseLogicException(CseLogicExceptionType.CANT_CONVERT_TO_DBL, data);

			CseObject result = null;

			if (suffix != "") {
				result = ParseFloatType(value.ToString(), suffix);
			}
			else {
				result = new CseObject(value);
			}

			result.IsLiteral = true;
			return result;
		}

		///
		/// <summary>
		///		Parses char literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// 
		/// <returns>A char value</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_CONVERT_TO_CHAR" />
		///
		internal static CseObject ParseChar(string data) {
			data = data.Remove(data.Length - 1, 1).Remove(0, 1);
			if (data.Length > 1 && !data.StartsWith("\\"))
				throw new CseLogicException(CseLogicExceptionType.CANT_CONVERT_TO_CHAR, data);
			else {
				ParseEscSeqs(ref data, false);

				CseObject result = new CseObject(data[0]);
				result.IsLiteral = true;
				return result;
			}
		}

		///
		/// <summary>
		///		Parses string literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// 
		/// <returns>A string value</returns>
		///
		internal static CseObject ParseStr(string data) {
			if (data.StartsWith("@")) {
				data = data.Remove(0, 1);
				ParseEscSeqs(ref data, true);
			}
			else {
				ParseEscSeqs(ref data, false);
			}

			CseObject result = new CseObject(data.Remove(data.Length - 1, 1).Remove(0, 1));
			result.IsLiteral = true;
			return result;
		}

		///
		/// <summary>
		///		Parses bool literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal</param>
		/// 
		/// <returns>A bool value</returns>
		///
		internal static CseObject ParseBool(string data) {
			CseObject result = null;

			if (data.Equals("true"))
				result = new CseObject(true);
			else
				result = new CseObject(false);

			result.IsLiteral = true;
			return result;
		}

		///
		/// <summary>
		///		Parses escape sequences found in char or string literals
		/// </summary>
		/// 
		/// <param name="data">String containing the literal that may have escape sequences</param>
		/// <param name="isVerbatim">
		///		Used to tell if the literal passed is a verbatim string. 
		///		True if data represents verbatim string, false otherwise
		///	</param>
		///	
		/// <exception cref="CseLogicExceptionType.HEX_ESC_CODE_NOT_RECOGNIZED" />
		///
		public static void ParseEscSeqs(ref string data, bool isVerbatim) {
			Dictionary<string, string> escapeMappings;

			if (isVerbatim) {
				escapeMappings = new Dictionary<string, string> {
					{"\"\"", "\""}
				};
			}
			else {
				escapeMappings = new Dictionary<string, string> {
					{"\\a", "\a"},
					{"\\b", "\b"},
					{"\\f", "\f"},
					{"\\n", "\n"},
					{"\\r", "\r"},
					{"\\t", "\t"},
					{"\\v", "\v"},
					{"\\0", "\0"},
					{"\\\"", "\""},
					{"\\'", "'"},
					{"\\\\", "\\"},
				};
			}

			foreach (KeyValuePair<string, string> escapeMapping in escapeMappings) {
				data = data.Replace(escapeMapping.Key, escapeMapping.Value);
			}

			Regex hexRegex = new Regex(@"\\(?:x(?<hexDigits>(?:\d|[a-fA-F]){1,4})|u(?<hexDigits>(?:\d|[a-fA-F]){4})|U(?<hexDigits>(?:\d|[a-fA-F]){8}))");
			try {
				MatchCollection mc = hexRegex.Matches(data);
				for (int i = mc.Count - 1; i >= 0; i--) {
					Group group = mc[i].Groups["hexDigits"];
					string hexChar = char.ConvertFromUtf32(int.Parse(group.Value, NumberStyles.AllowHexSpecifier));
					data = data.Substring(0, group.Index - 2) + hexChar + data.Substring(group.Index + group.Length);
				}
			}
			catch (ArgumentOutOfRangeException) {
				throw new CseLogicException(CseLogicExceptionType.HEX_ESC_CODE_NOT_RECOGNIZED);
			}
		}

		///
		/// <summary>
		///		Determines if value passed in is an integral-type
		/// </summary>
		/// 
		/// <param name="data">Value to examine</param>
		/// 
		/// <returns>True if value is an integral-type, false otherwise</returns>
		///
		public static bool IsIntType(CseObject data) {
			long longAttempt;
			return long.TryParse(data.Value.ToString(), out longAttempt);
		}

		///
		/// <summary>
		///		Changes the given integral-type object to the smallest integral data type
		///		that can contain its value. If xdata has a CompileTimeType that is
		///		unsigned, then the smallest unsigned integral type is used. Otherwise
		///		the smallest signed type is used. The only current exception to this is
		///		byte vs. sbyte as they are considered special cases and therefore, regardless
		///		if the original type is unsigned or not, byte is always attempted in place
		///		of sbyte.
		/// </summary>
		/// 
		/// <param name="xdata">Integral-type value to narrow</param>
		/// 
		/// <returns>An integral-type object with same Value as the xdata param</returns>
		/// 
		/// <exception cref="System.ArgumentException" />
		///
		public static CseObject NarrowIntType(CseObject xdata) {
			dynamic data = xdata.Value;
			dynamic result = null;

			if (IsUnsignedType(xdata)) {
				byte byteAttempt;
				ushort ushortAttempt;
				uint uintAttempt;
				ulong ulongAttempt;

				if (byte.TryParse(data.ToString(), out byteAttempt))
					result = byteAttempt;
				else if (ushort.TryParse(data.ToString(), out ushortAttempt))
					result = ushortAttempt;
				else if (uint.TryParse(data.ToString(), out uintAttempt))
					result = uintAttempt;
				else if (ulong.TryParse(data.ToString(), out ulongAttempt))
					result = ulongAttempt;
				else
					throw new ArgumentException(data.ToString() + " is not an integral type");
			}
			else {
				byte byteAttempt;
				short shortAttempt;
				int intAttempt;
				long longAttempt;

				if (byte.TryParse(data.ToString(), out byteAttempt))
					result = byteAttempt;
				else if (short.TryParse(data.ToString(), out shortAttempt))
					result = shortAttempt;
				else if (int.TryParse(data.ToString(), out intAttempt))
					result = intAttempt;
				else if (long.TryParse(data.ToString(), out longAttempt))
					result = longAttempt;
				else
					throw new ArgumentException(data.ToString() + " is not an integral type");
			}

			return new CseObject(result);
		}

		///
		/// <summary>
		///		Determines whether the xdata's CompileTimeType is an unsigned integral type or not
		/// </summary>
		/// 
		/// <param name="xdata">CseObject to examine the CompileTimeType of</param>
		/// 
		/// <returns>True if xdata's CompileTimeType is an unsigned integral type, false otherwise</returns>
		///
		private static bool IsUnsignedType(CseObject xdata) {
			List<Type> unsignedTypes = new List<Type> { typeof(byte), typeof(UInt16), typeof(UInt32), typeof(UInt64) };

			if (unsignedTypes.Contains(xdata.CompileTimeType))
				return true;
			else
				return false;
		}
	}
}