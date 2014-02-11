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
using CSE.Exceptions;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse cast expressions
	/// </summary>
	/// 
	internal static class CastExp {
		///
		/// <summary>
		///		Parses casts
		/// </summary>
		/// 
		/// <remarks>
		///		Can only perform a real cast in certain situations. When it can't it
		///		tries to mimic a cast using parsing or conversion.
		///	</remarks>
		///	
		/// <param name="instance">The root object</param>
		/// <param name="typeName">Type to cast to</param>
		/// <param name="cseData">Expression to cast</param>
		/// 
		/// <returns>The converted object</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_CAST_VALUE_TO_TYPE" />
		/// <exception cref="CseLogicExceptionType.OVERFLOW_TRYING_TO_CAST" />
		///
		// TODO: Check if the generic Cast<T> method would work
		internal static CseObject Parse(CseObject instance, string typeName, CseObject cseData) {
			dynamic data = cseData.Value;
			dynamic castedObj = null;
			Type dataType = TypeExp.GetTypeObj(data);

			if (dataType.IsEnum) {
				switch (typeName.ToLower()) {
					case "bool":
						castedObj = (bool)data;
						break;
					case "byte":
						castedObj = (byte)data;
						break;
					case "decimal":
						castedObj = (decimal)data;
						break;
					case "double":
						castedObj = (double)data;
						break;
					case "float":
						castedObj = (float)data;
						break;
					case "int":
						castedObj = (int)data;
						break;
					case "int16":
						castedObj = (Int16)data;
						break;
					case "int32":
						castedObj = (Int32)data;
						break;
					case "int64":
						castedObj = (Int64)data;
						break;
					case "long":
						castedObj = (long)data;
						break;
					case "sbyte":
						castedObj = (sbyte)data;
						break;
					case "short":
						castedObj = (short)data;
						break;
					case "single":
						castedObj = (Single)data;
						break;
					case "uint":
						castedObj = (uint)data;
						break;
					case "uint16":
						castedObj = (UInt16)data;
						break;
					case "uint32":
						castedObj = (UInt32)data;
						break;
					case "uint64":
						castedObj = (UInt64)data;
						break;
					case "ulong":
						castedObj = (ulong)data;
						break;
					case "ushort":
						castedObj = (ushort)data;
						break;
					default:
						castedObj = Enum.Parse(dataType, cseData.Value.ToString()); // instance.Value;
						break;
				}
			}
			else {
				switch (typeName.ToLower()) {
					case "bool":
						bool boolAttempt;
						if (bool.TryParse(data.ToString(), out boolAttempt))
							castedObj = boolAttempt;
						break;
					case "byte":
						byte byteAttempt;
						if (byte.TryParse(data.ToString(), out byteAttempt))
							castedObj = byteAttempt;
						break;
					case "decimal":
						decimal decimalAttempt;
						if (decimal.TryParse(data.ToString(), out decimalAttempt))
							castedObj = decimalAttempt;
						break;
					case "double":
						double doubleAttempt;
						if (double.TryParse(data.ToString(), out doubleAttempt))
							castedObj = doubleAttempt;
						break;
					case "float":
						float floatAttempt;
						if (float.TryParse(data.ToString(), out floatAttempt))
							castedObj = floatAttempt;
						break;
					case "int":
						int intAttempt;
						if (int.TryParse(data.ToString(), out intAttempt))
							castedObj = intAttempt;
						break;
					case "int16":
						Int16 int16Attempt;
						if (Int16.TryParse(data.ToString(), out int16Attempt))
							castedObj = int16Attempt;
						break;
					case "int32":
						Int32 int32Attempt;
						if (Int32.TryParse(data.ToString(), out int32Attempt))
							castedObj = int32Attempt;
						break;
					case "int64":
						Int64 int64Attempt;
						if (Int64.TryParse(data.ToString(), out int64Attempt))
							castedObj = int64Attempt;
						break;
					case "long":
						long longAttempt;
						if (long.TryParse(data.ToString(), out longAttempt))
							castedObj = longAttempt;
						break;
					case "sbyte":
						sbyte sbyteAttempt;
						if (sbyte.TryParse(data.ToString(), out sbyteAttempt))
							castedObj = sbyteAttempt;
						break;
					case "short":
						short shortAttempt;
						if (short.TryParse(data.ToString(), out shortAttempt))
							castedObj = shortAttempt;
						break;
					case "single":
						Single singleAttempt;
						if (Single.TryParse(data.ToString(), out singleAttempt))
							castedObj = singleAttempt;
						break;
					case "uint":
						uint uintAttempt;
						if (uint.TryParse(data.ToString(), out uintAttempt))
							castedObj = uintAttempt;
						break;
					case "uint16":
						UInt16 uint16Attempt;
						if (UInt16.TryParse(data.ToString(), out uint16Attempt))
							castedObj = uint16Attempt;
						break;
					case "uint32":
						UInt32 uint32Attempt;
						if (UInt32.TryParse(data.ToString(), out uint32Attempt))
							castedObj = uint32Attempt;
						break;
					case "uint64":
						UInt64 uint64Attempt;
						if (UInt64.TryParse(data.ToString(), out uint64Attempt))
							castedObj = uint64Attempt;
						break;
					case "ulong":
						ulong ulongAttempt;
						if (ulong.TryParse(data.ToString(), out ulongAttempt))
							castedObj = ulongAttempt;
						break;
					case "ushort":
						ushort ushortAttempt;
						if (ushort.TryParse(data.ToString(), out ushortAttempt))
							castedObj = ushortAttempt;
						break;
				}

				if (castedObj == null) {
					double dataAsDouble;
					if (double.TryParse(data.ToString(), out dataAsDouble)) {
						try {
							switch (typeName.ToLower()) {
								case "byte":
									castedObj = checked((byte)dataAsDouble);
									break;
								case "int":
									castedObj = checked((int)dataAsDouble);
									break;
								case "int16":
									castedObj = checked((Int16)dataAsDouble);
									break;
								case "int32":
									castedObj = checked((Int32)dataAsDouble);
									break;
								case "int64":
									castedObj = checked((Int64)dataAsDouble);
									break;
								case "long":
									castedObj = checked((long)dataAsDouble);
									break;
								case "sbyte":
									castedObj = checked((sbyte)dataAsDouble);
									break;
								case "short":
									castedObj = checked((short)dataAsDouble);
									break;
								case "single":
									castedObj = checked((Single)dataAsDouble);
									break;
								case "uint":
									castedObj = checked((uint)dataAsDouble);
									break;
								case "uint16":
									castedObj = checked((UInt16)dataAsDouble);
									break;
								case "uint32":
									castedObj = checked((UInt32)dataAsDouble);
									break;
								case "uint64":
									castedObj = checked((UInt64)dataAsDouble);
									break;
								case "ulong":
									castedObj = checked((ulong)dataAsDouble);
									break;
								case "ushort":
									castedObj = checked((ushort)dataAsDouble);
									break;
							}
						}
						catch (OverflowException) {
							throw new CseLogicException(CseLogicExceptionType.OVERFLOW_TRYING_TO_CAST, data.ToString(), typeName);
						}
					}
				}

				if (castedObj == null) {
					try {
						/* If parsing is not possible, try a conversion */
						Type typeToCastTo = TypeExp.GetType(typeName);
						castedObj = Convert.ChangeType(data, typeToCastTo);
					}
					catch {
						throw new CseLogicException(CseLogicExceptionType.CANT_CAST_VALUE_TO_TYPE, data.ToString(), typeName);
					}
				}
			}

			return new CseObject(castedObj) { IsLiteral = cseData.IsLiteral };
			//return cseData.Clone(castedObj);
		}
	}
}
