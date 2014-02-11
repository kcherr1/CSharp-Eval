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

namespace CSE.Exps {
	///
	/// <summary>
	///		The internal representation of a method resolution object.
	/// </summary>
	/// 
	internal struct MethResObject {
		///
		/// <summary>
		///		Method information object.
		/// </summary>
		/// 
		public MethodInfo MethInfo;

		///
		/// <summary>
		///		InvTypes. Unused.
		/// </summary>
		/// 
		public Type[] InvTypes;

		///
		/// <summary>
		///		The list of arguments for this method resolution.
		/// </summary>
		/// 
		public dynamic[] Args;

		///
		/// <summary>
		///		If this method resolution should match only in "expanded form", as defined in the C# specification, this is marked true,
		///		otherwise false.
		/// </summary>
		/// 
		public bool OnlyAppInExpForm;

		///
		/// <summary>
		///		The constructor for creating a MethResObject.
		/// </summary>
		/// 
		/// <param name="methInfo">The method information to set.</param>
		/// <param name="invTypes">unused. Send null</param>
		/// <param name="args">The argument list to set up for the constructed method resolution object.</param>
		/// <param name="onlyAppInExpForm">Whether or not the method resolution applies only in expanded form.</param>
		/// 
		public MethResObject(MethodInfo methInfo, Type[] invTypes, dynamic[] args, bool onlyAppInExpForm = false) {
			MethInfo = methInfo;
			InvTypes = invTypes;
			Args = args;
			OnlyAppInExpForm = onlyAppInExpForm;
		}
	}
}
