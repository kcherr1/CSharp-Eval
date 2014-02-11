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
using Antlr.Runtime;

namespace CSE.AntlrParser {
	[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
	internal partial class CseLexer : Antlr.Runtime.Lexer {
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

		public override void EmitErrorMessage(String msg) {
			throw new Exception(msg);
		}

		protected override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) {
			throw new MismatchedTokenException(ttype, input);
		}

		public override object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow) {
			throw e;
		}


		// delegates
		// delegators

		public CseLexer() {
			OnCreated();
		}

		public CseLexer(ICharStream input)
			: this(input, new RecognizerSharedState()) {
		}

		public CseLexer(ICharStream input, RecognizerSharedState state)
			: base(input, state) {

			OnCreated();
		}
		public override string GrammarFileName { get { return ""; } }

		private static readonly bool[] decisionCanBacktrack = new bool[0];


		partial void OnCreated();
		partial void EnterRule(string ruleName, int ruleIndex);
		partial void LeaveRule(string ruleName, int ruleIndex);

		partial void Enter_OCT_DIGIT();
		partial void Leave_OCT_DIGIT();

		// $ANTLR start "OCT_DIGIT"
		[GrammarRule("OCT_DIGIT")]
		private void mOCT_DIGIT() {
			Enter_OCT_DIGIT();
			EnterRule("OCT_DIGIT", 1);
			TraceIn("OCT_DIGIT", 1);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(578, 22);
					MatchRange('0', '7');

				}

			}
			finally {
				TraceOut("OCT_DIGIT", 1);
				LeaveRule("OCT_DIGIT", 1);
				Leave_OCT_DIGIT();
			}
		}
		// $ANTLR end "OCT_DIGIT"

		partial void Enter_DIGIT();
		partial void Leave_DIGIT();

		// $ANTLR start "DIGIT"
		[GrammarRule("DIGIT")]
		private void mDIGIT() {
			Enter_DIGIT();
			EnterRule("DIGIT", 2);
			TraceIn("DIGIT", 2);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(579, 19);
					MatchRange('0', '9');

				}

			}
			finally {
				TraceOut("DIGIT", 2);
				LeaveRule("DIGIT", 2);
				Leave_DIGIT();
			}
		}
		// $ANTLR end "DIGIT"

		partial void Enter_HEX_DIGIT();
		partial void Leave_HEX_DIGIT();

		// $ANTLR start "HEX_DIGIT"
		[GrammarRule("HEX_DIGIT")]
		private void mHEX_DIGIT() {
			Enter_HEX_DIGIT();
			EnterRule("HEX_DIGIT", 3);
			TraceIn("HEX_DIGIT", 3);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(580, 19);
					if ((input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f')) {
						input.Consume();

					}
					else {
						MismatchedSetException mse = new MismatchedSetException(null, input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;
					}


				}

			}
			finally {
				TraceOut("HEX_DIGIT", 3);
				LeaveRule("HEX_DIGIT", 3);
				Leave_HEX_DIGIT();
			}
		}
		// $ANTLR end "HEX_DIGIT"

		partial void Enter_LETTER();
		partial void Leave_LETTER();

		// $ANTLR start "LETTER"
		[GrammarRule("LETTER")]
		private void mLETTER() {
			Enter_LETTER();
			EnterRule("LETTER", 4);
			TraceIn("LETTER", 4);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(581, 16);
					if ((input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z')) {
						input.Consume();

					}
					else {
						MismatchedSetException mse = new MismatchedSetException(null, input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;
					}


				}

			}
			finally {
				TraceOut("LETTER", 4);
				LeaveRule("LETTER", 4);
				Leave_LETTER();
			}
		}
		// $ANTLR end "LETTER"

		partial void Enter_IDENT_START();
		partial void Leave_IDENT_START();

		// $ANTLR start "IDENT_START"
		[GrammarRule("IDENT_START")]
		private void mIDENT_START() {
			Enter_IDENT_START();
			EnterRule("IDENT_START", 5);
			TraceIn("IDENT_START", 5);
			try {
				int alt1=3;
				try {
					DebugEnterDecision(1, decisionCanBacktrack[1]);
					switch (input.LA(1)) {
						case '_': {
								alt1 = 1;
							}
							break;
						case 'A':
						case 'B':
						case 'C':
						case 'D':
						case 'E':
						case 'F':
						case 'G':
						case 'H':
						case 'I':
						case 'J':
						case 'K':
						case 'L':
						case 'M':
						case 'N':
						case 'O':
						case 'P':
						case 'Q':
						case 'R':
						case 'S':
						case 'T':
						case 'U':
						case 'V':
						case 'W':
						case 'X':
						case 'Y':
						case 'Z':
						case 'a':
						case 'b':
						case 'c':
						case 'd':
						case 'e':
						case 'f':
						case 'g':
						case 'h':
						case 'i':
						case 'j':
						case 'k':
						case 'l':
						case 'm':
						case 'n':
						case 'o':
						case 'p':
						case 'q':
						case 'r':
						case 's':
						case 't':
						case 'u':
						case 'v':
						case 'w':
						case 'x':
						case 'y':
						case 'z': {
								alt1 = 2;
							}
							break;
						case '\\': {
								alt1 = 3;
							}
							break;
						default: {
								NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
					}

				}
				finally { DebugExitDecision(1); }
				switch (alt1) {
					case 1:
						DebugEnterAlt(1); {
							DebugLocation(582, 24);
							Match('_');

						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(582, 30);
							mLETTER();

						}
						break;
					case 3:
						DebugEnterAlt(3); {
							DebugLocation(582, 39);
							Match('\\');
							DebugLocation(582, 44);
							mESC_SEQ();

						}
						break;

				}
			}
			finally {
				TraceOut("IDENT_START", 5);
				LeaveRule("IDENT_START", 5);
				Leave_IDENT_START();
			}
		}
		// $ANTLR end "IDENT_START"

		partial void Enter_IDENT_CONT();
		partial void Leave_IDENT_CONT();

		// $ANTLR start "IDENT_CONT"
		[GrammarRule("IDENT_CONT")]
		private void mIDENT_CONT() {
			Enter_IDENT_CONT();
			EnterRule("IDENT_CONT", 6);
			TraceIn("IDENT_CONT", 6);
			try {
				int alt2=4;
				try {
					DebugEnterDecision(2, decisionCanBacktrack[2]);
					switch (input.LA(1)) {
						case '_': {
								alt2 = 1;
							}
							break;
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9': {
								alt2 = 2;
							}
							break;
						case 'A':
						case 'B':
						case 'C':
						case 'D':
						case 'E':
						case 'F':
						case 'G':
						case 'H':
						case 'I':
						case 'J':
						case 'K':
						case 'L':
						case 'M':
						case 'N':
						case 'O':
						case 'P':
						case 'Q':
						case 'R':
						case 'S':
						case 'T':
						case 'U':
						case 'V':
						case 'W':
						case 'X':
						case 'Y':
						case 'Z':
						case 'a':
						case 'b':
						case 'c':
						case 'd':
						case 'e':
						case 'f':
						case 'g':
						case 'h':
						case 'i':
						case 'j':
						case 'k':
						case 'l':
						case 'm':
						case 'n':
						case 'o':
						case 'p':
						case 'q':
						case 'r':
						case 's':
						case 't':
						case 'u':
						case 'v':
						case 'w':
						case 'x':
						case 'y':
						case 'z': {
								alt2 = 3;
							}
							break;
						case '\\': {
								alt2 = 4;
							}
							break;
						default: {
								NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
					}

				}
				finally { DebugExitDecision(2); }
				switch (alt2) {
					case 1:
						DebugEnterAlt(1); {
							DebugLocation(583, 22);
							Match('_');

						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(583, 28);
							mDIGIT();

						}
						break;
					case 3:
						DebugEnterAlt(3); {
							DebugLocation(583, 36);
							mLETTER();

						}
						break;
					case 4:
						DebugEnterAlt(4); {
							DebugLocation(583, 45);
							Match('\\');
							DebugLocation(583, 50);
							mESC_SEQ();

						}
						break;

				}
			}
			finally {
				TraceOut("IDENT_CONT", 6);
				LeaveRule("IDENT_CONT", 6);
				Leave_IDENT_CONT();
			}
		}
		// $ANTLR end "IDENT_CONT"

		partial void Enter_WHITESPACE();
		partial void Leave_WHITESPACE();

		// $ANTLR start "WHITESPACE"
		[GrammarRule("WHITESPACE")]
		private void mWHITESPACE() {
			Enter_WHITESPACE();
			EnterRule("WHITESPACE", 7);
			TraceIn("WHITESPACE", 7);
			try {
				DebugEnterAlt(1);
				{
					DebugLocation(584, 20);
					if ((input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ') {
						input.Consume();

					}
					else {
						MismatchedSetException mse = new MismatchedSetException(null, input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;
					}


				}

			}
			finally {
				TraceOut("WHITESPACE", 7);
				LeaveRule("WHITESPACE", 7);
				Leave_WHITESPACE();
			}
		}
		// $ANTLR end "WHITESPACE"

		partial void Enter_ESC_SEQ();
		partial void Leave_ESC_SEQ();

		// $ANTLR start "ESC_SEQ"
		[GrammarRule("ESC_SEQ")]
		private void mESC_SEQ() {
			Enter_ESC_SEQ();
			EnterRule("ESC_SEQ", 8);
			TraceIn("ESC_SEQ", 8);
			try {
				int alt3=17;
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
							DebugLocation(586, 6);
							Match('a');

						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(587, 7);
							Match('b');

						}
						break;
					case 3:
						DebugEnterAlt(3); {
							DebugLocation(588, 7);
							Match('f');

						}
						break;
					case 4:
						DebugEnterAlt(4); {
							DebugLocation(589, 7);
							Match('n');

						}
						break;
					case 5:
						DebugEnterAlt(5); {
							DebugLocation(590, 7);
							Match('r');

						}
						break;
					case 6:
						DebugEnterAlt(6); {
							DebugLocation(591, 7);
							Match('t');

						}
						break;
					case 7:
						DebugEnterAlt(7); {
							DebugLocation(592, 7);
							Match('v');

						}
						break;
					case 8:
						DebugEnterAlt(8); {
							DebugLocation(593, 7);
							Match('0');

						}
						break;
					case 9:
						DebugEnterAlt(9); {
							DebugLocation(595, 7);
							Match('\"');

						}
						break;
					case 10:
						DebugEnterAlt(10); {
							DebugLocation(596, 7);
							Match('\'');

						}
						break;
					case 11:
						DebugEnterAlt(11); {
							DebugLocation(597, 7);
							Match('\\');

						}
						break;
					case 12:
						DebugEnterAlt(12); {
							DebugLocation(599, 7);
							Match('x');
							DebugLocation(599, 13);
							mHEX_DIGIT();

						}
						break;
					case 13:
						DebugEnterAlt(13); {
							DebugLocation(600, 7);
							Match('x');
							DebugLocation(600, 13);
							mHEX_DIGIT();
							DebugLocation(600, 24);
							mHEX_DIGIT();

						}
						break;
					case 14:
						DebugEnterAlt(14); {
							DebugLocation(601, 7);
							Match('x');
							DebugLocation(601, 13);
							mHEX_DIGIT();
							DebugLocation(601, 24);
							mHEX_DIGIT();
							DebugLocation(601, 35);
							mHEX_DIGIT();

						}
						break;
					case 15:
						DebugEnterAlt(15); {
							DebugLocation(602, 7);
							Match('x');
							DebugLocation(602, 13);
							mHEX_DIGIT();
							DebugLocation(602, 24);
							mHEX_DIGIT();
							DebugLocation(602, 35);
							mHEX_DIGIT();
							DebugLocation(602, 46);
							mHEX_DIGIT();

						}
						break;
					case 16:
						DebugEnterAlt(16); {
							DebugLocation(604, 7);
							Match('u');
							DebugLocation(604, 13);
							mHEX_DIGIT();
							DebugLocation(604, 24);
							mHEX_DIGIT();
							DebugLocation(604, 35);
							mHEX_DIGIT();
							DebugLocation(604, 46);
							mHEX_DIGIT();

						}
						break;
					case 17:
						DebugEnterAlt(17); {
							DebugLocation(605, 7);
							Match('U');
							DebugLocation(605, 13);
							mHEX_DIGIT();
							DebugLocation(605, 24);
							mHEX_DIGIT();
							DebugLocation(605, 35);
							mHEX_DIGIT();
							DebugLocation(605, 46);
							mHEX_DIGIT();
							DebugLocation(605, 57);
							mHEX_DIGIT();
							DebugLocation(605, 68);
							mHEX_DIGIT();
							DebugLocation(605, 79);
							mHEX_DIGIT();
							DebugLocation(605, 90);
							mHEX_DIGIT();

						}
						break;

				}
			}
			finally {
				TraceOut("ESC_SEQ", 8);
				LeaveRule("ESC_SEQ", 8);
				Leave_ESC_SEQ();
			}
		}
		// $ANTLR end "ESC_SEQ"

		partial void Enter_TERMCONST();
		partial void Leave_TERMCONST();

		// $ANTLR start "TERMCONST"
		[GrammarRule("TERMCONST")]
		private void mTERMCONST() {
			Enter_TERMCONST();
			EnterRule("TERMCONST", 9);
			TraceIn("TERMCONST", 9);
			try {
				int _type = TERMCONST;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(607, 12);
					Match('#');
					DebugLocation(607, 16);
					int alt4=8;
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
									DebugLocation(607, 17);
									Match('E');

								}
								break;
							case 2:
								DebugEnterAlt(2); {
									DebugLocation(607, 21);
									Match("PI");


								}
								break;
							case 3:
								DebugEnterAlt(3); {
									DebugLocation(607, 26);
									Match('G');

								}
								break;
							case 4:
								DebugEnterAlt(4); {
									DebugLocation(607, 30);
									Match("GC");


								}
								break;
							case 5:
								DebugEnterAlt(5); {
									DebugLocation(607, 35);
									Match("PHI");


								}
								break;
							case 6:
								DebugEnterAlt(6); {
									DebugLocation(607, 41);
									Match("GAMMA");


								}
								break;
							case 7:
								DebugEnterAlt(7); {
									DebugLocation(607, 49);
									Match('C');

								}
								break;
							case 8:
								DebugEnterAlt(8); {
									DebugLocation(607, 53);
									Match('H');

								}
								break;

						}
					}
					finally { DebugExitSubRule(4); }


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("TERMCONST", 9);
				LeaveRule("TERMCONST", 9);
				Leave_TERMCONST();
			}
		}
		// $ANTLR end "TERMCONST"

		partial void Enter_EQ();
		partial void Leave_EQ();

		// $ANTLR start "EQ"
		[GrammarRule("EQ")]
		private void mEQ() {
			Enter_EQ();
			EnterRule("EQ", 10);
			TraceIn("EQ", 10);
			try {
				int _type = EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(608, 7);
					Match('=');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("EQ", 10);
				LeaveRule("EQ", 10);
				Leave_EQ();
			}
		}
		// $ANTLR end "EQ"

		partial void Enter_DBL_EQ();
		partial void Leave_DBL_EQ();

		// $ANTLR start "DBL_EQ"
		[GrammarRule("DBL_EQ")]
		private void mDBL_EQ() {
			Enter_DBL_EQ();
			EnterRule("DBL_EQ", 11);
			TraceIn("DBL_EQ", 11);
			try {
				int _type = DBL_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(609, 10);
					Match("==");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBL_EQ", 11);
				LeaveRule("DBL_EQ", 11);
				Leave_DBL_EQ();
			}
		}
		// $ANTLR end "DBL_EQ"

		partial void Enter_BANG_EQ();
		partial void Leave_BANG_EQ();

		// $ANTLR start "BANG_EQ"
		[GrammarRule("BANG_EQ")]
		private void mBANG_EQ() {
			Enter_BANG_EQ();
			EnterRule("BANG_EQ", 12);
			TraceIn("BANG_EQ", 12);
			try {
				int _type = BANG_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(610, 10);
					Match("!=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("BANG_EQ", 12);
				LeaveRule("BANG_EQ", 12);
				Leave_BANG_EQ();
			}
		}
		// $ANTLR end "BANG_EQ"

		partial void Enter_LANGLE_EQ();
		partial void Leave_LANGLE_EQ();

		// $ANTLR start "LANGLE_EQ"
		[GrammarRule("LANGLE_EQ")]
		private void mLANGLE_EQ() {
			Enter_LANGLE_EQ();
			EnterRule("LANGLE_EQ", 13);
			TraceIn("LANGLE_EQ", 13);
			try {
				int _type = LANGLE_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(611, 12);
					Match("<=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("LANGLE_EQ", 13);
				LeaveRule("LANGLE_EQ", 13);
				Leave_LANGLE_EQ();
			}
		}
		// $ANTLR end "LANGLE_EQ"

		partial void Enter_RANGLE_EQ();
		partial void Leave_RANGLE_EQ();

		// $ANTLR start "RANGLE_EQ"
		[GrammarRule("RANGLE_EQ")]
		private void mRANGLE_EQ() {
			Enter_RANGLE_EQ();
			EnterRule("RANGLE_EQ", 14);
			TraceIn("RANGLE_EQ", 14);
			try {
				int _type = RANGLE_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(612, 12);
					Match(">=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("RANGLE_EQ", 14);
				LeaveRule("RANGLE_EQ", 14);
				Leave_RANGLE_EQ();
			}
		}
		// $ANTLR end "RANGLE_EQ"

		partial void Enter_LANGLE();
		partial void Leave_LANGLE();

		// $ANTLR start "LANGLE"
		[GrammarRule("LANGLE")]
		private void mLANGLE() {
			Enter_LANGLE();
			EnterRule("LANGLE", 15);
			TraceIn("LANGLE", 15);
			try {
				int _type = LANGLE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(613, 10);
					Match('<');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("LANGLE", 15);
				LeaveRule("LANGLE", 15);
				Leave_LANGLE();
			}
		}
		// $ANTLR end "LANGLE"

		partial void Enter_RANGLE();
		partial void Leave_RANGLE();

		// $ANTLR start "RANGLE"
		[GrammarRule("RANGLE")]
		private void mRANGLE() {
			Enter_RANGLE();
			EnterRule("RANGLE", 16);
			TraceIn("RANGLE", 16);
			try {
				int _type = RANGLE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(614, 10);
					Match('>');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("RANGLE", 16);
				LeaveRule("RANGLE", 16);
				Leave_RANGLE();
			}
		}
		// $ANTLR end "RANGLE"

		partial void Enter_DBLLANGLE();
		partial void Leave_DBLLANGLE();

		// $ANTLR start "DBLLANGLE"
		[GrammarRule("DBLLANGLE")]
		private void mDBLLANGLE() {
			Enter_DBLLANGLE();
			EnterRule("DBLLANGLE", 17);
			TraceIn("DBLLANGLE", 17);
			try {
				int _type = DBLLANGLE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(615, 12);
					Match("<<");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLLANGLE", 17);
				LeaveRule("DBLLANGLE", 17);
				Leave_DBLLANGLE();
			}
		}
		// $ANTLR end "DBLLANGLE"

		partial void Enter_DBLRANGLE();
		partial void Leave_DBLRANGLE();

		// $ANTLR start "DBLRANGLE"
		[GrammarRule("DBLRANGLE")]
		private void mDBLRANGLE() {
			Enter_DBLRANGLE();
			EnterRule("DBLRANGLE", 18);
			TraceIn("DBLRANGLE", 18);
			try {
				int _type = DBLRANGLE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(616, 12);
					Match(">>");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLRANGLE", 18);
				LeaveRule("DBLRANGLE", 18);
				Leave_DBLRANGLE();
			}
		}
		// $ANTLR end "DBLRANGLE"

		partial void Enter_PIPE();
		partial void Leave_PIPE();

		// $ANTLR start "PIPE"
		[GrammarRule("PIPE")]
		private void mPIPE() {
			Enter_PIPE();
			EnterRule("PIPE", 19);
			TraceIn("PIPE", 19);
			try {
				int _type = PIPE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(617, 8);
					Match('|');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("PIPE", 19);
				LeaveRule("PIPE", 19);
				Leave_PIPE();
			}
		}
		// $ANTLR end "PIPE"

		partial void Enter_DBLPIPE();
		partial void Leave_DBLPIPE();

		// $ANTLR start "DBLPIPE"
		[GrammarRule("DBLPIPE")]
		private void mDBLPIPE() {
			Enter_DBLPIPE();
			EnterRule("DBLPIPE", 20);
			TraceIn("DBLPIPE", 20);
			try {
				int _type = DBLPIPE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(618, 10);
					Match("||");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLPIPE", 20);
				LeaveRule("DBLPIPE", 20);
				Leave_DBLPIPE();
			}
		}
		// $ANTLR end "DBLPIPE"

		partial void Enter_AMP();
		partial void Leave_AMP();

		// $ANTLR start "AMP"
		[GrammarRule("AMP")]
		private void mAMP() {
			Enter_AMP();
			EnterRule("AMP", 21);
			TraceIn("AMP", 21);
			try {
				int _type = AMP;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(619, 7);
					Match('&');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("AMP", 21);
				LeaveRule("AMP", 21);
				Leave_AMP();
			}
		}
		// $ANTLR end "AMP"

		partial void Enter_DBLAMP();
		partial void Leave_DBLAMP();

		// $ANTLR start "DBLAMP"
		[GrammarRule("DBLAMP")]
		private void mDBLAMP() {
			Enter_DBLAMP();
			EnterRule("DBLAMP", 22);
			TraceIn("DBLAMP", 22);
			try {
				int _type = DBLAMP;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(620, 10);
					Match("&&");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLAMP", 22);
				LeaveRule("DBLAMP", 22);
				Leave_DBLAMP();
			}
		}
		// $ANTLR end "DBLAMP"

		partial void Enter_HAT();
		partial void Leave_HAT();

		// $ANTLR start "HAT"
		[GrammarRule("HAT")]
		private void mHAT() {
			Enter_HAT();
			EnterRule("HAT", 23);
			TraceIn("HAT", 23);
			try {
				int _type = HAT;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(621, 8);
					Match('^');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("HAT", 23);
				LeaveRule("HAT", 23);
				Leave_HAT();
			}
		}
		// $ANTLR end "HAT"

		partial void Enter_BANG();
		partial void Leave_BANG();

		// $ANTLR start "BANG"
		[GrammarRule("BANG")]
		private void mBANG() {
			Enter_BANG();
			EnterRule("BANG", 24);
			TraceIn("BANG", 24);
			try {
				int _type = BANG;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(622, 8);
					Match('!');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("BANG", 24);
				LeaveRule("BANG", 24);
				Leave_BANG();
			}
		}
		// $ANTLR end "BANG"

		partial void Enter_TILDE();
		partial void Leave_TILDE();

		// $ANTLR start "TILDE"
		[GrammarRule("TILDE")]
		private void mTILDE() {
			Enter_TILDE();
			EnterRule("TILDE", 25);
			TraceIn("TILDE", 25);
			try {
				int _type = TILDE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(623, 10);
					Match('~');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("TILDE", 25);
				LeaveRule("TILDE", 25);
				Leave_TILDE();
			}
		}
		// $ANTLR end "TILDE"

		partial void Enter_QUESTION();
		partial void Leave_QUESTION();

		// $ANTLR start "QUESTION"
		[GrammarRule("QUESTION")]
		private void mQUESTION() {
			Enter_QUESTION();
			EnterRule("QUESTION", 26);
			TraceIn("QUESTION", 26);
			try {
				int _type = QUESTION;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(624, 11);
					Match('?');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("QUESTION", 26);
				LeaveRule("QUESTION", 26);
				Leave_QUESTION();
			}
		}
		// $ANTLR end "QUESTION"

		partial void Enter_COLON();
		partial void Leave_COLON();

		// $ANTLR start "COLON"
		[GrammarRule("COLON")]
		private void mCOLON() {
			Enter_COLON();
			EnterRule("COLON", 27);
			TraceIn("COLON", 27);
			try {
				int _type = COLON;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(625, 9);
					Match(':');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("COLON", 27);
				LeaveRule("COLON", 27);
				Leave_COLON();
			}
		}
		// $ANTLR end "COLON"

		partial void Enter_CROSS();
		partial void Leave_CROSS();

		// $ANTLR start "CROSS"
		[GrammarRule("CROSS")]
		private void mCROSS() {
			Enter_CROSS();
			EnterRule("CROSS", 28);
			TraceIn("CROSS", 28);
			try {
				int _type = CROSS;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(626, 9);
					Match('+');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("CROSS", 28);
				LeaveRule("CROSS", 28);
				Leave_CROSS();
			}
		}
		// $ANTLR end "CROSS"

		partial void Enter_DASH();
		partial void Leave_DASH();

		// $ANTLR start "DASH"
		[GrammarRule("DASH")]
		private void mDASH() {
			Enter_DASH();
			EnterRule("DASH", 29);
			TraceIn("DASH", 29);
			try {
				int _type = DASH;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(627, 8);
					Match('-');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DASH", 29);
				LeaveRule("DASH", 29);
				Leave_DASH();
			}
		}
		// $ANTLR end "DASH"

		partial void Enter_STAR();
		partial void Leave_STAR();

		// $ANTLR start "STAR"
		[GrammarRule("STAR")]
		private void mSTAR() {
			Enter_STAR();
			EnterRule("STAR", 30);
			TraceIn("STAR", 30);
			try {
				int _type = STAR;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(628, 8);
					Match('*');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("STAR", 30);
				LeaveRule("STAR", 30);
				Leave_STAR();
			}
		}
		// $ANTLR end "STAR"

		partial void Enter_FSLASH();
		partial void Leave_FSLASH();

		// $ANTLR start "FSLASH"
		[GrammarRule("FSLASH")]
		private void mFSLASH() {
			Enter_FSLASH();
			EnterRule("FSLASH", 31);
			TraceIn("FSLASH", 31);
			try {
				int _type = FSLASH;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(629, 10);
					Match('/');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("FSLASH", 31);
				LeaveRule("FSLASH", 31);
				Leave_FSLASH();
			}
		}
		// $ANTLR end "FSLASH"

		partial void Enter_PER();
		partial void Leave_PER();

		// $ANTLR start "PER"
		[GrammarRule("PER")]
		private void mPER() {
			Enter_PER();
			EnterRule("PER", 32);
			TraceIn("PER", 32);
			try {
				int _type = PER;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(630, 7);
					Match('%');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("PER", 32);
				LeaveRule("PER", 32);
				Leave_PER();
			}
		}
		// $ANTLR end "PER"

		partial void Enter_DBLSTAR();
		partial void Leave_DBLSTAR();

		// $ANTLR start "DBLSTAR"
		[GrammarRule("DBLSTAR")]
		private void mDBLSTAR() {
			Enter_DBLSTAR();
			EnterRule("DBLSTAR", 33);
			TraceIn("DBLSTAR", 33);
			try {
				int _type = DBLSTAR;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(631, 10);
					Match("**");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLSTAR", 33);
				LeaveRule("DBLSTAR", 33);
				Leave_DBLSTAR();
			}
		}
		// $ANTLR end "DBLSTAR"

		partial void Enter_DBLCROSS();
		partial void Leave_DBLCROSS();

		// $ANTLR start "DBLCROSS"
		[GrammarRule("DBLCROSS")]
		private void mDBLCROSS() {
			Enter_DBLCROSS();
			EnterRule("DBLCROSS", 34);
			TraceIn("DBLCROSS", 34);
			try {
				int _type = DBLCROSS;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(632, 11);
					Match("++");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLCROSS", 34);
				LeaveRule("DBLCROSS", 34);
				Leave_DBLCROSS();
			}
		}
		// $ANTLR end "DBLCROSS"

		partial void Enter_DBLDASH();
		partial void Leave_DBLDASH();

		// $ANTLR start "DBLDASH"
		[GrammarRule("DBLDASH")]
		private void mDBLDASH() {
			Enter_DBLDASH();
			EnterRule("DBLDASH", 35);
			TraceIn("DBLDASH", 35);
			try {
				int _type = DBLDASH;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(633, 10);
					Match("--");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLDASH", 35);
				LeaveRule("DBLDASH", 35);
				Leave_DBLDASH();
			}
		}
		// $ANTLR end "DBLDASH"

		partial void Enter_CROSS_EQ();
		partial void Leave_CROSS_EQ();

		// $ANTLR start "CROSS_EQ"
		[GrammarRule("CROSS_EQ")]
		private void mCROSS_EQ() {
			Enter_CROSS_EQ();
			EnterRule("CROSS_EQ", 36);
			TraceIn("CROSS_EQ", 36);
			try {
				int _type = CROSS_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(634, 11);
					Match("+=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("CROSS_EQ", 36);
				LeaveRule("CROSS_EQ", 36);
				Leave_CROSS_EQ();
			}
		}
		// $ANTLR end "CROSS_EQ"

		partial void Enter_DASH_EQ();
		partial void Leave_DASH_EQ();

		// $ANTLR start "DASH_EQ"
		[GrammarRule("DASH_EQ")]
		private void mDASH_EQ() {
			Enter_DASH_EQ();
			EnterRule("DASH_EQ", 37);
			TraceIn("DASH_EQ", 37);
			try {
				int _type = DASH_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(635, 10);
					Match("-=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DASH_EQ", 37);
				LeaveRule("DASH_EQ", 37);
				Leave_DASH_EQ();
			}
		}
		// $ANTLR end "DASH_EQ"

		partial void Enter_STAR_EQ();
		partial void Leave_STAR_EQ();

		// $ANTLR start "STAR_EQ"
		[GrammarRule("STAR_EQ")]
		private void mSTAR_EQ() {
			Enter_STAR_EQ();
			EnterRule("STAR_EQ", 38);
			TraceIn("STAR_EQ", 38);
			try {
				int _type = STAR_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(636, 10);
					Match("*=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("STAR_EQ", 38);
				LeaveRule("STAR_EQ", 38);
				Leave_STAR_EQ();
			}
		}
		// $ANTLR end "STAR_EQ"

		partial void Enter_FSLASH_EQ();
		partial void Leave_FSLASH_EQ();

		// $ANTLR start "FSLASH_EQ"
		[GrammarRule("FSLASH_EQ")]
		private void mFSLASH_EQ() {
			Enter_FSLASH_EQ();
			EnterRule("FSLASH_EQ", 39);
			TraceIn("FSLASH_EQ", 39);
			try {
				int _type = FSLASH_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(637, 12);
					Match("/=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("FSLASH_EQ", 39);
				LeaveRule("FSLASH_EQ", 39);
				Leave_FSLASH_EQ();
			}
		}
		// $ANTLR end "FSLASH_EQ"

		partial void Enter_PER_EQ();
		partial void Leave_PER_EQ();

		// $ANTLR start "PER_EQ"
		[GrammarRule("PER_EQ")]
		private void mPER_EQ() {
			Enter_PER_EQ();
			EnterRule("PER_EQ", 40);
			TraceIn("PER_EQ", 40);
			try {
				int _type = PER_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(638, 10);
					Match("%=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("PER_EQ", 40);
				LeaveRule("PER_EQ", 40);
				Leave_PER_EQ();
			}
		}
		// $ANTLR end "PER_EQ"

		partial void Enter_DBLSTAR_EQ();
		partial void Leave_DBLSTAR_EQ();

		// $ANTLR start "DBLSTAR_EQ"
		[GrammarRule("DBLSTAR_EQ")]
		private void mDBLSTAR_EQ() {
			Enter_DBLSTAR_EQ();
			EnterRule("DBLSTAR_EQ", 41);
			TraceIn("DBLSTAR_EQ", 41);
			try {
				int _type = DBLSTAR_EQ;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(639, 13);
					Match("**=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DBLSTAR_EQ", 41);
				LeaveRule("DBLSTAR_EQ", 41);
				Leave_DBLSTAR_EQ();
			}
		}
		// $ANTLR end "DBLSTAR_EQ"

		partial void Enter_DOT();
		partial void Leave_DOT();

		// $ANTLR start "DOT"
		[GrammarRule("DOT")]
		private void mDOT() {
			Enter_DOT();
			EnterRule("DOT", 42);
			TraceIn("DOT", 42);
			try {
				int _type = DOT;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(640, 7);
					Match('.');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("DOT", 42);
				LeaveRule("DOT", 42);
				Leave_DOT();
			}
		}
		// $ANTLR end "DOT"

		partial void Enter_COMMA();
		partial void Leave_COMMA();

		// $ANTLR start "COMMA"
		[GrammarRule("COMMA")]
		private void mCOMMA() {
			Enter_COMMA();
			EnterRule("COMMA", 43);
			TraceIn("COMMA", 43);
			try {
				int _type = COMMA;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(641, 8);
					Match(',');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("COMMA", 43);
				LeaveRule("COMMA", 43);
				Leave_COMMA();
			}
		}
		// $ANTLR end "COMMA"

		partial void Enter_SEMI();
		partial void Leave_SEMI();

		// $ANTLR start "SEMI"
		[GrammarRule("SEMI")]
		private void mSEMI() {
			Enter_SEMI();
			EnterRule("SEMI", 44);
			TraceIn("SEMI", 44);
			try {
				int _type = SEMI;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(642, 7);
					Match(';');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("SEMI", 44);
				LeaveRule("SEMI", 44);
				Leave_SEMI();
			}
		}
		// $ANTLR end "SEMI"

		partial void Enter_LAMBDAOP();
		partial void Leave_LAMBDAOP();

		// $ANTLR start "LAMBDAOP"
		[GrammarRule("LAMBDAOP")]
		private void mLAMBDAOP() {
			Enter_LAMBDAOP();
			EnterRule("LAMBDAOP", 45);
			TraceIn("LAMBDAOP", 45);
			try {
				int _type = LAMBDAOP;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(643, 11);
					Match("=>");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("LAMBDAOP", 45);
				LeaveRule("LAMBDAOP", 45);
				Leave_LAMBDAOP();
			}
		}
		// $ANTLR end "LAMBDAOP"

		partial void Enter_LPAREN();
		partial void Leave_LPAREN();

		// $ANTLR start "LPAREN"
		[GrammarRule("LPAREN")]
		private void mLPAREN() {
			Enter_LPAREN();
			EnterRule("LPAREN", 46);
			TraceIn("LPAREN", 46);
			try {
				int _type = LPAREN;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(644, 9);
					Match('(');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("LPAREN", 46);
				LeaveRule("LPAREN", 46);
				Leave_LPAREN();
			}
		}
		// $ANTLR end "LPAREN"

		partial void Enter_RPAREN();
		partial void Leave_RPAREN();

		// $ANTLR start "RPAREN"
		[GrammarRule("RPAREN")]
		private void mRPAREN() {
			Enter_RPAREN();
			EnterRule("RPAREN", 47);
			TraceIn("RPAREN", 47);
			try {
				int _type = RPAREN;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(645, 9);
					Match(')');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("RPAREN", 47);
				LeaveRule("RPAREN", 47);
				Leave_RPAREN();
			}
		}
		// $ANTLR end "RPAREN"

		partial void Enter_LBRACE();
		partial void Leave_LBRACE();

		// $ANTLR start "LBRACE"
		[GrammarRule("LBRACE")]
		private void mLBRACE() {
			Enter_LBRACE();
			EnterRule("LBRACE", 48);
			TraceIn("LBRACE", 48);
			try {
				int _type = LBRACE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(646, 9);
					Match('{');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("LBRACE", 48);
				LeaveRule("LBRACE", 48);
				Leave_LBRACE();
			}
		}
		// $ANTLR end "LBRACE"

		partial void Enter_RBRACE();
		partial void Leave_RBRACE();

		// $ANTLR start "RBRACE"
		[GrammarRule("RBRACE")]
		private void mRBRACE() {
			Enter_RBRACE();
			EnterRule("RBRACE", 49);
			TraceIn("RBRACE", 49);
			try {
				int _type = RBRACE;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(647, 9);
					Match('}');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("RBRACE", 49);
				LeaveRule("RBRACE", 49);
				Leave_RBRACE();
			}
		}
		// $ANTLR end "RBRACE"

		partial void Enter_LBRACK();
		partial void Leave_LBRACK();

		// $ANTLR start "LBRACK"
		[GrammarRule("LBRACK")]
		private void mLBRACK() {
			Enter_LBRACK();
			EnterRule("LBRACK", 50);
			TraceIn("LBRACK", 50);
			try {
				int _type = LBRACK;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(648, 9);
					Match('[');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("LBRACK", 50);
				LeaveRule("LBRACK", 50);
				Leave_LBRACK();
			}
		}
		// $ANTLR end "LBRACK"

		partial void Enter_RBRACK();
		partial void Leave_RBRACK();

		// $ANTLR start "RBRACK"
		[GrammarRule("RBRACK")]
		private void mRBRACK() {
			Enter_RBRACK();
			EnterRule("RBRACK", 51);
			TraceIn("RBRACK", 51);
			try {
				int _type = RBRACK;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(649, 9);
					Match(']');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("RBRACK", 51);
				LeaveRule("RBRACK", 51);
				Leave_RBRACK();
			}
		}
		// $ANTLR end "RBRACK"

		partial void Enter_COMMENT();
		partial void Leave_COMMENT();

		// $ANTLR start "COMMENT"
		[GrammarRule("COMMENT")]
		private void mCOMMENT() {
			Enter_COMMENT();
			EnterRule("COMMENT", 52);
			TraceIn("COMMENT", 52);
			try {
				int _type = COMMENT;
				int _channel = DefaultTokenChannel;
				int alt8=3;
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
							DebugLocation(651, 7);
							Match("/*");

							DebugLocation(651, 12);
							try {
								DebugEnterSubRule(5);
								while (true) {
									int alt5=2;
									try {
										DebugEnterDecision(5, decisionCanBacktrack[5]);
										int LA5_0 = input.LA(1);

										if ((LA5_0 == '*')) {
											int LA5_1 = input.LA(2);

											if ((LA5_1 == '/')) {
												alt5 = 2;
											}
											else if (((LA5_1 >= '\u0000' && LA5_1 <= '.') || (LA5_1 >= '0' && LA5_1 <= '\uFFFF'))) {
												alt5 = 1;
											}


										}
										else if (((LA5_0 >= '\u0000' && LA5_0 <= ')') || (LA5_0 >= '+' && LA5_0 <= '\uFFFF'))) {
											alt5 = 1;
										}


									}
									finally { DebugExitDecision(5); }
									switch (alt5) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(651, 38);
												MatchAny();

											}
											break;

										default:
											goto loop5;
									}
								}

							loop5:
								;

							}
							finally { DebugExitSubRule(5); }

							DebugLocation(651, 43);
							Match("*/");

							DebugLocation(651, 49);
							Skip();

						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(652, 7);
							Match("/*");

							DebugLocation(652, 12);
							try {
								DebugEnterSubRule(6);
								while (true) {
									int alt6=2;
									try {
										DebugEnterDecision(6, decisionCanBacktrack[6]);
										int LA6_0 = input.LA(1);

										if (((LA6_0 >= '\u0000' && LA6_0 <= '\t') || (LA6_0 >= '\u000B' && LA6_0 <= '\uFFFF'))) {
											alt6 = 1;
										}


									}
									finally { DebugExitDecision(6); }
									switch (alt6) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(652, 13);
												if ((input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\uFFFF')) {
													input.Consume();

												}
												else {
													MismatchedSetException mse = new MismatchedSetException(null, input);
													DebugRecognitionException(mse);
													Recover(mse);
													throw mse;
												}


											}
											break;

										default:
											goto loop6;
									}
								}

							loop6:
								;

							}
							finally { DebugExitSubRule(6); }

							DebugLocation(652, 22);
							Skip();

						}
						break;
					case 3:
						DebugEnterAlt(3); {
							DebugLocation(653, 7);
							Match("//");

							DebugLocation(653, 12);
							try {
								DebugEnterSubRule(7);
								while (true) {
									int alt7=2;
									try {
										DebugEnterDecision(7, decisionCanBacktrack[7]);
										int LA7_0 = input.LA(1);

										if (((LA7_0 >= '\u0000' && LA7_0 <= '\t') || (LA7_0 >= '\u000B' && LA7_0 <= '\uFFFF'))) {
											alt7 = 1;
										}


									}
									finally { DebugExitDecision(7); }
									switch (alt7) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(653, 13);
												if ((input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\uFFFF')) {
													input.Consume();

												}
												else {
													MismatchedSetException mse = new MismatchedSetException(null, input);
													DebugRecognitionException(mse);
													Recover(mse);
													throw mse;
												}


											}
											break;

										default:
											goto loop7;
									}
								}

							loop7:
								;

							}
							finally { DebugExitSubRule(7); }

							DebugLocation(653, 22);
							Skip();

						}
						break;

				}
				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("COMMENT", 52);
				LeaveRule("COMMENT", 52);
				Leave_COMMENT();
			}
		}
		// $ANTLR end "COMMENT"

		partial void Enter_NULL();
		partial void Leave_NULL();

		// $ANTLR start "NULL"
		[GrammarRule("NULL")]
		private void mNULL() {
			Enter_NULL();
			EnterRule("NULL", 53);
			TraceIn("NULL", 53);
			try {
				int _type = NULL;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(656, 7);
					Match("null");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("NULL", 53);
				LeaveRule("NULL", 53);
				Leave_NULL();
			}
		}
		// $ANTLR end "NULL"

		partial void Enter_BOOL();
		partial void Leave_BOOL();

		// $ANTLR start "BOOL"
		[GrammarRule("BOOL")]
		private void mBOOL() {
			Enter_BOOL();
			EnterRule("BOOL", 54);
			TraceIn("BOOL", 54);
			try {
				int _type = BOOL;
				int _channel = DefaultTokenChannel;
				int alt9=2;
				try {
					DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0 == 't')) {
						alt9 = 1;
					}
					else if ((LA9_0 == 'f')) {
						alt9 = 2;
					}
					else {
						NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				finally { DebugExitDecision(9); }
				switch (alt9) {
					case 1:
						DebugEnterAlt(1); {
							DebugLocation(657, 7);
							Match("true");


						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(657, 16);
							Match("false");


						}
						break;

				}
				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("BOOL", 54);
				LeaveRule("BOOL", 54);
				Leave_BOOL();
			}
		}
		// $ANTLR end "BOOL"

		partial void Enter_REF();
		partial void Leave_REF();

		// $ANTLR start "REF"
		[GrammarRule("REF")]
		private void mREF() {
			Enter_REF();
			EnterRule("REF", 55);
			TraceIn("REF", 55);
			try {
				int _type = REF;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(658, 7);
					Match("ref");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("REF", 55);
				LeaveRule("REF", 55);
				Leave_REF();
			}
		}
		// $ANTLR end "REF"

		partial void Enter_OUT();
		partial void Leave_OUT();

		// $ANTLR start "OUT"
		[GrammarRule("OUT")]
		private void mOUT() {
			Enter_OUT();
			EnterRule("OUT", 56);
			TraceIn("OUT", 56);
			try {
				int _type = OUT;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(659, 7);
					Match("out");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("OUT", 56);
				LeaveRule("OUT", 56);
				Leave_OUT();
			}
		}
		// $ANTLR end "OUT"

		partial void Enter_NEW();
		partial void Leave_NEW();

		// $ANTLR start "NEW"
		[GrammarRule("NEW")]
		private void mNEW() {
			Enter_NEW();
			EnterRule("NEW", 57);
			TraceIn("NEW", 57);
			try {
				int _type = NEW;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(660, 7);
					Match("new");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("NEW", 57);
				LeaveRule("NEW", 57);
				Leave_NEW();
			}
		}
		// $ANTLR end "NEW"

		partial void Enter_ID();
		partial void Leave_ID();

		// $ANTLR start "ID"
		[GrammarRule("ID")]
		private void mID() {
			Enter_ID();
			EnterRule("ID", 58);
			TraceIn("ID", 58);
			try {
				int _type = ID;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(661, 6);
					int alt10=2;
					try {
						DebugEnterSubRule(10);
						try {
							DebugEnterDecision(10, decisionCanBacktrack[10]);
							int LA10_0 = input.LA(1);

							if ((LA10_0 == '@')) {
								alt10 = 1;
							}
						}
						finally { DebugExitDecision(10); }
						switch (alt10) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(661, 6);
									Match('@');

								}
								break;

						}
					}
					finally { DebugExitSubRule(10); }

					DebugLocation(661, 11);
					mIDENT_START();
					DebugLocation(661, 23);
					try {
						DebugEnterSubRule(11);
						while (true) {
							int alt11=2;
							try {
								DebugEnterDecision(11, decisionCanBacktrack[11]);
								int LA11_0 = input.LA(1);

								if (((LA11_0 >= '0' && LA11_0 <= '9') || (LA11_0 >= 'A' && LA11_0 <= 'Z') || LA11_0 == '\\' || LA11_0 == '_' || (LA11_0 >= 'a' && LA11_0 <= 'z'))) {
									alt11 = 1;
								}


							}
							finally { DebugExitDecision(11); }
							switch (alt11) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(661, 23);
										mIDENT_CONT();

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

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("ID", 58);
				LeaveRule("ID", 58);
				Leave_ID();
			}
		}
		// $ANTLR end "ID"

		partial void Enter_EINT();
		partial void Leave_EINT();

		// $ANTLR start "EINT"
		[GrammarRule("EINT")]
		private void mEINT() {
			Enter_EINT();
			EnterRule("EINT", 59);
			TraceIn("EINT", 59);
			try {
				int _type = EINT;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(662, 9);
					int cnt12=0;
					try {
						DebugEnterSubRule(12);
						while (true) {
							int alt12=2;
							try {
								DebugEnterDecision(12, decisionCanBacktrack[12]);
								int LA12_0 = input.LA(1);

								if (((LA12_0 >= '0' && LA12_0 <= '9'))) {
									alt12 = 1;
								}


							}
							finally { DebugExitDecision(12); }
							switch (alt12) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(662, 9);
										mDIGIT();

									}
									break;

								default:
									if (cnt12 >= 1)
										goto loop12;

									EarlyExitException eee12 = new EarlyExitException(12, input);
									DebugRecognitionException(eee12);
									throw eee12;
							}
							cnt12++;
						}
					loop12:
						;

					}
					finally { DebugExitSubRule(12); }

					DebugLocation(662, 16);
					if (input.LA(1) == 'E' || input.LA(1) == 'e') {
						input.Consume();

					}
					else {
						MismatchedSetException mse = new MismatchedSetException(null, input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;
					}

					DebugLocation(662, 26);
					int alt13=2;
					try {
						DebugEnterSubRule(13);
						try {
							DebugEnterDecision(13, decisionCanBacktrack[13]);
							int LA13_0 = input.LA(1);

							if ((LA13_0 == '+' || LA13_0 == '-')) {
								alt13 = 1;
							}
						}
						finally { DebugExitDecision(13); }
						switch (alt13) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(662, 26);
									if (input.LA(1) == '+' || input.LA(1) == '-') {
										input.Consume();

									}
									else {
										MismatchedSetException mse = new MismatchedSetException(null, input);
										DebugRecognitionException(mse);
										Recover(mse);
										throw mse;
									}


								}
								break;

						}
					}
					finally { DebugExitSubRule(13); }

					DebugLocation(662, 37);
					int cnt14=0;
					try {
						DebugEnterSubRule(14);
						while (true) {
							int alt14=2;
							try {
								DebugEnterDecision(14, decisionCanBacktrack[14]);
								int LA14_0 = input.LA(1);

								if (((LA14_0 >= '0' && LA14_0 <= '9'))) {
									alt14 = 1;
								}


							}
							finally { DebugExitDecision(14); }
							switch (alt14) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(662, 37);
										mDIGIT();

									}
									break;

								default:
									if (cnt14 >= 1)
										goto loop14;

									EarlyExitException eee14 = new EarlyExitException(14, input);
									DebugRecognitionException(eee14);
									throw eee14;
							}
							cnt14++;
						}
					loop14:
						;

					}
					finally { DebugExitSubRule(14); }

					DebugLocation(662, 44);
					int alt15=2;
					try {
						DebugEnterSubRule(15);
						try {
							DebugEnterDecision(15, decisionCanBacktrack[15]);
							int LA15_0 = input.LA(1);

							if ((LA15_0 == 'D' || LA15_0 == 'F' || LA15_0 == 'M' || LA15_0 == 'd' || LA15_0 == 'f' || LA15_0 == 'm')) {
								alt15 = 1;
							}
						}
						finally { DebugExitDecision(15); }
						switch (alt15) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(662, 44);
									if (input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm') {
										input.Consume();

									}
									else {
										MismatchedSetException mse = new MismatchedSetException(null, input);
										DebugRecognitionException(mse);
										Recover(mse);
										throw mse;
									}


								}
								break;

						}
					}
					finally { DebugExitSubRule(15); }


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("EINT", 59);
				LeaveRule("EINT", 59);
				Leave_EINT();
			}
		}
		// $ANTLR end "EINT"

		partial void Enter_EFLT();
		partial void Leave_EFLT();

		// $ANTLR start "EFLT"
		[GrammarRule("EFLT")]
		private void mEFLT() {
			Enter_EFLT();
			EnterRule("EFLT", 60);
			TraceIn("EFLT", 60);
			try {
				int _type = EFLT;
				int _channel = DefaultTokenChannel;
				int alt25=2;
				try {
					DebugEnterDecision(25, decisionCanBacktrack[25]);
					int LA25_0 = input.LA(1);

					if (((LA25_0 >= '0' && LA25_0 <= '9'))) {
						alt25 = 1;
					}
					else if ((LA25_0 == '.')) {
						alt25 = 2;
					}
					else {
						NoViableAltException nvae = new NoViableAltException("", 25, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				finally { DebugExitDecision(25); }
				switch (alt25) {
					case 1:
						DebugEnterAlt(1); {
							DebugLocation(663, 8);
							int cnt16=0;
							try {
								DebugEnterSubRule(16);
								while (true) {
									int alt16=2;
									try {
										DebugEnterDecision(16, decisionCanBacktrack[16]);
										int LA16_0 = input.LA(1);

										if (((LA16_0 >= '0' && LA16_0 <= '9'))) {
											alt16 = 1;
										}


									}
									finally { DebugExitDecision(16); }
									switch (alt16) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(663, 8);
												mDIGIT();

											}
											break;

										default:
											if (cnt16 >= 1)
												goto loop16;

											EarlyExitException eee16 = new EarlyExitException(16, input);
											DebugRecognitionException(eee16);
											throw eee16;
									}
									cnt16++;
								}
							loop16:
								;

							}
							finally { DebugExitSubRule(16); }

							DebugLocation(663, 15);
							mDOT();
							DebugLocation(663, 19);
							int cnt17=0;
							try {
								DebugEnterSubRule(17);
								while (true) {
									int alt17=2;
									try {
										DebugEnterDecision(17, decisionCanBacktrack[17]);
										int LA17_0 = input.LA(1);

										if (((LA17_0 >= '0' && LA17_0 <= '9'))) {
											alt17 = 1;
										}


									}
									finally { DebugExitDecision(17); }
									switch (alt17) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(663, 19);
												mDIGIT();

											}
											break;

										default:
											if (cnt17 >= 1)
												goto loop17;

											EarlyExitException eee17 = new EarlyExitException(17, input);
											DebugRecognitionException(eee17);
											throw eee17;
									}
									cnt17++;
								}
							loop17:
								;

							}
							finally { DebugExitSubRule(17); }

							DebugLocation(663, 26);
							if (input.LA(1) == 'E' || input.LA(1) == 'e') {
								input.Consume();

							}
							else {
								MismatchedSetException mse = new MismatchedSetException(null, input);
								DebugRecognitionException(mse);
								Recover(mse);
								throw mse;
							}

							DebugLocation(663, 36);
							int alt18=2;
							try {
								DebugEnterSubRule(18);
								try {
									DebugEnterDecision(18, decisionCanBacktrack[18]);
									int LA18_0 = input.LA(1);

									if ((LA18_0 == '+' || LA18_0 == '-')) {
										alt18 = 1;
									}
								}
								finally { DebugExitDecision(18); }
								switch (alt18) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(663, 36);
											if (input.LA(1) == '+' || input.LA(1) == '-') {
												input.Consume();

											}
											else {
												MismatchedSetException mse = new MismatchedSetException(null, input);
												DebugRecognitionException(mse);
												Recover(mse);
												throw mse;
											}


										}
										break;

								}
							}
							finally { DebugExitSubRule(18); }

							DebugLocation(663, 47);
							int cnt19=0;
							try {
								DebugEnterSubRule(19);
								while (true) {
									int alt19=2;
									try {
										DebugEnterDecision(19, decisionCanBacktrack[19]);
										int LA19_0 = input.LA(1);

										if (((LA19_0 >= '0' && LA19_0 <= '9'))) {
											alt19 = 1;
										}


									}
									finally { DebugExitDecision(19); }
									switch (alt19) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(663, 47);
												mDIGIT();

											}
											break;

										default:
											if (cnt19 >= 1)
												goto loop19;

											EarlyExitException eee19 = new EarlyExitException(19, input);
											DebugRecognitionException(eee19);
											throw eee19;
									}
									cnt19++;
								}
							loop19:
								;

							}
							finally { DebugExitSubRule(19); }

							DebugLocation(663, 54);
							int alt20=2;
							try {
								DebugEnterSubRule(20);
								try {
									DebugEnterDecision(20, decisionCanBacktrack[20]);
									int LA20_0 = input.LA(1);

									if ((LA20_0 == 'D' || LA20_0 == 'F' || LA20_0 == 'M' || LA20_0 == 'd' || LA20_0 == 'f' || LA20_0 == 'm')) {
										alt20 = 1;
									}
								}
								finally { DebugExitDecision(20); }
								switch (alt20) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(663, 54);
											if (input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm') {
												input.Consume();

											}
											else {
												MismatchedSetException mse = new MismatchedSetException(null, input);
												DebugRecognitionException(mse);
												Recover(mse);
												throw mse;
											}


										}
										break;

								}
							}
							finally { DebugExitSubRule(20); }


						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(664, 4);
							mDOT();
							DebugLocation(664, 8);
							int cnt21=0;
							try {
								DebugEnterSubRule(21);
								while (true) {
									int alt21=2;
									try {
										DebugEnterDecision(21, decisionCanBacktrack[21]);
										int LA21_0 = input.LA(1);

										if (((LA21_0 >= '0' && LA21_0 <= '9'))) {
											alt21 = 1;
										}


									}
									finally { DebugExitDecision(21); }
									switch (alt21) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(664, 8);
												mDIGIT();

											}
											break;

										default:
											if (cnt21 >= 1)
												goto loop21;

											EarlyExitException eee21 = new EarlyExitException(21, input);
											DebugRecognitionException(eee21);
											throw eee21;
									}
									cnt21++;
								}
							loop21:
								;

							}
							finally { DebugExitSubRule(21); }

							DebugLocation(664, 15);
							if (input.LA(1) == 'E' || input.LA(1) == 'e') {
								input.Consume();

							}
							else {
								MismatchedSetException mse = new MismatchedSetException(null, input);
								DebugRecognitionException(mse);
								Recover(mse);
								throw mse;
							}

							DebugLocation(664, 25);
							int alt22=2;
							try {
								DebugEnterSubRule(22);
								try {
									DebugEnterDecision(22, decisionCanBacktrack[22]);
									int LA22_0 = input.LA(1);

									if ((LA22_0 == '+' || LA22_0 == '-')) {
										alt22 = 1;
									}
								}
								finally { DebugExitDecision(22); }
								switch (alt22) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(664, 25);
											if (input.LA(1) == '+' || input.LA(1) == '-') {
												input.Consume();

											}
											else {
												MismatchedSetException mse = new MismatchedSetException(null, input);
												DebugRecognitionException(mse);
												Recover(mse);
												throw mse;
											}


										}
										break;

								}
							}
							finally { DebugExitSubRule(22); }

							DebugLocation(664, 36);
							int cnt23=0;
							try {
								DebugEnterSubRule(23);
								while (true) {
									int alt23=2;
									try {
										DebugEnterDecision(23, decisionCanBacktrack[23]);
										int LA23_0 = input.LA(1);

										if (((LA23_0 >= '0' && LA23_0 <= '9'))) {
											alt23 = 1;
										}


									}
									finally { DebugExitDecision(23); }
									switch (alt23) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(664, 36);
												mDIGIT();

											}
											break;

										default:
											if (cnt23 >= 1)
												goto loop23;

											EarlyExitException eee23 = new EarlyExitException(23, input);
											DebugRecognitionException(eee23);
											throw eee23;
									}
									cnt23++;
								}
							loop23:
								;

							}
							finally { DebugExitSubRule(23); }

							DebugLocation(664, 43);
							int alt24=2;
							try {
								DebugEnterSubRule(24);
								try {
									DebugEnterDecision(24, decisionCanBacktrack[24]);
									int LA24_0 = input.LA(1);

									if ((LA24_0 == 'D' || LA24_0 == 'F' || LA24_0 == 'M' || LA24_0 == 'd' || LA24_0 == 'f' || LA24_0 == 'm')) {
										alt24 = 1;
									}
								}
								finally { DebugExitDecision(24); }
								switch (alt24) {
									case 1:
										DebugEnterAlt(1); {
											DebugLocation(664, 43);
											if (input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm') {
												input.Consume();

											}
											else {
												MismatchedSetException mse = new MismatchedSetException(null, input);
												DebugRecognitionException(mse);
												Recover(mse);
												throw mse;
											}


										}
										break;

								}
							}
							finally { DebugExitSubRule(24); }


						}
						break;

				}
				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("EFLT", 60);
				LeaveRule("EFLT", 60);
				Leave_EFLT();
			}
		}
		// $ANTLR end "EFLT"

		partial void Enter_CH_INT();
		partial void Leave_CH_INT();

		// $ANTLR start "CH_INT"
		[GrammarRule("CH_INT")]
		private void mCH_INT() {
			Enter_CH_INT();
			EnterRule("CH_INT", 61);
			TraceIn("CH_INT", 61);
			try {
				int _type = CH_INT;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(666, 9);
					int cnt26=0;
					try {
						DebugEnterSubRule(26);
						while (true) {
							int alt26=2;
							try {
								DebugEnterDecision(26, decisionCanBacktrack[26]);
								int LA26_0 = input.LA(1);

								if (((LA26_0 >= '0' && LA26_0 <= '9'))) {
									alt26 = 1;
								}


							}
							finally { DebugExitDecision(26); }
							switch (alt26) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(666, 9);
										mDIGIT();

									}
									break;

								default:
									if (cnt26 >= 1)
										goto loop26;

									EarlyExitException eee26 = new EarlyExitException(26, input);
									DebugRecognitionException(eee26);
									throw eee26;
							}
							cnt26++;
						}
					loop26:
						;

					}
					finally { DebugExitSubRule(26); }

					DebugLocation(666, 16);
					mDOT();

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("CH_INT", 61);
				LeaveRule("CH_INT", 61);
				Leave_CH_INT();
			}
		}
		// $ANTLR end "CH_INT"

		partial void Enter_INT();
		partial void Leave_INT();

		// $ANTLR start "INT"
		[GrammarRule("INT")]
		private void mINT() {
			Enter_INT();
			EnterRule("INT", 62);
			TraceIn("INT", 62);
			try {
				int _type = INT;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(667, 7);
					int cnt27=0;
					try {
						DebugEnterSubRule(27);
						while (true) {
							int alt27=2;
							try {
								DebugEnterDecision(27, decisionCanBacktrack[27]);
								int LA27_0 = input.LA(1);

								if (((LA27_0 >= '0' && LA27_0 <= '9'))) {
									alt27 = 1;
								}


							}
							finally { DebugExitDecision(27); }
							switch (alt27) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(667, 7);
										mDIGIT();

									}
									break;

								default:
									if (cnt27 >= 1)
										goto loop27;

									EarlyExitException eee27 = new EarlyExitException(27, input);
									DebugRecognitionException(eee27);
									throw eee27;
							}
							cnt27++;
						}
					loop27:
						;

					}
					finally { DebugExitSubRule(27); }


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("INT", 62);
				LeaveRule("INT", 62);
				Leave_INT();
			}
		}
		// $ANTLR end "INT"

		partial void Enter_FLT();
		partial void Leave_FLT();

		// $ANTLR start "FLT"
		[GrammarRule("FLT")]
		private void mFLT() {
			Enter_FLT();
			EnterRule("FLT", 63);
			TraceIn("FLT", 63);
			try {
				int _type = FLT;
				int _channel = DefaultTokenChannel;
				int alt31=2;
				try {
					DebugEnterDecision(31, decisionCanBacktrack[31]);
					int LA31_0 = input.LA(1);

					if (((LA31_0 >= '0' && LA31_0 <= '9'))) {
						alt31 = 1;
					}
					else if ((LA31_0 == '.')) {
						alt31 = 2;
					}
					else {
						NoViableAltException nvae = new NoViableAltException("", 31, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				finally { DebugExitDecision(31); }
				switch (alt31) {
					case 1:
						DebugEnterAlt(1); {
							DebugLocation(668, 8);
							int cnt28=0;
							try {
								DebugEnterSubRule(28);
								while (true) {
									int alt28=2;
									try {
										DebugEnterDecision(28, decisionCanBacktrack[28]);
										int LA28_0 = input.LA(1);

										if (((LA28_0 >= '0' && LA28_0 <= '9'))) {
											alt28 = 1;
										}


									}
									finally { DebugExitDecision(28); }
									switch (alt28) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(668, 8);
												mDIGIT();

											}
											break;

										default:
											if (cnt28 >= 1)
												goto loop28;

											EarlyExitException eee28 = new EarlyExitException(28, input);
											DebugRecognitionException(eee28);
											throw eee28;
									}
									cnt28++;
								}
							loop28:
								;

							}
							finally { DebugExitSubRule(28); }

							DebugLocation(668, 15);
							mDOT();
							DebugLocation(668, 19);
							int cnt29=0;
							try {
								DebugEnterSubRule(29);
								while (true) {
									int alt29=2;
									try {
										DebugEnterDecision(29, decisionCanBacktrack[29]);
										int LA29_0 = input.LA(1);

										if (((LA29_0 >= '0' && LA29_0 <= '9'))) {
											alt29 = 1;
										}


									}
									finally { DebugExitDecision(29); }
									switch (alt29) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(668, 19);
												mDIGIT();

											}
											break;

										default:
											if (cnt29 >= 1)
												goto loop29;

											EarlyExitException eee29 = new EarlyExitException(29, input);
											DebugRecognitionException(eee29);
											throw eee29;
									}
									cnt29++;
								}
							loop29:
								;

							}
							finally { DebugExitSubRule(29); }


						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(669, 4);
							mDOT();
							DebugLocation(669, 8);
							int cnt30=0;
							try {
								DebugEnterSubRule(30);
								while (true) {
									int alt30=2;
									try {
										DebugEnterDecision(30, decisionCanBacktrack[30]);
										int LA30_0 = input.LA(1);

										if (((LA30_0 >= '0' && LA30_0 <= '9'))) {
											alt30 = 1;
										}


									}
									finally { DebugExitDecision(30); }
									switch (alt30) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(669, 8);
												mDIGIT();

											}
											break;

										default:
											if (cnt30 >= 1)
												goto loop30;

											EarlyExitException eee30 = new EarlyExitException(30, input);
											DebugRecognitionException(eee30);
											throw eee30;
									}
									cnt30++;
								}
							loop30:
								;

							}
							finally { DebugExitSubRule(30); }


						}
						break;

				}
				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("FLT", 63);
				LeaveRule("FLT", 63);
				Leave_FLT();
			}
		}
		// $ANTLR end "FLT"

		partial void Enter_INTWITHSUFFIX();
		partial void Leave_INTWITHSUFFIX();

		// $ANTLR start "INTWITHSUFFIX"
		[GrammarRule("INTWITHSUFFIX")]
		private void mINTWITHSUFFIX() {
			Enter_INTWITHSUFFIX();
			EnterRule("INTWITHSUFFIX", 64);
			TraceIn("INTWITHSUFFIX", 64);
			try {
				int _type = INTWITHSUFFIX;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(672, 4);
					mINT();
					DebugLocation(672, 8);
					int alt32=14;
					try {
						DebugEnterSubRule(32);
						try {
							DebugEnterDecision(32, decisionCanBacktrack[32]);
							try {
								alt32 = dfa32.Predict(input);
							}
							catch (NoViableAltException nvae) {
								DebugRecognitionException(nvae);
								throw;
							}
						}
						finally { DebugExitDecision(32); }
						switch (alt32) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(672, 9);
									Match('f');

								}
								break;
							case 2:
								DebugEnterAlt(2); {
									DebugLocation(672, 13);
									Match('F');

								}
								break;
							case 3:
								DebugEnterAlt(3); {
									DebugLocation(672, 17);
									Match('m');

								}
								break;
							case 4:
								DebugEnterAlt(4); {
									DebugLocation(672, 21);
									Match('M');

								}
								break;
							case 5:
								DebugEnterAlt(5); {
									DebugLocation(672, 25);
									Match('d');

								}
								break;
							case 6:
								DebugEnterAlt(6); {
									DebugLocation(672, 29);
									Match('D');

								}
								break;
							case 7:
								DebugEnterAlt(7); {
									DebugLocation(672, 33);
									Match('u');

								}
								break;
							case 8:
								DebugEnterAlt(8); {
									DebugLocation(672, 37);
									Match('U');

								}
								break;
							case 9:
								DebugEnterAlt(9); {
									DebugLocation(672, 41);
									Match('l');

								}
								break;
							case 10:
								DebugEnterAlt(10); {
									DebugLocation(672, 45);
									Match('L');

								}
								break;
							case 11:
								DebugEnterAlt(11); {
									DebugLocation(672, 49);
									Match("ul");


								}
								break;
							case 12:
								DebugEnterAlt(12); {
									DebugLocation(672, 54);
									Match("Ul");


								}
								break;
							case 13:
								DebugEnterAlt(13); {
									DebugLocation(672, 59);
									Match("uL");


								}
								break;
							case 14:
								DebugEnterAlt(14); {
									DebugLocation(672, 64);
									Match("UL");


								}
								break;

						}
					}
					finally { DebugExitSubRule(32); }


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("INTWITHSUFFIX", 64);
				LeaveRule("INTWITHSUFFIX", 64);
				Leave_INTWITHSUFFIX();
			}
		}
		// $ANTLR end "INTWITHSUFFIX"

		partial void Enter_FLTWITHSUFFIX();
		partial void Leave_FLTWITHSUFFIX();

		// $ANTLR start "FLTWITHSUFFIX"
		[GrammarRule("FLTWITHSUFFIX")]
		private void mFLTWITHSUFFIX() {
			Enter_FLTWITHSUFFIX();
			EnterRule("FLTWITHSUFFIX", 65);
			TraceIn("FLTWITHSUFFIX", 65);
			try {
				int _type = FLTWITHSUFFIX;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(675, 4);
					mFLT();
					DebugLocation(675, 8);
					if (input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm') {
						input.Consume();

					}
					else {
						MismatchedSetException mse = new MismatchedSetException(null, input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("FLTWITHSUFFIX", 65);
				LeaveRule("FLTWITHSUFFIX", 65);
				Leave_FLTWITHSUFFIX();
			}
		}
		// $ANTLR end "FLTWITHSUFFIX"

		partial void Enter_CHAR();
		partial void Leave_CHAR();

		// $ANTLR start "CHAR"
		[GrammarRule("CHAR")]
		private void mCHAR() {
			Enter_CHAR();
			EnterRule("CHAR", 66);
			TraceIn("CHAR", 66);
			try {
				int _type = CHAR;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(677, 7);
					Match('\'');
					DebugLocation(677, 12);
					int alt33=2;
					try {
						DebugEnterSubRule(33);
						try {
							DebugEnterDecision(33, decisionCanBacktrack[33]);
							int LA33_0 = input.LA(1);

							if ((LA33_0 == '\\')) {
								alt33 = 1;
							}
							else if (((LA33_0 >= '\u0000' && LA33_0 <= '[') || (LA33_0 >= ']' && LA33_0 <= '\uFFFF'))) {
								alt33 = 2;
							}
							else {
								NoViableAltException nvae = new NoViableAltException("", 33, 0, input);

								DebugRecognitionException(nvae);
								throw nvae;
							}
						}
						finally { DebugExitDecision(33); }
						switch (alt33) {
							case 1:
								DebugEnterAlt(1); {
									DebugLocation(677, 13);
									DebugEnterAlt(1);
									{
										DebugLocation(677, 14);
										Match('\\');
										DebugLocation(677, 19);
										mESC_SEQ();

									}


								}
								break;
							case 2:
								DebugEnterAlt(2); {
									DebugLocation(677, 30);
									if ((input.LA(1) >= '\u0000' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF')) {
										input.Consume();

									}
									else {
										MismatchedSetException mse = new MismatchedSetException(null, input);
										DebugRecognitionException(mse);
										Recover(mse);
										throw mse;
									}


								}
								break;

						}
					}
					finally { DebugExitSubRule(33); }

					DebugLocation(677, 37);
					Match('\'');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("CHAR", 66);
				LeaveRule("CHAR", 66);
				Leave_CHAR();
			}
		}
		// $ANTLR end "CHAR"

		partial void Enter_STR();
		partial void Leave_STR();

		// $ANTLR start "STR"
		[GrammarRule("STR")]
		private void mSTR() {
			Enter_STR();
			EnterRule("STR", 67);
			TraceIn("STR", 67);
			try {
				int _type = STR;
				int _channel = DefaultTokenChannel;
				int alt36=2;
				try {
					DebugEnterDecision(36, decisionCanBacktrack[36]);
					int LA36_0 = input.LA(1);

					if ((LA36_0 == '\"')) {
						alt36 = 1;
					}
					else if ((LA36_0 == '@')) {
						alt36 = 2;
					}
					else {
						NoViableAltException nvae = new NoViableAltException("", 36, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				finally { DebugExitDecision(36); }
				switch (alt36) {
					case 1:
						DebugEnterAlt(1); {
							DebugLocation(678, 7);
							Match('\"');
							DebugLocation(678, 11);
							try {
								DebugEnterSubRule(34);
								while (true) {
									int alt34=3;
									try {
										DebugEnterDecision(34, decisionCanBacktrack[34]);
										int LA34_0 = input.LA(1);

										if ((LA34_0 == '\"')) {
											alt34 = 3;
										}
										else if ((LA34_0 == '\\')) {
											alt34 = 1;
										}
										else if (((LA34_0 >= '\u0000' && LA34_0 <= '!') || (LA34_0 >= '#' && LA34_0 <= '[') || (LA34_0 >= ']' && LA34_0 <= '\uFFFF'))) {
											alt34 = 2;
										}


									}
									finally { DebugExitDecision(34); }
									switch (alt34) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(678, 37);
												DebugEnterAlt(1);
												{
													DebugLocation(678, 38);
													Match('\\');
													DebugLocation(678, 43);
													mESC_SEQ();

												}


											}
											break;
										case 2:
											DebugEnterAlt(2); {
												DebugLocation(678, 54);
												if ((input.LA(1) >= '\u0000' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF')) {
													input.Consume();

												}
												else {
													MismatchedSetException mse = new MismatchedSetException(null, input);
													DebugRecognitionException(mse);
													Recover(mse);
													throw mse;
												}


											}
											break;

										default:
											goto loop34;
									}
								}

							loop34:
								;

							}
							finally { DebugExitSubRule(34); }

							DebugLocation(678, 62);
							Match('\"');

						}
						break;
					case 2:
						DebugEnterAlt(2); {
							DebugLocation(679, 4);
							Match('@');
							DebugLocation(679, 8);
							Match('\"');
							DebugLocation(679, 12);
							try {
								DebugEnterSubRule(35);
								while (true) {
									int alt35=3;
									try {
										DebugEnterDecision(35, decisionCanBacktrack[35]);
										int LA35_0 = input.LA(1);

										if ((LA35_0 == '\"')) {
											int LA35_1 = input.LA(2);

											if ((LA35_1 == '\"')) {
												alt35 = 1;
											}


										}
										else if (((LA35_0 >= '\u0000' && LA35_0 <= '!') || (LA35_0 >= '#' && LA35_0 <= '\uFFFF'))) {
											alt35 = 2;
										}


									}
									finally { DebugExitDecision(35); }
									switch (alt35) {
										case 1:
											DebugEnterAlt(1); {
												DebugLocation(679, 13);
												Match("\"\"");


											}
											break;
										case 2:
											DebugEnterAlt(2); {
												DebugLocation(679, 20);
												if ((input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF')) {
													input.Consume();

												}
												else {
													MismatchedSetException mse = new MismatchedSetException(null, input);
													DebugRecognitionException(mse);
													Recover(mse);
													throw mse;
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

							DebugLocation(679, 27);
							Match('\"');

						}
						break;

				}
				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("STR", 67);
				LeaveRule("STR", 67);
				Leave_STR();
			}
		}
		// $ANTLR end "STR"

		partial void Enter_WS();
		partial void Leave_WS();

		// $ANTLR start "WS"
		[GrammarRule("WS")]
		private void mWS() {
			Enter_WS();
			EnterRule("WS", 68);
			TraceIn("WS", 68);
			try {
				int _type = WS;
				int _channel = DefaultTokenChannel;
				DebugEnterAlt(1);
				{
					DebugLocation(681, 6);
					int cnt37=0;
					try {
						DebugEnterSubRule(37);
						while (true) {
							int alt37=2;
							try {
								DebugEnterDecision(37, decisionCanBacktrack[37]);
								int LA37_0 = input.LA(1);

								if (((LA37_0 >= '\t' && LA37_0 <= '\n') || LA37_0 == '\r' || LA37_0 == ' ')) {
									alt37 = 1;
								}


							}
							finally { DebugExitDecision(37); }
							switch (alt37) {
								case 1:
									DebugEnterAlt(1); {
										DebugLocation(681, 6);
										mWHITESPACE();

									}
									break;

								default:
									if (cnt37 >= 1)
										goto loop37;

									EarlyExitException eee37 = new EarlyExitException(37, input);
									DebugRecognitionException(eee37);
									throw eee37;
							}
							cnt37++;
						}
					loop37:
						;

					}
					finally { DebugExitSubRule(37); }

					DebugLocation(681, 18);
					Skip();

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally {
				TraceOut("WS", 68);
				LeaveRule("WS", 68);
				Leave_WS();
			}
		}
		// $ANTLR end "WS"

		public override void mTokens() {
			int alt38=60;
			try {
				DebugEnterDecision(38, decisionCanBacktrack[38]);
				try {
					alt38 = dfa38.Predict(input);
				}
				catch (NoViableAltException nvae) {
					DebugRecognitionException(nvae);
					throw;
				}
			}
			finally { DebugExitDecision(38); }
			switch (alt38) {
				case 1:
					DebugEnterAlt(1); {
						DebugLocation(1, 10);
						mTERMCONST();

					}
					break;
				case 2:
					DebugEnterAlt(2); {
						DebugLocation(1, 20);
						mEQ();

					}
					break;
				case 3:
					DebugEnterAlt(3); {
						DebugLocation(1, 23);
						mDBL_EQ();

					}
					break;
				case 4:
					DebugEnterAlt(4); {
						DebugLocation(1, 30);
						mBANG_EQ();

					}
					break;
				case 5:
					DebugEnterAlt(5); {
						DebugLocation(1, 38);
						mLANGLE_EQ();

					}
					break;
				case 6:
					DebugEnterAlt(6); {
						DebugLocation(1, 48);
						mRANGLE_EQ();

					}
					break;
				case 7:
					DebugEnterAlt(7); {
						DebugLocation(1, 58);
						mLANGLE();

					}
					break;
				case 8:
					DebugEnterAlt(8); {
						DebugLocation(1, 65);
						mRANGLE();

					}
					break;
				case 9:
					DebugEnterAlt(9); {
						DebugLocation(1, 72);
						mDBLLANGLE();

					}
					break;
				case 10:
					DebugEnterAlt(10); {
						DebugLocation(1, 82);
						mDBLRANGLE();

					}
					break;
				case 11:
					DebugEnterAlt(11); {
						DebugLocation(1, 92);
						mPIPE();

					}
					break;
				case 12:
					DebugEnterAlt(12); {
						DebugLocation(1, 97);
						mDBLPIPE();

					}
					break;
				case 13:
					DebugEnterAlt(13); {
						DebugLocation(1, 105);
						mAMP();

					}
					break;
				case 14:
					DebugEnterAlt(14); {
						DebugLocation(1, 109);
						mDBLAMP();

					}
					break;
				case 15:
					DebugEnterAlt(15); {
						DebugLocation(1, 116);
						mHAT();

					}
					break;
				case 16:
					DebugEnterAlt(16); {
						DebugLocation(1, 120);
						mBANG();

					}
					break;
				case 17:
					DebugEnterAlt(17); {
						DebugLocation(1, 125);
						mTILDE();

					}
					break;
				case 18:
					DebugEnterAlt(18); {
						DebugLocation(1, 131);
						mQUESTION();

					}
					break;
				case 19:
					DebugEnterAlt(19); {
						DebugLocation(1, 140);
						mCOLON();

					}
					break;
				case 20:
					DebugEnterAlt(20); {
						DebugLocation(1, 146);
						mCROSS();

					}
					break;
				case 21:
					DebugEnterAlt(21); {
						DebugLocation(1, 152);
						mDASH();

					}
					break;
				case 22:
					DebugEnterAlt(22); {
						DebugLocation(1, 157);
						mSTAR();

					}
					break;
				case 23:
					DebugEnterAlt(23); {
						DebugLocation(1, 162);
						mFSLASH();

					}
					break;
				case 24:
					DebugEnterAlt(24); {
						DebugLocation(1, 169);
						mPER();

					}
					break;
				case 25:
					DebugEnterAlt(25); {
						DebugLocation(1, 173);
						mDBLSTAR();

					}
					break;
				case 26:
					DebugEnterAlt(26); {
						DebugLocation(1, 181);
						mDBLCROSS();

					}
					break;
				case 27:
					DebugEnterAlt(27); {
						DebugLocation(1, 190);
						mDBLDASH();

					}
					break;
				case 28:
					DebugEnterAlt(28); {
						DebugLocation(1, 198);
						mCROSS_EQ();

					}
					break;
				case 29:
					DebugEnterAlt(29); {
						DebugLocation(1, 207);
						mDASH_EQ();

					}
					break;
				case 30:
					DebugEnterAlt(30); {
						DebugLocation(1, 215);
						mSTAR_EQ();

					}
					break;
				case 31:
					DebugEnterAlt(31); {
						DebugLocation(1, 223);
						mFSLASH_EQ();

					}
					break;
				case 32:
					DebugEnterAlt(32); {
						DebugLocation(1, 233);
						mPER_EQ();

					}
					break;
				case 33:
					DebugEnterAlt(33); {
						DebugLocation(1, 240);
						mDBLSTAR_EQ();

					}
					break;
				case 34:
					DebugEnterAlt(34); {
						DebugLocation(1, 251);
						mDOT();

					}
					break;
				case 35:
					DebugEnterAlt(35); {
						DebugLocation(1, 255);
						mCOMMA();

					}
					break;
				case 36:
					DebugEnterAlt(36); {
						DebugLocation(1, 261);
						mSEMI();

					}
					break;
				case 37:
					DebugEnterAlt(37); {
						DebugLocation(1, 266);
						mLAMBDAOP();

					}
					break;
				case 38:
					DebugEnterAlt(38); {
						DebugLocation(1, 275);
						mLPAREN();

					}
					break;
				case 39:
					DebugEnterAlt(39); {
						DebugLocation(1, 282);
						mRPAREN();

					}
					break;
				case 40:
					DebugEnterAlt(40); {
						DebugLocation(1, 289);
						mLBRACE();

					}
					break;
				case 41:
					DebugEnterAlt(41); {
						DebugLocation(1, 296);
						mRBRACE();

					}
					break;
				case 42:
					DebugEnterAlt(42); {
						DebugLocation(1, 303);
						mLBRACK();

					}
					break;
				case 43:
					DebugEnterAlt(43); {
						DebugLocation(1, 310);
						mRBRACK();

					}
					break;
				case 44:
					DebugEnterAlt(44); {
						DebugLocation(1, 317);
						mCOMMENT();

					}
					break;
				case 45:
					DebugEnterAlt(45); {
						DebugLocation(1, 325);
						mNULL();

					}
					break;
				case 46:
					DebugEnterAlt(46); {
						DebugLocation(1, 330);
						mBOOL();

					}
					break;
				case 47:
					DebugEnterAlt(47); {
						DebugLocation(1, 335);
						mREF();

					}
					break;
				case 48:
					DebugEnterAlt(48); {
						DebugLocation(1, 339);
						mOUT();

					}
					break;
				case 49:
					DebugEnterAlt(49); {
						DebugLocation(1, 343);
						mNEW();

					}
					break;
				case 50:
					DebugEnterAlt(50); {
						DebugLocation(1, 347);
						mID();

					}
					break;
				case 51:
					DebugEnterAlt(51); {
						DebugLocation(1, 350);
						mEINT();

					}
					break;
				case 52:
					DebugEnterAlt(52); {
						DebugLocation(1, 355);
						mEFLT();

					}
					break;
				case 53:
					DebugEnterAlt(53); {
						DebugLocation(1, 360);
						mCH_INT();

					}
					break;
				case 54:
					DebugEnterAlt(54); {
						DebugLocation(1, 367);
						mINT();

					}
					break;
				case 55:
					DebugEnterAlt(55); {
						DebugLocation(1, 371);
						mFLT();

					}
					break;
				case 56:
					DebugEnterAlt(56); {
						DebugLocation(1, 375);
						mINTWITHSUFFIX();

					}
					break;
				case 57:
					DebugEnterAlt(57); {
						DebugLocation(1, 389);
						mFLTWITHSUFFIX();

					}
					break;
				case 58:
					DebugEnterAlt(58); {
						DebugLocation(1, 403);
						mCHAR();

					}
					break;
				case 59:
					DebugEnterAlt(59); {
						DebugLocation(1, 408);
						mSTR();

					}
					break;
				case 60:
					DebugEnterAlt(60); {
						DebugLocation(1, 412);
						mWS();

					}
					break;

			}

		}


		#region DFA
		DFA3 dfa3;
		DFA4 dfa4;
		DFA8 dfa8;
		DFA32 dfa32;
		DFA38 dfa38;

		protected override void InitDFAs() {
			base.InitDFAs();
			dfa3 = new DFA3(this);
			dfa4 = new DFA4(this);
			dfa8 = new DFA8(this, SpecialStateTransition8);
			dfa32 = new DFA32(this);
			dfa38 = new DFA38(this);
		}

		private class DFA3 : DFA {
			private const string DFA3_eotS =
			"\xF\xFFFF\x1\x10\x1\xFFFF\x1\x12\x1\xFFFF\x1\x14\x2\xFFFF";
			private const string DFA3_eofS =
			"\x16\xFFFF";
			private const string DFA3_minS =
			"\x1\x22\xB\xFFFF\x1\x30\x2\xFFFF\x1\x30\x1\xFFFF\x1\x30\x1\xFFFF\x1" +
				"\x30\x2\xFFFF";
			private const string DFA3_maxS =
			"\x1\x78\xB\xFFFF\x1\x66\x2\xFFFF\x1\x66\x1\xFFFF\x1\x66\x1\xFFFF\x1" +
				"\x66\x2\xFFFF";
			private const string DFA3_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x1\xA" +
				"\x1\xB\x1\xFFFF\x1\x10\x1\x11\x1\xFFFF\x1\xC\x1\xFFFF\x1\xD\x1\xFFFF" +
				"\x1\xE\x1\xF";
			private const string DFA3_specialS =
			"\x16\xFFFF}>";
			private static readonly string[] DFA3_transitionS =
			{
				"\x1\x9\x4\xFFFF\x1\xA\x8\xFFFF\x1\x8\x24\xFFFF\x1\xE\x6\xFFFF\x1\xB"+
				"\x4\xFFFF\x1\x1\x1\x2\x3\xFFFF\x1\x3\x7\xFFFF\x1\x4\x3\xFFFF\x1\x5\x1"+
				"\xFFFF\x1\x6\x1\xD\x1\x7\x1\xFFFF\x1\xC",
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
				"\xA\xF\x7\xFFFF\x6\xF\x1A\xFFFF\x6\xF",
				"",
				"",
				"\xA\x11\x7\xFFFF\x6\x11\x1A\xFFFF\x6\x11",
				"",
				"\xA\x13\x7\xFFFF\x6\x13\x1A\xFFFF\x6\x13",
				"",
				"\xA\x15\x7\xFFFF\x6\x15\x1A\xFFFF\x6\x15",
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

			public DFA3(BaseRecognizer recognizer) {
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

			public override string Description { get { return "585:10: fragment ESC_SEQ : ( 'a' | 'b' | 'f' | 'n' | 'r' | 't' | 'v' | '0' | '\\\"' | '\\'' | '\\\\' | 'x' HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT );"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private class DFA4 : DFA {
			private const string DFA4_eotS =
			"\x3\xFFFF\x1\xA\x7\xFFFF";
			private const string DFA4_eofS =
			"\xB\xFFFF";
			private const string DFA4_minS =
			"\x1\x43\x1\xFFFF\x1\x48\x1\x41\x7\xFFFF";
			private const string DFA4_maxS =
			"\x1\x50\x1\xFFFF\x1\x49\x1\x43\x7\xFFFF";
			private const string DFA4_acceptS =
			"\x1\xFFFF\x1\x1\x2\xFFFF\x1\x7\x1\x8\x1\x2\x1\x5\x1\x4\x1\x6\x1\x3";
			private const string DFA4_specialS =
			"\xB\xFFFF}>";
			private static readonly string[] DFA4_transitionS =
			{
				"\x1\x4\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\x5\x7\xFFFF\x1\x2",
				"",
				"\x1\x7\x1\x6",
				"\x1\x9\x1\xFFFF\x1\x8",
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

			public DFA4(BaseRecognizer recognizer) {
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

			public override string Description { get { return "607:16: ( 'E' | 'PI' | 'G' | 'GC' | 'PHI' | 'GAMMA' | 'C' | 'H' )"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private class DFA8 : DFA {
			private const string DFA8_eotS =
			"\x2\xFFFF\x1\x7\x1\xFFFF\x2\x7\x3\xFFFF";
			private const string DFA8_eofS =
			"\x9\xFFFF";
			private const string DFA8_minS =
			"\x1\x2F\x1\x2A\x1\x0\x1\xFFFF\x2\x0\x3\xFFFF";
			private const string DFA8_maxS =
			"\x2\x2F\x1\xFFFF\x1\xFFFF\x2\xFFFF\x3\xFFFF";
			private const string DFA8_acceptS =
			"\x3\xFFFF\x1\x3\x2\xFFFF\x1\x1\x1\x2\x1\x1";
			private const string DFA8_specialS =
			"\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x1\x0\x3\xFFFF}>";
			private static readonly string[] DFA8_transitionS =
			{
				"\x1\x1",
				"\x1\x2\x4\xFFFF\x1\x3",
				"\xA\x5\x1\x6\x1F\x5\x1\x4\xFFD5\x5",
				"",
				"\xA\x5\x1\x6\x1F\x5\x1\x4\x4\x5\x1\x8\xFFD0\x5",
				"\xA\x5\x1\x6\x1F\x5\x1\x4\xFFD5\x5",
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

			public override string Description { get { return "650:1: COMMENT : ( '/*' ( options {greedy=false; } : . )* '*/' | '/*' (~ '\\n' )* | '//' (~ '\\n' )* );"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private int SpecialStateTransition8(DFA dfa, int s, IIntStream _input) {
			IIntStream input = _input;
			int _s = s;
			switch (s) {

				case 0:
					int LA8_5 = input.LA(1);

					s = -1;
					if ((LA8_5 == '*')) { s = 4; }

					else if (((LA8_5 >= '\u0000' && LA8_5 <= '\t') || (LA8_5 >= '\u000B' && LA8_5 <= ')') || (LA8_5 >= '+' && LA8_5 <= '\uFFFF'))) { s = 5; }

					else if ((LA8_5 == '\n')) { s = 6; }

					else
						s = 7;

					if (s >= 0)
						return s;
					break;

				case 1:
					int LA8_4 = input.LA(1);

					s = -1;
					if ((LA8_4 == '/')) { s = 8; }

					else if ((LA8_4 == '*')) { s = 4; }

					else if (((LA8_4 >= '\u0000' && LA8_4 <= '\t') || (LA8_4 >= '\u000B' && LA8_4 <= ')') || (LA8_4 >= '+' && LA8_4 <= '.') || (LA8_4 >= '0' && LA8_4 <= '\uFFFF'))) { s = 5; }

					else if ((LA8_4 == '\n')) { s = 6; }

					else
						s = 7;

					if (s >= 0)
						return s;
					break;

				case 2:
					int LA8_2 = input.LA(1);

					s = -1;
					if ((LA8_2 == '*')) { s = 4; }

					else if (((LA8_2 >= '\u0000' && LA8_2 <= '\t') || (LA8_2 >= '\u000B' && LA8_2 <= ')') || (LA8_2 >= '+' && LA8_2 <= '\uFFFF'))) { s = 5; }

					else if ((LA8_2 == '\n')) { s = 6; }

					else
						s = 7;

					if (s >= 0)
						return s;
					break;
			}
			NoViableAltException nvae = new NoViableAltException(dfa.Description, 8, _s, input);
			dfa.Error(nvae);
			throw nvae;
		}
		private class DFA32 : DFA {
			private const string DFA32_eotS =
			"\x7\xFFFF\x1\xD\x1\x10\x8\xFFFF";
			private const string DFA32_eofS =
			"\x11\xFFFF";
			private const string DFA32_minS =
			"\x1\x44\x6\xFFFF\x2\x4C\x8\xFFFF";
			private const string DFA32_maxS =
			"\x1\x75\x6\xFFFF\x2\x6C\x8\xFFFF";
			private const string DFA32_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x2\xFFFF\x1\x9\x1\xA\x1" +
				"\xB\x1\xD\x1\x7\x1\xC\x1\xE\x1\x8";
			private const string DFA32_specialS =
			"\x11\xFFFF}>";
			private static readonly string[] DFA32_transitionS =
			{
				"\x1\x6\x1\xFFFF\x1\x2\x5\xFFFF\x1\xA\x1\x4\x7\xFFFF\x1\x8\xE\xFFFF"+
				"\x1\x5\x1\xFFFF\x1\x1\x5\xFFFF\x1\x9\x1\x3\x7\xFFFF\x1\x7",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xC\x1F\xFFFF\x1\xB",
				"\x1\xF\x1F\xFFFF\x1\xE",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

			private static readonly short[] DFA32_eot = DFA.UnpackEncodedString(DFA32_eotS);
			private static readonly short[] DFA32_eof = DFA.UnpackEncodedString(DFA32_eofS);
			private static readonly char[] DFA32_min = DFA.UnpackEncodedStringToUnsignedChars(DFA32_minS);
			private static readonly char[] DFA32_max = DFA.UnpackEncodedStringToUnsignedChars(DFA32_maxS);
			private static readonly short[] DFA32_accept = DFA.UnpackEncodedString(DFA32_acceptS);
			private static readonly short[] DFA32_special = DFA.UnpackEncodedString(DFA32_specialS);
			private static readonly short[][] DFA32_transition;

			static DFA32() {
				int numStates = DFA32_transitionS.Length;
				DFA32_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA32_transition[i] = DFA.UnpackEncodedString(DFA32_transitionS[i]);
				}
			}

			public DFA32(BaseRecognizer recognizer) {
				this.recognizer = recognizer;
				this.decisionNumber = 32;
				this.eot = DFA32_eot;
				this.eof = DFA32_eof;
				this.min = DFA32_min;
				this.max = DFA32_max;
				this.accept = DFA32_accept;
				this.special = DFA32_special;
				this.transition = DFA32_transition;
			}

			public override string Description { get { return "672:8: ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' | 'u' | 'U' | 'l' | 'L' | 'ul' | 'Ul' | 'uL' | 'UL' )"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}

		private class DFA38 : DFA {
			private const string DFA38_eotS =
			"\x2\xFFFF\x1\x27\x1\x29\x1\x2C\x1\x2F\x1\x31\x1\x33\x4\xFFFF\x1\x36" +
				"\x1\x39\x1\x3C\x1\x3F\x1\x41\x1\x42\x8\xFFFF\x5\x20\x2\xFFFF\x1\x4A\x18" +
				"\xFFFF\x1\x4F\x8\xFFFF\x1\x50\x6\x20\x2\xFFFF\x1\x59\x6\xFFFF\x1\x20" +
				"\x1\x5C\x2\x20\x1\x5F\x1\x60\x1\xFFFF\x1\x50\x1\x61\x1\xFFFF\x1\x62\x1" +
				"\x20\x4\xFFFF\x1\x62";
			private const string DFA38_eofS =
			"\x64\xFFFF";
			private const string DFA38_minS =
			"\x1\x9\x1\xFFFF\x2\x3D\x1\x3C\x1\x3D\x1\x7C\x1\x26\x4\xFFFF\x1\x2B\x1" +
				"\x2D\x2\x2A\x1\x3D\x1\x30\x8\xFFFF\x1\x65\x1\x72\x1\x61\x1\x65\x1\x75" +
				"\x1\x22\x1\xFFFF\x1\x2E\x18\xFFFF\x1\x3D\x8\xFFFF\x1\x30\x1\x6C\x1\x77" +
				"\x1\x75\x1\x6C\x1\x66\x1\x74\x2\xFFFF\x1\x30\x6\xFFFF\x1\x6C\x1\x30\x1" +
				"\x65\x1\x73\x2\x30\x1\xFFFF\x2\x30\x1\xFFFF\x1\x30\x1\x65\x4\xFFFF\x1" +
				"\x30";
			private const string DFA38_maxS =
			"\x1\x7E\x1\xFFFF\x1\x3E\x2\x3D\x1\x3E\x1\x7C\x1\x26\x4\xFFFF\x5\x3D" +
				"\x1\x39\x8\xFFFF\x1\x75\x1\x72\x1\x61\x1\x65\x1\x75\x1\x7A\x1\xFFFF\x1" +
				"\x75\x18\xFFFF\x1\x3D\x8\xFFFF\x1\x6D\x1\x6C\x1\x77\x1\x75\x1\x6C\x1" +
				"\x66\x1\x74\x2\xFFFF\x1\x39\x6\xFFFF\x1\x6C\x1\x7A\x1\x65\x1\x73\x2\x7A" +
				"\x1\xFFFF\x1\x6D\x1\x7A\x1\xFFFF\x1\x7A\x1\x65\x4\xFFFF\x1\x7A";
			private const string DFA38_acceptS =
			"\x1\xFFFF\x1\x1\x6\xFFFF\x1\xF\x1\x11\x1\x12\x1\x13\x6\xFFFF\x1\x23" +
				"\x1\x24\x1\x26\x1\x27\x1\x28\x1\x29\x1\x2A\x1\x2B\x6\xFFFF\x1\x32\x1" +
				"\xFFFF\x1\x3A\x1\x3B\x1\x3C\x1\x3\x1\x25\x1\x2\x1\x4\x1\x10\x1\x5\x1" +
				"\x9\x1\x7\x1\x6\x1\xA\x1\x8\x1\xC\x1\xB\x1\xE\x1\xD\x1\x1A\x1\x1C\x1" +
				"\x14\x1\x1B\x1\x1D\x1\x15\x1\xFFFF\x1\x1E\x1\x16\x1\x1F\x1\x2C\x1\x17" +
				"\x1\x20\x1\x18\x1\x22\x7\xFFFF\x1\x36\x1\x33\x1\xFFFF\x1\x38\x1\x21\x1" +
				"\x19\x1\x37\x1\x34\x1\x39\x6\xFFFF\x1\x35\x2\xFFFF\x1\x31\x2\xFFFF\x1" +
				"\x2F\x1\x30\x1\x2D\x1\x2E\x1\xFFFF";
			private const string DFA38_specialS =
			"\x64\xFFFF}>";
			private static readonly string[] DFA38_transitionS =
			{
				"\x2\x24\x2\xFFFF\x1\x24\x12\xFFFF\x1\x24\x1\x3\x1\x23\x1\x1\x1\xFFFF"+
				"\x1\x10\x1\x7\x1\x22\x1\x14\x1\x15\x1\xE\x1\xC\x1\x12\x1\xD\x1\x11\x1"+
				"\xF\xA\x21\x1\xB\x1\x13\x1\x4\x1\x2\x1\x5\x1\xA\x1\x1F\x1A\x20\x1\x18"+
				"\x1\x20\x1\x19\x1\x8\x1\x20\x1\xFFFF\x5\x20\x1\x1C\x7\x20\x1\x1A\x1"+
				"\x1E\x2\x20\x1\x1D\x1\x20\x1\x1B\x6\x20\x1\x16\x1\x6\x1\x17\x1\x9",
				"",
				"\x1\x25\x1\x26",
				"\x1\x28",
				"\x1\x2B\x1\x2A",
				"\x1\x2D\x1\x2E",
				"\x1\x30",
				"\x1\x32",
				"",
				"",
				"",
				"",
				"\x1\x34\x11\xFFFF\x1\x35",
				"\x1\x37\xF\xFFFF\x1\x38",
				"\x1\x3A\x12\xFFFF\x1\x3B",
				"\x1\x3E\x4\xFFFF\x1\x3E\xD\xFFFF\x1\x3D",
				"\x1\x40",
				"\xA\x43",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x45\xF\xFFFF\x1\x44",
				"\x1\x46",
				"\x1\x47",
				"\x1\x48",
				"\x1\x49",
				"\x1\x23\x1E\xFFFF\x1A\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x20\x1\xFFFF"+
				"\x1A\x20",
				"",
				"\x1\x4C\x1\xFFFF\xA\x21\xA\xFFFF\x1\x4D\x1\x4B\x1\x4D\x5\xFFFF\x2"+
				"\x4D\x7\xFFFF\x1\x4D\xE\xFFFF\x1\x4D\x1\x4B\x1\x4D\x5\xFFFF\x2\x4D\x7"+
				"\xFFFF\x1\x4D",
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
				"\x1\x4E",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\xA\x43\xA\xFFFF\x1\x52\x1\x51\x1\x52\x6\xFFFF\x1\x52\x16\xFFFF\x1"+
				"\x52\x1\x51\x1\x52\x6\xFFFF\x1\x52",
				"\x1\x53",
				"\x1\x54",
				"\x1\x55",
				"\x1\x56",
				"\x1\x57",
				"\x1\x58",
				"",
				"",
				"\xA\x5A",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x5B",
				"\xA\x20\x7\xFFFF\x1A\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x20\x1\xFFFF"+
				"\x1A\x20",
				"\x1\x5D",
				"\x1\x5E",
				"\xA\x20\x7\xFFFF\x1A\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x20\x1\xFFFF"+
				"\x1A\x20",
				"\xA\x20\x7\xFFFF\x1A\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x20\x1\xFFFF"+
				"\x1A\x20",
				"",
				"\xA\x5A\xA\xFFFF\x1\x52\x1\x51\x1\x52\x6\xFFFF\x1\x52\x16\xFFFF\x1"+
				"\x52\x1\x51\x1\x52\x6\xFFFF\x1\x52",
				"\xA\x20\x7\xFFFF\x1A\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x20\x1\xFFFF"+
				"\x1A\x20",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x20\x1\xFFFF"+
				"\x1A\x20",
				"\x1\x63",
				"",
				"",
				"",
				"",
				"\xA\x20\x7\xFFFF\x1A\x20\x1\xFFFF\x1\x20\x2\xFFFF\x1\x20\x1\xFFFF"+
				"\x1A\x20"
			};

			private static readonly short[] DFA38_eot = DFA.UnpackEncodedString(DFA38_eotS);
			private static readonly short[] DFA38_eof = DFA.UnpackEncodedString(DFA38_eofS);
			private static readonly char[] DFA38_min = DFA.UnpackEncodedStringToUnsignedChars(DFA38_minS);
			private static readonly char[] DFA38_max = DFA.UnpackEncodedStringToUnsignedChars(DFA38_maxS);
			private static readonly short[] DFA38_accept = DFA.UnpackEncodedString(DFA38_acceptS);
			private static readonly short[] DFA38_special = DFA.UnpackEncodedString(DFA38_specialS);
			private static readonly short[][] DFA38_transition;

			static DFA38() {
				int numStates = DFA38_transitionS.Length;
				DFA38_transition = new short[numStates][];
				for (int i=0; i < numStates; i++) {
					DFA38_transition[i] = DFA.UnpackEncodedString(DFA38_transitionS[i]);
				}
			}

			public DFA38(BaseRecognizer recognizer) {
				this.recognizer = recognizer;
				this.decisionNumber = 38;
				this.eot = DFA38_eot;
				this.eof = DFA38_eof;
				this.min = DFA38_min;
				this.max = DFA38_max;
				this.accept = DFA38_accept;
				this.special = DFA38_special;
				this.transition = DFA38_transition;
			}

			public override string Description { get { return "1:1: Tokens : ( TERMCONST | EQ | DBL_EQ | BANG_EQ | LANGLE_EQ | RANGLE_EQ | LANGLE | RANGLE | DBLLANGLE | DBLRANGLE | PIPE | DBLPIPE | AMP | DBLAMP | HAT | BANG | TILDE | QUESTION | COLON | CROSS | DASH | STAR | FSLASH | PER | DBLSTAR | DBLCROSS | DBLDASH | CROSS_EQ | DASH_EQ | STAR_EQ | FSLASH_EQ | PER_EQ | DBLSTAR_EQ | DOT | COMMA | SEMI | LAMBDAOP | LPAREN | RPAREN | LBRACE | RBRACE | LBRACK | RBRACK | COMMENT | NULL | BOOL | REF | OUT | NEW | ID | EINT | EFLT | CH_INT | INT | FLT | INTWITHSUFFIX | FLTWITHSUFFIX | CHAR | STR | WS );"; } }

			public override void Error(NoViableAltException nvae) {
				DebugRecognitionException(nvae);
			}
		}


		#endregion
	}

}
