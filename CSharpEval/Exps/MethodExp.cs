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
	///		Used to parse method call expressions
	/// </summary>
	/// 
	internal static class MethodExp {
		///
		/// <summary>
		///		Flags used in GetMethod() to locate the method being called
		/// </summary>
		/// 
		private static BindingFlags findFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance;

		///
		/// <summary>
		///		Parses method calls
		/// </summary>
		/// 
		/// <param name="environment">The environment containing the method</param>
		/// <param name="methName">Name of the method</param>
		/// <param name="args">CseObject array containing arguments to be sent to the method. Each CseObject is one argument</param>
		/// 
		/// <returns>CseObject containing the return result of the method call or CseObject containing null if method is void</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.METHOD_CALL_AMBIGUOUS" />
		/// <exception cref="CseLogicExceptionType.METHOD_CANT_IMPLICITLY_COERCE_ARGS" />
		/// <exception cref="CseLogicExceptionType.METHOD_DOESNT_EXIST" />
		/// <exception cref="CseLogicExceptionType.METHOD_EXISTS_BUT_CANT_BE_INVOKED" />
		///
		public static CseObject Parse(CseObject environment, string methName, List<CseObject> args) {
			MethResSettings mrSettings = new MethResSettings() {
				Args = (args == null ? new CseObject[] { } : args.ToArray()),
				Env = environment.Value,
				Name = methName
			};
			List<MethResObject> appMeths = MethRes.GetApplicableMembers(mrSettings);

			if (appMeths.Count == 0) {
				mrSettings.IsExtInvocation = true;
				appMeths = MethRes.GetApplicableMembers(mrSettings);
			}

			MethodInfo mi = null;
			Type envType = TypeExp.GetTypeObj(environment.Value);

			try {
				switch (appMeths.Count) {
					// No methods exist with that name
					case 0:
						// TODO: doesn't exist OR no applicable methods can be called
						throw new CseLogicException(CseLogicExceptionType.METHOD_DOESNT_EXIST, methName);

					// Only 1 method exists with that name, so try to do what's necessary to coerce args (if they exist)
					// to match its signature.
					case 1:
						MethResObject mrObj = appMeths[0];

						if (args != null) {
							for (int i = 0; i < args.Count; i++) {
								try {
									args[i] = CastExp.Parse(environment, mrObj.MethInfo.GetParameters()[i].ParameterType.Name, args[i]);
								}
								catch (CseLogicException) {
									// fuck it, continue
								}
							}
						}
						//NarrowAllIntTypes(ref args);

						mi = mrObj.MethInfo;
						break;

					// Method is overloaded.
					// Idea is to simulate C#'s best match algorithm for finding the most appropriate method to call
					// and if still unsure, throw exception so user can use casting for further clarification.
					default:
						Type[] types = GetTypeArray(args);

						mi = envType.GetMethod(methName, findFlags | BindingFlags.ExactBinding, null, types, null);

						if (mi != null)
							break;

						if (CanCoerce(args)) {
							NarrowAllIntTypes(ref args);
							types = GetTypeArray(args);
						}

						MethodInfo tryMeth = envType.GetMethod(methName, findFlags, null, types, null);
						foreach (MethResObject m in appMeths) {
							if (m.MethInfo == tryMeth) {
								mi = tryMeth;
								break;
							}
						}

						if (mi != null)
							break;

						// TODO: Attempt to coerce args to formal param types of overloaded methods



						if (mi == null)
							throw new CseLogicException(CseLogicExceptionType.METHOD_CALL_AMBIGUOUS, methName);

						break;
				}
			}
			catch (AmbiguousMatchException) {
				throw new CseLogicException(CseLogicExceptionType.METHOD_CALL_AMBIGUOUS, methName);
			}
			catch (CseLogicException) {
				throw;
			}
			catch {
				throw new CseLogicException(CseLogicExceptionType.METHOD_EXISTS_BUT_CANT_BE_INVOKED, methName);
			}

			if (mi == null) {
				throw new CseLogicException(CseLogicExceptionType.METHOD_EXISTS_BUT_CANT_BE_INVOKED, methName);
			}
			else {
				dynamic result = mi.Invoke(environment.Value, GetObjArgs(args));

				CseObject xo = new CseObject(result);
				xo.CompileTimeType = mi.ReturnType;

				if (args != null) {
					foreach (CseObject arg in args) {
						if (arg.CallMod != CallArgMod.VAL) {
							AssignExp.Parse(arg.EnvChain, arg.EnvNames, arg.EnvIndices, arg.Value);
						}
					}
				}

				return xo;
			}
		}

		///
		/// <summary>
		///		Determines if it is possible to coerce the given list of arguments
		///		so a method signature can be matched.
		/// </summary>
		/// 
		/// <param name="args">List of arguments to check</param>
		/// 
		/// <returns>
		///		True if exactly one argument is of an integral type, false otherwise.
		///		Idea is to only coerce integral arguments since floating point arguments
		///		would lose precision when converted to a narrower type and objects don't
		///		need it due to inheritance (i.e. they will match the method signature without
		///		it). If there is more than one integral argument, then the chance that the
		///		wrong overloaded method is called is too great, and so this method returns
		///		false meaning it can't safely coerce the integral args. If only one is found,
		///		and a method can't be matched without coercion, then we can safely narrow
		///		down that one integral arg without worry about matching the wrong method.
		/// </returns>
		/// 
		private static bool CanCoerce(List<CseObject> args) {
			if (args == null)
				return false;

			bool foundIntType = false;
			bool canCoerce = false;

			for (int i = 0; i < args.Count; i++) {
				CseObject arg = args[i];

				if (LiteralExp.IsIntType(arg)) {
					if (!foundIntType) {
						canCoerce = true;
						foundIntType = true;
					}
					else {
						canCoerce = false;
						break;
					}
				}
			}

			return canCoerce;
		}

		///
		/// <summary>
		///		Inspects all CseObjects in args and for the literal integral values, it
		///		converts their type to the most narrow type that can contain their value.
		///		E.g. if the value is a literal 300 (not the value of an identifier as those
		///		types aren't changed), then the smallest integral data type that can store
		///		that would be a short. This increases the chance that the given args will
		///		match a wider method signature.
		/// </summary>
		/// 
		/// <param name="args">Arguments to inspect and convert</param>
		/// 
		private static void NarrowAllIntTypes(ref List<CseObject> args) {
			if (args == null)
				return;

			for (int i = 0; i < args.Count; i++) {
				CseObject arg = args[i];

				if (LiteralExp.IsIntType(arg) && arg.IsLiteral) {
					args[i] = LiteralExp.NarrowIntType(arg);
					args[i].CompileTimeType = args[i].Value.GetType();
				}
			}
		}

		///
		/// <summary>
		///		Converts list of CseObject arguments into a type array using either
		///		their CompileTimeType property or if that is null, using GetType() on
		///		their Value property.
		/// </summary>
		/// 
		/// <param name="args">Arguments to extract the types of</param>
		/// 
		/// <returns>
		///		A type array from the CompileTimeType or the inherited (from Object) GetType() on the Value
		///		property of each CseObject in args
		///	</returns>
		/// 
		private static Type[] GetTypeArray(List<CseObject> args) {
			if (args == null)
				return null;

			Type[] types = new Type[args.Count];

			for (int i = 0; i < args.Count; i++) {
				if (args[i].CompileTimeType == null) {
					if (args[i].Value == null) {
						types[i] = null;
					}
					else {
						if (args[i].CallMod == CallArgMod.OUT || args[i].CallMod == CallArgMod.REF) {
							types[i] = args[i].Value.GetType().MakeByRefType();
						}
						else {
							types[i] = args[i].Value.GetType();
						}
					}
				}
				else {
					if (args[i].CallMod == CallArgMod.OUT || args[i].CallMod == CallArgMod.REF) {
						types[i] = args[i].CompileTimeType.MakeByRefType();
					}
					else {
						types[i] = args[i].CompileTimeType;
					}
				}
			}

			return types;
		}

		///
		/// <summary>
		///		Converts list of CseObject arguments into a object array using their
		///		Value property
		/// </summary>
		/// 
		/// <param name="args">Arguments to extract the Value property of</param>
		/// 
		/// <returns>An object array from the Value property of each argument in args</returns>
		/// 
		private static object[] GetObjArgs(List<CseObject> args) {
			if (args == null)
				return null;

			object[] objArgs = new object[args.Count];

			for (int i = 0; i < args.Count; i++)
				objArgs[i] = args[i].Value;

			return objArgs;
		}
	}
}