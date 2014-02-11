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

#pragma warning disable 219, 162, 1591

using System;
using System.Collections.Generic;
using Antlr.Runtime;
using CSE.Exps;
using List = System.Collections.IList;

namespace CSE.AntlrParser {
	[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
	internal partial class CseParser : Antlr.Runtime.Parser {
		internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "SEMI", "EQ", "ID", "CROSS_EQ", "LPAREN", "RPAREN", "DASH_EQ", "STAR_EQ", "FSLASH_EQ", "PER_EQ", "DBLSTAR_EQ", "QUESTION", "COLON", "DBLPIPE", "DBLAMP", "PIPE", "HAT", "AMP", "DBL_EQ", "BANG_EQ", "LANGLE", "RANGLE", "LANGLE_EQ", "RANGLE_EQ", "DBLLANGLE", "DBLRANGLE", "CROSS", "DASH", "STAR", "FSLASH", "PER", "DBLSTAR", "BANG", "TILDE", "NEW", "DOT", "LBRACK", "RBRACK", "COMMA", "REF", "OUT", "CH_INT", "EINT", "EFLT", "INT", "FLT", "INTWITHSUFFIX", "FLTWITHSUFFIX", "BOOL", "STR", "CHAR", "NULL", "TERMCONST", "OCT_DIGIT", "DIGIT", "HEX_DIGIT", "LETTER", "ESC_SEQ", "IDENT_START", "IDENT_CONT", "WHITESPACE", "DBLCROSS", "DBLDASH", "LAMBDAOP", "LBRACE", "RBRACE", "COMMENT", "WS"
	};
		public const int EOF=-1;
		public const int SEMI=4;
		public const int EQ=5;
		public const int ID=6;
		public const int CROSS_EQ=7;
		public const int LPAREN=8;
		public const int RPAREN=9;
		public const int DASH_EQ=10;
		public const int STAR_EQ=11;
		public const int FSLASH_EQ=12;
		public const int PER_EQ=13;
		public const int DBLSTAR_EQ=14;
		public const int QUESTION=15;
		public const int COLON=16;
		public const int DBLPIPE=17;
		public const int DBLAMP=18;
		public const int PIPE=19;
		public const int HAT=20;
		public const int AMP=21;
		public const int DBL_EQ=22;
		public const int BANG_EQ=23;
		public const int LANGLE=24;
		public const int RANGLE=25;
		public const int LANGLE_EQ=26;
		public const int RANGLE_EQ=27;
		public const int DBLLANGLE=28;
		public const int DBLRANGLE=29;
		public const int CROSS=30;
		public const int DASH=31;
		public const int STAR=32;
		public const int FSLASH=33;
		public const int PER=34;
		public const int DBLSTAR=35;
		public const int BANG=36;
		public const int TILDE=37;
		public const int NEW=38;
		public const int DOT=39;
		public const int LBRACK=40;
		public const int RBRACK=41;
		public const int COMMA=42;
		public const int REF=43;
		public const int OUT=44;
		public const int CH_INT=45;
		public const int EINT=46;
		public const int EFLT=47;
		public const int INT=48;
		public const int FLT=49;
		public const int INTWITHSUFFIX=50;
		public const int FLTWITHSUFFIX=51;
		public const int BOOL=52;
		public const int STR=53;
		public const int CHAR=54;
		public const int NULL=55;
		public const int TERMCONST=56;
		public const int OCT_DIGIT=57;
		public const int DIGIT=58;
		public const int HEX_DIGIT=59;
		public const int LETTER=60;
		public const int ESC_SEQ=61;
		public const int IDENT_START=62;
		public const int IDENT_CONT=63;
		public const int WHITESPACE=64;
		public const int DBLCROSS=65;
		public const int DBLDASH=66;
		public const int LAMBDAOP=67;
		public const int LBRACE=68;
		public const int RBRACE=69;
		public const int COMMENT=70;
		public const int WS=71;

		// delegates
		// delegators

#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[] {
				false, // invalid decision
				true, true, true, true, true, true, true, true, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, true, false, false, false, false, 
				false, false, false, false, false, false, false, false, true, true, 
				true, true, true, 
			};
#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
#endif
		public CseParser(ITokenStream input)
			: this(input, new RecognizerSharedState()) {
		}
		public CseParser(ITokenStream input, RecognizerSharedState state)
			: base(input, state) {

			OnCreated();
		}


		public override string[] TokenNames {
			get { return CseParser.tokenNames; }
		}
		public override string GrammarFileName {
			get { return ""; }
		}


		public override void EmitErrorMessage(String msg) {
			throw new Exception(msg);
		}

