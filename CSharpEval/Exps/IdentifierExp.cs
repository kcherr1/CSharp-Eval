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
using System.Collections.Generic;
using System.Reflection;
using CSE.Exceptions;

namespace CSE.Exps {
  ///
  /// <summary>
  ///		Used to parse identifier expressions
  /// </summary>
  /// 
  internal static class IdentifierExp {
    ///
    /// <summary>
    ///		Combines standard bindingflag options to be used to find the identifier
    /// </summary>
    /// 
    private static BindingFlags defaultFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public;

    ///
    /// <summary>
    ///		Parses identifiers (fields or properties)
    /// </summary>
    /// 
    /// <param name="environment">The environment containing the field or property</param>
    /// <param name="data">The name of the field or property</param>
    /// 
    /// <returns>An CseObject containing the value of the identifier or containing null if identifier cannot be found</returns>
    /// 
    /// <exception cref="CseLogicExceptionType.IDENT_NOT_FOUND" />
    ///
    internal static CseObject Parse(CseObject environment, string data) {
      if (data[0].Equals('@'))
        data = data.Remove(0, 1);

      LiteralExp.ParseEscSeqs(ref data, false);

      CseObject result = null;
      Type instanceType = TypeExp.GetTypeObj(environment.Value);

      if (!instanceType.IsEnum) {
        if (environment == CsEval.EvalEnvironment) {
          CseObject tempLookup = TempIdentifierExp.Lookup(data);
          if (tempLookup != null)
            return tempLookup;
        }

        FieldInfo fieldInfo = instanceType.GetField(data, defaultFlags | BindingFlags.GetField);
        if (fieldInfo != null) {
          result = new CseObject(fieldInfo.GetValue(environment.Value));
          result.CompileTimeType = fieldInfo.FieldType;
        }
        else {
          PropertyInfo propertyInfo = instanceType.GetProperty(data, defaultFlags | BindingFlags.GetProperty);
          if (propertyInfo != null) {
            result = new CseObject(propertyInfo.GetValue(environment.Value, null));
            result.CompileTimeType = propertyInfo.PropertyType;
          }
          else {
            Type t = TypeExp.GetType(data);
            if (t != null) {
              result = new CseObject(t);
              result.CompileTimeType = t.GetType();
            }
            else {
              throw new CseLogicException(CseLogicExceptionType.IDENT_NOT_FOUND, data);
            }
          }
        }
      }
      else {
        dynamic resultObj = Enum.Parse(instanceType, data);
        result = new CseObject(resultObj);
        result.CompileTimeType = resultObj.GetType();
      }

      return result;
    }

    ///
    /// <summary>
    ///		Assigns a value to the specified identifier (field or property).
    ///		Since any field or property that is a ValueType will not have its
    ///		value changed without explicitly being set, this method is given the
    ///		entire list of objects of the lhs chain expression and uses recursion to
    ///		set them right to left.
    /// </summary>
    /// 
    /// <example>
    ///		<c language="C#">x.y.z = 3</c>
    ///		This will set z = 3, then y = z (the newly changed z), then x = y.
    ///		If the expression is simply <c language="C#">x = 3</c>, then that is the only assignment
    ///		performed and all List arguments contain only a single value.
    /// </example>
    /// 
    /// <param name="envChain">
    ///		List of CseObjects from the chain expression of the lhs. This makes up the
    ///		list of environment objects. In the case of x = 3, envChain would contain
    ///		x's value.
    ///	</param>
    /// <param name="envNames">List of field/property names in the lhs chain expression. In the case of x = 3, envNames would contain "x".</param>
    /// <param name="envIndices">
    ///		List of array indices for each array in the lhs chain expression. For each non-array, the
    ///		envIndices at that index is null. In the case of x = 3, envIndices would contain null.
    ///		In the case of x[2] = 3, envIndices would contain 2.
    ///	</param>
    /// <param name="xrhs">Rhs expression</param>
    /// 
    /// <returns>xrhs's Value property</returns>
    /// 
    /// <exception cref="CseLogicExceptionType.ARRAY_INDEX_NOT_INT" />
    /// <exception cref="CseLogicExceptionType.CANT_FIND_IDENT_IN_ENV" />
    ///
    internal static object Assign(List<CseObject> envChain, List<string> envNames, List<CseObject> envIndices, CseObject xrhs) {
      object rhs = (xrhs == null ? null : xrhs.Value);

      if (envChain.Count == 0)
        return rhs;

      CseObject env = envChain[envChain.Count - 1];
      string envName = envNames[envNames.Count - 1];
      CseObject envIndex = envIndices[envIndices.Count - 1];

      //Type instanceType = TypeExp.GetTypeObj(env.Value);
      Type instanceType = env.ValueType;

      // Arrays
      if (envIndex != null) {
        MemberInfo member;
        ICollection arrMember;

        member = instanceType.GetField(envName, defaultFlags | BindingFlags.GetField);
        if (member != null) {
          arrMember = (ICollection)((FieldInfo)member).GetValue(env.Value);
        }
        else {
          member = instanceType.GetProperty(envName, defaultFlags | BindingFlags.GetProperty);
          if (member != null)
            arrMember = (ICollection)((PropertyInfo)member).GetValue(env.Value, null);
          else
            throw new CseLogicException(CseLogicExceptionType.CANT_FIND_IDENT_IN_ENV, envName, env.Value.ToString());
        }

        Array arrMemberAsArray = arrMember as Array;
        IDictionary arrMemberAsIDict = arrMember as IDictionary;

        if (arrMemberAsArray != null) {
          int index;
          if (int.TryParse(envIndex.Value.ToString(), out index))
            arrMemberAsArray.SetValue(rhs, index);
          else
            throw new CseLogicException(CseLogicExceptionType.ARRAY_INDEX_NOT_INT);
        }
        else if (arrMemberAsIDict != null) {
          arrMemberAsIDict[envIndex.Value] = rhs;
        }
      }
      // Nonarrays
      else {
        if (env == CsEval.EvalEnvironment) {
          CseObject tempLookup = TempIdentifierExp.Lookup(envName);
          if (tempLookup != null) {
            TempIdentifierExp.Assign(envName, rhs);
            return tempLookup;
          }
        }

        FieldInfo fieldInfo = instanceType.GetField(envName, defaultFlags | BindingFlags.GetField);
        if (fieldInfo != null) {
          fieldInfo.SetValue(env.Value, rhs);
        }
        else {
          PropertyInfo propertyInfo = instanceType.GetProperty(envName, defaultFlags | BindingFlags.GetProperty);
          if (propertyInfo != null)
            propertyInfo.SetValue(env.Value, rhs, null);
          else
            throw new CseLogicException(CseLogicExceptionType.CANT_FIND_IDENT_IN_ENV, envName, env.Value.ToString());
        }
      }

      envChain.RemoveAt(envChain.Count - 1);
      envNames.RemoveAt(envNames.Count - 1);
      envIndices.RemoveAt(envIndices.Count - 1);

      return IdentifierExp.Assign(envChain, envNames, envIndices, env);
    }
  }
}