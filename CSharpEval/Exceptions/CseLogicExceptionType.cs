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

namespace CSE.Exceptions {
	///
	/// <summary>
	///		Holds all logical exception types thrown when a 
	///		statement contains a logical error
	/// </summary>
	/// 
	internal enum CseLogicExceptionType {
		///
		/// <summary>
		///		Arithmetic exception
		/// </summary>
		/// 
		/// <example>"h" + 3</example>
		/// 
		ARITH_EXCEPTION,

		///
		/// <summary>
		///		Array index is not an integer
		/// </summary>
		/// 
		/// <example>arrayIdent["Hello"]</example>
		/// 
		ARRAY_INDEX_NOT_INT,

		///
		/// <summary>
		///		Can't apply unary plus (or "affirmation") to a non-numeric value
		/// </summary>
		/// 
		/// <example>+ "Hello"</example>
		/// 
		CANT_AFFIRM_NON_NUM,

		///
		/// <summary>
		///		Can't cast the given value to the given type
		/// </summary>
		/// 
		/// <example>(ulong) -3</example>
		/// 
		CANT_CAST_VALUE_TO_TYPE,

		///
		/// <summary>
		///		Can't parse the given value as a character
		/// </summary>
		/// 
		/// <example></example>
		/// 
		CANT_CONVERT_TO_CHAR,

		///
		/// <summary>
		///		Can't parse the given value as a double
		/// </summary>
		/// 
		/// <example></example>
		/// 
		CANT_CONVERT_TO_DBL,

		///
		/// <summary>
		///		Can't parse the given value as a floating point type
		/// </summary>
		/// 
		/// <example></example>
		/// 
		CANT_CONVERT_TO_FLT_TYPE,

		///
		/// <summary>
		///		Can't parse the given value as an integral type
		/// </summary>
		/// 
		/// <example></example>
		/// 
		CANT_CONVERT_TO_INT_TYPE,

		///
		/// <summary>
		///		Can't find identifier in given environment
		/// </summary>
		/// 
		/// <example></example>
		/// 
		CANT_FIND_IDENT_IN_ENV,

		///
		/// <summary>
		///		Can't apply unary minus (or negation) to a non-numeric value
		/// </summary>
		/// 
		/// <example>- "Hello"</example>
		/// 
		CANT_NEGATE_NON_NUM,

		///
		/// <summary>
		///		Error while trying to apply unary minus (or negation) to the given value
		/// </summary>
		/// 
		/// <example>- unsignedTypeVariable</example>
		/// 
		ERROR_NEGATING_VALUE_OF_TYPE,

		///
		/// <summary>
		///		Hex escape character is not a recognizable unicode character
		/// </summary>
		/// 
		/// <example>\U12345678</example>
		/// 
		HEX_ESC_CODE_NOT_RECOGNIZED,

		///
		/// <summary>
		///		Identifier is not an array but is being used like one
		/// </summary>
		/// 
		/// <example>nonArrayIdent[3]</example>
		/// 
		IDENT_IS_NOT_ARRAY,

		///
		/// <summary>
		///		Identifier can't be found / doesn't exist
		/// </summary>
		/// 
		/// <example>unknownIdent</example>
		/// 
		IDENT_NOT_FOUND,

		///
		/// <summary>
		///		Left operand to arithmetic expression is non-numeric.
		///		Not throw if both left and right operands are strings.
		/// </summary>
		/// 
		/// <example></example>
		/// 
		LEFT_OP_NON_NUM,

		///
		/// <summary>
		///		Method is overloaded and correct method to call can't be
		///		accurately determined given the types of arguments being
		///		sent.
		/// </summary>
		/// 
		/// <example></example>
		/// 
		METHOD_CALL_AMBIGUOUS,

		///
		/// <summary>
		///		Method is not overloaded but arguments can't be
		///		coerced to match its signature
		/// </summary>
		/// 
		/// <example></example>
		/// 
		METHOD_CANT_IMPLICITLY_COERCE_ARGS,

		///
		/// <summary>
		///		Method doesn't exist
		/// </summary>
		/// 
		/// <example>UnknownMethod()</example>
		/// 
		METHOD_DOESNT_EXIST,

		///
		/// <summary>
		///		Method does exist but (for some reason) can't be called
		/// </summary>
		/// 
		/// <example></example>
		/// 
		METHOD_EXISTS_BUT_CANT_BE_INVOKED,

		///
		/// <summary>
		///		Value is not a number but is being used in such a way that demands
		///		it to be.
		/// </summary>
		/// 
		/// <example></example>
		/// 
		NOT_A_NUM,

		///
		/// <summary>
		///		Out or ref keyword used on a literal
		/// </summary>
		/// 
		/// <example>Foo(out 3.2);</example>
		/// 
		OUT_OR_REF_USED_WITH_LIT,

		///
		/// <summary>
		///		Overflow (or underflow) when trying to cast given value to given type
		/// </summary>
		/// 
		/// <example></example>
		/// 
		OVERFLOW_TRYING_TO_CAST,

		/// <summary>
		///		Decimal operators are not valid for the power operator.
		/// </summary>
		/// 
		POW_OP_TYPE_INVALID,

		///
		/// <summary>
		///		Right operand to arithmetic expression is non-numeric.
		///		Not throw if both left and right operands are strings.
		/// </summary>
		/// 
		/// <example></example>
		/// 
		RIGHT_OP_NON_NUM,

		///
		/// <summary>
		///		Type can't be found / doesn't exist
		/// </summary>
		/// 
		/// <example>new UnknownType()</example>
		/// 
		UNKNOWN_TYPE
	}
}
