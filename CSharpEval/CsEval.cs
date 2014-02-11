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
using System.IO;
using System.Text;
using Antlr.Runtime;
using CSE.AntlrParser;
using CSE.Exps;

namespace CSE {
  ///
  /// <summary>
  ///		Main class for evaluating expressions
  /// </summary>
  /// 
  public static class CsEval {
    ///
    /// <summary>
    ///		Root evaluation environment. This is the 
    ///		instance that all expressions are 
    ///		evaluated against.
    /// </summary>
    /// 
    internal static CseObject evalEnvironment;

    ///
    /// <summary>
    ///		Gets/Sets the evaluation environment
    /// </summary>
    /// 
    /// <see cref="CsEval.evalEnvironment"/>
    /// 
    public static object EvalEnvironment {
      get { return evalEnvironment; }
      set { evalEnvironment = new CseObject(value); }
    }

    ///
    /// <summary>
    ///		Used for quick evaluation.
    ///		Use this when the evaluation environment changes often.
    ///		If the environment is consistent, set CsEval.EvalEnvironment
    ///		then call CsEval.Eval(string data).
    /// </summary>
    /// 
    /// <param name="evalEnvironment">
    ///		Provides an evaluation environment for the given expression.
    ///		The stored evaluation environment is temporarily replaced
    ///		when the given statement is evaluated and restored afterwards.
    ///	</param>
    /// <param name="data">The expression to evaluate</param>
    /// 
    /// <returns>The return result of evaluating the expression</returns>
    /// 
    public static object Eval(object evalEnvironment, string data) {
      CseObject saveDebugInstance = CsEval.evalEnvironment;
      CsEval.evalEnvironment = new CseObject(evalEnvironment);
      object result = Eval(data);
      CsEval.evalEnvironment = saveDebugInstance;

      return result;
    }

    ///
    /// <summary>
    ///		Used for normal evaluation.
    /// </summary>
    /// 
    /// <param name="data">The expression to evaluate</param>
    /// 
    /// <returns>The return result of evaluating the expression</returns>
    ///
    public static object Eval(string data) {
      CsEvaluator evaluator = GetEvaluator(data);
      return Eval(evaluator);
    }

    ///
    /// <summary>
    ///		Used for delayed or continuous evaluation.
    ///		Use this when you want to parse the expression first and evaluate
    ///		it later. Or for when the same expression needs to be evaluated 
    ///		several times. CsEvaluator instance comes from CsEval.GetEvaluator.
    /// </summary>
    /// 
    /// <param name="evaluator">The CsEvaluator returned from a call to CsEval.GetEvaluator</param>
    /// 
    /// <returns>The return result of evaluating the expression</returns>
    /// 
    /// <exception cref="System.Exception" />
    ///
    public static object Eval(CsEvaluator evaluator) {
      if (CsEval.EvalEnvironment == null)
        throw new Exception("CsEval.EvalEnvironment must be set first. " +
                      "Please refer to http://www.csharp-eval.com/HowTo.php for more information");

      try {
        object result = evaluator.parser.exp().Value;
        return result;
      }
      catch (Antlr.Runtime.RecognitionException re) {
        if (re.Token.Type == CseParser.SEMI)
          throw new Exception("Parsing Error At EOL");
        else
          throw new Exception(String.Format("Parsing Error At \"{0}\"", re.Token.Text));
      }
      catch (Exception npe) {
        throw new Exception("Internal error: " + npe.Message);
      }
    }

    ///
    /// <summary>
    ///		Gets a CsEvaluator object for the expression
    /// </summary>
    /// 
    /// <param name="data">Expression to evaluate</param>
    /// 
    /// <returns>CsEvaluator object for the given expression</returns>
    /// 
    public static CsEvaluator GetEvaluator(string data) {
      if (!data.TrimEnd().EndsWith("\n;"))
        data += "\n;";

      CseParser parser = 
        new CseParser(
          new CommonTokenStream(
            new CseLexer(
              new ANTLRInputStream(
                new MemoryStream(Encoding.UTF8.GetBytes(data))
              )
            )
          )
        );

      CsEvaluator evaluator = new CsEvaluator();
      evaluator.parser = parser;

      return evaluator;
    }
  }
}
