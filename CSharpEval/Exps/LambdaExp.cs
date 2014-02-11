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

#pragma warning disable 1591

using System;
using System.Collections.Generic;

namespace CSE.Exps {
	///
	/// <summary>
	///		Used to parse lambda expressions
	/// </summary>
	/// 
	/// <remarks>This doesn't work yet</remarks>
	/// 
	internal class Lambda<T> {
		///
		/// <summary>
		///		
		/// </summary>
		/// 
		public T Data { get; set; }

		///
		/// <summary>
		///		
		/// </summary>
		/// 
		public Lambda(T data) {
			this.Data = data;
		}
	}

	///
	/// <summary>
	///		
	/// </summary>
	/// 
	internal static class LambdaExp {
		///
		/// <summary>
		///		
		/// </summary>
		/// 
		public static dynamic Parse(string[] parameters, string body) {
			dynamic lambda = null;

			switch (parameters.Length) {
				case 1:
					lambda = new Lambda<Func<dynamic, dynamic>>((dynamic a0) => {
						//TempIdentifierExp.PushScope();
						TempIdentifierExp.AddIdent(a0.GetType(), parameters[0], a0);
						dynamic result = CsEval.Eval(body);
						//TempIdentifierExp.PopScope();
						return result;
					});
					break;
				case 2:
					lambda = new Lambda<Func<dynamic, dynamic, dynamic>>((a0, a1) => {
						//TempIdentifierExp.PushScope();
						TempIdentifierExp.AddIdent(a0.GetType(), parameters[0], a0);
						TempIdentifierExp.AddIdent(a1.GetType(), parameters[1], a1);
						dynamic result = CsEval.Eval(body);
						//TempIdentifierExp.PopScope();
						return result;
					});
					break;
			}

			return lambda;
		}

		///
		/// <summary>
		///		
		/// </summary>
		/// 
		public static dynamic Invoke(dynamic lambda, object[] args) {
			//dynamic clambda = new Func<int, int>(lambda.Data);
			return MethodExp.Parse(CsEval.evalEnvironment, "Foo", new List<CseObject>() { new CseObject(lambda) }).Value;


			//dynamic result = null;

			//switch (args.Length) {
			//   case 1:
			//      result = lambda.Data(args[0]);
			//      break;
			//   case 2:
			//      result = lambda.Data(args[0], args[1]);
			//      break;
			//}

			//return value;
		}
	}
}
