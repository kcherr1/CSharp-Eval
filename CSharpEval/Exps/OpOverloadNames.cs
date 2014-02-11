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

using System.Reflection;

namespace CSE.Exps {
	///
	/// <summary>
	///		Contains the names of the methods generated when operator overloading is used
	/// </summary>
	/// 
	internal static class OpOverloadNames {
		///
		/// <summary>
		///		Binding flags for looking up and invoking an operator overloaded method
		/// </summary>
		/// 
		public static BindingFlags Flags = BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static;

		///
		/// <summary>
		///		Method name generated when the unary plus operator is overloaded
		/// </summary>
		/// 
		public static string UPLUS = "op_UnaryPlus";

		///
		/// <summary>
		///		Method name generated when the unary negation operator is overloaded
		/// </summary>
		/// 
		public static string UMINUS = "op_UnaryNegation";

		///
		/// <summary>
		///		Method name generated when the logical negation operator is overloaded
		/// </summary>
		/// 
		public static string BANG = "op_LogicalNot";

		///
		/// <summary>
		///		Method name generated when the increment operator is overloaded
		/// </summary>
		/// 
		public static string INC = "op_Increment";

		///
		/// <summary>
		///		Method name generated when the decrement operator is overloaded
		/// </summary>
		/// 
		public static string DEC = "op_Decrement";

		///
		/// <summary>
		///		Method name generated when the true operator is overloaded
		/// </summary>
		/// 
		public static string TRUE = "op_True";

		///
		/// <summary>
		///		Method name generated when the false operator is overloaded
		/// </summary>
		/// 
		public static string FALSE = "op_False";

		///
		/// <summary>
		///		Method name generated when the addition operator is overloaded
		/// </summary>
		/// 
		public static string ADD = "op_Addition";

		///
		/// <summary>
		///		Method name generated when the subtraction operator is overloaded
		/// </summary>
		/// 
		public static string SUB = "op_Subtraction";

		///
		/// <summary>
		///		Method name generated when the multiplication operator is overloaded
		/// </summary>
		/// 
		public static string MUL = "op_Multiply";

		///
		/// <summary>
		///		Method name generated when the division operator is overloaded
		/// </summary>
		/// 
		public static string DIV = "op_Division";

		///
		/// <summary>
		///		Method name generated when the modulus operator is overloaded
		/// </summary>
		/// 
		public static string MOD = "op_Modulus";

		///
		/// <summary>
		///		Method name generated when the bitwise and operator is overloaded
		/// </summary>
		/// 
		public static string BIT_AND = "op_BitwiseAnd";

		///
		/// <summary>
		///		Method name generated when the bitwise or operator is overloaded
		/// </summary>
		/// 
		public static string BIT_OR = "op_BitwiseOr";

		///
		/// <summary>
		///		Method name generated when the bitwise xor operator is overloaded
		/// </summary>
		/// 
		public static string BIT_XOR = "op_ExclusiveOr";

		///
		/// <summary>
		///		Method name generated when the bitwise negation operator is overloaded
		/// </summary>
		/// 
		public static string BIT_NOT = "op_OnesComplement";

		///
		/// <summary>
		///		Method name generated when the right shift operator is overloaded
		/// </summary>
		/// 
		public static string BIT_RSHIFT = "op_RightShift";

		///
		/// <summary>
		///		Method name generated when the left shift operator is overloaded
		/// </summary>
		/// 
		public static string BIT_LSHIFT = "op_LeftShift";

		///
		/// <summary>
		///		Method name generated when the equals operator is overloaded
		/// </summary>
		/// 
		public static string EQ = "op_Equality";

		///
		/// <summary>
		///		Method name generated when the not equals operator is overloaded
		/// </summary>
		/// 
		public static string NEQ = "op_Inequality";

		///
		/// <summary>
		///		Method name generated when the less than operator is overloaded
		/// </summary>
		/// 
		public static string LT = "op_LessThan";

		///
		/// <summary>
		///		Method name generated when the less than or equal to operator is overloaded
		/// </summary>
		/// 
		public static string LTE = "op_LessThanOrEqual";

		///
		/// <summary>
		///		Method name generated when the greater than operator is overloaded
		/// </summary>
		/// 
		public static string GT = "op_GreaterThan";

		///
		/// <summary>
		///		Method name generated when the greater than or equal to operator is overloaded
		/// </summary>
		/// 
		public static string GTE = "op_GreaterThanOrEqual";

		///
		/// <summary>
		///		Method name generated when the implicit conversion operator is overloaded
		/// </summary>
		/// 
		public static string COV_WIDE = "op_Implicit";

		///
		/// <summary>
		///		Method name generated when the explicit coversion operator is overloaded
		/// </summary>
		/// 
		public static string COV_NARROW = "op_Explicit";
	}
}
