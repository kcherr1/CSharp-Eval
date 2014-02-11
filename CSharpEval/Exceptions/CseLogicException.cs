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

namespace CSE.Exceptions {
	///
	/// <summary>
	///		Primary class for all logic exceptions in statements
	/// </summary>
	/// 
	internal class CseLogicException : Exception {
		///
		/// <summary>
		///		Constructor
		/// </summary>
		/// 
		/// <param name="type">Type of exception to display</param>
		/// 
		public CseLogicException(CseLogicExceptionType type) : base(GetExceptionMsg(type)) { }

		///
		/// <summary>
		///		Constructor
		/// </summary>
		/// 
		/// <param name="type">Type of exception to display</param>
		/// <param name="args">Argument(s) to send to the formatted string that param type produces</param>
		/// 
		public CseLogicException(CseLogicExceptionType type, params object[] args) : base(String.Format(GetExceptionMsg(type), QuoteArgs(args))) { }

		///
		/// <summary>
		///		Places double quotes around each argument sent to the constructor.
		///		This changes a statement like:
		///			Can't cast -3 to ulong
		///		to:
		///			Can't cast "-3" to "ulong"
		/// </summary>
		/// 
		/// <param name="args">Arguments to convert to strings with double quotes around them</param>
		/// 
		/// <returns>String array containing each object in param args converted to a string with double quotes around it</returns>
		/// 
		private static string[] QuoteArgs(object[] args) {
			string[] quotedArgs = new string[args.Length];

			for (int i = 0; i < args.Length; i++)
				quotedArgs[i] = "\"" + args[i].ToString() + "\"";

			return quotedArgs;
		}

		///
		/// <summary>
		///		Converts CseLogicExceptionType value to a formatted exception message
		///		(to be used in String.Format())
		/// </summary>
		/// 
		/// <param name="CseLogicExceptionType">Exception to convert to a message</param>
		/// 
		/// <returns>The corresponding message for the exception type given</returns>
		/// 
		private static string GetExceptionMsg(CseLogicExceptionType CseLogicExceptionType) {
			string msg = null;

			switch (CseLogicExceptionType) {
				case CseLogicExceptionType.ARITH_EXCEPTION:
					msg = "Arithmetic exception for {0}";
					break;
				case CseLogicExceptionType.ARRAY_INDEX_NOT_INT:
					msg = "Array index must be an int";
					break;
				case CseLogicExceptionType.CANT_AFFIRM_NON_NUM:
					msg = "Can't affirm {0} since it is not numeric";
					break;
				case CseLogicExceptionType.CANT_CAST_VALUE_TO_TYPE:
					msg = "Can't cast {0} to {1}";
					break;
				case CseLogicExceptionType.CANT_CONVERT_TO_CHAR:
					msg = "Can't convert {0} to char";
					break;
				case CseLogicExceptionType.CANT_CONVERT_TO_DBL:
					msg = "Can't convert {0} to double";
					break;
				case CseLogicExceptionType.CANT_CONVERT_TO_FLT_TYPE:
					msg = "Can't convert {0} to a float type";
					break;
				case CseLogicExceptionType.CANT_CONVERT_TO_INT_TYPE:
					msg = "Can't convert {0} to an integral type";
					break;
				case CseLogicExceptionType.CANT_FIND_IDENT_IN_ENV:
					msg = "Can't find {0} in {1}";
					break;
				case CseLogicExceptionType.CANT_NEGATE_NON_NUM:
					msg = "Can't negate {0} since it is not numeric";
					break;
				case CseLogicExceptionType.ERROR_NEGATING_VALUE_OF_TYPE:
					msg = "Error negating {0} of type {1}";
					break;
				case CseLogicExceptionType.HEX_ESC_CODE_NOT_RECOGNIZED:
					msg = "Hex escape code not recognized";
					break;
				case CseLogicExceptionType.IDENT_IS_NOT_ARRAY:
					msg = "Identifier {0} is not an array";
					break;
				case CseLogicExceptionType.IDENT_NOT_FOUND:
					msg = "Identifier {0} not found";
					break;
				case CseLogicExceptionType.LEFT_OP_NON_NUM:
					msg = "Left operand {0} non-numeric";
					break;
				case CseLogicExceptionType.METHOD_CALL_AMBIGUOUS:
					msg = "Call to method {0} is ambiguous. Please cast arg(s) to desired type to resolve.";
					break;
				case CseLogicExceptionType.METHOD_CANT_IMPLICITLY_COERCE_ARGS:
					msg = "Can't implicity coerce arg(s) to method {0}. Please cast arg(s) to proper type.";
					break;
				case CseLogicExceptionType.METHOD_DOESNT_EXIST:
					msg = "Method {0} doesn't exist";
					break;
				case CseLogicExceptionType.METHOD_EXISTS_BUT_CANT_BE_INVOKED:
					msg = "Method {0} exists but can not be invoked";
					break;
				case CseLogicExceptionType.NOT_A_NUM:
					msg = "{0} is not a valid number";
					break;
				case CseLogicExceptionType.OUT_OR_REF_USED_WITH_LIT:
					msg = "Keywords 'out' and 'ref' cannot be used with a literal";
					break;
				case CseLogicExceptionType.OVERFLOW_TRYING_TO_CAST:
					msg = "Overflow when trying to cast {0} to {1}";
					break;
				case CseLogicExceptionType.POW_OP_TYPE_INVALID:
					msg = "Operand {0} to power operator is an invalid type";
					break;
				case CseLogicExceptionType.RIGHT_OP_NON_NUM:
					msg = "Right operand {0} non-numeric";
					break;
				case CseLogicExceptionType.UNKNOWN_TYPE:
					msg = "Unknown Type {0}";
					break;
			}

			return msg;
		}
	}
}
