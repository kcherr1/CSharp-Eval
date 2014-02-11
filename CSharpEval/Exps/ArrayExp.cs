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
using System.Collections;
using System.Reflection;
using CSE.Exceptions;

namespace CSE.Exps {
  ///
  /// <summary>
  ///		Used to parse array index expressions
  /// </summary>
  /// 
  internal static class ArrayExp {
    ///
    /// <summary>
    ///		Parses array expressions
    /// </summary>
    /// 
    /// <param name="rootInstance">Environment where the array is implemented</param>
    /// <param name="arrayIdent">Name of the array</param>
    /// <param name="index">Object for the index value</param>
    /// 
    /// <returns>CseObject containing the array element at the specified index</returns>
    /// 
    /// <exception cref="CseLogicExceptionType.IDENT_IS_NOT_ARRAY" />
    /// <exception cref="CseLogicExceptionType.IDENT_NOT_FOUND" />
    ///
    public static CseObject Parse(CseObject rootInstance, string arrayIdent, CseObject index) {
      BindingFlags flags = BindingFlags.NonPublic |
                 BindingFlags.Public |
                 BindingFlags.Static |
                 BindingFlags.Instance;

      Type rootInstanceType = TypeExp.GetTypeObj(rootInstance.Value);

      object result = null;
      FieldInfo fieldInfo = rootInstanceType.GetField(arrayIdent, flags);
      if (fieldInfo != null) {
        result = fieldInfo.GetValue(rootInstance.Value);
      }
      else {
        PropertyInfo propertyInfo = rootInstanceType.GetProperty(arrayIdent);
        if (propertyInfo != null)
          result = propertyInfo.GetValue(rootInstance.Value, null);
        else
          throw new CseLogicException(CseLogicExceptionType.IDENT_NOT_FOUND, arrayIdent);
      }

      IDictionary dictionary = result as IDictionary;
      Array array = result as Array;

      if (dictionary != null) {
        return new CseObject(dictionary[index.Value]);
      }
      else if (array != null) {
        return new CseObject(array.GetValue(long.Parse(index.Value.ToString())));
      }
      else {
        throw new CseLogicException(CseLogicExceptionType.IDENT_IS_NOT_ARRAY, arrayIdent);
      }
    }
  }
}