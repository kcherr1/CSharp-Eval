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
using System.Reflection;
using CSE.Exceptions;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse arithmetic expressions
	/// </summary>
	/// 
	internal static class ArithExp {
		///
		/// <summary>
		///		Parses arithmetic expressions
		/// </summary>
		/// 
		/// <param name="leftOperand">Left operand</param>
		/// <param name="rightOperand">Right operand</param>
		/// <param name="arithType">Arithmetic operator type</param>
		/// 
		/// <remarks>
		///		Only works with operands that evaluate to either numeric or string types. If both operands are strings
		///		and arithType is ADD, concatenation is performed. Else, if either operand is of a float type, both are 
		///		treated as float type. Else, both are treated as int types. This is to ensure proper behavior of operators 
		///		such as addition and division. If operands are of int type, result is then parsed as a literal expression
		///		to ensure correct return type.
		///	</remarks>
		///	
		/// <returns>Result of arithmetic operation</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.ARITH_EXCEPTION" />
		/// <exception cref="CseLogicExceptionType.LEFT_OP_NON_NUM" />
		/// <exception cref="CseLogicExceptionType.RIGHT_OP_NON_NUM" />
		/// 
		internal static CseObject Parse(CseObject leftOperand, CseObject rightOperand, ArithType arithType) {
			dynamic result = null;
			dynamic leftOpValue = leftOperand.Value;
			dynamic rightOpValue = rightOperand.Value;
			string methOpName = null;

			try {
				switch (arithType) {
					case ArithType.ADD:
						methOpName = OpOverloadNames.ADD;
						result = leftOpValue + rightOpValue;
						break;
					case ArithType.DIV:
						methOpName = OpOverloadNames.DIV;
						result = leftOpValue / rightOpValue;
						break;
					case ArithType.MOD:
						methOpName = OpOverloadNames.MOD;
						result = leftOpValue % rightOpValue;
						break;
					case ArithType.MUL:
						methOpName = OpOverloadNames.MUL;
						result = leftOpValue * rightOpValue;
						break;
					case ArithType.POW:
						result = Math.Pow(leftOpValue, rightOpValue);
						break;
					case ArithType.SUB:
						methOpName = OpOverloadNames.SUB;
						result = leftOpValue - rightOpValue;
						break;
				}
				return new CseObject(result);
			}
			catch {
				if (methOpName == null)
					throw new CseLogicException(CseLogicExceptionType.ARITH_EXCEPTION, leftOpValue, rightOpValue);

				MethodInfo leftOpMeth = leftOpValue.GetType().GetMethod(methOpName, OpOverloadNames.Flags);
				MethodInfo rightOpMeth = rightOpValue.GetType().GetMethod(methOpName, OpOverloadNames.Flags);

				if (leftOpMeth == null && rightOpMeth == null)
					throw new CseLogicException(CseLogicExceptionType.ARITH_EXCEPTION, leftOpValue, rightOpValue);
				else if (leftOpMeth != null) {
					try {
						result = new CseObject(leftOpMeth.Invoke(leftOpValue, new object[] { leftOpValue, rightOpValue }));
					}
					catch {
						throw new CseLogicException(CseLogicExceptionType.ARITH_EXCEPTION, leftOpValue, rightOpValue);
					}
				}
				else if (rightOpMeth != null) {
					try {
						result = new CseObject(rightOpMeth.Invoke(rightOpValue, new object[] { leftOpValue, rightOpValue }));
					}
					catch {
						throw new CseLogicException(CseLogicExceptionType.ARITH_EXCEPTION, leftOpValue, rightOpValue);
					}
				}
				else {
					throw new CseLogicException(CseLogicExceptionType.ARITH_EXCEPTION, leftOpValue, rightOpValue);
				}
			}

			return new CseObject(result);
		}

		///
		/// <summary>
		///		Applies numeric affirmation (i.e. unary plus) to numeric values
		/// </summary>
		/// 
		/// <param name="obj">The CseObject with the value to affirm</param>
		/// 
		/// <returns>The CseObject after affirmation</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_AFFIRM_NON_NUM" />
		/// 
		internal static CseObject Affirm(CseObject obj) {
			CseObject result = (CseObject)obj.Clone();

			dynamic value = obj.Value;
			double numValue;

			if (value is string)
				throw new CseLogicException(CseLogicExceptionType.CANT_AFFIRM_NON_NUM, value.ToString());
			else if (!double.TryParse(value.ToString(), out numValue)) {
				MethodInfo mi = value.GetType().GetMethod(OpOverloadNames.UPLUS);
				if (null != mi) {
					result.Value = value.GetType().InvokeMember(OpOverloadNames.UPLUS, OpOverloadNames.Flags, null, CsEval.evalEnvironment, new object[] { value });
					return result;
				}
				else
					throw new CseLogicException(CseLogicExceptionType.CANT_AFFIRM_NON_NUM, value.ToString());
			}

			return result;
		}

		///
		/// <summary>
		///		Applies numeric negation (i.e. unary minus) to numeric values
		/// </summary>
		/// 
		/// <param name="obj">The CseObject with the value to negate</param>
		/// 
		/// <returns>The CseObject after negation</returns>
		/// 
		/// <exception cref="CseLogicExceptionType.CANT_NEGATE_NON_NUM" />
		/// <exception cref="CseLogicExceptionType.ERROR_NEGATING_VALUE_OF_TYPE" />
		/// 
		internal static CseObject Negate(CseObject obj) {
			CseObject result = (CseObject)obj.Clone();

			dynamic value = obj.Value;
			double numValue;

			if (value is string)
				throw new CseLogicException(CseLogicExceptionType.CANT_NEGATE_NON_NUM, value.ToString());
			else if (!double.TryParse(value.ToString(), out numValue)) {
				MethodInfo mi = value.GetType().GetMethod(OpOverloadNames.UMINUS);
				if (null != mi) {
					result.Value = value.GetType().InvokeMember(OpOverloadNames.UMINUS, OpOverloadNames.Flags, null, CsEval.evalEnvironment, new object[] { value });
					return result;
				}
				else
					throw new CseLogicException(CseLogicExceptionType.CANT_NEGATE_NON_NUM, value.ToString());
			}

			numValue *= -1;
			result.Value = numValue;

			try {
				result = CastExp.Parse(CsEval.evalEnvironment, value.GetType().Name, result);
			}
			catch {
				if (value.ToString().ToLower().Contains("e"))
					result = LiteralExp.ParseEType(numValue.ToString());
				else if (value.ToString().Contains("."))
					result = LiteralExp.ParseFloatType(numValue.ToString(), null);
				else
					throw new CseLogicException(CseLogicExceptionType.ERROR_NEGATING_VALUE_OF_TYPE, value.ToString(), value.GetType().Name);
			}

			return result;
		}
	}
}