		protected override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) {
			throw new MismatchedTokenException(ttype, input);
		}

		public override object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow) {
			throw e;
		}


		partial void OnCreated();
		partial void EnterRule(string ruleName, int ruleIndex);
		partial void LeaveRule(string ruleName, int ruleIndex);

		#region Rules

		partial void Enter_exp();
		partial void Leave_exp();

		// $ANTLR start "exp"
		[GrammarRule("exp")]
		public CseObject exp() {
			Enter_exp();
			EnterRule("exp", 1);
			TraceIn("exp", 1);

			CseObject value = default(CseObject);

			CseObject subExp1 = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "exp");
				DebugLocation(109, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(110, 4);
						PushFollow(Follow._subExp_in_exp118);
						subExp1 = subExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(110, 11);
						Match(input, SEMI, Follow._SEMI_in_exp120);
						if (state.failed)
							return value;
						DebugLocation(110, 16);
						if (state.backtracking == 0) {
							value = subExp1;
						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("exp", 1);
					LeaveRule("exp", 1);
					Leave_exp();
				}
				DebugLocation(111, 1);
			}
			finally { DebugExitRule(GrammarFileName, "exp"); }
			return value;

		}
		// $ANTLR end "exp"


		partial void Enter_subExp();
		partial void Leave_subExp();

		// $ANTLR start "subExp"
		[GrammarRule("subExp")]
		private CseObject subExp() {
			Enter_subExp();
			EnterRule("subExp", 2);
			TraceIn("subExp", 2);

			CseObject value = default(CseObject);

			CseObject assign2 = default(CseObject);
			CseObject nonAssign3 = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "subExp");
				DebugLocation(114, 1);
				try {
					int alt1=2;
					try {
						DebugEnterDecision(1, decisionCanBacktrack[1]);
						try {
							alt1 = dfa1.Predict(input);
						}
						catch (NoViableAltException nvae) {
							DebugRecognitionException(nvae);
							throw;
						}
					}
					finally { DebugExitDecision(1); }
					switch (alt1) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(115, 4);
								PushFollow(Follow._assign_in_subExp138);
								assign2 = assign();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(115, 12);
								if (state.backtracking == 0) {
									value = assign2;
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(116, 4);
								PushFollow(Follow._nonAssign_in_subExp146);
								nonAssign3 = nonAssign();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(116, 15);
								if (state.backtracking == 0) {
									value = nonAssign3;
								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("subExp", 2);
					LeaveRule("subExp", 2);
					Leave_subExp();
				}
				DebugLocation(117, 1);
			}
			finally { DebugExitRule(GrammarFileName, "subExp"); }
			return value;

		}
		// $ANTLR end "subExp"


		partial void Enter_assign();
		partial void Leave_assign();

		// $ANTLR start "assign"
		[GrammarRule("assign")]
		private CseObject assign() {
			Enter_assign();
			EnterRule("assign", 3);
			TraceIn("assign", 3);

			CseObject value = default(CseObject);

			IToken ID6=null;
			CseObject icp = default(CseObject);
			CseObject subExp4 = default(CseObject);
			CseParser.typeExp_return typeExp5 = default(CseParser.typeExp_return);
			CseObject subExp7 = default(CseObject);
			CseObject subExp8 = default(CseObject);
			CseParser.typeExp_return typeExp9 = default(CseParser.typeExp_return);
			CseObject subExp10 = default(CseObject);
			CseParser.typeExp_return typeExp11 = default(CseParser.typeExp_return);
			CseObject subExp12 = default(CseObject);
			CseParser.typeExp_return typeExp13 = default(CseParser.typeExp_return);
			CseObject subExp14 = default(CseObject);
			CseParser.typeExp_return typeExp15 = default(CseParser.typeExp_return);
			CseObject subExp16 = default(CseObject);
			CseParser.typeExp_return typeExp17 = default(CseParser.typeExp_return);
			CseObject subExp18 = default(CseObject);
			CseParser.typeExp_return typeExp19 = default(CseParser.typeExp_return);

			try {
				DebugEnterRule(GrammarFileName, "assign");
				DebugLocation(118, 1);
				try {
					int alt8=8;
					try {
						DebugEnterDecision(8, decisionCanBacktrack[8]);
						try {
							alt8 = dfa8.Predict(input);
						}
						catch (NoViableAltException nvae) {
							DebugRecognitionException(nvae);
							throw;
						}
					}
					finally { DebugExitDecision(8); }
					switch (alt8) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(119, 7);
								PushFollow(Follow._identChainList_in_assign165);
								icp = identChainList();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(119, 23);
								Match(input, EQ, Follow._EQ_in_assign167);
								if (state.failed)
									return value;
								DebugLocation(119, 26);
								PushFollow(Follow._subExp_in_assign169);
								subExp4 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(119, 33);
								if (state.backtracking == 0) {
									value = AssignExp.Parse(icp.EnvChain, icp.EnvNames, icp.EnvIndices, subExp4);
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(120, 4);
								PushFollow(Follow._typeExp_in_assign176);
								typeExp5 = typeExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(120, 12);
								ID6 = (IToken)Match(input, ID, Follow._ID_in_assign178);
								if (state.failed)
									return value;
								DebugLocation(120, 15);
								Match(input, EQ, Follow._EQ_in_assign180);
								if (state.failed)
									return value;
								DebugLocation(120, 18);
								PushFollow(Follow._subExp_in_assign182);
								subExp7 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(121, 3);
								if (state.backtracking == 0) {

									value = new CseObject(null);
									TempIdentifierExp.AddIdent((Type)(typeExp5 != null ? typeExp5.value : default(CseObject)).Value, (ID6 != null ? ID6.Text : null), subExp7);

								}

							}
							break;
						case 3:
							DebugEnterAlt(3); {
								DebugLocation(125, 7);
								PushFollow(Follow._identChainList_in_assign194);
								icp = identChainList();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(125, 23);
								Match(input, CROSS_EQ, Follow._CROSS_EQ_in_assign196);
								if (state.failed)
									return value;
								DebugLocation(125, 32);
								int alt2=2;
								try {
									DebugEnterSubRule(2);
									try {
										DebugEnterDecision(2, decisionCanBacktrack[2]);
										try {
											alt2 = dfa2.Predict(input);
										}
										catch (NoViableAltException nvae) {
											DebugRecognitionException(nvae);
											throw;
										}
									}
									finally { DebugExitDecision(2); }
									switch (alt2) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(125, 33);
												Match(input, LPAREN, Follow._LPAREN_in_assign199);
												if (state.failed)
													return value;
												DebugLocation(125, 40);
												PushFollow(Follow._typeExp_in_assign201);
												typeExp9 = typeExp();
												PopFollow();
												if (state.failed)
													return value;
												DebugLocation(125, 48);
												Match(input, RPAREN, Follow._RPAREN_in_assign203);
												if (state.failed)
													return value;

											}
											break;

									}
								}
								finally { DebugExitSubRule(2); }

								DebugLocation(125, 57);
								PushFollow(Follow._subExp_in_assign207);
								subExp8 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(126, 3);
								if (state.backtracking == 0) {

									CseObject result = ArithExp.Parse(icp, subExp8, ArithType.ADD);
									if ((typeExp9 != null ? typeExp9.value : default(CseObject)) != null) {
										result = CastExp.Parse(null, (typeExp9 != null ? input.ToString(typeExp9.Start, typeExp9.Stop) : null), result);
									}

									String fullTypeName = icp.Value.GetType().ToString();
									int indexOfDot = fullTypeName.IndexOf('.');
									String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);

									result = CastExp.Parse(null, typeName, result);

									value = AssignExp.Parse(icp.EnvChain, icp.EnvNames, icp.EnvIndices, result);

								}

							}
							break;
						case 4:
							DebugEnterAlt(4); {
								DebugLocation(140, 7);
								PushFollow(Follow._identChainList_in_assign219);
								icp = identChainList();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(140, 23);
								Match(input, DASH_EQ, Follow._DASH_EQ_in_assign221);
								if (state.failed)
									return value;
								DebugLocation(140, 31);
								int alt3=2;
								try {
									DebugEnterSubRule(3);
									try {
										DebugEnterDecision(3, decisionCanBacktrack[3]);
										try {
											alt3 = dfa3.Predict(input);
										}
										catch (NoViableAltException nvae) {
											DebugRecognitionException(nvae);
											throw;
										}
									}
									finally { DebugExitDecision(3); }
									switch (alt3) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(140, 32);
												Match(input, LPAREN, Follow._LPAREN_in_assign224);
												if (state.failed)
													return value;
												DebugLocation(140, 39);
												PushFollow(Follow._typeExp_in_assign226);
												typeExp11 = typeExp();
												PopFollow();
												if (state.failed)
													return value;
												DebugLocation(140, 47);
												Match(input, RPAREN, Follow._RPAREN_in_assign228);
												if (state.failed)
													return value;

											}
											break;

									}
								}
								finally { DebugExitSubRule(3); }

								DebugLocation(140, 56);
								PushFollow(Follow._subExp_in_assign232);
								subExp10 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(141, 3);
								if (state.backtracking == 0) {

									CseObject result = ArithExp.Parse(icp, subExp10, ArithType.SUB);
									if ((typeExp11 != null ? typeExp11.value : default(CseObject)) != null) { result = CastExp.Parse(null, (typeExp11 != null ? input.ToString(typeExp11.Start, typeExp11.Stop) : null), result); }
									String fullTypeName = icp.Value.GetType().ToString();
									int indexOfDot = fullTypeName.IndexOf('.');
									String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
									result = CastExp.Parse(null, typeName, result);
									value = AssignExp.Parse(icp.EnvChain, icp.EnvNames, icp.EnvIndices, result);

								}

							}
							break;
						case 5:
							DebugEnterAlt(5); {
								DebugLocation(150, 7);
								PushFollow(Follow._identChainList_in_assign244);
								icp = identChainList();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(150, 23);
								Match(input, STAR_EQ, Follow._STAR_EQ_in_assign246);
								if (state.failed)
									return value;
								DebugLocation(150, 31);
								int alt4=2;
								try {
									DebugEnterSubRule(4);
									try {
										DebugEnterDecision(4, decisionCanBacktrack[4]);
										try {
											alt4 = dfa4.Predict(input);
										}
										catch (NoViableAltException nvae) {
											DebugRecognitionException(nvae);
											throw;
										}
									}
									finally { DebugExitDecision(4); }
									switch (alt4) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(150, 32);
												Match(input, LPAREN, Follow._LPAREN_in_assign249);
												if (state.failed)
													return value;
												DebugLocation(150, 39);
												PushFollow(Follow._typeExp_in_assign251);
												typeExp13 = typeExp();
												PopFollow();
												if (state.failed)
													return value;
												DebugLocation(150, 47);
												Match(input, RPAREN, Follow._RPAREN_in_assign253);
												if (state.failed)
													return value;

											}
											break;

									}
								}
								finally { DebugExitSubRule(4); }

								DebugLocation(150, 56);
								PushFollow(Follow._subExp_in_assign257);
								subExp12 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(151, 3);
								if (state.backtracking == 0) {

									CseObject result = ArithExp.Parse(icp, subExp12, ArithType.MUL);
									if ((typeExp13 != null ? typeExp13.value : default(CseObject)) != null) { result = CastExp.Parse(null, (typeExp13 != null ? input.ToString(typeExp13.Start, typeExp13.Stop) : null), result); }
									String fullTypeName = icp.Value.GetType().ToString();
									int indexOfDot = fullTypeName.IndexOf('.');
									String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
									result = CastExp.Parse(null, typeName, result);
									value = AssignExp.Parse(icp.EnvChain, icp.EnvNames, icp.EnvIndices, result);

								}

							}
							break;
						case 6:
							DebugEnterAlt(6); {
								DebugLocation(160, 7);
								PushFollow(Follow._identChainList_in_assign269);
								icp = identChainList();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(160, 23);
								Match(input, FSLASH_EQ, Follow._FSLASH_EQ_in_assign271);
								if (state.failed)
									return value;
								DebugLocation(160, 33);
								int alt5=2;
								try {
									DebugEnterSubRule(5);
									try {
										DebugEnterDecision(5, decisionCanBacktrack[5]);
										try {
											alt5 = dfa5.Predict(input);
										}
										catch (NoViableAltException nvae) {
											DebugRecognitionException(nvae);
											throw;
										}
									}
									finally { DebugExitDecision(5); }
									switch (alt5) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(160, 34);
												Match(input, LPAREN, Follow._LPAREN_in_assign274);
												if (state.failed)
													return value;
												DebugLocation(160, 41);
												PushFollow(Follow._typeExp_in_assign276);
												typeExp15 = typeExp();
												PopFollow();
												if (state.failed)
													return value;
												DebugLocation(160, 49);
												Match(input, RPAREN, Follow._RPAREN_in_assign278);
												if (state.failed)
													return value;

											}
											break;

									}
								}
								finally { DebugExitSubRule(5); }

								DebugLocation(160, 58);
								PushFollow(Follow._subExp_in_assign282);
								subExp14 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(161, 3);
								if (state.backtracking == 0) {

									CseObject result = ArithExp.Parse(icp, subExp14, ArithType.DIV);
									if ((typeExp15 != null ? typeExp15.value : default(CseObject)) != null) { result = CastExp.Parse(null, (typeExp15 != null ? input.ToString(typeExp15.Start, typeExp15.Stop) : null), result); }
									String fullTypeName = icp.Value.GetType().ToString();
									int indexOfDot = fullTypeName.IndexOf('.');
									String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
									result = CastExp.Parse(null, typeName, result);
									value = AssignExp.Parse(icp.EnvChain, icp.EnvNames, icp.EnvIndices, result);

								}

							}
							break;
						case 7:
							DebugEnterAlt(7); {
								DebugLocation(170, 7);
								PushFollow(Follow._identChainList_in_assign294);
								icp = identChainList();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(170, 23);
								Match(input, PER_EQ, Follow._PER_EQ_in_assign296);
								if (state.failed)
									return value;
								DebugLocation(170, 30);
								int alt6=2;
								try {
									DebugEnterSubRule(6);
									try {
										DebugEnterDecision(6, decisionCanBacktrack[6]);
										try {
											alt6 = dfa6.Predict(input);
										}
										catch (NoViableAltException nvae) {
											DebugRecognitionException(nvae);
											throw;
										}
									}
									finally { DebugExitDecision(6); }
									switch (alt6) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(170, 31);
												Match(input, LPAREN, Follow._LPAREN_in_assign299);
												if (state.failed)
													return value;
												DebugLocation(170, 38);
												PushFollow(Follow._typeExp_in_assign301);
												typeExp17 = typeExp();
												PopFollow();
												if (state.failed)
													return value;
												DebugLocation(170, 46);
												Match(input, RPAREN, Follow._RPAREN_in_assign303);
												if (state.failed)
													return value;

											}
											break;

									}
								}
								finally { DebugExitSubRule(6); }

								DebugLocation(170, 55);
								PushFollow(Follow._subExp_in_assign307);
								subExp16 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(171, 3);
								if (state.backtracking == 0) {

									CseObject result = ArithExp.Parse(icp, subExp16, ArithType.MOD);
									if ((typeExp17 != null ? typeExp17.value : default(CseObject)) != null) { result = CastExp.Parse(null, (typeExp17 != null ? input.ToString(typeExp17.Start, typeExp17.Stop) : null), result); }
									String fullTypeName = icp.Value.GetType().ToString();
									int indexOfDot = fullTypeName.IndexOf('.');
									String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
									result = CastExp.Parse(null, typeName, result);
									value = AssignExp.Parse(icp.EnvChain, icp.EnvNames, icp.EnvIndices, result);

								}

							}
							break;
						case 8:
							DebugEnterAlt(8); {
								DebugLocation(180, 7);
								PushFollow(Follow._identChainList_in_assign319);
								icp = identChainList();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(180, 23);
								Match(input, DBLSTAR_EQ, Follow._DBLSTAR_EQ_in_assign321);
								if (state.failed)
									return value;
								DebugLocation(180, 34);
								int alt7=2;
								try {
									DebugEnterSubRule(7);
									try {
										DebugEnterDecision(7, decisionCanBacktrack[7]);
										try {
											alt7 = dfa7.Predict(input);
										}
										catch (NoViableAltException nvae) {
											DebugRecognitionException(nvae);
											throw;
										}
									}
									finally { DebugExitDecision(7); }
									switch (alt7) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(180, 35);
												Match(input, LPAREN, Follow._LPAREN_in_assign324);
												if (state.failed)
													return value;
												DebugLocation(180, 42);
												PushFollow(Follow._typeExp_in_assign326);
												typeExp19 = typeExp();
												PopFollow();
												if (state.failed)
													return value;
												DebugLocation(180, 50);
												Match(input, RPAREN, Follow._RPAREN_in_assign328);
												if (state.failed)
													return value;

											}
											break;

									}
								}
								finally { DebugExitSubRule(7); }

								DebugLocation(180, 59);
								PushFollow(Follow._subExp_in_assign332);
								subExp18 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(181, 3);
								if (state.backtracking == 0) {

									CseObject result = ArithExp.Parse(icp, subExp18, ArithType.POW);

									// TODO: put this part into a C# method
									if ((typeExp19 != null ? typeExp19.value : default(CseObject)) != null) { result = CastExp.Parse(null, (typeExp19 != null ? input.ToString(typeExp19.Start, typeExp19.Stop) : null), result); }
									String fullTypeName = icp.Value.GetType().ToString();
									int indexOfDot = fullTypeName.IndexOf('.');
									String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
									result = CastExp.Parse(null, typeName, result);
									value = AssignExp.Parse(icp.EnvChain, icp.EnvNames, icp.EnvIndices, result);

								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("assign", 3);
					LeaveRule("assign", 3);
					Leave_assign();
				}
				DebugLocation(193, 1);
			}
			finally { DebugExitRule(GrammarFileName, "assign"); }
			return value;

		}
		// $ANTLR end "assign"


		partial void Enter_nonAssign();
		partial void Leave_nonAssign();

		// $ANTLR start "nonAssign"
		[GrammarRule("nonAssign")]
		private CseObject nonAssign() {
			Enter_nonAssign();
			EnterRule("nonAssign", 4);
			TraceIn("nonAssign", 4);

			CseObject value = default(CseObject);

			IToken ID22=null;
			CseObject condExp20 = default(CseObject);
			CseParser.typeExp_return typeExp21 = default(CseParser.typeExp_return);

			try {
				DebugEnterRule(GrammarFileName, "nonAssign");
				DebugLocation(194, 1);
				try {
					int alt9=2;
					try {
						DebugEnterDecision(9, decisionCanBacktrack[9]);
						int LA9_0 = input.LA(1);

						if ((LA9_0 == LPAREN || (LA9_0 >= CROSS && LA9_0 <= DASH) || (LA9_0 >= BANG && LA9_0 <= NEW) || (LA9_0 >= CH_INT && LA9_0 <= TERMCONST))) {
							alt9 = 1;
						}
						else if ((LA9_0 == ID)) {
							int LA9_2 = input.LA(2);

							if ((LA9_2 == EOF || LA9_2 == SEMI || (LA9_2 >= LPAREN && LA9_2 <= RPAREN) || (LA9_2 >= QUESTION && LA9_2 <= DBLSTAR) || (LA9_2 >= DOT && LA9_2 <= COMMA))) {
								alt9 = 1;
							}
							else if ((LA9_2 == ID)) {
								alt9 = 2;
							}
							else {
								if (state.backtracking > 0) { state.failed = true; return value; }
								NoViableAltException nvae = new NoViableAltException("", 9, 2, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
						}
						else {
							if (state.backtracking > 0) { state.failed = true; return value; }
							NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					finally { DebugExitDecision(9); }
					switch (alt9) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(195, 4);
								PushFollow(Follow._condExp_in_nonAssign354);
								condExp20 = condExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(195, 12);
								if (state.backtracking == 0) {
									value = condExp20;
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(196, 4);
								PushFollow(Follow._typeExp_in_nonAssign361);
								typeExp21 = typeExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(196, 12);
								ID22 = (IToken)Match(input, ID, Follow._ID_in_nonAssign363);
								if (state.failed)
									return value;
								DebugLocation(197, 3);
								if (state.backtracking == 0) {

									value = new CseObject(null);
									TempIdentifierExp.AddIdent((Type)(typeExp21 != null ? typeExp21.value : default(CseObject)).Value, (ID22 != null ? ID22.Text : null));

								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("nonAssign", 4);
					LeaveRule("nonAssign", 4);
					Leave_nonAssign();
				}
				DebugLocation(201, 1);
			}
			finally { DebugExitRule(GrammarFileName, "nonAssign"); }
			return value;

		}
		// $ANTLR end "nonAssign"


		partial void Enter_condExp();
		partial void Leave_condExp();

		// $ANTLR start "condExp"
		[GrammarRule("condExp")]
		private CseObject condExp() {
			Enter_condExp();
			EnterRule("condExp", 5);
			TraceIn("condExp", 5);

			CseObject value = default(CseObject);

			CseObject loe = default(CseObject);
			CseObject se = default(CseObject);
			CseObject ce = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "condExp");
				DebugLocation(203, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(204, 7);
						PushFollow(Follow._logOrExp_in_condExp385);
						loe = logOrExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(204, 17);
						if (state.backtracking == 0) {
							value = loe;
						}
						DebugLocation(205, 2);
						int alt10=2;
						try {
							DebugEnterSubRule(10);
							try {
								DebugEnterDecision(10, decisionCanBacktrack[10]);
								int LA10_0 = input.LA(1);

								if ((LA10_0 == QUESTION)) {
									alt10 = 1;
								}
							}
							finally { DebugExitDecision(10); }
							switch (alt10) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(206, 4);
										Match(input, QUESTION, Follow._QUESTION_in_condExp395);
										if (state.failed)
											return value;
										DebugLocation(206, 15);
										PushFollow(Follow._subExp_in_condExp399);
										se = subExp();
										PopFollow();
										if (state.failed)
											return value;
										DebugLocation(206, 23);
										Match(input, COLON, Follow._COLON_in_condExp401);
										if (state.failed)
											return value;
										DebugLocation(206, 31);
										PushFollow(Follow._subExp_in_condExp405);
										ce = subExp();
										PopFollow();
										if (state.failed)
											return value;
										DebugLocation(206, 39);
										if (state.backtracking == 0) {
											value = CondExp.Ternary(value, se, ce);
										}

									}
									break;

							}
						}
						finally { DebugExitSubRule(10); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("condExp", 5);
					LeaveRule("condExp", 5);
					Leave_condExp();
				}
				DebugLocation(208, 1);
			}
			finally { DebugExitRule(GrammarFileName, "condExp"); }
			return value;

		}
		// $ANTLR end "condExp"


		partial void Enter_logOrExp();
		partial void Leave_logOrExp();

		// $ANTLR start "logOrExp"
		[GrammarRule("logOrExp")]
		private CseObject logOrExp() {
			Enter_logOrExp();
			EnterRule("logOrExp", 6);
			TraceIn("logOrExp", 6);

			CseObject value = default(CseObject);

			CseObject lae = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "logOrExp");
				DebugLocation(216, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(217, 7);
						PushFollow(Follow._logAndExp_in_logOrExp434);
						lae = logAndExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(217, 18);
						if (state.backtracking == 0) {
							value = lae;
						}
						DebugLocation(218, 2);
						try {
							DebugEnterSubRule(11);
							while (true) {
								int alt11=2;
								try {
									DebugEnterDecision(11, decisionCanBacktrack[11]);
									int LA11_0 = input.LA(1);

									if ((LA11_0 == DBLPIPE)) {
										alt11 = 1;
									}


								}
								finally { DebugExitDecision(11); }
								switch (alt11) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(219, 3);
											Match(input, DBLPIPE, Follow._DBLPIPE_in_logOrExp444);
											if (state.failed)
												return value;
											DebugLocation(219, 14);
											PushFollow(Follow._logAndExp_in_logOrExp448);
											lae = logAndExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(219, 24);
											if (state.backtracking == 0) {
												value = LogicalExp.Parse(value, lae, LogicalType.OR);
											}

										}
										break;

									default:
										goto loop11;
								}
							}

						loop11:
							;

						}
						finally { DebugExitSubRule(11); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("logOrExp", 6);
					LeaveRule("logOrExp", 6);
					Leave_logOrExp();
				}
				DebugLocation(221, 1);
			}
			finally { DebugExitRule(GrammarFileName, "logOrExp"); }
			return value;

		}
		// $ANTLR end "logOrExp"


		partial void Enter_logAndExp();
		partial void Leave_logAndExp();

		// $ANTLR start "logAndExp"
		[GrammarRule("logAndExp")]
		private CseObject logAndExp() {
			Enter_logAndExp();
			EnterRule("logAndExp", 7);
			TraceIn("logAndExp", 7);

			CseObject value = default(CseObject);

			CseObject boe = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "logAndExp");
				DebugLocation(223, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(224, 7);
						PushFollow(Follow._bitOrExp_in_logAndExp471);
						boe = bitOrExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(224, 17);
						if (state.backtracking == 0) {
							value = boe;
						}
						DebugLocation(225, 2);
						try {
							DebugEnterSubRule(12);
							while (true) {
								int alt12=2;
								try {
									DebugEnterDecision(12, decisionCanBacktrack[12]);
									int LA12_0 = input.LA(1);

									if ((LA12_0 == DBLAMP)) {
										alt12 = 1;
									}


								}
								finally { DebugExitDecision(12); }
								switch (alt12) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(226, 3);
											Match(input, DBLAMP, Follow._DBLAMP_in_logAndExp481);
											if (state.failed)
												return value;
											DebugLocation(226, 13);
											PushFollow(Follow._bitOrExp_in_logAndExp485);
											boe = bitOrExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(226, 22);
											if (state.backtracking == 0) {
												value = LogicalExp.Parse(value, boe, LogicalType.AND);
											}

										}
										break;

									default:
										goto loop12;
								}
							}

						loop12:
							;

						}
						finally { DebugExitSubRule(12); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("logAndExp", 7);
					LeaveRule("logAndExp", 7);
					Leave_logAndExp();
				}
				DebugLocation(228, 1);
			}
			finally { DebugExitRule(GrammarFileName, "logAndExp"); }
			return value;

		}
		// $ANTLR end "logAndExp"


		partial void Enter_bitOrExp();
		partial void Leave_bitOrExp();

		// $ANTLR start "bitOrExp"
		[GrammarRule("bitOrExp")]
		private CseObject bitOrExp() {
			Enter_bitOrExp();
			EnterRule("bitOrExp", 8);
			TraceIn("bitOrExp", 8);

			CseObject value = default(CseObject);

			CseObject xe = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "bitOrExp");
				DebugLocation(230, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(231, 6);
						PushFollow(Follow._xorExp_in_bitOrExp508);
						xe = xorExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(231, 14);
						if (state.backtracking == 0) {
							value = xe;
						}
						DebugLocation(232, 2);
						try {
							DebugEnterSubRule(13);
							while (true) {
								int alt13=2;
								try {
									DebugEnterDecision(13, decisionCanBacktrack[13]);
									int LA13_0 = input.LA(1);

									if ((LA13_0 == PIPE)) {
										alt13 = 1;
									}


								}
								finally { DebugExitDecision(13); }
								switch (alt13) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(233, 3);
											Match(input, PIPE, Follow._PIPE_in_bitOrExp517);
											if (state.failed)
												return value;
											DebugLocation(233, 10);
											PushFollow(Follow._xorExp_in_bitOrExp521);
											xe = xorExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(233, 17);
											if (state.backtracking == 0) {
												value = BitwiseExp.Parse(value, xe, BitwiseType.OR);
											}

										}
										break;

									default:
										goto loop13;
								}
							}

						loop13:
							;

						}
						finally { DebugExitSubRule(13); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("bitOrExp", 8);
					LeaveRule("bitOrExp", 8);
					Leave_bitOrExp();
				}
				DebugLocation(235, 1);
			}
			finally { DebugExitRule(GrammarFileName, "bitOrExp"); }
			return value;

		}
		// $ANTLR end "bitOrExp"


		partial void Enter_xorExp();
		partial void Leave_xorExp();

		// $ANTLR start "xorExp"
		[GrammarRule("xorExp")]
		private CseObject xorExp() {
			Enter_xorExp();
			EnterRule("xorExp", 9);
			TraceIn("xorExp", 9);

			CseObject value = default(CseObject);

			CseObject bae = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "xorExp");
				DebugLocation(237, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(238, 7);
						PushFollow(Follow._bitAndExp_in_xorExp543);
						bae = bitAndExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(238, 18);
						if (state.backtracking == 0) {
							value = bae;
						}
						DebugLocation(239, 2);
						try {
							DebugEnterSubRule(14);
							while (true) {
								int alt14=2;
								try {
									DebugEnterDecision(14, decisionCanBacktrack[14]);
									int LA14_0 = input.LA(1);

									if ((LA14_0 == HAT)) {
										alt14 = 1;
									}


								}
								finally { DebugExitDecision(14); }
								switch (alt14) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(240, 3);
											Match(input, HAT, Follow._HAT_in_xorExp552);
											if (state.failed)
												return value;
											DebugLocation(240, 10);
											PushFollow(Follow._bitAndExp_in_xorExp556);
											bae = bitAndExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(240, 20);
											if (state.backtracking == 0) {
												value = XorExp.Parse(value, bae);
											}

										}
										break;

									default:
										goto loop14;
								}
							}

						loop14:
							;

						}
						finally { DebugExitSubRule(14); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("xorExp", 9);
					LeaveRule("xorExp", 9);
					Leave_xorExp();
				}
				DebugLocation(242, 1);
			}
			finally { DebugExitRule(GrammarFileName, "xorExp"); }
			return value;

		}
		// $ANTLR end "xorExp"


		partial void Enter_bitAndExp();
		partial void Leave_bitAndExp();

		// $ANTLR start "bitAndExp"
		[GrammarRule("bitAndExp")]
		private CseObject bitAndExp() {
			Enter_bitAndExp();
			EnterRule("bitAndExp", 10);
			TraceIn("bitAndExp", 10);

			CseObject value = default(CseObject);

			CseObject ee = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "bitAndExp");
				DebugLocation(244, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(245, 6);
						PushFollow(Follow._eqExp_in_bitAndExp578);
						ee = eqExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(245, 13);
						if (state.backtracking == 0) {
							value = ee;
						}
						DebugLocation(246, 2);
						try {
							DebugEnterSubRule(15);
							while (true) {
								int alt15=2;
								try {
									DebugEnterDecision(15, decisionCanBacktrack[15]);
									int LA15_0 = input.LA(1);

									if ((LA15_0 == AMP)) {
										alt15 = 1;
									}


								}
								finally { DebugExitDecision(15); }
								switch (alt15) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(247, 3);
											Match(input, AMP, Follow._AMP_in_bitAndExp587);
											if (state.failed)
												return value;
											DebugLocation(247, 9);
											PushFollow(Follow._eqExp_in_bitAndExp591);
											ee = eqExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(247, 15);
											if (state.backtracking == 0) {
												value = BitwiseExp.Parse(value, ee, BitwiseType.AND);
											}

										}
										break;

									default:
										goto loop15;
								}
							}

						loop15:
							;

						}
						finally { DebugExitSubRule(15); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("bitAndExp", 10);
					LeaveRule("bitAndExp", 10);
					Leave_bitAndExp();
				}
				DebugLocation(249, 1);
			}
			finally { DebugExitRule(GrammarFileName, "bitAndExp"); }
			return value;

		}
		// $ANTLR end "bitAndExp"


		partial void Enter_eqExp();
		partial void Leave_eqExp();

		// $ANTLR start "eqExp"
		[GrammarRule("eqExp")]
		private CseObject eqExp() {
			Enter_eqExp();
			EnterRule("eqExp", 11);
			TraceIn("eqExp", 11);

			CseObject value = default(CseObject);

			CseObject re = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "eqExp");
				DebugLocation(251, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(252, 6);
						PushFollow(Follow._relExp_in_eqExp613);
						re = relExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(252, 14);
						if (state.backtracking == 0) {
							value = re;
						}
						DebugLocation(253, 4);
						try {
							DebugEnterSubRule(16);
							while (true) {
								int alt16=3;
								try {
									DebugEnterDecision(16, decisionCanBacktrack[16]);
									int LA16_0 = input.LA(1);

									if ((LA16_0 == DBL_EQ)) {
										alt16 = 1;
									}
									else if ((LA16_0 == BANG_EQ)) {
										alt16 = 2;
									}


								}
								finally { DebugExitDecision(16); }
								switch (alt16) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(253, 6);
											Match(input, DBL_EQ, Follow._DBL_EQ_in_eqExp623);
											if (state.failed)
												return value;
											DebugLocation(253, 15);
											PushFollow(Follow._relExp_in_eqExp627);
											re = relExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(253, 22);
											if (state.backtracking == 0) {
												value = CondExp.Parse(value, re, CondType.EQ);
											}

										}
										break;
									case 2:
										DebugEnterAlt(2); {
											DebugLocation(255, 3);
											Match(input, BANG_EQ, Follow._BANG_EQ_in_eqExp638);
											if (state.failed)
												return value;
											DebugLocation(255, 13);
											PushFollow(Follow._relExp_in_eqExp642);
											re = relExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(255, 20);
											if (state.backtracking == 0) {
												value = CondExp.Parse(value, re, CondType.NEQ);
											}

										}
										break;

									default:
										goto loop16;
								}
							}

						loop16:
							;

						}
						finally { DebugExitSubRule(16); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("eqExp", 11);
					LeaveRule("eqExp", 11);
					Leave_eqExp();
				}
				DebugLocation(257, 1);
			}
			finally { DebugExitRule(GrammarFileName, "eqExp"); }
			return value;

		}
		// $ANTLR end "eqExp"


		partial void Enter_relExp();
		partial void Leave_relExp();

		// $ANTLR start "relExp"
		[GrammarRule("relExp")]
		private CseObject relExp() {
			Enter_relExp();
			EnterRule("relExp", 12);
			TraceIn("relExp", 12);

			CseObject value = default(CseObject);

			CseObject se = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "relExp");
				DebugLocation(259, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(260, 6);
						PushFollow(Follow._shiftExp_in_relExp667);
						se = shiftExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(260, 16);
						if (state.backtracking == 0) {
							value = se;
						}
						DebugLocation(261, 4);
						try {
							DebugEnterSubRule(17);
							while (true) {
								int alt17=5;
								try {
									DebugEnterDecision(17, decisionCanBacktrack[17]);
									switch (input.LA(1)) {
										case LANGLE: {
												alt17 = 1;
											}
											break;
										case RANGLE: {
												alt17 = 2;
											}
											break;
										case LANGLE_EQ: {
												alt17 = 3;
											}
											break;
										case RANGLE_EQ: {
												alt17 = 4;
											}
											break;

									}

								}
								finally { DebugExitDecision(17); }
								switch (alt17) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(261, 6);
											Match(input, LANGLE, Follow._LANGLE_in_relExp676);
											if (state.failed)
												return value;
											DebugLocation(261, 15);
											PushFollow(Follow._shiftExp_in_relExp680);
											se = shiftExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(261, 24);
											if (state.backtracking == 0) {
												value = CondExp.Parse(value, se, CondType.LT);
											}

										}
										break;
									case 2:
										DebugEnterAlt(2); {
											DebugLocation(263, 6);
											Match(input, RANGLE, Follow._RANGLE_in_relExp697);
											if (state.failed)
												return value;
											DebugLocation(263, 15);
											PushFollow(Follow._shiftExp_in_relExp701);
											se = shiftExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(263, 24);
											if (state.backtracking == 0) {
												value = CondExp.Parse(value, se, CondType.GT);
											}

										}
										break;
									case 3:
										DebugEnterAlt(3); {
											DebugLocation(265, 6);
											Match(input, LANGLE_EQ, Follow._LANGLE_EQ_in_relExp718);
											if (state.failed)
												return value;
											DebugLocation(265, 18);
											PushFollow(Follow._shiftExp_in_relExp722);
											se = shiftExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(265, 27);
											if (state.backtracking == 0) {
												value = CondExp.Parse(value, se, CondType.LTE);
											}

										}
										break;
									case 4:
										DebugEnterAlt(4); {
											DebugLocation(267, 6);
											Match(input, RANGLE_EQ, Follow._RANGLE_EQ_in_relExp739);
											if (state.failed)
												return value;
											DebugLocation(267, 18);
											PushFollow(Follow._shiftExp_in_relExp743);
											se = shiftExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(267, 27);
											if (state.backtracking == 0) {
												value = CondExp.Parse(value, se, CondType.GTE);
											}

										}
										break;

									default:
										goto loop17;
								}
							}

						loop17:
							;

						}
						finally { DebugExitSubRule(17); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("relExp", 12);
					LeaveRule("relExp", 12);
					Leave_relExp();
				}
				DebugLocation(269, 1);
			}
			finally { DebugExitRule(GrammarFileName, "relExp"); }
			return value;

		}
		// $ANTLR end "relExp"


		partial void Enter_shiftExp();
		partial void Leave_shiftExp();

		// $ANTLR start "shiftExp"
		[GrammarRule("shiftExp")]
		private CseObject shiftExp() {
			Enter_shiftExp();
			EnterRule("shiftExp", 13);
			TraceIn("shiftExp", 13);

			CseObject value = default(CseObject);

			CseObject ae = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "shiftExp");
				DebugLocation(271, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(272, 6);
						PushFollow(Follow._addExp_in_shiftExp768);
						ae = addExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(272, 14);
						if (state.backtracking == 0) {
							value = ae;
						}
						DebugLocation(273, 4);
						try {
							DebugEnterSubRule(18);
							while (true) {
								int alt18=3;
								try {
									DebugEnterDecision(18, decisionCanBacktrack[18]);
									int LA18_0 = input.LA(1);

									if ((LA18_0 == DBLLANGLE)) {
										alt18 = 1;
									}
									else if ((LA18_0 == DBLRANGLE)) {
										alt18 = 2;
									}


								}
								finally { DebugExitDecision(18); }
								switch (alt18) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(273, 6);
											Match(input, DBLLANGLE, Follow._DBLLANGLE_in_shiftExp778);
											if (state.failed)
												return value;
											DebugLocation(273, 18);
											PushFollow(Follow._addExp_in_shiftExp782);
											ae = addExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(273, 25);
											if (state.backtracking == 0) {
												value = BitwiseExp.Parse(value, ae, BitwiseType.SHL);
											}

										}
										break;
									case 2:
										DebugEnterAlt(2); {
											DebugLocation(275, 6);
											Match(input, DBLRANGLE, Follow._DBLRANGLE_in_shiftExp799);
											if (state.failed)
												return value;
											DebugLocation(275, 18);
											PushFollow(Follow._addExp_in_shiftExp803);
											ae = addExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(275, 25);
											if (state.backtracking == 0) {
												value = BitwiseExp.Parse(value, ae, BitwiseType.SHR);
											}

										}
										break;

									default:
										goto loop18;
								}
							}

						loop18:
							;

						}
						finally { DebugExitSubRule(18); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("shiftExp", 13);
					LeaveRule("shiftExp", 13);
					Leave_shiftExp();
				}
				DebugLocation(277, 1);
			}
			finally { DebugExitRule(GrammarFileName, "shiftExp"); }
			return value;

		}
		// $ANTLR end "shiftExp"


		partial void Enter_addExp();
		partial void Leave_addExp();

		// $ANTLR start "addExp"
		[GrammarRule("addExp")]
		private CseObject addExp() {
			Enter_addExp();
			EnterRule("addExp", 14);
			TraceIn("addExp", 14);

			CseObject value = default(CseObject);

			CseObject me = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "addExp");
				DebugLocation(279, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(280, 6);
						PushFollow(Follow._multExp_in_addExp828);
						me = multExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(280, 15);
						if (state.backtracking == 0) {
							value = me;
						}
						DebugLocation(281, 4);
						try {
							DebugEnterSubRule(19);
							while (true) {
								int alt19=3;
								try {
									DebugEnterDecision(19, decisionCanBacktrack[19]);
									int LA19_0 = input.LA(1);

									if ((LA19_0 == CROSS)) {
										alt19 = 1;
									}
									else if ((LA19_0 == DASH)) {
										alt19 = 2;
									}


								}
								finally { DebugExitDecision(19); }
								switch (alt19) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(281, 6);
											Match(input, CROSS, Follow._CROSS_in_addExp837);
											if (state.failed)
												return value;
											DebugLocation(281, 14);
											PushFollow(Follow._multExp_in_addExp841);
											me = multExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(281, 22);
											if (state.backtracking == 0) {
												value = ArithExp.Parse(value, me, ArithType.ADD);
											}

										}
										break;
									case 2:
										DebugEnterAlt(2); {
											DebugLocation(283, 6);
											Match(input, DASH, Follow._DASH_in_addExp856);
											if (state.failed)
												return value;
											DebugLocation(283, 13);
											PushFollow(Follow._multExp_in_addExp860);
											me = multExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(283, 22);
											if (state.backtracking == 0) {
												value = ArithExp.Parse(value, me, ArithType.SUB);
											}

										}
										break;

									default:
										goto loop19;
								}
							}

						loop19:
							;

						}
						finally { DebugExitSubRule(19); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("addExp", 14);
					LeaveRule("addExp", 14);
					Leave_addExp();
				}
				DebugLocation(285, 1);
			}
			finally { DebugExitRule(GrammarFileName, "addExp"); }
			return value;

		}
		// $ANTLR end "addExp"


		partial void Enter_multExp();
		partial void Leave_multExp();

		// $ANTLR start "multExp"
		[GrammarRule("multExp")]
		private CseObject multExp() {
			Enter_multExp();
			EnterRule("multExp", 15);
			TraceIn("multExp", 15);

			CseObject value = default(CseObject);

			CseObject pe = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "multExp");
				DebugLocation(286, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(287, 6);
						PushFollow(Follow._powExp_in_multExp884);
						pe = powExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(287, 14);
						if (state.backtracking == 0) {
							value = pe;
						}
						DebugLocation(288, 4);
						try {
							DebugEnterSubRule(20);
							while (true) {
								int alt20=4;
								try {
									DebugEnterDecision(20, decisionCanBacktrack[20]);
									switch (input.LA(1)) {
										case STAR: {
												alt20 = 1;
											}
											break;
										case FSLASH: {
												alt20 = 2;
											}
											break;
										case PER: {
												alt20 = 3;
											}
											break;

									}

								}
								finally { DebugExitDecision(20); }
								switch (alt20) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(288, 6);
											Match(input, STAR, Follow._STAR_in_multExp894);
											if (state.failed)
												return value;
											DebugLocation(288, 13);
											PushFollow(Follow._powExp_in_multExp898);
											pe = powExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(288, 22);
											if (state.backtracking == 0) {
												value = ArithExp.Parse(value, pe, ArithType.MUL);
											}

										}
										break;
									case 2:
										DebugEnterAlt(2); {
											DebugLocation(290, 5);
											Match(input, FSLASH, Follow._FSLASH_in_multExp913);
											if (state.failed)
												return value;
											DebugLocation(290, 14);
											PushFollow(Follow._powExp_in_multExp917);
											pe = powExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(290, 21);
											if (state.backtracking == 0) {
												value = ArithExp.Parse(value, pe, ArithType.DIV);
											}

										}
										break;
									case 3:
										DebugEnterAlt(3); {
											DebugLocation(292, 5);
											Match(input, PER, Follow._PER_in_multExp930);
											if (state.failed)
												return value;
											DebugLocation(292, 11);
											PushFollow(Follow._powExp_in_multExp934);
											pe = powExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(292, 20);
											if (state.backtracking == 0) {
												value = ArithExp.Parse(value, pe, ArithType.MOD);
											}

										}
										break;

									default:
										goto loop20;
								}
							}

						loop20:
							;

						}
						finally { DebugExitSubRule(20); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("multExp", 15);
					LeaveRule("multExp", 15);
					Leave_multExp();
				}
				DebugLocation(294, 1);
			}
			finally { DebugExitRule(GrammarFileName, "multExp"); }
			return value;

		}
		// $ANTLR end "multExp"

		protected class powExp_scope {
			public List<CseObject> powOperands;
		}
		partial void powExp_scopeInit(powExp_scope scope);
		partial void powExp_scopeAfter(powExp_scope scope);
		protected Stack<powExp_scope> powExp_stack = new Stack<powExp_scope>();


		partial void Enter_powExp();
		partial void Leave_powExp();

		// $ANTLR start "powExp"
		[GrammarRule("powExp")]
		private CseObject powExp() {
			Enter_powExp();
			EnterRule("powExp", 16);
			TraceIn("powExp", 16);
			powExp_stack.Push(new powExp_scope());
			powExp_scopeInit(powExp_stack.Peek());

			CseObject value = default(CseObject);

			CseObject ue = default(CseObject);
			CseObject ue2 = default(CseObject);

			((powExp_scope)powExp_stack.Peek()).powOperands = new List<CseObject>();
			try {
				DebugEnterRule(GrammarFileName, "powExp");
				DebugLocation(295, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(346, 6);
						PushFollow(Follow._unaryExp_in_powExp973);
						ue = unaryExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(346, 16);
						if (state.backtracking == 0) {
							((powExp_scope)powExp_stack.Peek()).powOperands.Add(ue);
						}
						DebugLocation(347, 4);
						try {
							DebugEnterSubRule(21);
							while (true) {
								int alt21=2;
								try {
									DebugEnterDecision(21, decisionCanBacktrack[21]);
									int LA21_0 = input.LA(1);

									if ((LA21_0 == DBLSTAR)) {
										alt21 = 1;
									}


								}
								finally { DebugExitDecision(21); }
								switch (alt21) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(348, 5);
											Match(input, DBLSTAR, Follow._DBLSTAR_in_powExp987);
											if (state.failed)
												return value;
											DebugLocation(348, 16);
											PushFollow(Follow._unaryExp_in_powExp991);
											ue2 = unaryExp();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(348, 26);
											if (state.backtracking == 0) {
												((powExp_scope)powExp_stack.Peek()).powOperands.Add(ue2);
											}

										}
										break;

									default:
										goto loop21;
								}
							}

						loop21:
							;

						}
						finally { DebugExitSubRule(21); }


					}

					if (state.backtracking == 0) {

						bool negate = false;
						CseObject first = null;
						CseObject second = null;
						double firstValue = 0.0;

						if (((powExp_scope)powExp_stack.Peek()).powOperands.Count == 1) {
							value = ((powExp_scope)powExp_stack.Peek()).powOperands[0];
						}
						else if (((powExp_scope)powExp_stack.Peek()).powOperands.Count == 2) {
							first = ((powExp_scope)powExp_stack.Peek()).powOperands[0];
							second = ((powExp_scope)powExp_stack.Peek()).powOperands[1];
							firstValue = double.Parse(first.Value.ToString());

							if (firstValue < 0) {
								negate = true;
								first = new CseObject(Math.Abs(firstValue));
							}
							else {
								negate = false;
							}

							value = ArithExp.Parse(first, second, ArithType.POW);

							if (negate)
								value = -value;
						}
						else {
							value = ((powExp_scope)powExp_stack.Peek()).powOperands[((powExp_scope)powExp_stack.Peek()).powOperands.Count - 1];
							for (int i = ((powExp_scope)powExp_stack.Peek()).powOperands.Count - 2; i >= 0; i--) {
								first = ((powExp_scope)powExp_stack.Peek()).powOperands[i];
								firstValue = double.Parse(first.Value.ToString());

								if (firstValue < 0) {
									negate = true;
									first = new CseObject(Math.Abs(firstValue));
								}
								else {
									negate = false;
								}

								value = ArithExp.Parse(first, value, ArithType.POW);

								if (negate)
									value = -value;
							}
						}

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("powExp", 16);
					LeaveRule("powExp", 16);
					Leave_powExp();
					powExp_scopeAfter(powExp_stack.Peek());
					powExp_stack.Pop();
				}
				DebugLocation(350, 1);
			}
			finally { DebugExitRule(GrammarFileName, "powExp"); }
			return value;

		}
		// $ANTLR end "powExp"

		protected class unaryExp_scope {
			public List<char> signs;
		}
		partial void unaryExp_scopeInit(unaryExp_scope scope);
		partial void unaryExp_scopeAfter(unaryExp_scope scope);
		protected Stack<unaryExp_scope> unaryExp_stack = new Stack<unaryExp_scope>();


		partial void Enter_unaryExp();
		partial void Leave_unaryExp();

		// $ANTLR start "unaryExp"
		[GrammarRule("unaryExp")]
		private CseObject unaryExp() {
			Enter_unaryExp();
			EnterRule("unaryExp", 17);
			TraceIn("unaryExp", 17);
			unaryExp_stack.Push(new unaryExp_scope());
			unaryExp_scopeInit(unaryExp_stack.Peek());

			CseObject value = default(CseObject);

			IToken sign=null;
			CseObject unaryExpPart23 = default(CseObject);


			((unaryExp_scope)unaryExp_stack.Peek()).signs = new List<char>();

			try {
				DebugEnterRule(GrammarFileName, "unaryExp");
				DebugLocation(351, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(369, 4);
						try {
							DebugEnterSubRule(22);
							while (true) {
								int alt22=2;
								try {
									DebugEnterDecision(22, decisionCanBacktrack[22]);
									int LA22_0 = input.LA(1);

									if (((LA22_0 >= CROSS && LA22_0 <= DASH) || (LA22_0 >= BANG && LA22_0 <= TILDE))) {
										alt22 = 1;
									}


								}
								finally { DebugExitDecision(22); }
								switch (alt22) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(370, 7);
											sign = (IToken)input.LT(1);
											if ((input.LA(1) >= CROSS && input.LA(1) <= DASH) || (input.LA(1) >= BANG && input.LA(1) <= TILDE)) {
												input.Consume();
												state.errorRecovery = false;
												state.failed = false;
											}
											else {
												if (state.backtracking > 0) { state.failed = true; return value; }
												MismatchedSetException mse = new MismatchedSetException(null, input);
												DebugRecognitionException(mse);
												throw mse;
											}

											DebugLocation(370, 32);
											if (state.backtracking == 0) {
												((unaryExp_scope)unaryExp_stack.Peek()).signs.Add((sign != null ? sign.Text : null)[0]);
											}

										}
										break;

									default:
										goto loop22;
								}
							}

						loop22:
							;

						}
						finally { DebugExitSubRule(22); }

						DebugLocation(372, 4);
						PushFollow(Follow._unaryExpPart_in_unaryExp1055);
						unaryExpPart23 = unaryExpPart();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(372, 17);
						if (state.backtracking == 0) {
							value = unaryExpPart23;
						}

					}

					if (state.backtracking == 0) {

						if (((unaryExp_scope)unaryExp_stack.Peek()).signs.Count > 0) {
							((unaryExp_scope)unaryExp_stack.Peek()).signs.Reverse();
							foreach (char c in ((unaryExp_scope)unaryExp_stack.Peek()).signs) {
								if (c == '-')
									value = ArithExp.Negate(value);
								else if (c == '+')
									value = ArithExp.Affirm(value);
								else if (c == '~')
									value = BitwiseExp.Parse(value, null, BitwiseType.NOT);
								else /* c == '!' */
									value = LogicalExp.Parse(value, null, LogicalType.NOT);
							}
						}

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("unaryExp", 17);
					LeaveRule("unaryExp", 17);
					Leave_unaryExp();
					unaryExp_scopeAfter(unaryExp_stack.Peek());
					unaryExp_stack.Pop();
				}
				DebugLocation(373, 1);
			}
			finally { DebugExitRule(GrammarFileName, "unaryExp"); }
			return value;

		}
		// $ANTLR end "unaryExp"


		partial void Enter_unaryExpPart();
		partial void Leave_unaryExpPart();

		// $ANTLR start "unaryExpPart"
		[GrammarRule("unaryExpPart")]
		private CseObject unaryExpPart() {
			Enter_unaryExpPart();
			EnterRule("unaryExpPart", 18);
			TraceIn("unaryExpPart", 18);

			CseObject value = default(CseObject);

			CseObject litExp24 = default(CseObject);
			CseObject objChainList25 = default(CseObject);
			CseObject castOrParenExp26 = default(CseObject);
			CseObject objCon27 = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "unaryExpPart");
				DebugLocation(374, 1);
				try {
					int alt23=4;
					try {
						DebugEnterDecision(23, decisionCanBacktrack[23]);
						switch (input.LA(1)) {
							case CH_INT:
							case EINT:
							case EFLT:
							case INT:
							case FLT:
							case INTWITHSUFFIX:
							case FLTWITHSUFFIX:
							case BOOL:
							case STR:
							case CHAR:
							case NULL:
							case TERMCONST: {
									alt23 = 1;
								}
								break;
							case ID: {
									alt23 = 2;
								}
								break;
							case LPAREN: {
									alt23 = 3;
								}
								break;
							case NEW: {
									alt23 = 4;
								}
								break;
							default: {
									if (state.backtracking > 0) { state.failed = true; return value; }
									NoViableAltException nvae = new NoViableAltException("", 23, 0, input);

									DebugRecognitionException(nvae);
									throw nvae;
								}
						}

					}
					finally { DebugExitDecision(23); }
					switch (alt23) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(375, 4);
								PushFollow(Follow._litExp_in_unaryExpPart1071);
								litExp24 = litExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(375, 18);
								if (state.backtracking == 0) {
									value = litExp24;
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(376, 4);
								PushFollow(Follow._objChainList_in_unaryExpPart1085);
								objChainList25 = objChainList(CsEval.evalEnvironment);
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(376, 41);
								if (state.backtracking == 0) {
									value = objChainList25;
								}

							}
							break;
						case 3:
							DebugEnterAlt(3); {
								DebugLocation(377, 4);
								PushFollow(Follow._castOrParenExp_in_unaryExpPart1093);
								castOrParenExp26 = castOrParenExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(377, 24);
								if (state.backtracking == 0) {
									value = castOrParenExp26;
								}

							}
							break;
						case 4:
							DebugEnterAlt(4); {
								DebugLocation(378, 4);
								PushFollow(Follow._objCon_in_unaryExpPart1105);
								objCon27 = objCon();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(378, 19);
								if (state.backtracking == 0) {
									value = objCon27;
								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("unaryExpPart", 18);
					LeaveRule("unaryExpPart", 18);
					Leave_unaryExpPart();
				}
				DebugLocation(379, 1);
			}
			finally { DebugExitRule(GrammarFileName, "unaryExpPart"); }
			return value;

		}
		// $ANTLR end "unaryExpPart"


		partial void Enter_objCon();
		partial void Leave_objCon();

		// $ANTLR start "objCon"
		[GrammarRule("objCon")]
		private CseObject objCon() {
			Enter_objCon();
			EnterRule("objCon", 19);
			TraceIn("objCon", 19);

			CseObject value = default(CseObject);

			List<CseObject> al = default(List<CseObject>);
			CseParser.typeExp_return typeExp28 = default(CseParser.typeExp_return);
			CseObject objChainList29 = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "objCon");
				DebugLocation(380, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(381, 4);
						Match(input, NEW, Follow._NEW_in_objCon1129);
						if (state.failed)
							return value;
						DebugLocation(381, 8);
						PushFollow(Follow._typeExp_in_objCon1131);
						typeExp28 = typeExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(381, 16);
						Match(input, LPAREN, Follow._LPAREN_in_objCon1133);
						if (state.failed)
							return value;
						DebugLocation(381, 25);
						int alt24=2;
						try {
							DebugEnterSubRule(24);
							try {
								DebugEnterDecision(24, decisionCanBacktrack[24]);
								int LA24_0 = input.LA(1);

								if ((LA24_0 == ID || LA24_0 == LPAREN || (LA24_0 >= CROSS && LA24_0 <= DASH) || (LA24_0 >= BANG && LA24_0 <= NEW) || (LA24_0 >= REF && LA24_0 <= TERMCONST))) {
									alt24 = 1;
								}
							}
							finally { DebugExitDecision(24); }
							switch (alt24) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(381, 25);
										PushFollow(Follow._argList_in_objCon1137);
										al = argList();
										PopFollow();
										if (state.failed)
											return value;

									}
									break;

							}
						}
						finally { DebugExitSubRule(24); }

						DebugLocation(381, 35);
						Match(input, RPAREN, Follow._RPAREN_in_objCon1140);
						if (state.failed)
							return value;
						DebugLocation(381, 42);
						if (state.backtracking == 0) {
							value = ObjectConstructionExp.Parse(CsEval.evalEnvironment, (typeExp28 != null ? input.ToString(typeExp28.Start, typeExp28.Stop) : null), al);
						}
						DebugLocation(382, 4);
						int alt25=2;
						try {
							DebugEnterSubRule(25);
							try {
								DebugEnterDecision(25, decisionCanBacktrack[25]);
								int LA25_0 = input.LA(1);

								if ((LA25_0 == DOT)) {
									alt25 = 1;
								}
							}
							finally { DebugExitDecision(25); }
							switch (alt25) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(382, 5);
										Match(input, DOT, Follow._DOT_in_objCon1148);
										if (state.failed)
											return value;
										DebugLocation(382, 9);
										PushFollow(Follow._objChainList_in_objCon1150);
										objChainList29 = objChainList(value);
										PopFollow();
										if (state.failed)
											return value;

									}
									break;

							}
						}
						finally { DebugExitSubRule(25); }

						DebugLocation(382, 35);
						if (state.backtracking == 0) {
							if (objChainList29 != null) { value = objChainList29; }
						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("objCon", 19);
					LeaveRule("objCon", 19);
					Leave_objCon();
				}
				DebugLocation(383, 1);
			}
			finally { DebugExitRule(GrammarFileName, "objCon"); }
			return value;

		}
		// $ANTLR end "objCon"


		partial void Enter_castOrParenExp();
		partial void Leave_castOrParenExp();

		// $ANTLR start "castOrParenExp"
		[GrammarRule("castOrParenExp")]
		private CseObject castOrParenExp() {
			Enter_castOrParenExp();
			EnterRule("castOrParenExp", 20);
			TraceIn("castOrParenExp", 20);

			CseObject value = default(CseObject);

			CseParser.typeExp_return typeExp30 = default(CseParser.typeExp_return);
			CseObject unaryExp31 = default(CseObject);
			CseObject subExp32 = default(CseObject);
			CseObject objChainList33 = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "castOrParenExp");
				DebugLocation(384, 1);
				try {
					int alt27=2;
					try {
						DebugEnterDecision(27, decisionCanBacktrack[27]);
						int LA27_0 = input.LA(1);

						if ((LA27_0 == LPAREN)) {
							int LA27_1 = input.LA(2);

							if ((EvaluatePredicate(synpred45_Cse_fragment))) {
								alt27 = 1;
							}
							else if ((true)) {
								alt27 = 2;
							}
							else {
								if (state.backtracking > 0) { state.failed = true; return value; }
								NoViableAltException nvae = new NoViableAltException("", 27, 1, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
						}
						else {
							if (state.backtracking > 0) { state.failed = true; return value; }
							NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					finally { DebugExitDecision(27); }
					switch (alt27) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(385, 4);
								Match(input, LPAREN, Follow._LPAREN_in_castOrParenExp1172);
								if (state.failed)
									return value;
								DebugLocation(385, 11);
								PushFollow(Follow._typeExp_in_castOrParenExp1174);
								typeExp30 = typeExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(385, 19);
								Match(input, RPAREN, Follow._RPAREN_in_castOrParenExp1176);
								if (state.failed)
									return value;
								DebugLocation(385, 26);
								PushFollow(Follow._unaryExp_in_castOrParenExp1178);
								unaryExp31 = unaryExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(385, 36);
								if (state.backtracking == 0) {
									value = CastExp.Parse(CsEval.evalEnvironment, (typeExp30 != null ? input.ToString(typeExp30.Start, typeExp30.Stop) : null), unaryExp31);
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(386, 4);
								Match(input, LPAREN, Follow._LPAREN_in_castOrParenExp1186);
								if (state.failed)
									return value;
								DebugLocation(386, 11);
								PushFollow(Follow._subExp_in_castOrParenExp1188);
								subExp32 = subExp();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(386, 18);
								Match(input, RPAREN, Follow._RPAREN_in_castOrParenExp1190);
								if (state.failed)
									return value;
								DebugLocation(386, 28);
								if (state.backtracking == 0) {
									value = subExp32;
								}
								DebugLocation(387, 4);
								int alt26=2;
								try {
									DebugEnterSubRule(26);
									try {
										DebugEnterDecision(26, decisionCanBacktrack[26]);
										int LA26_0 = input.LA(1);

										if ((LA26_0 == DOT)) {
											alt26 = 1;
										}
									}
									finally { DebugExitDecision(26); }
									switch (alt26) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(387, 5);
												Match(input, DOT, Follow._DOT_in_castOrParenExp1201);
												if (state.failed)
													return value;
												DebugLocation(387, 9);
												PushFollow(Follow._objChainList_in_castOrParenExp1203);
												objChainList33 = objChainList(value);
												PopFollow();
												if (state.failed)
													return value;

											}
											break;

									}
								}
								finally { DebugExitSubRule(26); }

								DebugLocation(387, 34);
								if (state.backtracking == 0) {
									if (objChainList33 != null) { value = objChainList33; }
								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("castOrParenExp", 20);
					LeaveRule("castOrParenExp", 20);
					Leave_castOrParenExp();
				}
				DebugLocation(388, 1);
			}
			finally { DebugExitRule(GrammarFileName, "castOrParenExp"); }
			return value;

		}
		// $ANTLR end "castOrParenExp"

		public class typeExp_return : ParserRuleReturnScope<IToken> {
			public CseObject value;
		}

		partial void Enter_typeExp();
		partial void Leave_typeExp();

		// $ANTLR start "typeExp"
		[GrammarRule("typeExp")]
		private CseParser.typeExp_return typeExp() {
			Enter_typeExp();
			EnterRule("typeExp", 21);
			TraceIn("typeExp", 21);
			CseParser.typeExp_return retval = new CseParser.typeExp_return();
			retval.Start = (IToken)input.LT(1);

			IToken ID34=null;

			try {
				DebugEnterRule(GrammarFileName, "typeExp");
				DebugLocation(389, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(390, 4);
						ID34 = (IToken)Match(input, ID, Follow._ID_in_typeExp1224);
						if (state.failed)
							return retval;
						DebugLocation(391, 3);
						if (state.backtracking == 0) {

							Type t = Type.GetType((ID34 != null ? ID34.Text : null));

							if (t == null)
								t = TypeExp.GetType((ID34 != null ? ID34.Text : null));

							retval.value = new CseObject(t);

						}

					}

					retval.Stop = (IToken)input.LT(-1);

				}

				catch {
					throw;
				}
				finally {
					TraceOut("typeExp", 21);
					LeaveRule("typeExp", 21);
					Leave_typeExp();
				}
				DebugLocation(399, 1);
			}
			finally { DebugExitRule(GrammarFileName, "typeExp"); }
			return retval;

		}
		// $ANTLR end "typeExp"

		protected class identChainList_scope {
			public List<CseObject> envChain;
			public List<string> envNames;
			public List<CseObject> envIndices;
			public CseObject lastChainValue;
		}
		partial void identChainList_scopeInit(identChainList_scope scope);
		partial void identChainList_scopeAfter(identChainList_scope scope);
		protected Stack<identChainList_scope> identChainList_stack = new Stack<identChainList_scope>();


		partial void Enter_identChainList();
		partial void Leave_identChainList();

		// $ANTLR start "identChainList"
		[GrammarRule("identChainList")]
		private CseObject identChainList() {
			Enter_identChainList();
			EnterRule("identChainList", 22);
			TraceIn("identChainList", 22);
			identChainList_stack.Push(new identChainList_scope());
			identChainList_scopeInit(identChainList_stack.Peek());

			CseObject value = default(CseObject);

			CseParser.identChainPart_return icp = default(CseParser.identChainPart_return);


			value = null;
			((identChainList_scope)identChainList_stack.Peek()).envChain = new List<CseObject>();
			((identChainList_scope)identChainList_stack.Peek()).envNames = new List<string>();
			((identChainList_scope)identChainList_stack.Peek()).envIndices = new List<CseObject>();
			((identChainList_scope)identChainList_stack.Peek()).lastChainValue = CsEval.evalEnvironment;

			try {
				DebugEnterRule(GrammarFileName, "identChainList");
				DebugLocation(400, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(420, 8);
						PushFollow(Follow._identChainPart_in_identChainList1260);
						icp = identChainPart(((identChainList_scope)identChainList_stack.Peek()).lastChainValue);
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(421, 4);
						if (state.backtracking == 0) {

							value = (icp != null ? icp.value : default(CseObject));
							((identChainList_scope)identChainList_stack.Peek()).envChain.Add(CsEval.evalEnvironment);
							((identChainList_scope)identChainList_stack.Peek()).envNames.Add((icp != null ? icp.name : default(string)));
							((identChainList_scope)identChainList_stack.Peek()).envIndices.Add((icp != null ? icp.index : default(CseObject)));
							((identChainList_scope)identChainList_stack.Peek()).lastChainValue = value;

						}
						DebugLocation(428, 4);
						try {
							DebugEnterSubRule(28);
							while (true) {
								int alt28=2;
								try {
									DebugEnterDecision(28, decisionCanBacktrack[28]);
									int LA28_0 = input.LA(1);

									if ((LA28_0 == DOT)) {
										alt28 = 1;
									}


								}
								finally { DebugExitDecision(28); }
								switch (alt28) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(429, 3);
											Match(input, DOT, Follow._DOT_in_identChainList1275);
											if (state.failed)
												return value;
											DebugLocation(429, 10);
											PushFollow(Follow._identChainPart_in_identChainList1279);
											icp = identChainPart(((identChainList_scope)identChainList_stack.Peek()).lastChainValue);
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(430, 3);
											if (state.backtracking == 0) {

												((identChainList_scope)identChainList_stack.Peek()).envChain.Add(value);
												value = (icp != null ? icp.value : default(CseObject));
												((identChainList_scope)identChainList_stack.Peek()).envNames.Add((icp != null ? icp.name : default(string)));
												((identChainList_scope)identChainList_stack.Peek()).envIndices.Add((icp != null ? icp.index : default(CseObject)));
												((identChainList_scope)identChainList_stack.Peek()).lastChainValue = value;

											}

										}
										break;

									default:
										goto loop28;
								}
							}

						loop28:
							;

						}
						finally { DebugExitSubRule(28); }


					}

					if (state.backtracking == 0) {

						value.EnvChain = ((identChainList_scope)identChainList_stack.Peek()).envChain;
						value.EnvNames = ((identChainList_scope)identChainList_stack.Peek()).envNames;
						value.EnvIndices = ((identChainList_scope)identChainList_stack.Peek()).envIndices;
						//value.Value = ((identChainList_scope)identChainList_stack.Peek()).lastChainValue.Value;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("identChainList", 22);
					LeaveRule("identChainList", 22);
					Leave_identChainList();
					identChainList_scopeAfter(identChainList_stack.Peek());
					identChainList_stack.Pop();
				}
				DebugLocation(438, 1);
			}
			finally { DebugExitRule(GrammarFileName, "identChainList"); }
			return value;

		}
		// $ANTLR end "identChainList"

		public class identChainPart_return : ParserRuleReturnScope<IToken> {
			public CseObject value;
			public string name;
			public CseObject index;
		}

		partial void Enter_identChainPart();
		partial void Leave_identChainPart();

		// $ANTLR start "identChainPart"
		[GrammarRule("identChainPart")]
		private CseParser.identChainPart_return identChainPart(CseObject lastChainValue) {
			Enter_identChainPart();
			EnterRule("identChainPart", 23);
			TraceIn("identChainPart", 23);
			CseParser.identChainPart_return retval = new CseParser.identChainPart_return();
			retval.Start = (IToken)input.LT(1);

			CseParser.identExp_return identExp35 = default(CseParser.identExp_return);
			CseParser.arrayExp_return arrayExp36 = default(CseParser.arrayExp_return);

			try {
				DebugEnterRule(GrammarFileName, "identChainPart");
				DebugLocation(439, 1);
				try {
					int alt29=2;
					try {
						DebugEnterDecision(29, decisionCanBacktrack[29]);
						int LA29_0 = input.LA(1);

						if ((LA29_0 == ID)) {
							int LA29_1 = input.LA(2);

							if ((LA29_1 == LBRACK)) {
								alt29 = 2;
							}
							else if ((LA29_1 == EOF || LA29_1 == EQ || LA29_1 == CROSS_EQ || (LA29_1 >= DASH_EQ && LA29_1 <= DBLSTAR_EQ) || LA29_1 == DOT)) {
								alt29 = 1;
							}
							else {
								if (state.backtracking > 0) { state.failed = true; return retval; }
								NoViableAltException nvae = new NoViableAltException("", 29, 1, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
						}
						else {
							if (state.backtracking > 0) { state.failed = true; return retval; }
							NoViableAltException nvae = new NoViableAltException("", 29, 0, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					finally { DebugExitDecision(29); }
					switch (alt29) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(440, 4);
								PushFollow(Follow._identExp_in_identChainPart1306);
								identExp35 = identExp(lastChainValue);
								PopFollow();
								if (state.failed)
									return retval;
								DebugLocation(441, 4);
								if (state.backtracking == 0) {

									retval.value = (identExp35 != null ? identExp35.value : default(CseObject));
									retval.name = (identExp35 != null ? input.ToString(identExp35.Start, identExp35.Stop) : null);
									retval.index = null;

								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(446, 4);
								PushFollow(Follow._arrayExp_in_identChainPart1318);
								arrayExp36 = arrayExp(lastChainValue);
								PopFollow();
								if (state.failed)
									return retval;
								DebugLocation(447, 4);
								if (state.backtracking == 0) {

									retval.value = (arrayExp36 != null ? arrayExp36.value : default(CseObject));
									retval.name = (arrayExp36 != null ? arrayExp36.name : default(string));
									retval.index = (arrayExp36 != null ? arrayExp36.index : default(CseObject));

								}

							}
							break;

					}
					retval.Stop = (IToken)input.LT(-1);

				}

				catch {
					throw;
				}
				finally {
					TraceOut("identChainPart", 23);
					LeaveRule("identChainPart", 23);
					Leave_identChainPart();
				}
				DebugLocation(452, 1);
			}
			finally { DebugExitRule(GrammarFileName, "identChainPart"); }
			return retval;

		}
		// $ANTLR end "identChainPart"

		protected class objChainList_scope {
			public CseObject lastChainValue;
		}
		partial void objChainList_scopeInit(objChainList_scope scope);
		partial void objChainList_scopeAfter(objChainList_scope scope);
		protected Stack<objChainList_scope> objChainList_stack = new Stack<objChainList_scope>();


		partial void Enter_objChainList();
		partial void Leave_objChainList();

		// $ANTLR start "objChainList"
		[GrammarRule("objChainList")]
		private CseObject objChainList(CseObject startChainValue) {
			Enter_objChainList();
			EnterRule("objChainList", 24);
			TraceIn("objChainList", 24);
			objChainList_stack.Push(new objChainList_scope());
			objChainList_scopeInit(objChainList_stack.Peek());

			CseObject value = default(CseObject);

			CseObject ocp = default(CseObject);

			((objChainList_scope)objChainList_stack.Peek()).lastChainValue = startChainValue;
			try {
				DebugEnterRule(GrammarFileName, "objChainList");
				DebugLocation(453, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(456, 7);
						PushFollow(Follow._objChainPart_in_objChainList1351);
						ocp = objChainPart(((objChainList_scope)objChainList_stack.Peek()).lastChainValue);
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(456, 52);
						if (state.backtracking == 0) {
							value = ocp;
							((objChainList_scope)objChainList_stack.Peek()).lastChainValue = value;
						}
						DebugLocation(457, 4);
						try {
							DebugEnterSubRule(30);
							while (true) {
								int alt30=2;
								try {
									DebugEnterDecision(30, decisionCanBacktrack[30]);
									int LA30_0 = input.LA(1);

									if ((LA30_0 == DOT)) {
										alt30 = 1;
									}


								}
								finally { DebugExitDecision(30); }
								switch (alt30) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(458, 5);
											Match(input, DOT, Follow._DOT_in_objChainList1365);
											if (state.failed)
												return value;
											DebugLocation(458, 12);
											PushFollow(Follow._objChainPart_in_objChainList1369);
											ocp = objChainPart(((objChainList_scope)objChainList_stack.Peek()).lastChainValue);
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(458, 57);
											if (state.backtracking == 0) {
												value = ocp;
												((objChainList_scope)objChainList_stack.Peek()).lastChainValue = value;
											}

										}
										break;

									default:
										goto loop30;
								}
							}

						loop30:
							;

						}
						finally { DebugExitSubRule(30); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("objChainList", 24);
					LeaveRule("objChainList", 24);
					Leave_objChainList();
					objChainList_scopeAfter(objChainList_stack.Peek());
					objChainList_stack.Pop();
				}
				DebugLocation(460, 1);
			}
			finally { DebugExitRule(GrammarFileName, "objChainList"); }
			return value;

		}
		// $ANTLR end "objChainList"


		partial void Enter_objChainPart();
		partial void Leave_objChainPart();

		// $ANTLR start "objChainPart"
		[GrammarRule("objChainPart")]
		private CseObject objChainPart(CseObject lastChainValue) {
			Enter_objChainPart();
			EnterRule("objChainPart", 25);
			TraceIn("objChainPart", 25);

			CseObject value = default(CseObject);

			CseParser.identExp_return identExp37 = default(CseParser.identExp_return);
			CseObject callExp38 = default(CseObject);
			CseParser.arrayExp_return arrayExp39 = default(CseParser.arrayExp_return);

			try {
				DebugEnterRule(GrammarFileName, "objChainPart");
				DebugLocation(461, 1);
				try {
					int alt31=3;
					try {
						DebugEnterDecision(31, decisionCanBacktrack[31]);
						int LA31_0 = input.LA(1);

						if ((LA31_0 == ID)) {
							switch (input.LA(2)) {
								case LPAREN: {
										alt31 = 2;
									}
									break;
								case LBRACK: {
										alt31 = 3;
									}
									break;
								case EOF:
								case SEMI:
								case RPAREN:
								case QUESTION:
								case COLON:
								case DBLPIPE:
								case DBLAMP:
								case PIPE:
								case HAT:
								case AMP:
								case DBL_EQ:
								case BANG_EQ:
								case LANGLE:
								case RANGLE:
								case LANGLE_EQ:
								case RANGLE_EQ:
								case DBLLANGLE:
								case DBLRANGLE:
								case CROSS:
								case DASH:
								case STAR:
								case FSLASH:
								case PER:
								case DBLSTAR:
								case DOT:
								case RBRACK:
								case COMMA: {
										alt31 = 1;
									}
									break;
								default: {
										if (state.backtracking > 0) { state.failed = true; return value; }
										NoViableAltException nvae = new NoViableAltException("", 31, 1, input);

										DebugRecognitionException(nvae);
										throw nvae;
									}
							}

						}
						else {
							if (state.backtracking > 0) { state.failed = true; return value; }
							NoViableAltException nvae = new NoViableAltException("", 31, 0, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					finally { DebugExitDecision(31); }
					switch (alt31) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(462, 4);
								PushFollow(Follow._identExp_in_objChainPart1393);
								identExp37 = identExp(lastChainValue);
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(462, 30);
								if (state.backtracking == 0) {
									value = (identExp37 != null ? identExp37.value : default(CseObject));
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(463, 4);
								PushFollow(Follow._callExp_in_objChainPart1401);
								callExp38 = callExp(lastChainValue);
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(463, 29);
								if (state.backtracking == 0) {
									value = callExp38;
								}

							}
							break;
						case 3:
							DebugEnterAlt(3); {
								DebugLocation(464, 4);
								PushFollow(Follow._arrayExp_in_objChainPart1409);
								arrayExp39 = arrayExp(lastChainValue);
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(464, 30);
								if (state.backtracking == 0) {
									value = (arrayExp39 != null ? arrayExp39.value : default(CseObject));
								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("objChainPart", 25);
					LeaveRule("objChainPart", 25);
					Leave_objChainPart();
				}
				DebugLocation(465, 1);
			}
			finally { DebugExitRule(GrammarFileName, "objChainPart"); }
			return value;

		}
		// $ANTLR end "objChainPart"

		public class identExp_return : ParserRuleReturnScope<IToken> {
			public CseObject value;
		}

		partial void Enter_identExp();
		partial void Leave_identExp();

		// $ANTLR start "identExp"
		[GrammarRule("identExp")]
		private CseParser.identExp_return identExp(CseObject lastChainValue) {
			Enter_identExp();
			EnterRule("identExp", 26);
			TraceIn("identExp", 26);
			CseParser.identExp_return retval = new CseParser.identExp_return();
			retval.Start = (IToken)input.LT(1);

			IToken ID40=null;

			try {
				DebugEnterRule(GrammarFileName, "identExp");
				DebugLocation(466, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(467, 4);
						ID40 = (IToken)Match(input, ID, Follow._ID_in_identExp1427);
						if (state.failed)
							return retval;
						DebugLocation(467, 7);
						if (state.backtracking == 0) {
							retval.value = IdentifierExp.Parse(lastChainValue, (ID40 != null ? ID40.Text : null));
						}

					}

					retval.Stop = (IToken)input.LT(-1);

				}

				catch {
					throw;
				}
				finally {
					TraceOut("identExp", 26);
					LeaveRule("identExp", 26);
					Leave_identExp();
				}
				DebugLocation(468, 1);
			}
			finally { DebugExitRule(GrammarFileName, "identExp"); }
			return retval;

		}
		// $ANTLR end "identExp"


		partial void Enter_callExp();
		partial void Leave_callExp();

		// $ANTLR start "callExp"
		[GrammarRule("callExp")]
		private CseObject callExp(CseObject lastChainValue) {
			Enter_callExp();
			EnterRule("callExp", 27);
			TraceIn("callExp", 27);

			CseObject value = default(CseObject);

			IToken ID41=null;
			List<CseObject> al = default(List<CseObject>);

			try {
				DebugEnterRule(GrammarFileName, "callExp");
				DebugLocation(470, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(471, 4);
						ID41 = (IToken)Match(input, ID, Follow._ID_in_callExp1445);
						if (state.failed)
							return value;
						DebugLocation(471, 7);
						Match(input, LPAREN, Follow._LPAREN_in_callExp1447);
						if (state.failed)
							return value;
						DebugLocation(471, 16);
						int alt32=2;
						try {
							DebugEnterSubRule(32);
							try {
								DebugEnterDecision(32, decisionCanBacktrack[32]);
								int LA32_0 = input.LA(1);

								if ((LA32_0 == ID || LA32_0 == LPAREN || (LA32_0 >= CROSS && LA32_0 <= DASH) || (LA32_0 >= BANG && LA32_0 <= NEW) || (LA32_0 >= REF && LA32_0 <= TERMCONST))) {
									alt32 = 1;
								}
							}
							finally { DebugExitDecision(32); }
							switch (alt32) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(471, 16);
										PushFollow(Follow._argList_in_callExp1451);
										al = argList();
										PopFollow();
										if (state.failed)
											return value;

									}
									break;

							}
						}
						finally { DebugExitSubRule(32); }

						DebugLocation(471, 26);
						Match(input, RPAREN, Follow._RPAREN_in_callExp1454);
						if (state.failed)
							return value;
						DebugLocation(471, 33);
						if (state.backtracking == 0) {
							value = MethodExp.Parse(lastChainValue, (ID41 != null ? ID41.Text : null), al);
						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("callExp", 27);
					LeaveRule("callExp", 27);
					Leave_callExp();
				}
				DebugLocation(472, 1);
			}
			finally { DebugExitRule(GrammarFileName, "callExp"); }
			return value;

		}
		// $ANTLR end "callExp"

		public class arrayExp_return : ParserRuleReturnScope<IToken> {
			public CseObject value;
			public string name;
			public CseObject index;
		}

		partial void Enter_arrayExp();
		partial void Leave_arrayExp();

		// $ANTLR start "arrayExp"
		[GrammarRule("arrayExp")]
		private CseParser.arrayExp_return arrayExp(CseObject lastChainValue) {
			Enter_arrayExp();
			EnterRule("arrayExp", 28);
			TraceIn("arrayExp", 28);
			CseParser.arrayExp_return retval = new CseParser.arrayExp_return();
			retval.Start = (IToken)input.LT(1);

			IToken ID42=null;
			CseObject subExp43 = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "arrayExp");
				DebugLocation(473, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(474, 4);
						ID42 = (IToken)Match(input, ID, Follow._ID_in_arrayExp1471);
						if (state.failed)
							return retval;
						DebugLocation(474, 7);
						Match(input, LBRACK, Follow._LBRACK_in_arrayExp1473);
						if (state.failed)
							return retval;
						DebugLocation(474, 14);
						PushFollow(Follow._subExp_in_arrayExp1475);
						subExp43 = subExp();
						PopFollow();
						if (state.failed)
							return retval;
						DebugLocation(474, 21);
						Match(input, RBRACK, Follow._RBRACK_in_arrayExp1477);
						if (state.failed)
							return retval;
						DebugLocation(475, 4);
						if (state.backtracking == 0) {

							retval.value = ArrayExp.Parse(lastChainValue, (ID42 != null ? ID42.Text : null), subExp43);
							retval.name = (ID42 != null ? ID42.Text : null);
							retval.index = subExp43;

						}

					}

					retval.Stop = (IToken)input.LT(-1);

				}

				catch {
					throw;
				}
				finally {
					TraceOut("arrayExp", 28);
					LeaveRule("arrayExp", 28);
					Leave_arrayExp();
				}
				DebugLocation(480, 1);
			}
			finally { DebugExitRule(GrammarFileName, "arrayExp"); }
			return retval;

		}
		// $ANTLR end "arrayExp"


		partial void Enter_argList();
		partial void Leave_argList();

		// $ANTLR start "argList"
		[GrammarRule("argList")]
		private List<CseObject> argList() {
			Enter_argList();
			EnterRule("argList", 29);
			TraceIn("argList", 29);

			List<CseObject> value = default(List<CseObject>);

			CseObject a = default(CseObject);

			value = new List<CseObject>();
			try {
				DebugEnterRule(GrammarFileName, "argList");
				DebugLocation(481, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(483, 5);
						PushFollow(Follow._arg_in_argList1504);
						a = arg();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(483, 10);
						if (state.backtracking == 0) {
							value.Add(a);
						}
						DebugLocation(484, 4);
						try {
							DebugEnterSubRule(33);
							while (true) {
								int alt33=2;
								try {
									DebugEnterDecision(33, decisionCanBacktrack[33]);
									int LA33_0 = input.LA(1);

									if ((LA33_0 == COMMA)) {
										alt33 = 1;
									}


								}
								finally { DebugExitDecision(33); }
								switch (alt33) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(485, 6);
											Match(input, COMMA, Follow._COMMA_in_argList1518);
											if (state.failed)
												return value;
											DebugLocation(485, 13);
											PushFollow(Follow._arg_in_argList1522);
											a = arg();
											PopFollow();
											if (state.failed)
												return value;
											DebugLocation(485, 18);
											if (state.backtracking == 0) {
												value.Add(a);
											}

										}
										break;

									default:
										goto loop33;
								}
							}

						loop33:
							;

						}
						finally { DebugExitSubRule(33); }


					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("argList", 29);
					LeaveRule("argList", 29);
					Leave_argList();
				}
				DebugLocation(487, 1);
			}
			finally { DebugExitRule(GrammarFileName, "argList"); }
			return value;

		}
		// $ANTLR end "argList"


		partial void Enter_arg();
		partial void Leave_arg();

		// $ANTLR start "arg"
		[GrammarRule("arg")]
		private CseObject arg() {
			Enter_arg();
			EnterRule("arg", 30);
			TraceIn("arg", 30);

			CseObject value = default(CseObject);

			CseObject subExp44 = default(CseObject);
			CallArgMod argModExp45 = default(CallArgMod);

			try {
				DebugEnterRule(GrammarFileName, "arg");
				DebugLocation(488, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(489, 4);
						PushFollow(Follow._argModExp_in_arg1544);
						argModExp45 = argModExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(489, 14);
						PushFollow(Follow._subExp_in_arg1546);
						subExp44 = subExp();
						PopFollow();
						if (state.failed)
							return value;
						DebugLocation(490, 4);
						if (state.backtracking == 0) {

							value = subExp44;
							value.CallMod = argModExp45;

						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("arg", 30);
					LeaveRule("arg", 30);
					Leave_arg();
				}
				DebugLocation(494, 1);
			}
			finally { DebugExitRule(GrammarFileName, "arg"); }
			return value;

		}
		// $ANTLR end "arg"


		partial void Enter_argModExp();
		partial void Leave_argModExp();

		// $ANTLR start "argModExp"
		[GrammarRule("argModExp")]
		private CallArgMod argModExp() {
			Enter_argModExp();
			EnterRule("argModExp", 31);
			TraceIn("argModExp", 31);

			CallArgMod value = default(CallArgMod);

			try {
				DebugEnterRule(GrammarFileName, "argModExp");
				DebugLocation(495, 1);
				try {
					int alt34=3;
					try {
						DebugEnterDecision(34, decisionCanBacktrack[34]);
						switch (input.LA(1)) {
							case REF: {
									alt34 = 1;
								}
								break;
							case OUT: {
									alt34 = 2;
								}
								break;
							case ID:
							case LPAREN:
							case CROSS:
							case DASH:
							case BANG:
							case TILDE:
							case NEW:
							case CH_INT:
							case EINT:
							case EFLT:
							case INT:
							case FLT:
							case INTWITHSUFFIX:
							case FLTWITHSUFFIX:
							case BOOL:
							case STR:
							case CHAR:
							case NULL:
							case TERMCONST: {
									alt34 = 3;
								}
								break;
							default: {
									if (state.backtracking > 0) { state.failed = true; return value; }
									NoViableAltException nvae = new NoViableAltException("", 34, 0, input);

									DebugRecognitionException(nvae);
									throw nvae;
								}
						}

					}
					finally { DebugExitDecision(34); }
					switch (alt34) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(496, 4);
								Match(input, REF, Follow._REF_in_argModExp1566);
								if (state.failed)
									return value;
								DebugLocation(496, 8);
								if (state.backtracking == 0) {
									value = CallArgMod.REF;
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(497, 4);
								Match(input, OUT, Follow._OUT_in_argModExp1573);
								if (state.failed)
									return value;
								DebugLocation(497, 8);
								if (state.backtracking == 0) {
									value = CallArgMod.OUT;
								}

							}
							break;
						case 3:
							DebugEnterAlt(3); {
								DebugLocation(498, 5);
								if (state.backtracking == 0) {
									value = CallArgMod.VAL;
								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("argModExp", 31);
					LeaveRule("argModExp", 31);
					Leave_argModExp();
				}
				DebugLocation(499, 1);
			}
			finally { DebugExitRule(GrammarFileName, "argModExp"); }
			return value;

		}
		// $ANTLR end "argModExp"

		protected class litExp_scope {
			public CseObject lastChainValue;
		}
		partial void litExp_scopeInit(litExp_scope scope);
		partial void litExp_scopeAfter(litExp_scope scope);
		protected Stack<litExp_scope> litExp_stack = new Stack<litExp_scope>();


		partial void Enter_litExp();
		partial void Leave_litExp();

		// $ANTLR start "litExp"
		[GrammarRule("litExp")]
		private CseObject litExp() {
			Enter_litExp();
			EnterRule("litExp", 32);
			TraceIn("litExp", 32);
			litExp_stack.Push(new litExp_scope());
			litExp_scopeInit(litExp_stack.Peek());

			CseObject value = default(CseObject);

			IToken CH_INT47=null;
			CseObject ocp = default(CseObject);
			CseObject lit46 = default(CseObject);

			((litExp_scope)litExp_stack.Peek()).lastChainValue = CsEval.evalEnvironment;
			try {
				DebugEnterRule(GrammarFileName, "litExp");
				DebugLocation(511, 1);
				try {
					int alt37=2;
					try {
						DebugEnterDecision(37, decisionCanBacktrack[37]);
						int LA37_0 = input.LA(1);

						if (((LA37_0 >= EINT && LA37_0 <= TERMCONST))) {
							alt37 = 1;
						}
						else if ((LA37_0 == CH_INT)) {
							alt37 = 2;
						}
						else {
							if (state.backtracking > 0) { state.failed = true; return value; }
							NoViableAltException nvae = new NoViableAltException("", 37, 0, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					finally { DebugExitDecision(37); }
					switch (alt37) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(514, 4);
								PushFollow(Follow._lit_in_litExp1606);
								lit46 = lit();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(514, 8);
								if (state.backtracking == 0) {
									value = lit46;
									((litExp_scope)litExp_stack.Peek()).lastChainValue = value;
								}
								DebugLocation(515, 4);
								try {
									DebugEnterSubRule(35);
									while (true) {
										int alt35=2;
										try {
											DebugEnterDecision(35, decisionCanBacktrack[35]);
											int LA35_0 = input.LA(1);

											if ((LA35_0 == DOT)) {
												alt35 = 1;
											}


										}
										finally { DebugExitDecision(35); }
										switch (alt35) {
											case 1:
												DebugEnterAlt(1); {
													DebugLocation(516, 5);
													Match(input, DOT, Follow._DOT_in_litExp1619);
													if (state.failed)
														return value;
													DebugLocation(516, 12);
													PushFollow(Follow._objChainPart_in_litExp1623);
													ocp = objChainPart(((litExp_scope)litExp_stack.Peek()).lastChainValue);
													PopFollow();
													if (state.failed)
														return value;
													DebugLocation(516, 51);
													if (state.backtracking == 0) {
														value = ocp;
														((litExp_scope)litExp_stack.Peek()).lastChainValue = value;
													}

												}
												break;

											default:
												goto loop35;
										}
									}

								loop35:
									;

								}
								finally { DebugExitSubRule(35); }


							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(519, 4);
								CH_INT47 = (IToken)Match(input, CH_INT, Follow._CH_INT_in_litExp1642);
								if (state.failed)
									return value;
								DebugLocation(520, 6);
								if (state.backtracking == 0) {
									((litExp_scope)litExp_stack.Peek()).lastChainValue = LiteralExp.ParseIntType((CH_INT47 != null ? CH_INT47.Text : null).Substring(0, (CH_INT47 != null ? CH_INT47.Text : null).Length - 1), false);
								}
								DebugLocation(521, 7);
								PushFollow(Follow._objChainPart_in_litExp1656);
								ocp = objChainPart(((litExp_scope)litExp_stack.Peek()).lastChainValue);
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(522, 5);
								if (state.backtracking == 0) {
									value = ocp;
									((litExp_scope)litExp_stack.Peek()).lastChainValue = value;
								}
								DebugLocation(523, 4);
								try {
									DebugEnterSubRule(36);
									while (true) {
										int alt36=2;
										try {
											DebugEnterDecision(36, decisionCanBacktrack[36]);
											int LA36_0 = input.LA(1);

											if ((LA36_0 == DOT)) {
												alt36 = 1;
											}


										}
										finally { DebugExitDecision(36); }
										switch (alt36) {
											case 1:
												DebugEnterAlt(1); {
													DebugLocation(524, 5);
													Match(input, DOT, Follow._DOT_in_litExp1674);
													if (state.failed)
														return value;
													DebugLocation(524, 12);
													PushFollow(Follow._objChainPart_in_litExp1678);
													ocp = objChainPart(((litExp_scope)litExp_stack.Peek()).lastChainValue);
													PopFollow();
													if (state.failed)
														return value;
													DebugLocation(524, 51);
													if (state.backtracking == 0) {
														value = ocp;
														((litExp_scope)litExp_stack.Peek()).lastChainValue = value;
													}

												}
												break;

											default:
												goto loop36;
										}
									}

								loop36:
									;

								}
								finally { DebugExitSubRule(36); }


							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("litExp", 32);
					LeaveRule("litExp", 32);
					Leave_litExp();
					litExp_scopeAfter(litExp_stack.Peek());
					litExp_stack.Pop();
				}
				DebugLocation(526, 1);
			}
			finally { DebugExitRule(GrammarFileName, "litExp"); }
			return value;

		}
		// $ANTLR end "litExp"


		partial void Enter_lit();
		partial void Leave_lit();

		// $ANTLR start "lit"
		[GrammarRule("lit")]
		private CseObject lit() {
			Enter_lit();
			EnterRule("lit", 33);
			TraceIn("lit", 33);

			CseObject value = default(CseObject);

			CseObject boolLit48 = default(CseObject);
			CseObject numLit49 = default(CseObject);
			CseObject strLit50 = default(CseObject);
			CseObject charLit51 = default(CseObject);
			CseObject termConst52 = default(CseObject);

			try {
				DebugEnterRule(GrammarFileName, "lit");
				DebugLocation(527, 1);
				try {
					int alt38=6;
					try {
						DebugEnterDecision(38, decisionCanBacktrack[38]);
						switch (input.LA(1)) {
							case BOOL: {
									alt38 = 1;
								}
								break;
							case EINT:
							case EFLT:
							case INT:
							case FLT:
							case INTWITHSUFFIX:
							case FLTWITHSUFFIX: {
									alt38 = 2;
								}
								break;
							case STR: {
									alt38 = 3;
								}
								break;
							case CHAR: {
									alt38 = 4;
								}
								break;
							case NULL: {
									alt38 = 5;
								}
								break;
							case TERMCONST: {
									alt38 = 6;
								}
								break;
							default: {
									if (state.backtracking > 0) { state.failed = true; return value; }
									NoViableAltException nvae = new NoViableAltException("", 38, 0, input);

									DebugRecognitionException(nvae);
									throw nvae;
								}
						}

					}
					finally { DebugExitDecision(38); }
					switch (alt38) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(528, 4);
								PushFollow(Follow._boolLit_in_lit1701);
								boolLit48 = boolLit();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(528, 12);
								if (state.backtracking == 0) {
									value = boolLit48;
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(529, 4);
								PushFollow(Follow._numLit_in_lit1708);
								numLit49 = numLit();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(529, 11);
								if (state.backtracking == 0) {
									value = numLit49;
								}

							}
							break;
						case 3:
							DebugEnterAlt(3); {
								DebugLocation(530, 4);
								PushFollow(Follow._strLit_in_lit1715);
								strLit50 = strLit();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(530, 11);
								if (state.backtracking == 0) {
									value = strLit50;
								}

							}
							break;
						case 4:
							DebugEnterAlt(4); {
								DebugLocation(531, 4);
								PushFollow(Follow._charLit_in_lit1722);
								charLit51 = charLit();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(531, 12);
								if (state.backtracking == 0) {
									value = charLit51;
								}

							}
							break;
						case 5:
							DebugEnterAlt(5); {
								DebugLocation(532, 4);
								PushFollow(Follow._nullLit_in_lit1729);
								nullLit();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(532, 12);
								if (state.backtracking == 0) {
									value = new CseObject(null);
								}

							}
							break;
						case 6:
							DebugEnterAlt(6); {
								DebugLocation(533, 4);
								PushFollow(Follow._termConst_in_lit1736);
								termConst52 = termConst();
								PopFollow();
								if (state.failed)
									return value;
								DebugLocation(533, 14);
								if (state.backtracking == 0) {
									value = termConst52;
								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("lit", 33);
					LeaveRule("lit", 33);
					Leave_lit();
				}
				DebugLocation(534, 1);
			}
			finally { DebugExitRule(GrammarFileName, "lit"); }
			return value;

		}
		// $ANTLR end "lit"


		partial void Enter_numLit();
		partial void Leave_numLit();

		// $ANTLR start "numLit"
		[GrammarRule("numLit")]
		private CseObject numLit() {
			Enter_numLit();
			EnterRule("numLit", 34);
			TraceIn("numLit", 34);

			CseObject value = default(CseObject);

			IToken expNum=null;
			IToken INT53=null;
			IToken FLT54=null;
			IToken INTWITHSUFFIX55=null;
			IToken FLTWITHSUFFIX56=null;

			try {
				DebugEnterRule(GrammarFileName, "numLit");
				DebugLocation(535, 1);
				try {
					int alt39=5;
					try {
						DebugEnterDecision(39, decisionCanBacktrack[39]);
						switch (input.LA(1)) {
							case EINT:
							case EFLT: {
									alt39 = 1;
								}
								break;
							case INT: {
									alt39 = 2;
								}
								break;
							case FLT: {
									alt39 = 3;
								}
								break;
							case INTWITHSUFFIX: {
									alt39 = 4;
								}
								break;
							case FLTWITHSUFFIX: {
									alt39 = 5;
								}
								break;
							default: {
									if (state.backtracking > 0) { state.failed = true; return value; }
									NoViableAltException nvae = new NoViableAltException("", 39, 0, input);

									DebugRecognitionException(nvae);
									throw nvae;
								}
						}

					}
					finally { DebugExitDecision(39); }
					switch (alt39) {
						case 1:
							DebugEnterAlt(1); {
								DebugLocation(536, 11);
								expNum = (IToken)input.LT(1);
								if ((input.LA(1) >= EINT && input.LA(1) <= EFLT)) {
									input.Consume();
									state.errorRecovery = false;
									state.failed = false;
								}
								else {
									if (state.backtracking > 0) { state.failed = true; return value; }
									MismatchedSetException mse = new MismatchedSetException(null, input);
									DebugRecognitionException(mse);
									throw mse;
								}

								DebugLocation(537, 3);
								if (state.backtracking == 0) {
									value = LiteralExp.ParseEType((expNum != null ? expNum.Text : null));
								}

							}
							break;
						case 2:
							DebugEnterAlt(2); {
								DebugLocation(538, 4);
								INT53 = (IToken)Match(input, INT, Follow._INT_in_numLit1771);
								if (state.failed)
									return value;
								DebugLocation(539, 3);
								if (state.backtracking == 0) {
									value = LiteralExp.ParseIntType((INT53 != null ? INT53.Text : null), false);
								}

							}
							break;
						case 3:
							DebugEnterAlt(3); {
								DebugLocation(540, 4);
								FLT54 = (IToken)Match(input, FLT, Follow._FLT_in_numLit1780);
								if (state.failed)
									return value;
								DebugLocation(541, 3);
								if (state.backtracking == 0) {
									value = LiteralExp.ParseFloatType((FLT54 != null ? FLT54.Text : null), false);
								}

							}
							break;
						case 4:
							DebugEnterAlt(4); {
								DebugLocation(542, 4);
								INTWITHSUFFIX55 = (IToken)Match(input, INTWITHSUFFIX, Follow._INTWITHSUFFIX_in_numLit1789);
								if (state.failed)
									return value;
								DebugLocation(543, 3);
								if (state.backtracking == 0) {
									value = LiteralExp.ParseIntType((INTWITHSUFFIX55 != null ? INTWITHSUFFIX55.Text : null), true);
								}

							}
							break;
						case 5:
							DebugEnterAlt(5); {
								DebugLocation(544, 4);
								FLTWITHSUFFIX56 = (IToken)Match(input, FLTWITHSUFFIX, Follow._FLTWITHSUFFIX_in_numLit1798);
								if (state.failed)
									return value;
								DebugLocation(545, 3);
								if (state.backtracking == 0) {
									value = LiteralExp.ParseFloatType((FLTWITHSUFFIX56 != null ? FLTWITHSUFFIX56.Text : null), true);
								}

							}
							break;

					}
				}

				catch {
					throw;
				}
				finally {
					TraceOut("numLit", 34);
					LeaveRule("numLit", 34);
					Leave_numLit();
				}
				DebugLocation(546, 1);
			}
			finally { DebugExitRule(GrammarFileName, "numLit"); }
			return value;

		}
		// $ANTLR end "numLit"


		partial void Enter_boolLit();
		partial void Leave_boolLit();

		// $ANTLR start "boolLit"
		[GrammarRule("boolLit")]
		private CseObject boolLit() {
			Enter_boolLit();
			EnterRule("boolLit", 35);
			TraceIn("boolLit", 35);

			CseObject value = default(CseObject);

			IToken BOOL57=null;

			try {
				DebugEnterRule(GrammarFileName, "boolLit");
				DebugLocation(547, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(548, 4);
						BOOL57 = (IToken)Match(input, BOOL, Follow._BOOL_in_boolLit1816);
						if (state.failed)
							return value;
						DebugLocation(548, 9);
						if (state.backtracking == 0) {
							value = LiteralExp.ParseBool((BOOL57 != null ? BOOL57.Text : null));
						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("boolLit", 35);
					LeaveRule("boolLit", 35);
					Leave_boolLit();
				}
				DebugLocation(549, 1);
			}
			finally { DebugExitRule(GrammarFileName, "boolLit"); }
			return value;

		}
		// $ANTLR end "boolLit"


		partial void Enter_strLit();
		partial void Leave_strLit();

		// $ANTLR start "strLit"
		[GrammarRule("strLit")]
		private CseObject strLit() {
			Enter_strLit();
			EnterRule("strLit", 36);
			TraceIn("strLit", 36);

			CseObject value = default(CseObject);

			IToken STR58=null;

			try {
				DebugEnterRule(GrammarFileName, "strLit");
				DebugLocation(550, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(551, 4);
						STR58 = (IToken)Match(input, STR, Follow._STR_in_strLit1832);
						if (state.failed)
							return value;
						DebugLocation(551, 8);
						if (state.backtracking == 0) {
							value = LiteralExp.ParseStr((STR58 != null ? STR58.Text : null));
						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("strLit", 36);
					LeaveRule("strLit", 36);
					Leave_strLit();
				}
				DebugLocation(552, 1);
			}
			finally { DebugExitRule(GrammarFileName, "strLit"); }
			return value;

		}
		// $ANTLR end "strLit"


		partial void Enter_charLit();
		partial void Leave_charLit();

		// $ANTLR start "charLit"
		[GrammarRule("charLit")]
		private CseObject charLit() {
			Enter_charLit();
			EnterRule("charLit", 37);
			TraceIn("charLit", 37);

			CseObject value = default(CseObject);

			IToken CHAR59=null;

			try {
				DebugEnterRule(GrammarFileName, "charLit");
				DebugLocation(553, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(554, 4);
						CHAR59 = (IToken)Match(input, CHAR, Follow._CHAR_in_charLit1848);
						if (state.failed)
							return value;
						DebugLocation(554, 9);
						if (state.backtracking == 0) {
							value = LiteralExp.ParseChar((CHAR59 != null ? CHAR59.Text : null));
						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("charLit", 37);
					LeaveRule("charLit", 37);
					Leave_charLit();
				}
				DebugLocation(555, 1);
			}
			finally { DebugExitRule(GrammarFileName, "charLit"); }
			return value;

		}
		// $ANTLR end "charLit"


		partial void Enter_nullLit();
		partial void Leave_nullLit();

		// $ANTLR start "nullLit"
		[GrammarRule("nullLit")]
		private void nullLit() {
			Enter_nullLit();
			EnterRule("nullLit", 38);
			TraceIn("nullLit", 38);
			try {
				DebugEnterRule(GrammarFileName, "nullLit");
				DebugLocation(556, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(557, 4);
						Match(input, NULL, Follow._NULL_in_nullLit1860);
						if (state.failed)
							return;

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("nullLit", 38);
					LeaveRule("nullLit", 38);
					Leave_nullLit();
				}
				DebugLocation(558, 1);
			}
			finally { DebugExitRule(GrammarFileName, "nullLit"); }
			return;

		}
		// $ANTLR end "nullLit"


		partial void Enter_termConst();
		partial void Leave_termConst();

		// $ANTLR start "termConst"
		[GrammarRule("termConst")]
		private CseObject termConst() {
			Enter_termConst();
			EnterRule("termConst", 39);
			TraceIn("termConst", 39);

			CseObject value = default(CseObject);

			IToken constLbl=null;

			try {
				DebugEnterRule(GrammarFileName, "termConst");
				DebugLocation(560, 1);
				try {
					DebugEnterAlt(1);
					{
						DebugLocation(561, 13);
						constLbl = (IToken)Match(input, TERMCONST, Follow._TERMCONST_in_termConst1879);
						if (state.failed)
							return value;
						DebugLocation(562, 3);
						if (state.backtracking == 0) {

							if ((constLbl != null ? constLbl.Text : null) == "#E")
								value = new CseObject(Math.E);
							else if ((constLbl != null ? constLbl.Text : null) == "#G")
								value = new CseObject(9.8);
							else if ((constLbl != null ? constLbl.Text : null) == "#PI")
								value = new CseObject(Math.PI);
							else if ((constLbl != null ? constLbl.Text : null) == "#GC")
								value = new CseObject(6.673e-11);
							else if ((constLbl != null ? constLbl.Text : null) == "#PHI")
								value = new CseObject((Math.Sqrt(5) + 1.0) / 2.0);
							else if ((constLbl != null ? constLbl.Text : null) == "#GAMMA")
								value = new CseObject(0.5772156649);
							else if ((constLbl != null ? constLbl.Text : null) == "#C")
								value = new CseObject(299792458);
							else if ((constLbl != null ? constLbl.Text : null) == "#H")
								value = new CseObject(6.62606893e-34);

						}

					}

				}

				catch {
					throw;
				}
				finally {
					TraceOut("termConst", 39);
					LeaveRule("termConst", 39);
					Leave_termConst();
				}
				DebugLocation(572, 1);
			}
			finally { DebugExitRule(GrammarFileName, "termConst"); }
			return value;

		}
		// $ANTLR end "termConst"

		partial void Enter_synpred1_Cse_fragment();
		partial void Leave_synpred1_Cse_fragment();

		// $ANTLR start synpred1_Cse
		public void synpred1_Cse_fragment() {
			Enter_synpred1_Cse_fragment();
			EnterRule("synpred1_Cse_fragment", 40);
			TraceIn("synpred1_Cse_fragment", 40);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(115, 4);
					PushFollow(Follow._assign_in_synpred1_Cse138);
					assign();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred1_Cse_fragment", 40);
				LeaveRule("synpred1_Cse_fragment", 40);
				Leave_synpred1_Cse_fragment();
			}
		}
		// $ANTLR end synpred1_Cse

		partial void Enter_synpred2_Cse_fragment();
		partial void Leave_synpred2_Cse_fragment();

		// $ANTLR start synpred2_Cse
		public void synpred2_Cse_fragment() {
			CseObject icp = default(CseObject);

			Enter_synpred2_Cse_fragment();
			EnterRule("synpred2_Cse_fragment", 41);
			TraceIn("synpred2_Cse_fragment", 41);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(119, 7);
					PushFollow(Follow._identChainList_in_synpred2_Cse165);
					icp = identChainList();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(119, 23);
					Match(input, EQ, Follow._EQ_in_synpred2_Cse167);
					if (state.failed)
						return;
					DebugLocation(119, 26);
					PushFollow(Follow._subExp_in_synpred2_Cse169);
					subExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred2_Cse_fragment", 41);
				LeaveRule("synpred2_Cse_fragment", 41);
				Leave_synpred2_Cse_fragment();
			}
		}
		// $ANTLR end synpred2_Cse

		partial void Enter_synpred3_Cse_fragment();
		partial void Leave_synpred3_Cse_fragment();

		// $ANTLR start synpred3_Cse
		public void synpred3_Cse_fragment() {
			Enter_synpred3_Cse_fragment();
			EnterRule("synpred3_Cse_fragment", 42);
			TraceIn("synpred3_Cse_fragment", 42);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(120, 4);
					PushFollow(Follow._typeExp_in_synpred3_Cse176);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(120, 12);
					Match(input, ID, Follow._ID_in_synpred3_Cse178);
					if (state.failed)
						return;
					DebugLocation(120, 15);
					Match(input, EQ, Follow._EQ_in_synpred3_Cse180);
					if (state.failed)
						return;
					DebugLocation(120, 18);
					PushFollow(Follow._subExp_in_synpred3_Cse182);
					subExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred3_Cse_fragment", 42);
				LeaveRule("synpred3_Cse_fragment", 42);
				Leave_synpred3_Cse_fragment();
			}
		}
		// $ANTLR end synpred3_Cse

		partial void Enter_synpred4_Cse_fragment();
		partial void Leave_synpred4_Cse_fragment();

		// $ANTLR start synpred4_Cse
		public void synpred4_Cse_fragment() {
			Enter_synpred4_Cse_fragment();
			EnterRule("synpred4_Cse_fragment", 43);
			TraceIn("synpred4_Cse_fragment", 43);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(125, 33);
					Match(input, LPAREN, Follow._LPAREN_in_synpred4_Cse199);
					if (state.failed)
						return;
					DebugLocation(125, 40);
					PushFollow(Follow._typeExp_in_synpred4_Cse201);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(125, 48);
					Match(input, RPAREN, Follow._RPAREN_in_synpred4_Cse203);
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred4_Cse_fragment", 43);
				LeaveRule("synpred4_Cse_fragment", 43);
				Leave_synpred4_Cse_fragment();
			}
		}
		// $ANTLR end synpred4_Cse

		partial void Enter_synpred5_Cse_fragment();
		partial void Leave_synpred5_Cse_fragment();

		// $ANTLR start synpred5_Cse
		public void synpred5_Cse_fragment() {
			CseObject icp = default(CseObject);

			Enter_synpred5_Cse_fragment();
			EnterRule("synpred5_Cse_fragment", 44);
			TraceIn("synpred5_Cse_fragment", 44);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(125, 7);
					PushFollow(Follow._identChainList_in_synpred5_Cse194);
					icp = identChainList();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(125, 23);
					Match(input, CROSS_EQ, Follow._CROSS_EQ_in_synpred5_Cse196);
					if (state.failed)
						return;
					DebugLocation(125, 32);
					int alt40=2;
					try {
						DebugEnterSubRule(40);
						try {
							DebugEnterDecision(40, decisionCanBacktrack[40]);
							try {
								alt40 = dfa40.Predict(input);
							}
							catch (NoViableAltException nvae) {
								DebugRecognitionException(nvae);
								throw;
							}
						}
						finally { DebugExitDecision(40); }
						switch (alt40) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(125, 33);
									Match(input, LPAREN, Follow._LPAREN_in_synpred5_Cse199);
									if (state.failed)
										return;
									DebugLocation(125, 40);
									PushFollow(Follow._typeExp_in_synpred5_Cse201);
									typeExp();
									PopFollow();
									if (state.failed)
										return;
									DebugLocation(125, 48);
									Match(input, RPAREN, Follow._RPAREN_in_synpred5_Cse203);
									if (state.failed)
										return;

								}
								break;

						}
					}
					finally { DebugExitSubRule(40); }

					DebugLocation(125, 57);
					PushFollow(Follow._subExp_in_synpred5_Cse207);
					subExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred5_Cse_fragment", 44);
				LeaveRule("synpred5_Cse_fragment", 44);
				Leave_synpred5_Cse_fragment();
			}
		}
		// $ANTLR end synpred5_Cse

		partial void Enter_synpred6_Cse_fragment();
		partial void Leave_synpred6_Cse_fragment();

		// $ANTLR start synpred6_Cse
		public void synpred6_Cse_fragment() {
			Enter_synpred6_Cse_fragment();
			EnterRule("synpred6_Cse_fragment", 45);
			TraceIn("synpred6_Cse_fragment", 45);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(140, 32);
					Match(input, LPAREN, Follow._LPAREN_in_synpred6_Cse224);
					if (state.failed)
						return;
					DebugLocation(140, 39);
					PushFollow(Follow._typeExp_in_synpred6_Cse226);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(140, 47);
					Match(input, RPAREN, Follow._RPAREN_in_synpred6_Cse228);
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred6_Cse_fragment", 45);
				LeaveRule("synpred6_Cse_fragment", 45);
				Leave_synpred6_Cse_fragment();
			}
		}
		// $ANTLR end synpred6_Cse

		partial void Enter_synpred7_Cse_fragment();
		partial void Leave_synpred7_Cse_fragment();

		// $ANTLR start synpred7_Cse
		public void synpred7_Cse_fragment() {
			CseObject icp = default(CseObject);

			Enter_synpred7_Cse_fragment();
			EnterRule("synpred7_Cse_fragment", 46);
			TraceIn("synpred7_Cse_fragment", 46);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(140, 7);
					PushFollow(Follow._identChainList_in_synpred7_Cse219);
					icp = identChainList();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(140, 23);
					Match(input, DASH_EQ, Follow._DASH_EQ_in_synpred7_Cse221);
					if (state.failed)
						return;
					DebugLocation(140, 31);
					int alt41=2;
					try {
						DebugEnterSubRule(41);
						try {
							DebugEnterDecision(41, decisionCanBacktrack[41]);
							try {
								alt41 = dfa41.Predict(input);
							}
							catch (NoViableAltException nvae) {
								DebugRecognitionException(nvae);
								throw;
							}
						}
						finally { DebugExitDecision(41); }
						switch (alt41) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(140, 32);
									Match(input, LPAREN, Follow._LPAREN_in_synpred7_Cse224);
									if (state.failed)
										return;
									DebugLocation(140, 39);
									PushFollow(Follow._typeExp_in_synpred7_Cse226);
									typeExp();
									PopFollow();
									if (state.failed)
										return;
									DebugLocation(140, 47);
									Match(input, RPAREN, Follow._RPAREN_in_synpred7_Cse228);
									if (state.failed)
										return;

								}
								break;

						}
					}
					finally { DebugExitSubRule(41); }

					DebugLocation(140, 56);
					PushFollow(Follow._subExp_in_synpred7_Cse232);
					subExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred7_Cse_fragment", 46);
				LeaveRule("synpred7_Cse_fragment", 46);
				Leave_synpred7_Cse_fragment();
			}
		}
		// $ANTLR end synpred7_Cse

		partial void Enter_synpred8_Cse_fragment();
		partial void Leave_synpred8_Cse_fragment();

		// $ANTLR start synpred8_Cse
		public void synpred8_Cse_fragment() {
			Enter_synpred8_Cse_fragment();
			EnterRule("synpred8_Cse_fragment", 47);
			TraceIn("synpred8_Cse_fragment", 47);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(150, 32);
					Match(input, LPAREN, Follow._LPAREN_in_synpred8_Cse249);
					if (state.failed)
						return;
					DebugLocation(150, 39);
					PushFollow(Follow._typeExp_in_synpred8_Cse251);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(150, 47);
					Match(input, RPAREN, Follow._RPAREN_in_synpred8_Cse253);
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred8_Cse_fragment", 47);
				LeaveRule("synpred8_Cse_fragment", 47);
				Leave_synpred8_Cse_fragment();
			}
		}
		// $ANTLR end synpred8_Cse

		partial void Enter_synpred9_Cse_fragment();
		partial void Leave_synpred9_Cse_fragment();

		// $ANTLR start synpred9_Cse
		public void synpred9_Cse_fragment() {
			CseObject icp = default(CseObject);

			Enter_synpred9_Cse_fragment();
			EnterRule("synpred9_Cse_fragment", 48);
			TraceIn("synpred9_Cse_fragment", 48);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(150, 7);
					PushFollow(Follow._identChainList_in_synpred9_Cse244);
					icp = identChainList();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(150, 23);
					Match(input, STAR_EQ, Follow._STAR_EQ_in_synpred9_Cse246);
					if (state.failed)
						return;
					DebugLocation(150, 31);
					int alt42=2;
					try {
						DebugEnterSubRule(42);
						try {
							DebugEnterDecision(42, decisionCanBacktrack[42]);
							try {
								alt42 = dfa42.Predict(input);
							}
							catch (NoViableAltException nvae) {
								DebugRecognitionException(nvae);
								throw;
							}
						}
						finally { DebugExitDecision(42); }
						switch (alt42) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(150, 32);
									Match(input, LPAREN, Follow._LPAREN_in_synpred9_Cse249);
									if (state.failed)
										return;
									DebugLocation(150, 39);
									PushFollow(Follow._typeExp_in_synpred9_Cse251);
									typeExp();
									PopFollow();
									if (state.failed)
										return;
									DebugLocation(150, 47);
									Match(input, RPAREN, Follow._RPAREN_in_synpred9_Cse253);
									if (state.failed)
										return;

								}
								break;

						}
					}
					finally { DebugExitSubRule(42); }

					DebugLocation(150, 56);
					PushFollow(Follow._subExp_in_synpred9_Cse257);
					subExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred9_Cse_fragment", 48);
				LeaveRule("synpred9_Cse_fragment", 48);
				Leave_synpred9_Cse_fragment();
			}
		}
		// $ANTLR end synpred9_Cse

		partial void Enter_synpred10_Cse_fragment();
		partial void Leave_synpred10_Cse_fragment();

		// $ANTLR start synpred10_Cse
		public void synpred10_Cse_fragment() {
			Enter_synpred10_Cse_fragment();
			EnterRule("synpred10_Cse_fragment", 49);
			TraceIn("synpred10_Cse_fragment", 49);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(160, 34);
					Match(input, LPAREN, Follow._LPAREN_in_synpred10_Cse274);
					if (state.failed)
						return;
					DebugLocation(160, 41);
					PushFollow(Follow._typeExp_in_synpred10_Cse276);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(160, 49);
					Match(input, RPAREN, Follow._RPAREN_in_synpred10_Cse278);
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred10_Cse_fragment", 49);
				LeaveRule("synpred10_Cse_fragment", 49);
				Leave_synpred10_Cse_fragment();
			}
		}
		// $ANTLR end synpred10_Cse

		partial void Enter_synpred11_Cse_fragment();
		partial void Leave_synpred11_Cse_fragment();

		// $ANTLR start synpred11_Cse
		public void synpred11_Cse_fragment() {
			CseObject icp = default(CseObject);

			Enter_synpred11_Cse_fragment();
			EnterRule("synpred11_Cse_fragment", 50);
			TraceIn("synpred11_Cse_fragment", 50);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(160, 7);
					PushFollow(Follow._identChainList_in_synpred11_Cse269);
					icp = identChainList();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(160, 23);
					Match(input, FSLASH_EQ, Follow._FSLASH_EQ_in_synpred11_Cse271);
					if (state.failed)
						return;
					DebugLocation(160, 33);
					int alt43=2;
					try {
						DebugEnterSubRule(43);
						try {
							DebugEnterDecision(43, decisionCanBacktrack[43]);
							try {
								alt43 = dfa43.Predict(input);
							}
							catch (NoViableAltException nvae) {
								DebugRecognitionException(nvae);
								throw;
							}
						}
						finally { DebugExitDecision(43); }
						switch (alt43) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(160, 34);
									Match(input, LPAREN, Follow._LPAREN_in_synpred11_Cse274);
									if (state.failed)
										return;
									DebugLocation(160, 41);
									PushFollow(Follow._typeExp_in_synpred11_Cse276);
									typeExp();
									PopFollow();
									if (state.failed)
										return;
									DebugLocation(160, 49);
									Match(input, RPAREN, Follow._RPAREN_in_synpred11_Cse278);
									if (state.failed)
										return;

								}
								break;

						}
					}
					finally { DebugExitSubRule(43); }

					DebugLocation(160, 58);
					PushFollow(Follow._subExp_in_synpred11_Cse282);
					subExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred11_Cse_fragment", 50);
				LeaveRule("synpred11_Cse_fragment", 50);
				Leave_synpred11_Cse_fragment();
			}
		}
		// $ANTLR end synpred11_Cse

		partial void Enter_synpred12_Cse_fragment();
		partial void Leave_synpred12_Cse_fragment();

		// $ANTLR start synpred12_Cse
		public void synpred12_Cse_fragment() {
			Enter_synpred12_Cse_fragment();
			EnterRule("synpred12_Cse_fragment", 51);
			TraceIn("synpred12_Cse_fragment", 51);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(170, 31);
					Match(input, LPAREN, Follow._LPAREN_in_synpred12_Cse299);
					if (state.failed)
						return;
					DebugLocation(170, 38);
					PushFollow(Follow._typeExp_in_synpred12_Cse301);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(170, 46);
					Match(input, RPAREN, Follow._RPAREN_in_synpred12_Cse303);
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred12_Cse_fragment", 51);
				LeaveRule("synpred12_Cse_fragment", 51);
				Leave_synpred12_Cse_fragment();
			}
		}
		// $ANTLR end synpred12_Cse

		partial void Enter_synpred13_Cse_fragment();
		partial void Leave_synpred13_Cse_fragment();

		// $ANTLR start synpred13_Cse
		public void synpred13_Cse_fragment() {
			CseObject icp = default(CseObject);

			Enter_synpred13_Cse_fragment();
			EnterRule("synpred13_Cse_fragment", 52);
			TraceIn("synpred13_Cse_fragment", 52);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(170, 7);
					PushFollow(Follow._identChainList_in_synpred13_Cse294);
					icp = identChainList();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(170, 23);
					Match(input, PER_EQ, Follow._PER_EQ_in_synpred13_Cse296);
					if (state.failed)
						return;
					DebugLocation(170, 30);
					int alt44=2;
					try {
						DebugEnterSubRule(44);
						try {
							DebugEnterDecision(44, decisionCanBacktrack[44]);
							try {
								alt44 = dfa44.Predict(input);
							}
							catch (NoViableAltException nvae) {
								DebugRecognitionException(nvae);
								throw;
							}
						}
						finally { DebugExitDecision(44); }
						switch (alt44) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(170, 31);
									Match(input, LPAREN, Follow._LPAREN_in_synpred13_Cse299);
									if (state.failed)
										return;
									DebugLocation(170, 38);
									PushFollow(Follow._typeExp_in_synpred13_Cse301);
									typeExp();
									PopFollow();
									if (state.failed)
										return;
									DebugLocation(170, 46);
									Match(input, RPAREN, Follow._RPAREN_in_synpred13_Cse303);
									if (state.failed)
										return;

								}
								break;

						}
					}
					finally { DebugExitSubRule(44); }

					DebugLocation(170, 55);
					PushFollow(Follow._subExp_in_synpred13_Cse307);
					subExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred13_Cse_fragment", 52);
				LeaveRule("synpred13_Cse_fragment", 52);
				Leave_synpred13_Cse_fragment();
			}
		}
		// $ANTLR end synpred13_Cse

		partial void Enter_synpred14_Cse_fragment();
		partial void Leave_synpred14_Cse_fragment();

		// $ANTLR start synpred14_Cse
		public void synpred14_Cse_fragment() {
			Enter_synpred14_Cse_fragment();
			EnterRule("synpred14_Cse_fragment", 53);
			TraceIn("synpred14_Cse_fragment", 53);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(180, 35);
					Match(input, LPAREN, Follow._LPAREN_in_synpred14_Cse324);
					if (state.failed)
						return;
					DebugLocation(180, 42);
					PushFollow(Follow._typeExp_in_synpred14_Cse326);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(180, 50);
					Match(input, RPAREN, Follow._RPAREN_in_synpred14_Cse328);
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred14_Cse_fragment", 53);
				LeaveRule("synpred14_Cse_fragment", 53);
				Leave_synpred14_Cse_fragment();
			}
		}
		// $ANTLR end synpred14_Cse

		partial void Enter_synpred45_Cse_fragment();
		partial void Leave_synpred45_Cse_fragment();

		// $ANTLR start synpred45_Cse
		public void synpred45_Cse_fragment() {
			Enter_synpred45_Cse_fragment();
			EnterRule("synpred45_Cse_fragment", 84);
			TraceIn("synpred45_Cse_fragment", 84);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(385, 4);
					Match(input, LPAREN, Follow._LPAREN_in_synpred45_Cse1172);
					if (state.failed)
						return;
					DebugLocation(385, 11);
					PushFollow(Follow._typeExp_in_synpred45_Cse1174);
					typeExp();
					PopFollow();
					if (state.failed)
						return;
					DebugLocation(385, 19);
					Match(input, RPAREN, Follow._RPAREN_in_synpred45_Cse1176);
					if (state.failed)
						return;
					DebugLocation(385, 26);
					PushFollow(Follow._unaryExp_in_synpred45_Cse1178);
					unaryExp();
					PopFollow();
					if (state.failed)
						return;

				}

			}
			finally {
				TraceOut("synpred45_Cse_fragment", 84);
				LeaveRule("synpred45_Cse_fragment", 84);
				Leave_synpred45_Cse_fragment();
			}
		}
		// $ANTLR end synpred45_Cse
		#endregion Rules

		#region Synpreds
		private bool EvaluatePredicate(System.Action fragment) {
			bool success = false;
			state.backtracking++;
			try {
				DebugBeginBacktrack(state.backtracking);
				int start = input.Mark();
				try {
					fragment();
				}
				catch (RecognitionException re) {
					System.Console.Error.WriteLine("impossible: " + re);
				}
				success = !state.failed;
				input.Rewind(start);
			}
			finally {
				DebugEndBacktrack(state.backtracking, success);
			}
			state.backtracking--;
			state.failed = false;
			return success;
		}
		#endregion Synpreds


		#region DFA
		DFA1 dfa1;
		DFA8 dfa8;
		DFA2 dfa2;
		DFA3 dfa3;
		DFA4 dfa4;
		DFA5 dfa5;
		DFA6 dfa6;
		DFA7 dfa7;
		DFA40 dfa40;
		DFA41 dfa41;
		DFA42 dfa42;
		DFA43 dfa43;
		DFA44 dfa44;

		protected override void InitDFAs() {
			base.InitDFAs();
			dfa1 = new DFA1(this, SpecialStateTransition1);
			dfa8 = new DFA8(this, SpecialStateTransition8);
			dfa2 = new DFA2(this, SpecialStateTransition2);
			dfa3 = new DFA3(this, SpecialStateTransition3);
			dfa4 = new DFA4(this, SpecialStateTransition4);
			dfa5 = new DFA5(this, SpecialStateTransition5);
			dfa6 = new DFA6(this, SpecialStateTransition6);
			dfa7 = new DFA7(this, SpecialStateTransition7);
			dfa40 = new DFA40(this, SpecialStateTransition40);
			dfa41 = new DFA41(this, SpecialStateTransition41);
			dfa42 = new DFA42(this, SpecialStateTransition42);
			dfa43 = new DFA43(this, SpecialStateTransition43);
			dfa44 = new DFA44(this, SpecialStateTransition44);
		}

		private class DFA1 : DFA {
			private const string DFA1_eotS =
			"\x11\xFFFF";
			private const string DFA1_eofS =
			"\x11\xFFFF";
			private const string DFA1_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA1_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA1_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA1_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA1_transitionS =
			{
				"\x1\x1\x1\xFFFF\x1\x2\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
			private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
			private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
			private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
			private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
			private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
			private static readonly short[][] DFA1_transition;

			static DFA1() {
				int numStates = DFA1_transitionS.Length;
				DFA1_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
				}
			}

			public DFA1(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 1;
				this.eot = DFA1_eot;
				this.eof = DFA1_eof;
				this.min = DFA1_min;
				this.max = DFA1_max;
				this.accept = DFA1_accept;
				this.special = DFA1_special;
				this.transition = DFA1_transition;
			}

			public override string Description { get { return "114:1: subExp returns [CseObject value] : ( assign | nonAssign );"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition1(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA1_1 = input.LA(1);


					int index1_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred1_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index1_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 1, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA8 : DFA {
			private const string DFA8_eotS =
			"\xA\xFFFF";
			private const string DFA8_eofS =
			"\xA\xFFFF";
			private const string DFA8_minS =
			"\x1\x6\x1\x0\x8\xFFFF";
			private const string DFA8_maxS =
			"\x1\x6\x1\x0\x8\xFFFF";
			private const string DFA8_acceptS =
			"\x2\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8";
			private const string DFA8_specialS =
			"\x1\xFFFF\x1\x0\x8\xFFFF}>";
			private static readonly string[] DFA8_transitionS =
			{
				"\x1\x1",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
			private static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
			private static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
			private static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
			private static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
			private static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
			private static readonly short[][] DFA8_transition;

			static DFA8() {
				int numStates = DFA8_transitionS.Length;
				DFA8_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA8_transition[i] = DFA.UnpackEncodedString(DFA8_transitionS[i]);
				}
			}

			public DFA8(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 8;
				this.eot = DFA8_eot;
				this.eof = DFA8_eof;
				this.min = DFA8_min;
				this.max = DFA8_max;
				this.accept = DFA8_accept;
				this.special = DFA8_special;
				this.transition = DFA8_transition;
			}

			public override string Description { get { return "118:1: assign returns [CseObject value] : (icp= identChainList EQ subExp | typeExp ID EQ subExp | icp= identChainList CROSS_EQ ( LPAREN typeExp RPAREN )? subExp | icp= identChainList DASH_EQ ( LPAREN typeExp RPAREN )? subExp | icp= identChainList STAR_EQ ( LPAREN typeExp RPAREN )? subExp | icp= identChainList FSLASH_EQ ( LPAREN typeExp RPAREN )? subExp | icp= identChainList PER_EQ ( LPAREN typeExp RPAREN )? subExp | icp= identChainList DBLSTAR_EQ ( LPAREN typeExp RPAREN )? subExp );"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition8(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA8_1 = input.LA(1);


					int index8_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred2_Cse_fragment))) { s = 2; }

					else if ((EvaluatePredicate(synpred3_Cse_fragment))) { s = 3; }

					else if ((EvaluatePredicate(synpred5_Cse_fragment))) { s = 4; }

					else if ((EvaluatePredicate(synpred7_Cse_fragment))) { s = 5; }

					else if ((EvaluatePredicate(synpred9_Cse_fragment))) { s = 6; }

					else if ((EvaluatePredicate(synpred11_Cse_fragment))) { s = 7; }

					else if ((EvaluatePredicate(synpred13_Cse_fragment))) { s = 8; }

					else if ((true)) { s = 9; }


					input.Seek(index8_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 8, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA2 : DFA {
			private const string DFA2_eotS =
			"\x11\xFFFF";
			private const string DFA2_eofS =
			"\x11\xFFFF";
			private const string DFA2_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA2_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA2_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA2_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA2_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
			private static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
			private static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
			private static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
			private static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
			private static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
			private static readonly short[][] DFA2_transition;

			static DFA2() {
				int numStates = DFA2_transitionS.Length;
				DFA2_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA2_transition[i] = DFA.UnpackEncodedString(DFA2_transitionS[i]);
				}
			}

			public DFA2(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 2;
				this.eot = DFA2_eot;
				this.eof = DFA2_eof;
				this.min = DFA2_min;
				this.max = DFA2_max;
				this.accept = DFA2_accept;
				this.special = DFA2_special;
				this.transition = DFA2_transition;
			}

			public override string Description { get { return "125:32: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition2(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA2_1 = input.LA(1);


					int index2_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred4_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index2_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 2, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA3 : DFA {
			private const string DFA3_eotS =
			"\x11\xFFFF";
			private const string DFA3_eofS =
			"\x11\xFFFF";
			private const string DFA3_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA3_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA3_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA3_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA3_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
			private static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
			private static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
			private static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
			private static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
			private static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
			private static readonly short[][] DFA3_transition;

			static DFA3() {
				int numStates = DFA3_transitionS.Length;
				DFA3_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA3_transition[i] = DFA.UnpackEncodedString(DFA3_transitionS[i]);
				}
			}

			public DFA3(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 3;
				this.eot = DFA3_eot;
				this.eof = DFA3_eof;
				this.min = DFA3_min;
				this.max = DFA3_max;
				this.accept = DFA3_accept;
				this.special = DFA3_special;
				this.transition = DFA3_transition;
			}

			public override string Description { get { return "140:31: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition3(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA3_1 = input.LA(1);


					int index3_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred6_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index3_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 3, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA4 : DFA {
			private const string DFA4_eotS =
			"\x11\xFFFF";
			private const string DFA4_eofS =
			"\x11\xFFFF";
			private const string DFA4_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA4_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA4_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA4_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA4_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
			private static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
			private static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
			private static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
			private static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
			private static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
			private static readonly short[][] DFA4_transition;

			static DFA4() {
				int numStates = DFA4_transitionS.Length;
				DFA4_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA4_transition[i] = DFA.UnpackEncodedString(DFA4_transitionS[i]);
				}
			}

			public DFA4(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 4;
				this.eot = DFA4_eot;
				this.eof = DFA4_eof;
				this.min = DFA4_min;
				this.max = DFA4_max;
				this.accept = DFA4_accept;
				this.special = DFA4_special;
				this.transition = DFA4_transition;
			}

			public override string Description { get { return "150:31: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition4(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA4_1 = input.LA(1);


					int index4_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred8_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index4_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 4, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA5 : DFA {
			private const string DFA5_eotS =
			"\x11\xFFFF";
			private const string DFA5_eofS =
			"\x11\xFFFF";
			private const string DFA5_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA5_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA5_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA5_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA5_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
			private static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
			private static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
			private static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
			private static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
			private static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
			private static readonly short[][] DFA5_transition;

			static DFA5() {
				int numStates = DFA5_transitionS.Length;
				DFA5_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA5_transition[i] = DFA.UnpackEncodedString(DFA5_transitionS[i]);
				}
			}

			public DFA5(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 5;
				this.eot = DFA5_eot;
				this.eof = DFA5_eof;
				this.min = DFA5_min;
				this.max = DFA5_max;
				this.accept = DFA5_accept;
				this.special = DFA5_special;
				this.transition = DFA5_transition;
			}

			public override string Description { get { return "160:33: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition5(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA5_1 = input.LA(1);


					int index5_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred10_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index5_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 5, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA6 : DFA {
			private const string DFA6_eotS =
			"\x11\xFFFF";
			private const string DFA6_eofS =
			"\x11\xFFFF";
			private const string DFA6_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA6_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA6_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA6_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA6_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
			private static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
			private static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
			private static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
			private static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
			private static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
			private static readonly short[][] DFA6_transition;

			static DFA6() {
				int numStates = DFA6_transitionS.Length;
				DFA6_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA6_transition[i] = DFA.UnpackEncodedString(DFA6_transitionS[i]);
				}
			}

			public DFA6(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 6;
				this.eot = DFA6_eot;
				this.eof = DFA6_eof;
				this.min = DFA6_min;
				this.max = DFA6_max;
				this.accept = DFA6_accept;
				this.special = DFA6_special;
				this.transition = DFA6_transition;
			}

			public override string Description { get { return "170:30: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition6(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA6_1 = input.LA(1);


					int index6_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred12_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index6_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 6, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA7 : DFA {
			private const string DFA7_eotS =
			"\x11\xFFFF";
			private const string DFA7_eofS =
			"\x11\xFFFF";
			private const string DFA7_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA7_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA7_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA7_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA7_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
			private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
			private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
			private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
			private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
			private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
			private static readonly short[][] DFA7_transition;

			static DFA7() {
				int numStates = DFA7_transitionS.Length;
				DFA7_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
				}
			}

			public DFA7(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 7;
				this.eot = DFA7_eot;
				this.eof = DFA7_eof;
				this.min = DFA7_min;
				this.max = DFA7_max;
				this.accept = DFA7_accept;
				this.special = DFA7_special;
				this.transition = DFA7_transition;
			}

			public override string Description { get { return "180:34: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition7(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA7_1 = input.LA(1);


					int index7_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred14_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index7_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 7, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA40 : DFA {
			private const string DFA40_eotS =
			"\x11\xFFFF";
			private const string DFA40_eofS =
			"\x11\xFFFF";
			private const string DFA40_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA40_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA40_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA40_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA40_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA40_eot = DFA.UnpackEncodedString(DFA40_eotS);
			private static readonly short[] DFA40_eof = DFA.UnpackEncodedString(DFA40_eofS);
			private static readonly char[] DFA40_min = DFA.UnpackEncodedStringToUnsignedChars(DFA40_minS);
			private static readonly char[] DFA40_max = DFA.UnpackEncodedStringToUnsignedChars(DFA40_maxS);
			private static readonly short[] DFA40_accept = DFA.UnpackEncodedString(DFA40_acceptS);
			private static readonly short[] DFA40_special = DFA.UnpackEncodedString(DFA40_specialS);
			private static readonly short[][] DFA40_transition;

			static DFA40() {
				int numStates = DFA40_transitionS.Length;
				DFA40_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA40_transition[i] = DFA.UnpackEncodedString(DFA40_transitionS[i]);
				}
			}

			public DFA40(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 40;
				this.eot = DFA40_eot;
				this.eof = DFA40_eof;
				this.min = DFA40_min;
				this.max = DFA40_max;
				this.accept = DFA40_accept;
				this.special = DFA40_special;
				this.transition = DFA40_transition;
			}

			public override string Description { get { return "125:32: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition40(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA40_1 = input.LA(1);


					int index40_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred4_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index40_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 40, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA41 : DFA {
			private const string DFA41_eotS =
			"\x11\xFFFF";
			private const string DFA41_eofS =
			"\x11\xFFFF";
			private const string DFA41_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA41_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA41_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA41_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA41_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA41_eot = DFA.UnpackEncodedString(DFA41_eotS);
			private static readonly short[] DFA41_eof = DFA.UnpackEncodedString(DFA41_eofS);
			private static readonly char[] DFA41_min = DFA.UnpackEncodedStringToUnsignedChars(DFA41_minS);
			private static readonly char[] DFA41_max = DFA.UnpackEncodedStringToUnsignedChars(DFA41_maxS);
			private static readonly short[] DFA41_accept = DFA.UnpackEncodedString(DFA41_acceptS);
			private static readonly short[] DFA41_special = DFA.UnpackEncodedString(DFA41_specialS);
			private static readonly short[][] DFA41_transition;

			static DFA41() {
				int numStates = DFA41_transitionS.Length;
				DFA41_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA41_transition[i] = DFA.UnpackEncodedString(DFA41_transitionS[i]);
				}
			}

			public DFA41(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 41;
				this.eot = DFA41_eot;
				this.eof = DFA41_eof;
				this.min = DFA41_min;
				this.max = DFA41_max;
				this.accept = DFA41_accept;
				this.special = DFA41_special;
				this.transition = DFA41_transition;
			}

			public override string Description { get { return "140:31: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition41(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA41_1 = input.LA(1);


					int index41_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred6_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index41_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 41, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA42 : DFA {
			private const string DFA42_eotS =
			"\x11\xFFFF";
			private const string DFA42_eofS =
			"\x11\xFFFF";
			private const string DFA42_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA42_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA42_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA42_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA42_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA42_eot = DFA.UnpackEncodedString(DFA42_eotS);
			private static readonly short[] DFA42_eof = DFA.UnpackEncodedString(DFA42_eofS);
			private static readonly char[] DFA42_min = DFA.UnpackEncodedStringToUnsignedChars(DFA42_minS);
			private static readonly char[] DFA42_max = DFA.UnpackEncodedStringToUnsignedChars(DFA42_maxS);
			private static readonly short[] DFA42_accept = DFA.UnpackEncodedString(DFA42_acceptS);
			private static readonly short[] DFA42_special = DFA.UnpackEncodedString(DFA42_specialS);
			private static readonly short[][] DFA42_transition;

			static DFA42() {
				int numStates = DFA42_transitionS.Length;
				DFA42_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA42_transition[i] = DFA.UnpackEncodedString(DFA42_transitionS[i]);
				}
			}

			public DFA42(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 42;
				this.eot = DFA42_eot;
				this.eof = DFA42_eof;
				this.min = DFA42_min;
				this.max = DFA42_max;
				this.accept = DFA42_accept;
				this.special = DFA42_special;
				this.transition = DFA42_transition;
			}

			public override string Description { get { return "150:31: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition42(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA42_1 = input.LA(1);


					int index42_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred8_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index42_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 42, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA43 : DFA {
			private const string DFA43_eotS =
			"\x11\xFFFF";
			private const string DFA43_eofS =
			"\x11\xFFFF";
			private const string DFA43_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA43_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA43_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA43_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA43_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
			private static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
			private static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
			private static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
			private static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
			private static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
			private static readonly short[][] DFA43_transition;

			static DFA43() {
				int numStates = DFA43_transitionS.Length;
				DFA43_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA43_transition[i] = DFA.UnpackEncodedString(DFA43_transitionS[i]);
				}
			}

			public DFA43(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 43;
				this.eot = DFA43_eot;
				this.eof = DFA43_eof;
				this.min = DFA43_min;
				this.max = DFA43_max;
				this.accept = DFA43_accept;
				this.special = DFA43_special;
				this.transition = DFA43_transition;
			}

			public override string Description { get { return "160:33: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition43(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA43_1 = input.LA(1);


					int index43_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred10_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index43_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 43, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA44 : DFA {
			private const string DFA44_eotS =
			"\x11\xFFFF";
			private const string DFA44_eofS =
			"\x11\xFFFF";
			private const string DFA44_minS =
			"\x1\x6\x1\x0\xF\xFFFF";
			private const string DFA44_maxS =
			"\x1\x38\x1\x0\xF\xFFFF";
			private const string DFA44_acceptS =
			"\x2\xFFFF\x1\x2\xD\xFFFF\x1\x1";
			private const string DFA44_specialS =
			"\x1\xFFFF\x1\x0\xF\xFFFF}>";
			private static readonly string[] DFA44_transitionS =
			{
				"\x1\x2\x1\xFFFF\x1\x1\x15\xFFFF\x2\x2\x4\xFFFF\x3\x2\x6\xFFFF\xC\x2",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA44_eot = DFA.UnpackEncodedString(DFA44_eotS);
			private static readonly short[] DFA44_eof = DFA.UnpackEncodedString(DFA44_eofS);
			private static readonly char[] DFA44_min = DFA.UnpackEncodedStringToUnsignedChars(DFA44_minS);
			private static readonly char[] DFA44_max = DFA.UnpackEncodedStringToUnsignedChars(DFA44_maxS);
			private static readonly short[] DFA44_accept = DFA.UnpackEncodedString(DFA44_acceptS);
			private static readonly short[] DFA44_special = DFA.UnpackEncodedString(DFA44_specialS);
			private static readonly short[][] DFA44_transition;

			static DFA44() {
				int numStates = DFA44_transitionS.Length;
				DFA44_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA44_transition[i] = DFA.UnpackEncodedString(DFA44_transitionS[i]);
				}
			}

			public DFA44(BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition)
				: base(specialStateTransition) {
				this.recognizer = recognizer;
				this.decisionNumber = 44;
				this.eot = DFA44_eot;
				this.eof = DFA44_eof;
				this.min = DFA44_min;
				this.max = DFA44_max;
				this.accept = DFA44_accept;
				this.special = DFA44_special;
				this.transition = DFA44_transition;
			}

			public override string Description { get { return "170:30: ( LPAREN typeExp RPAREN )?"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition44(DFA dfa, int s, IIntStream _input) {
			ITokenStream input = (ITokenStream)_input;
			int _s = s;
			switch (s) {

				case 0:
					int LA44_1 = input.LA(1);


					int index44_1 = input.Index;
					input.Rewind();
					s = -1;
					if ((EvaluatePredicate(synpred12_Cse_fragment))) { s = 16; }

					else if ((true)) { s = 2; }


					input.Seek(index44_1);
					if (s >= 0)
						return s;
					break;
			}
			if (state.backtracking > 0) { state.failed = true; return -1; }
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 44, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}

		#endregion DFA

		#region Follow sets
		private static class Follow {
			public static readonly BitSet _subExp_in_exp118 = new BitSet(new ulong[] { 0x10UL });
			public static readonly BitSet _SEMI_in_exp120 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _assign_in_subExp138 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _nonAssign_in_subExp146 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_assign165 = new BitSet(new ulong[] { 0x20UL });
			public static readonly BitSet _EQ_in_assign167 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign169 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _typeExp_in_assign176 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _ID_in_assign178 = new BitSet(new ulong[] { 0x20UL });
			public static readonly BitSet _EQ_in_assign180 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign182 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_assign194 = new BitSet(new ulong[] { 0x80UL });
			public static readonly BitSet _CROSS_EQ_in_assign196 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_assign199 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_assign201 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_assign203 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign207 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_assign219 = new BitSet(new ulong[] { 0x400UL });
			public static readonly BitSet _DASH_EQ_in_assign221 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_assign224 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_assign226 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_assign228 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign232 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_assign244 = new BitSet(new ulong[] { 0x800UL });
			public static readonly BitSet _STAR_EQ_in_assign246 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_assign249 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_assign251 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_assign253 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign257 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_assign269 = new BitSet(new ulong[] { 0x1000UL });
			public static readonly BitSet _FSLASH_EQ_in_assign271 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_assign274 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_assign276 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_assign278 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign282 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_assign294 = new BitSet(new ulong[] { 0x2000UL });
			public static readonly BitSet _PER_EQ_in_assign296 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_assign299 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_assign301 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_assign303 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign307 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_assign319 = new BitSet(new ulong[] { 0x4000UL });
			public static readonly BitSet _DBLSTAR_EQ_in_assign321 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_assign324 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_assign326 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_assign328 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_assign332 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _condExp_in_nonAssign354 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _typeExp_in_nonAssign361 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _ID_in_nonAssign363 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _logOrExp_in_condExp385 = new BitSet(new ulong[] { 0x8002UL });
			public static readonly BitSet _QUESTION_in_condExp395 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_condExp399 = new BitSet(new ulong[] { 0x10000UL });
			public static readonly BitSet _COLON_in_condExp401 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_condExp405 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _logAndExp_in_logOrExp434 = new BitSet(new ulong[] { 0x20002UL });
			public static readonly BitSet _DBLPIPE_in_logOrExp444 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _logAndExp_in_logOrExp448 = new BitSet(new ulong[] { 0x20002UL });
			public static readonly BitSet _bitOrExp_in_logAndExp471 = new BitSet(new ulong[] { 0x40002UL });
			public static readonly BitSet _DBLAMP_in_logAndExp481 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _bitOrExp_in_logAndExp485 = new BitSet(new ulong[] { 0x40002UL });
			public static readonly BitSet _xorExp_in_bitOrExp508 = new BitSet(new ulong[] { 0x80002UL });
			public static readonly BitSet _PIPE_in_bitOrExp517 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _xorExp_in_bitOrExp521 = new BitSet(new ulong[] { 0x80002UL });
			public static readonly BitSet _bitAndExp_in_xorExp543 = new BitSet(new ulong[] { 0x100002UL });
			public static readonly BitSet _HAT_in_xorExp552 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _bitAndExp_in_xorExp556 = new BitSet(new ulong[] { 0x100002UL });
			public static readonly BitSet _eqExp_in_bitAndExp578 = new BitSet(new ulong[] { 0x200002UL });
			public static readonly BitSet _AMP_in_bitAndExp587 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _eqExp_in_bitAndExp591 = new BitSet(new ulong[] { 0x200002UL });
			public static readonly BitSet _relExp_in_eqExp613 = new BitSet(new ulong[] { 0xC00002UL });
			public static readonly BitSet _DBL_EQ_in_eqExp623 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _relExp_in_eqExp627 = new BitSet(new ulong[] { 0xC00002UL });
			public static readonly BitSet _BANG_EQ_in_eqExp638 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _relExp_in_eqExp642 = new BitSet(new ulong[] { 0xC00002UL });
			public static readonly BitSet _shiftExp_in_relExp667 = new BitSet(new ulong[] { 0xF000002UL });
			public static readonly BitSet _LANGLE_in_relExp676 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _shiftExp_in_relExp680 = new BitSet(new ulong[] { 0xF000002UL });
			public static readonly BitSet _RANGLE_in_relExp697 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _shiftExp_in_relExp701 = new BitSet(new ulong[] { 0xF000002UL });
			public static readonly BitSet _LANGLE_EQ_in_relExp718 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _shiftExp_in_relExp722 = new BitSet(new ulong[] { 0xF000002UL });
			public static readonly BitSet _RANGLE_EQ_in_relExp739 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _shiftExp_in_relExp743 = new BitSet(new ulong[] { 0xF000002UL });
			public static readonly BitSet _addExp_in_shiftExp768 = new BitSet(new ulong[] { 0x30000002UL });
			public static readonly BitSet _DBLLANGLE_in_shiftExp778 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _addExp_in_shiftExp782 = new BitSet(new ulong[] { 0x30000002UL });
			public static readonly BitSet _DBLRANGLE_in_shiftExp799 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _addExp_in_shiftExp803 = new BitSet(new ulong[] { 0x30000002UL });
			public static readonly BitSet _multExp_in_addExp828 = new BitSet(new ulong[] { 0xC0000002UL });
			public static readonly BitSet _CROSS_in_addExp837 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _multExp_in_addExp841 = new BitSet(new ulong[] { 0xC0000002UL });
			public static readonly BitSet _DASH_in_addExp856 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _multExp_in_addExp860 = new BitSet(new ulong[] { 0xC0000002UL });
			public static readonly BitSet _powExp_in_multExp884 = new BitSet(new ulong[] { 0x700000002UL });
			public static readonly BitSet _STAR_in_multExp894 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _powExp_in_multExp898 = new BitSet(new ulong[] { 0x700000002UL });
			public static readonly BitSet _FSLASH_in_multExp913 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _powExp_in_multExp917 = new BitSet(new ulong[] { 0x700000002UL });
			public static readonly BitSet _PER_in_multExp930 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _powExp_in_multExp934 = new BitSet(new ulong[] { 0x700000002UL });
			public static readonly BitSet _unaryExp_in_powExp973 = new BitSet(new ulong[] { 0x800000002UL });
			public static readonly BitSet _DBLSTAR_in_powExp987 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _unaryExp_in_powExp991 = new BitSet(new ulong[] { 0x800000002UL });
			public static readonly BitSet _set_in_unaryExp1033 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _unaryExpPart_in_unaryExp1055 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _litExp_in_unaryExpPart1071 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _objChainList_in_unaryExpPart1085 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _castOrParenExp_in_unaryExpPart1093 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _objCon_in_unaryExpPart1105 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _NEW_in_objCon1129 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_objCon1131 = new BitSet(new ulong[] { 0x100UL });
			public static readonly BitSet _LPAREN_in_objCon1133 = new BitSet(new ulong[] { 0x1FFF870C0000340UL });
			public static readonly BitSet _argList_in_objCon1137 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_objCon1140 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _DOT_in_objCon1148 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _objChainList_in_objCon1150 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_castOrParenExp1172 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_castOrParenExp1174 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_castOrParenExp1176 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _unaryExp_in_castOrParenExp1178 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_castOrParenExp1186 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_castOrParenExp1188 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_castOrParenExp1190 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _DOT_in_castOrParenExp1201 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _objChainList_in_castOrParenExp1203 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _ID_in_typeExp1224 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainPart_in_identChainList1260 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _DOT_in_identChainList1275 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _identChainPart_in_identChainList1279 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _identExp_in_identChainPart1306 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _arrayExp_in_identChainPart1318 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _objChainPart_in_objChainList1351 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _DOT_in_objChainList1365 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _objChainPart_in_objChainList1369 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _identExp_in_objChainPart1393 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _callExp_in_objChainPart1401 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _arrayExp_in_objChainPart1409 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _ID_in_identExp1427 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _ID_in_callExp1445 = new BitSet(new ulong[] { 0x100UL });
			public static readonly BitSet _LPAREN_in_callExp1447 = new BitSet(new ulong[] { 0x1FFF870C0000340UL });
			public static readonly BitSet _argList_in_callExp1451 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_callExp1454 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _ID_in_arrayExp1471 = new BitSet(new ulong[] { 0x10000000000UL });
			public static readonly BitSet _LBRACK_in_arrayExp1473 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_arrayExp1475 = new BitSet(new ulong[] { 0x20000000000UL });
			public static readonly BitSet _RBRACK_in_arrayExp1477 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _arg_in_argList1504 = new BitSet(new ulong[] { 0x40000000002UL });
			public static readonly BitSet _COMMA_in_argList1518 = new BitSet(new ulong[] { 0x1FFF870C0000140UL });
			public static readonly BitSet _arg_in_argList1522 = new BitSet(new ulong[] { 0x40000000002UL });
			public static readonly BitSet _argModExp_in_arg1544 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_arg1546 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _REF_in_argModExp1566 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _OUT_in_argModExp1573 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _lit_in_litExp1606 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _DOT_in_litExp1619 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _objChainPart_in_litExp1623 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _CH_INT_in_litExp1642 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _objChainPart_in_litExp1656 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _DOT_in_litExp1674 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _objChainPart_in_litExp1678 = new BitSet(new ulong[] { 0x8000000002UL });
			public static readonly BitSet _boolLit_in_lit1701 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _numLit_in_lit1708 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _strLit_in_lit1715 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _charLit_in_lit1722 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _nullLit_in_lit1729 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _termConst_in_lit1736 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _set_in_numLit1756 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _INT_in_numLit1771 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _FLT_in_numLit1780 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _INTWITHSUFFIX_in_numLit1789 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _FLTWITHSUFFIX_in_numLit1798 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _BOOL_in_boolLit1816 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _STR_in_strLit1832 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _CHAR_in_charLit1848 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _NULL_in_nullLit1860 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _TERMCONST_in_termConst1879 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _assign_in_synpred1_Cse138 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_synpred2_Cse165 = new BitSet(new ulong[] { 0x20UL });
			public static readonly BitSet _EQ_in_synpred2_Cse167 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_synpred2_Cse169 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _typeExp_in_synpred3_Cse176 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _ID_in_synpred3_Cse178 = new BitSet(new ulong[] { 0x20UL });
			public static readonly BitSet _EQ_in_synpred3_Cse180 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_synpred3_Cse182 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_synpred4_Cse199 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred4_Cse201 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred4_Cse203 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_synpred5_Cse194 = new BitSet(new ulong[] { 0x80UL });
			public static readonly BitSet _CROSS_EQ_in_synpred5_Cse196 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_synpred5_Cse199 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred5_Cse201 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred5_Cse203 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_synpred5_Cse207 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_synpred6_Cse224 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred6_Cse226 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred6_Cse228 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_synpred7_Cse219 = new BitSet(new ulong[] { 0x400UL });
			public static readonly BitSet _DASH_EQ_in_synpred7_Cse221 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_synpred7_Cse224 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred7_Cse226 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred7_Cse228 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_synpred7_Cse232 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_synpred8_Cse249 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred8_Cse251 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred8_Cse253 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_synpred9_Cse244 = new BitSet(new ulong[] { 0x800UL });
			public static readonly BitSet _STAR_EQ_in_synpred9_Cse246 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_synpred9_Cse249 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred9_Cse251 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred9_Cse253 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_synpred9_Cse257 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_synpred10_Cse274 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred10_Cse276 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred10_Cse278 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_synpred11_Cse269 = new BitSet(new ulong[] { 0x1000UL });
			public static readonly BitSet _FSLASH_EQ_in_synpred11_Cse271 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_synpred11_Cse274 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred11_Cse276 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred11_Cse278 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_synpred11_Cse282 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_synpred12_Cse299 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred12_Cse301 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred12_Cse303 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _identChainList_in_synpred13_Cse294 = new BitSet(new ulong[] { 0x2000UL });
			public static readonly BitSet _PER_EQ_in_synpred13_Cse296 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _LPAREN_in_synpred13_Cse299 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred13_Cse301 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred13_Cse303 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _subExp_in_synpred13_Cse307 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_synpred14_Cse324 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred14_Cse326 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred14_Cse328 = new BitSet(new ulong[] { 0x2UL });
			public static readonly BitSet _LPAREN_in_synpred45_Cse1172 = new BitSet(new ulong[] { 0x40UL });
			public static readonly BitSet _typeExp_in_synpred45_Cse1174 = new BitSet(new ulong[] { 0x200UL });
			public static readonly BitSet _RPAREN_in_synpred45_Cse1176 = new BitSet(new ulong[] { 0x1FFE070C0000140UL });
			public static readonly BitSet _unaryExp_in_synpred45_Cse1178 = new BitSet(new ulong[] { 0x2UL });

		}
		#endregion Follow sets
	}

}
