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

namespace CSE.Exps {
	///
	/// <summary>
	///		Used in overloaded and overwritten method resolution
	/// </summary>
	/// 
	internal struct MethResSettings {
		///
		/// <summary>
		///		The parent environment in which this object exists
		/// </summary>
		/// 
		public object Env;

		///
		/// <summary>
		///		The name of this particular method
		/// </summary>
		/// 
		public string Name;

		///
		/// <summary>
		///		The list of arguments for the method
		/// </summary>
		/// 
		public CseObject[] Args;

		///
		/// <summary>
		///		Whether or not this is an extended invocation
		/// </summary>
		/// 
		public bool IsExtInvocation;

		///
		/// <summary>
		///		Constructor for MethResSettings objects
		/// </summary>
		/// 
		/// <param name="env">The environment to use</param>
		/// <param name="name">The name of the method</param>
		/// <param name="args">Arguments to pass to the method</param>
		/// <param name="isExtInvocation">True if this is an extended invocation, false otherwise</param>
		/// 

		public MethResSettings(object env, string name, CseObject[] args, bool isExtInvocation) {
			Env = env;
			Name = name;
			Args = args;
			IsExtInvocation = isExtInvocation;
		}
	}
}
