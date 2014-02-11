// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g 2011-06-05 18:07:25

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


/*
	CSharp Eval, a library for arbitrary execution of C# code
	Copyright 2011 Kevin A. Cherry and Timothy W. Wright

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
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class CseSHLexer : Lexer {
    public const int KEYWORD = 19;
    public const int LETTER = 7;
    public const int IDENT_START = 9;
    public const int CHAR = 15;
    public const int HEX_DIGIT = 6;
    public const int WHITESPACE = 11;
    public const int EOF = -1;
    public const int NUM = 18;
    public const int STR = 14;
    public const int OCT_DIGIT = 4;
    public const int IDENT_CONT = 10;
    public const int ESC_SEQ = 8;
    public const int WS = 13;
    public const int OP = 21;
    public const int IDENT = 20;
    public const int DIGIT = 5;
    public const int COMMENT = 22;
    public const int DOT = 12;
    public const int FLTWITHSUFFIX = 17;
    public const int INTWITHSUFFIX = 16;

    // delegates
    // delegators

    public CseSHLexer() 
    {
		InitializeCyclicDFAs();
    }
    public CseSHLexer(ICharStream input)
		: this(input, null) {
    }
    public CseSHLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g";} 
    }

    // $ANTLR start "OCT_DIGIT"
    public void mOCT_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:29:19: ( '0' .. '7' )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:29:22: '0' .. '7'
            {
            	MatchRange('0','7'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "OCT_DIGIT"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:30:15: ( '0' .. '9' )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:30:19: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:31:19: ( '0' .. '9' | 'A' .. 'F' | 'a' .. 'f' )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "LETTER"
    public void mLETTER() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:32:16: ( 'a' .. 'z' | 'A' .. 'Z' )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "LETTER"

    // $ANTLR start "IDENT_START"
    public void mIDENT_START() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:33:21: ( '_' | LETTER | '\\\\' ( ESC_SEQ )? )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case '_':
            	{
                alt2 = 1;
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
            case 'z':
            	{
                alt2 = 2;
                }
                break;
            case '\\':
            	{
                alt2 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:33:24: '_'
                    {
                    	Match('_'); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:33:30: LETTER
                    {
                    	mLETTER(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:33:39: '\\\\' ( ESC_SEQ )?
                    {
                    	Match('\\'); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:33:44: ( ESC_SEQ )?
                    	int alt1 = 2;
                    	int LA1_0 = input.LA(1);

                    	if ( (LA1_0 == '\"' || LA1_0 == '\'' || LA1_0 == '0' || LA1_0 == 'U' || LA1_0 == '\\' || (LA1_0 >= 'a' && LA1_0 <= 'b') || LA1_0 == 'f' || LA1_0 == 'n' || LA1_0 == 'r' || (LA1_0 >= 't' && LA1_0 <= 'v') || LA1_0 == 'x') )
                    	{
                    	    alt1 = 1;
                    	}
                    	switch (alt1) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:33:44: ESC_SEQ
                    	        {
                    	        	mESC_SEQ(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT_START"

    // $ANTLR start "IDENT_CONT"
    public void mIDENT_CONT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:34:20: ( '_' | DIGIT | LETTER | '\\\\' ( ESC_SEQ )? )
            int alt4 = 4;
            switch ( input.LA(1) ) 
            {
            case '_':
            	{
                alt4 = 1;
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
            case '9':
            	{
                alt4 = 2;
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
            case 'z':
            	{
                alt4 = 3;
                }
                break;
            case '\\':
            	{
                alt4 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d4s0 =
            	        new NoViableAltException("", 4, 0, input);

            	    throw nvae_d4s0;
            }

            switch (alt4) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:34:22: '_'
                    {
                    	Match('_'); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:34:28: DIGIT
                    {
                    	mDIGIT(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:34:36: LETTER
                    {
                    	mLETTER(); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:34:45: '\\\\' ( ESC_SEQ )?
                    {
                    	Match('\\'); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:34:50: ( ESC_SEQ )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == '\"' || LA3_0 == '\'' || LA3_0 == '0' || LA3_0 == 'U' || LA3_0 == '\\' || (LA3_0 >= 'a' && LA3_0 <= 'b') || LA3_0 == 'f' || LA3_0 == 'n' || LA3_0 == 'r' || (LA3_0 >= 't' && LA3_0 <= 'v') || LA3_0 == 'x') )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:34:50: ESC_SEQ
                    	        {
                    	        	mESC_SEQ(); 

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT_CONT"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:35:20: ( ' ' | '\\t' | '\\n' | '\\r' )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    // $ANTLR start "ESC_SEQ"
    public void mESC_SEQ() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:37:4: ( 'a' | 'b' | 'f' | 'n' | 'r' | 't' | 'v' | '0' | '\\\"' | '\\'' | '\\\\' | 'x' | 'x' HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'u' | 'u' HEX_DIGIT | 'u' HEX_DIGIT HEX_DIGIT | 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' | 'U' HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            int alt5 = 30;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:37:6: 'a'
                    {
                    	Match('a'); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:38:7: 'b'
                    {
                    	Match('b'); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:39:7: 'f'
                    {
                    	Match('f'); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:40:7: 'n'
                    {
                    	Match('n'); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:41:7: 'r'
                    {
                    	Match('r'); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:42:7: 't'
                    {
                    	Match('t'); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:43:7: 'v'
                    {
                    	Match('v'); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:45:7: '0'
                    {
                    	Match('0'); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:46:7: '\\\"'
                    {
                    	Match('\"'); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:47:7: '\\''
                    {
                    	Match('\''); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:48:7: '\\\\'
                    {
                    	Match('\\'); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:50:7: 'x'
                    {
                    	Match('x'); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:51:7: 'x' HEX_DIGIT
                    {
                    	Match('x'); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:52:7: 'x' HEX_DIGIT HEX_DIGIT
                    {
                    	Match('x'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:53:7: 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('x'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:54:7: 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('x'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:57:7: 'u'
                    {
                    	Match('u'); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:58:7: 'u' HEX_DIGIT
                    {
                    	Match('u'); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:59:7: 'u' HEX_DIGIT HEX_DIGIT
                    {
                    	Match('u'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 20 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:60:7: 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('u'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 21 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:61:7: 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('u'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 22 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:63:7: 'U'
                    {
                    	Match('U'); 

                    }
                    break;
                case 23 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:64:7: 'U' HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 24 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:65:7: 'U' HEX_DIGIT HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 25 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:66:7: 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 26 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:67:7: 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 27 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:68:7: 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 28 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:69:7: 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 29 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:70:7: 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;
                case 30 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:71:7: 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
                    {
                    	Match('U'); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 
                    	mHEX_DIGIT(); 

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ESC_SEQ"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:75:2: ( '.' )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:75:4: '.'
            {
            	Match('.'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:78:4: ( ( WHITESPACE )+ )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:78:6: ( WHITESPACE )+
            {
            	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:78:6: ( WHITESPACE )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= '\t' && LA6_0 <= '\n') || LA6_0 == '\r' || LA6_0 == ' ') )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:78:6: WHITESPACE
            			    {
            			    	mWHITESPACE(); 

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "STR"
    public void mSTR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:81:5: ( '\"' ( options {greedy=false; } : ( '\\\\' ESC_SEQ ) | ~ '\\\\' )* '\"' | '\"' (~ '\\n' )* | '@' '\"' ( '\"\"' | ~ '\"' )* '\"' | '@' '\"' (~ '\\n' )* )
            int alt11 = 4;
            alt11 = dfa11.Predict(input);
            switch (alt11) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:81:7: '\"' ( options {greedy=false; } : ( '\\\\' ESC_SEQ ) | ~ '\\\\' )* '\"'
                    {
                    	Match('\"'); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:81:11: ( options {greedy=false; } : ( '\\\\' ESC_SEQ ) | ~ '\\\\' )*
                    	do 
                    	{
                    	    int alt7 = 3;
                    	    int LA7_0 = input.LA(1);

                    	    if ( (LA7_0 == '\"') )
                    	    {
                    	        alt7 = 3;
                    	    }
                    	    else if ( (LA7_0 == '\\') )
                    	    {
                    	        alt7 = 1;
                    	    }
                    	    else if ( ((LA7_0 >= '\u0000' && LA7_0 <= '!') || (LA7_0 >= '#' && LA7_0 <= '[') || (LA7_0 >= ']' && LA7_0 <= '\uFFFF')) )
                    	    {
                    	        alt7 = 2;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:81:37: ( '\\\\' ESC_SEQ )
                    			    {
                    			    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:81:37: ( '\\\\' ESC_SEQ )
                    			    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:81:38: '\\\\' ESC_SEQ
                    			    	{
                    			    		Match('\\'); 
                    			    		mESC_SEQ(); 

                    			    	}


                    			    }
                    			    break;
                    			case 2 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:81:54: ~ '\\\\'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop7;
                    	    }
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	Match('\"'); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:82:4: '\"' (~ '\\n' )*
                    {
                    	Match('\"'); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:82:8: (~ '\\n' )*
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( ((LA8_0 >= '\u0000' && LA8_0 <= '\t') || (LA8_0 >= '\u000B' && LA8_0 <= '\uFFFF')) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:82:9: ~ '\\n'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop8;
                    	    }
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements


                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:83:4: '@' '\"' ( '\"\"' | ~ '\"' )* '\"'
                    {
                    	Match('@'); 
                    	Match('\"'); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:83:12: ( '\"\"' | ~ '\"' )*
                    	do 
                    	{
                    	    int alt9 = 3;
                    	    int LA9_0 = input.LA(1);

                    	    if ( (LA9_0 == '\"') )
                    	    {
                    	        int LA9_1 = input.LA(2);

                    	        if ( (LA9_1 == '\"') )
                    	        {
                    	            alt9 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA9_0 >= '\u0000' && LA9_0 <= '!') || (LA9_0 >= '#' && LA9_0 <= '\uFFFF')) )
                    	    {
                    	        alt9 = 2;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:83:13: '\"\"'
                    			    {
                    			    	Match("\"\""); 


                    			    }
                    			    break;
                    			case 2 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:83:20: ~ '\"'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop9;
                    	    }
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements

                    	Match('\"'); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:84:4: '@' '\"' (~ '\\n' )*
                    {
                    	Match('@'); 
                    	Match('\"'); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:84:12: (~ '\\n' )*
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( ((LA10_0 >= '\u0000' && LA10_0 <= '\t') || (LA10_0 >= '\u000B' && LA10_0 <= '\uFFFF')) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:84:13: ~ '\\n'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STR"

    // $ANTLR start "CHAR"
    public void mCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:87:5: ( '\\'' ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' ) '\\'' | '\\'' ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' )? )
            int alt14 = 2;
            alt14 = dfa14.Predict(input);
            switch (alt14) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:87:7: '\\'' ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' ) '\\''
                    {
                    	Match('\''); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:87:12: ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' )
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == '\\') )
                    	{
                    	    alt12 = 1;
                    	}
                    	else if ( ((LA12_0 >= '\u0000' && LA12_0 <= '[') || (LA12_0 >= ']' && LA12_0 <= '\uFFFF')) )
                    	{
                    	    alt12 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d12s0 =
                    	        new NoViableAltException("", 12, 0, input);

                    	    throw nvae_d12s0;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:87:13: ( '\\\\' ESC_SEQ )
                    	        {
                    	        	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:87:13: ( '\\\\' ESC_SEQ )
                    	        	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:87:14: '\\\\' ESC_SEQ
                    	        	{
                    	        		Match('\\'); 
                    	        		mESC_SEQ(); 

                    	        	}


                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:87:30: ~ '\\\\'
                    	        {
                    	        	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}

                    	Match('\''); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:88:4: '\\'' ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' )?
                    {
                    	Match('\''); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:88:9: ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' )?
                    	int alt13 = 3;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == '\\') )
                    	{
                    	    alt13 = 1;
                    	}
                    	else if ( ((LA13_0 >= '\u0000' && LA13_0 <= '[') || (LA13_0 >= ']' && LA13_0 <= '\uFFFF')) )
                    	{
                    	    alt13 = 2;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:88:10: ( '\\\\' ESC_SEQ )
                    	        {
                    	        	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:88:10: ( '\\\\' ESC_SEQ )
                    	        	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:88:11: '\\\\' ESC_SEQ
                    	        	{
                    	        		Match('\\'); 
                    	        		mESC_SEQ(); 

                    	        	}


                    	        }
                    	        break;
                    	    case 2 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:88:27: ~ '\\\\'
                    	        {
                    	        	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR"

    // $ANTLR start "INTWITHSUFFIX"
    public void mINTWITHSUFFIX() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:2: ( ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' | 'u' | 'U' | 'l' | 'L' | 'ul' | 'Ul' | 'uL' | 'UL' ) )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:4: ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' | 'u' | 'U' | 'l' | 'L' | 'ul' | 'Ul' | 'uL' | 'UL' )
            {
            	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:4: ( DIGIT )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= '0' && LA15_0 <= '9')) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:4: DIGIT
            			    {
            			    	mDIGIT(); 

            			    }
            			    break;

            			default:
            			    if ( cnt15 >= 1 ) goto loop15;
            		            EarlyExitException eee15 =
            		                new EarlyExitException(15, input);
            		            throw eee15;
            	    }
            	    cnt15++;
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:11: ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' | 'u' | 'U' | 'l' | 'L' | 'ul' | 'Ul' | 'uL' | 'UL' )
            	int alt16 = 14;
            	alt16 = dfa16.Predict(input);
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:12: 'f'
            	        {
            	        	Match('f'); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:16: 'F'
            	        {
            	        	Match('F'); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:20: 'm'
            	        {
            	        	Match('m'); 

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:24: 'M'
            	        {
            	        	Match('M'); 

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:28: 'd'
            	        {
            	        	Match('d'); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:32: 'D'
            	        {
            	        	Match('D'); 

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:36: 'u'
            	        {
            	        	Match('u'); 

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:40: 'U'
            	        {
            	        	Match('U'); 

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:44: 'l'
            	        {
            	        	Match('l'); 

            	        }
            	        break;
            	    case 10 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:48: 'L'
            	        {
            	        	Match('L'); 

            	        }
            	        break;
            	    case 11 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:52: 'ul'
            	        {
            	        	Match("ul"); 


            	        }
            	        break;
            	    case 12 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:57: 'Ul'
            	        {
            	        	Match("Ul"); 


            	        }
            	        break;
            	    case 13 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:62: 'uL'
            	        {
            	        	Match("uL"); 


            	        }
            	        break;
            	    case 14 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:92:67: 'UL'
            	        {
            	        	Match("UL"); 


            	        }
            	        break;

            	}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "INTWITHSUFFIX"

    // $ANTLR start "FLTWITHSUFFIX"
    public void mFLTWITHSUFFIX() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:96:2: ( ( DIGIT )+ DOT ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' ) | DOT ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' ) )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( ((LA20_0 >= '0' && LA20_0 <= '9')) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == '.') )
            {
                alt20 = 2;
            }
            else 
            {
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:96:4: ( DIGIT )+ DOT ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:96:4: ( DIGIT )+
                    	int cnt17 = 0;
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);

                    	    if ( ((LA17_0 >= '0' && LA17_0 <= '9')) )
                    	    {
                    	        alt17 = 1;
                    	    }


                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:96:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt17 >= 1 ) goto loop17;
                    		            EarlyExitException eee17 =
                    		                new EarlyExitException(17, input);
                    		            throw eee17;
                    	    }
                    	    cnt17++;
                    	} while (true);

                    	loop17:
                    		;	// Stops C# compiler whining that label 'loop17' has no statements

                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:96:15: ( DIGIT )+
                    	int cnt18 = 0;
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    int LA18_0 = input.LA(1);

                    	    if ( ((LA18_0 >= '0' && LA18_0 <= '9')) )
                    	    {
                    	        alt18 = 1;
                    	    }


                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:96:15: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt18 >= 1 ) goto loop18;
                    		            EarlyExitException eee18 =
                    		                new EarlyExitException(18, input);
                    		            throw eee18;
                    	    }
                    	    cnt18++;
                    	} while (true);

                    	loop18:
                    		;	// Stops C# compiler whining that label 'loop18' has no statements

                    	if ( input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:97:5: DOT ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )
                    {
                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:97:9: ( DIGIT )+
                    	int cnt19 = 0;
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);

                    	    if ( ((LA19_0 >= '0' && LA19_0 <= '9')) )
                    	    {
                    	        alt19 = 1;
                    	    }


                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:97:9: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt19 >= 1 ) goto loop19;
                    		            EarlyExitException eee19 =
                    		                new EarlyExitException(19, input);
                    		            throw eee19;
                    	    }
                    	    cnt19++;
                    	} while (true);

                    	loop19:
                    		;	// Stops C# compiler whining that label 'loop19' has no statements

                    	if ( input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FLTWITHSUFFIX"

    // $ANTLR start "NUM"
    public void mNUM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:5: ( ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )? | ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )? | DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )? | ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' ) | ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' ) | DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' ) | ( DIGIT )+ | ( DIGIT )+ DOT ( DIGIT )+ | DOT ( DIGIT )+ | ( DIGIT )+ DOT | ( DIGIT )+ ( 'e' | 'E' ) | ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) | INTWITHSUFFIX | FLTWITHSUFFIX )
            int alt46 = 14;
            alt46 = dfa46.Predict(input);
            switch (alt46) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:7: ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )?
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:7: ( DIGIT )+
                    	int cnt21 = 0;
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( ((LA21_0 >= '0' && LA21_0 <= '9')) )
                    	    {
                    	        alt21 = 1;
                    	    }


                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:7: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt21 >= 1 ) goto loop21;
                    		            EarlyExitException eee21 =
                    		                new EarlyExitException(21, input);
                    		            throw eee21;
                    	    }
                    	    cnt21++;
                    	} while (true);

                    	loop21:
                    		;	// Stops C# compiler whining that label 'loop21' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:24: ( '+' | '-' )?
                    	int alt22 = 2;
                    	int LA22_0 = input.LA(1);

                    	if ( (LA22_0 == '+' || LA22_0 == '-') )
                    	{
                    	    alt22 = 1;
                    	}
                    	switch (alt22) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
                    	        {
                    	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:35: ( DIGIT )+
                    	int cnt23 = 0;
                    	do 
                    	{
                    	    int alt23 = 2;
                    	    int LA23_0 = input.LA(1);

                    	    if ( ((LA23_0 >= '0' && LA23_0 <= '9')) )
                    	    {
                    	        alt23 = 1;
                    	    }


                    	    switch (alt23) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:35: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt23 >= 1 ) goto loop23;
                    		            EarlyExitException eee23 =
                    		                new EarlyExitException(23, input);
                    		            throw eee23;
                    	    }
                    	    cnt23++;
                    	} while (true);

                    	loop23:
                    		;	// Stops C# compiler whining that label 'loop23' has no statements

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:100:42: ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )?
                    	int alt24 = 2;
                    	int LA24_0 = input.LA(1);

                    	if ( (LA24_0 == 'D' || LA24_0 == 'F' || LA24_0 == 'M' || LA24_0 == 'd' || LA24_0 == 'f' || LA24_0 == 'm') )
                    	{
                    	    alt24 = 1;
                    	}
                    	switch (alt24) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
                    	        {
                    	        	if ( input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm' ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:4: ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )?
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:4: ( DIGIT )+
                    	int cnt25 = 0;
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( ((LA25_0 >= '0' && LA25_0 <= '9')) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt25 >= 1 ) goto loop25;
                    		            EarlyExitException eee25 =
                    		                new EarlyExitException(25, input);
                    		            throw eee25;
                    	    }
                    	    cnt25++;
                    	} while (true);

                    	loop25:
                    		;	// Stops C# compiler whining that label 'loop25' has no statements

                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:15: ( DIGIT )+
                    	int cnt26 = 0;
                    	do 
                    	{
                    	    int alt26 = 2;
                    	    int LA26_0 = input.LA(1);

                    	    if ( ((LA26_0 >= '0' && LA26_0 <= '9')) )
                    	    {
                    	        alt26 = 1;
                    	    }


                    	    switch (alt26) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:15: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt26 >= 1 ) goto loop26;
                    		            EarlyExitException eee26 =
                    		                new EarlyExitException(26, input);
                    		            throw eee26;
                    	    }
                    	    cnt26++;
                    	} while (true);

                    	loop26:
                    		;	// Stops C# compiler whining that label 'loop26' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:32: ( '+' | '-' )?
                    	int alt27 = 2;
                    	int LA27_0 = input.LA(1);

                    	if ( (LA27_0 == '+' || LA27_0 == '-') )
                    	{
                    	    alt27 = 1;
                    	}
                    	switch (alt27) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
                    	        {
                    	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:43: ( DIGIT )+
                    	int cnt28 = 0;
                    	do 
                    	{
                    	    int alt28 = 2;
                    	    int LA28_0 = input.LA(1);

                    	    if ( ((LA28_0 >= '0' && LA28_0 <= '9')) )
                    	    {
                    	        alt28 = 1;
                    	    }


                    	    switch (alt28) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:43: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt28 >= 1 ) goto loop28;
                    		            EarlyExitException eee28 =
                    		                new EarlyExitException(28, input);
                    		            throw eee28;
                    	    }
                    	    cnt28++;
                    	} while (true);

                    	loop28:
                    		;	// Stops C# compiler whining that label 'loop28' has no statements

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:101:50: ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )?
                    	int alt29 = 2;
                    	int LA29_0 = input.LA(1);

                    	if ( (LA29_0 == 'D' || LA29_0 == 'F' || LA29_0 == 'M' || LA29_0 == 'd' || LA29_0 == 'f' || LA29_0 == 'm') )
                    	{
                    	    alt29 = 1;
                    	}
                    	switch (alt29) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
                    	        {
                    	        	if ( input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm' ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:102:4: DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )?
                    {
                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:102:8: ( DIGIT )+
                    	int cnt30 = 0;
                    	do 
                    	{
                    	    int alt30 = 2;
                    	    int LA30_0 = input.LA(1);

                    	    if ( ((LA30_0 >= '0' && LA30_0 <= '9')) )
                    	    {
                    	        alt30 = 1;
                    	    }


                    	    switch (alt30) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:102:8: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt30 >= 1 ) goto loop30;
                    		            EarlyExitException eee30 =
                    		                new EarlyExitException(30, input);
                    		            throw eee30;
                    	    }
                    	    cnt30++;
                    	} while (true);

                    	loop30:
                    		;	// Stops C# compiler whining that label 'loop30' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:102:25: ( '+' | '-' )?
                    	int alt31 = 2;
                    	int LA31_0 = input.LA(1);

                    	if ( (LA31_0 == '+' || LA31_0 == '-') )
                    	{
                    	    alt31 = 1;
                    	}
                    	switch (alt31) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
                    	        {
                    	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:102:36: ( DIGIT )+
                    	int cnt32 = 0;
                    	do 
                    	{
                    	    int alt32 = 2;
                    	    int LA32_0 = input.LA(1);

                    	    if ( ((LA32_0 >= '0' && LA32_0 <= '9')) )
                    	    {
                    	        alt32 = 1;
                    	    }


                    	    switch (alt32) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:102:36: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt32 >= 1 ) goto loop32;
                    		            EarlyExitException eee32 =
                    		                new EarlyExitException(32, input);
                    		            throw eee32;
                    	    }
                    	    cnt32++;
                    	} while (true);

                    	loop32:
                    		;	// Stops C# compiler whining that label 'loop32' has no statements

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:102:43: ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )?
                    	int alt33 = 2;
                    	int LA33_0 = input.LA(1);

                    	if ( (LA33_0 == 'D' || LA33_0 == 'F' || LA33_0 == 'M' || LA33_0 == 'd' || LA33_0 == 'f' || LA33_0 == 'm') )
                    	{
                    	    alt33 = 1;
                    	}
                    	switch (alt33) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:
                    	        {
                    	        	if ( input.LA(1) == 'D' || input.LA(1) == 'F' || input.LA(1) == 'M' || input.LA(1) == 'd' || input.LA(1) == 'f' || input.LA(1) == 'm' ) 
                    	        	{
                    	        	    input.Consume();

                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    Recover(mse);
                    	        	    throw mse;}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:104:4: ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:104:4: ( DIGIT )+
                    	int cnt34 = 0;
                    	do 
                    	{
                    	    int alt34 = 2;
                    	    int LA34_0 = input.LA(1);

                    	    if ( ((LA34_0 >= '0' && LA34_0 <= '9')) )
                    	    {
                    	        alt34 = 1;
                    	    }


                    	    switch (alt34) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:104:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt34 >= 1 ) goto loop34;
                    		            EarlyExitException eee34 =
                    		                new EarlyExitException(34, input);
                    		            throw eee34;
                    	    }
                    	    cnt34++;
                    	} while (true);

                    	loop34:
                    		;	// Stops C# compiler whining that label 'loop34' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 5 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:105:4: ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:105:4: ( DIGIT )+
                    	int cnt35 = 0;
                    	do 
                    	{
                    	    int alt35 = 2;
                    	    int LA35_0 = input.LA(1);

                    	    if ( ((LA35_0 >= '0' && LA35_0 <= '9')) )
                    	    {
                    	        alt35 = 1;
                    	    }


                    	    switch (alt35) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:105:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt35 >= 1 ) goto loop35;
                    		            EarlyExitException eee35 =
                    		                new EarlyExitException(35, input);
                    		            throw eee35;
                    	    }
                    	    cnt35++;
                    	} while (true);

                    	loop35:
                    		;	// Stops C# compiler whining that label 'loop35' has no statements

                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:105:15: ( DIGIT )+
                    	int cnt36 = 0;
                    	do 
                    	{
                    	    int alt36 = 2;
                    	    int LA36_0 = input.LA(1);

                    	    if ( ((LA36_0 >= '0' && LA36_0 <= '9')) )
                    	    {
                    	        alt36 = 1;
                    	    }


                    	    switch (alt36) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:105:15: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt36 >= 1 ) goto loop36;
                    		            EarlyExitException eee36 =
                    		                new EarlyExitException(36, input);
                    		            throw eee36;
                    	    }
                    	    cnt36++;
                    	} while (true);

                    	loop36:
                    		;	// Stops C# compiler whining that label 'loop36' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 6 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:106:4: DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )
                    {
                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:106:8: ( DIGIT )+
                    	int cnt37 = 0;
                    	do 
                    	{
                    	    int alt37 = 2;
                    	    int LA37_0 = input.LA(1);

                    	    if ( ((LA37_0 >= '0' && LA37_0 <= '9')) )
                    	    {
                    	        alt37 = 1;
                    	    }


                    	    switch (alt37) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:106:8: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt37 >= 1 ) goto loop37;
                    		            EarlyExitException eee37 =
                    		                new EarlyExitException(37, input);
                    		            throw eee37;
                    	    }
                    	    cnt37++;
                    	} while (true);

                    	loop37:
                    		;	// Stops C# compiler whining that label 'loop37' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 7 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:108:4: ( DIGIT )+
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:108:4: ( DIGIT )+
                    	int cnt38 = 0;
                    	do 
                    	{
                    	    int alt38 = 2;
                    	    int LA38_0 = input.LA(1);

                    	    if ( ((LA38_0 >= '0' && LA38_0 <= '9')) )
                    	    {
                    	        alt38 = 1;
                    	    }


                    	    switch (alt38) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:108:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt38 >= 1 ) goto loop38;
                    		            EarlyExitException eee38 =
                    		                new EarlyExitException(38, input);
                    		            throw eee38;
                    	    }
                    	    cnt38++;
                    	} while (true);

                    	loop38:
                    		;	// Stops C# compiler whining that label 'loop38' has no statements


                    }
                    break;
                case 8 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:109:4: ( DIGIT )+ DOT ( DIGIT )+
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:109:4: ( DIGIT )+
                    	int cnt39 = 0;
                    	do 
                    	{
                    	    int alt39 = 2;
                    	    int LA39_0 = input.LA(1);

                    	    if ( ((LA39_0 >= '0' && LA39_0 <= '9')) )
                    	    {
                    	        alt39 = 1;
                    	    }


                    	    switch (alt39) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:109:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt39 >= 1 ) goto loop39;
                    		            EarlyExitException eee39 =
                    		                new EarlyExitException(39, input);
                    		            throw eee39;
                    	    }
                    	    cnt39++;
                    	} while (true);

                    	loop39:
                    		;	// Stops C# compiler whining that label 'loop39' has no statements

                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:109:15: ( DIGIT )+
                    	int cnt40 = 0;
                    	do 
                    	{
                    	    int alt40 = 2;
                    	    int LA40_0 = input.LA(1);

                    	    if ( ((LA40_0 >= '0' && LA40_0 <= '9')) )
                    	    {
                    	        alt40 = 1;
                    	    }


                    	    switch (alt40) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:109:15: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt40 >= 1 ) goto loop40;
                    		            EarlyExitException eee40 =
                    		                new EarlyExitException(40, input);
                    		            throw eee40;
                    	    }
                    	    cnt40++;
                    	} while (true);

                    	loop40:
                    		;	// Stops C# compiler whining that label 'loop40' has no statements


                    }
                    break;
                case 9 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:110:4: DOT ( DIGIT )+
                    {
                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:110:8: ( DIGIT )+
                    	int cnt41 = 0;
                    	do 
                    	{
                    	    int alt41 = 2;
                    	    int LA41_0 = input.LA(1);

                    	    if ( ((LA41_0 >= '0' && LA41_0 <= '9')) )
                    	    {
                    	        alt41 = 1;
                    	    }


                    	    switch (alt41) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:110:8: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt41 >= 1 ) goto loop41;
                    		            EarlyExitException eee41 =
                    		                new EarlyExitException(41, input);
                    		            throw eee41;
                    	    }
                    	    cnt41++;
                    	} while (true);

                    	loop41:
                    		;	// Stops C# compiler whining that label 'loop41' has no statements


                    }
                    break;
                case 10 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:111:4: ( DIGIT )+ DOT
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:111:4: ( DIGIT )+
                    	int cnt42 = 0;
                    	do 
                    	{
                    	    int alt42 = 2;
                    	    int LA42_0 = input.LA(1);

                    	    if ( ((LA42_0 >= '0' && LA42_0 <= '9')) )
                    	    {
                    	        alt42 = 1;
                    	    }


                    	    switch (alt42) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:111:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt42 >= 1 ) goto loop42;
                    		            EarlyExitException eee42 =
                    		                new EarlyExitException(42, input);
                    		            throw eee42;
                    	    }
                    	    cnt42++;
                    	} while (true);

                    	loop42:
                    		;	// Stops C# compiler whining that label 'loop42' has no statements

                    	mDOT(); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:112:4: ( DIGIT )+ ( 'e' | 'E' )
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:112:4: ( DIGIT )+
                    	int cnt43 = 0;
                    	do 
                    	{
                    	    int alt43 = 2;
                    	    int LA43_0 = input.LA(1);

                    	    if ( ((LA43_0 >= '0' && LA43_0 <= '9')) )
                    	    {
                    	        alt43 = 1;
                    	    }


                    	    switch (alt43) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:112:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt43 >= 1 ) goto loop43;
                    		            EarlyExitException eee43 =
                    		                new EarlyExitException(43, input);
                    		            throw eee43;
                    	    }
                    	    cnt43++;
                    	} while (true);

                    	loop43:
                    		;	// Stops C# compiler whining that label 'loop43' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 12 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:113:4: ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' )
                    {
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:113:4: ( DIGIT )+
                    	int cnt44 = 0;
                    	do 
                    	{
                    	    int alt44 = 2;
                    	    int LA44_0 = input.LA(1);

                    	    if ( ((LA44_0 >= '0' && LA44_0 <= '9')) )
                    	    {
                    	        alt44 = 1;
                    	    }


                    	    switch (alt44) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:113:4: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt44 >= 1 ) goto loop44;
                    		            EarlyExitException eee44 =
                    		                new EarlyExitException(44, input);
                    		            throw eee44;
                    	    }
                    	    cnt44++;
                    	} while (true);

                    	loop44:
                    		;	// Stops C# compiler whining that label 'loop44' has no statements

                    	mDOT(); 
                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:113:15: ( DIGIT )+
                    	int cnt45 = 0;
                    	do 
                    	{
                    	    int alt45 = 2;
                    	    int LA45_0 = input.LA(1);

                    	    if ( ((LA45_0 >= '0' && LA45_0 <= '9')) )
                    	    {
                    	        alt45 = 1;
                    	    }


                    	    switch (alt45) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:113:15: DIGIT
                    			    {
                    			    	mDIGIT(); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt45 >= 1 ) goto loop45;
                    		            EarlyExitException eee45 =
                    		                new EarlyExitException(45, input);
                    		            throw eee45;
                    	    }
                    	    cnt45++;
                    	} while (true);

                    	loop45:
                    		;	// Stops C# compiler whining that label 'loop45' has no statements

                    	if ( input.LA(1) == 'E' || input.LA(1) == 'e' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 13 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:114:4: INTWITHSUFFIX
                    {
                    	mINTWITHSUFFIX(); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:115:4: FLTWITHSUFFIX
                    {
                    	mFLTWITHSUFFIX(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUM"

    // $ANTLR start "KEYWORD"
    public void mKEYWORD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = KEYWORD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:120:2: ( 'abstract' | 'event' | 'new' | 'struct' | 'as' | 'explicit' | 'null' | 'switch' | 'base' | 'extern' | 'object' | 'this' | 'bool' | 'false' | 'operator' | 'throw' | 'break' | 'finally' | 'out' | 'true' | 'byte' | 'fixed' | 'override' | 'try' | 'case' | 'float' | 'params' | 'typeof' | 'catch' | 'for' | 'private' | 'uint' | 'char' | 'foreach' | 'protected' | 'ulong' | 'checked' | 'goto' | 'public' | 'unchecked' | 'class' | 'if' | 'readonly' | 'unsafe' | 'const' | 'implicit' | 'ref' | 'ushort' | 'continue' | 'in' | 'return' | 'using' | 'decimal' | 'int' | 'sbyte' | 'virtual' | 'default' | 'interface' | 'sealed' | 'volatile' | 'delegate' | 'internal' | 'short' | 'void' | 'do' | 'is' | 'sizeof' | 'while' | 'double' | 'lock' | 'stackalloc' | 'else' | 'long' | 'static' | 'enum' | 'namespace' | 'string' )
            int alt47 = 77;
            alt47 = dfa47.Predict(input);
            switch (alt47) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:120:4: 'abstract'
                    {
                    	Match("abstract"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:120:17: 'event'
                    {
                    	Match("event"); 


                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:120:27: 'new'
                    {
                    	Match("new"); 


                    }
                    break;
                case 4 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:120:35: 'struct'
                    {
                    	Match("struct"); 


                    }
                    break;
                case 5 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:120:46: 'as'
                    {
                    	Match("as"); 


                    }
                    break;
                case 6 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:121:4: 'explicit'
                    {
                    	Match("explicit"); 


                    }
                    break;
                case 7 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:121:17: 'null'
                    {
                    	Match("null"); 


                    }
                    break;
                case 8 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:121:26: 'switch'
                    {
                    	Match("switch"); 


                    }
                    break;
                case 9 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:121:37: 'base'
                    {
                    	Match("base"); 


                    }
                    break;
                case 10 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:121:46: 'extern'
                    {
                    	Match("extern"); 


                    }
                    break;
                case 11 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:122:4: 'object'
                    {
                    	Match("object"); 


                    }
                    break;
                case 12 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:122:15: 'this'
                    {
                    	Match("this"); 


                    }
                    break;
                case 13 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:122:24: 'bool'
                    {
                    	Match("bool"); 


                    }
                    break;
                case 14 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:122:33: 'false'
                    {
                    	Match("false"); 


                    }
                    break;
                case 15 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:122:43: 'operator'
                    {
                    	Match("operator"); 


                    }
                    break;
                case 16 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:123:4: 'throw'
                    {
                    	Match("throw"); 


                    }
                    break;
                case 17 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:123:14: 'break'
                    {
                    	Match("break"); 


                    }
                    break;
                case 18 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:123:24: 'finally'
                    {
                    	Match("finally"); 


                    }
                    break;
                case 19 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:123:36: 'out'
                    {
                    	Match("out"); 


                    }
                    break;
                case 20 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:123:44: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 21 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:124:4: 'byte'
                    {
                    	Match("byte"); 


                    }
                    break;
                case 22 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:124:13: 'fixed'
                    {
                    	Match("fixed"); 


                    }
                    break;
                case 23 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:124:23: 'override'
                    {
                    	Match("override"); 


                    }
                    break;
                case 24 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:124:36: 'try'
                    {
                    	Match("try"); 


                    }
                    break;
                case 25 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:124:44: 'case'
                    {
                    	Match("case"); 


                    }
                    break;
                case 26 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:125:4: 'float'
                    {
                    	Match("float"); 


                    }
                    break;
                case 27 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:125:14: 'params'
                    {
                    	Match("params"); 


                    }
                    break;
                case 28 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:125:25: 'typeof'
                    {
                    	Match("typeof"); 


                    }
                    break;
                case 29 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:125:36: 'catch'
                    {
                    	Match("catch"); 


                    }
                    break;
                case 30 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:125:46: 'for'
                    {
                    	Match("for"); 


                    }
                    break;
                case 31 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:126:4: 'private'
                    {
                    	Match("private"); 


                    }
                    break;
                case 32 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:126:16: 'uint'
                    {
                    	Match("uint"); 


                    }
                    break;
                case 33 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:126:25: 'char'
                    {
                    	Match("char"); 


                    }
                    break;
                case 34 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:126:34: 'foreach'
                    {
                    	Match("foreach"); 


                    }
                    break;
                case 35 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:126:46: 'protected'
                    {
                    	Match("protected"); 


                    }
                    break;
                case 36 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:127:4: 'ulong'
                    {
                    	Match("ulong"); 


                    }
                    break;
                case 37 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:127:14: 'checked'
                    {
                    	Match("checked"); 


                    }
                    break;
                case 38 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:127:26: 'goto'
                    {
                    	Match("goto"); 


                    }
                    break;
                case 39 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:127:35: 'public'
                    {
                    	Match("public"); 


                    }
                    break;
                case 40 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:127:46: 'unchecked'
                    {
                    	Match("unchecked"); 


                    }
                    break;
                case 41 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:128:4: 'class'
                    {
                    	Match("class"); 


                    }
                    break;
                case 42 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:128:14: 'if'
                    {
                    	Match("if"); 


                    }
                    break;
                case 43 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:128:21: 'readonly'
                    {
                    	Match("readonly"); 


                    }
                    break;
                case 44 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:128:34: 'unsafe'
                    {
                    	Match("unsafe"); 


                    }
                    break;
                case 45 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:128:45: 'const'
                    {
                    	Match("const"); 


                    }
                    break;
                case 46 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:129:4: 'implicit'
                    {
                    	Match("implicit"); 


                    }
                    break;
                case 47 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:129:17: 'ref'
                    {
                    	Match("ref"); 


                    }
                    break;
                case 48 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:129:25: 'ushort'
                    {
                    	Match("ushort"); 


                    }
                    break;
                case 49 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:129:36: 'continue'
                    {
                    	Match("continue"); 


                    }
                    break;
                case 50 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:129:49: 'in'
                    {
                    	Match("in"); 


                    }
                    break;
                case 51 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:130:4: 'return'
                    {
                    	Match("return"); 


                    }
                    break;
                case 52 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:130:15: 'using'
                    {
                    	Match("using"); 


                    }
                    break;
                case 53 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:130:25: 'decimal'
                    {
                    	Match("decimal"); 


                    }
                    break;
                case 54 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:130:37: 'int'
                    {
                    	Match("int"); 


                    }
                    break;
                case 55 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:130:45: 'sbyte'
                    {
                    	Match("sbyte"); 


                    }
                    break;
                case 56 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:131:4: 'virtual'
                    {
                    	Match("virtual"); 


                    }
                    break;
                case 57 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:131:16: 'default'
                    {
                    	Match("default"); 


                    }
                    break;
                case 58 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:131:28: 'interface'
                    {
                    	Match("interface"); 


                    }
                    break;
                case 59 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:131:42: 'sealed'
                    {
                    	Match("sealed"); 


                    }
                    break;
                case 60 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:132:4: 'volatile'
                    {
                    	Match("volatile"); 


                    }
                    break;
                case 61 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:132:17: 'delegate'
                    {
                    	Match("delegate"); 


                    }
                    break;
                case 62 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:132:30: 'internal'
                    {
                    	Match("internal"); 


                    }
                    break;
                case 63 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:132:43: 'short'
                    {
                    	Match("short"); 


                    }
                    break;
                case 64 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:133:4: 'void'
                    {
                    	Match("void"); 


                    }
                    break;
                case 65 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:133:13: 'do'
                    {
                    	Match("do"); 


                    }
                    break;
                case 66 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:133:20: 'is'
                    {
                    	Match("is"); 


                    }
                    break;
                case 67 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:133:27: 'sizeof'
                    {
                    	Match("sizeof"); 


                    }
                    break;
                case 68 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:133:38: 'while'
                    {
                    	Match("while"); 


                    }
                    break;
                case 69 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:133:48: 'double'
                    {
                    	Match("double"); 


                    }
                    break;
                case 70 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:134:4: 'lock'
                    {
                    	Match("lock"); 


                    }
                    break;
                case 71 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:134:13: 'stackalloc'
                    {
                    	Match("stackalloc"); 


                    }
                    break;
                case 72 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:134:28: 'else'
                    {
                    	Match("else"); 


                    }
                    break;
                case 73 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:134:37: 'long'
                    {
                    	Match("long"); 


                    }
                    break;
                case 74 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:134:46: 'static'
                    {
                    	Match("static"); 


                    }
                    break;
                case 75 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:135:4: 'enum'
                    {
                    	Match("enum"); 


                    }
                    break;
                case 76 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:135:13: 'namespace'
                    {
                    	Match("namespace"); 


                    }
                    break;
                case 77 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:135:27: 'string'
                    {
                    	Match("string"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "KEYWORD"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:139:2: ( ( '@' )? IDENT_START ( IDENT_CONT )* )
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:139:4: ( '@' )? IDENT_START ( IDENT_CONT )*
            {
            	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:139:4: ( '@' )?
            	int alt48 = 2;
            	int LA48_0 = input.LA(1);

            	if ( (LA48_0 == '@') )
            	{
            	    alt48 = 1;
            	}
            	switch (alt48) 
            	{
            	    case 1 :
            	        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:139:4: '@'
            	        {
            	        	Match('@'); 

            	        }
            	        break;

            	}

            	mIDENT_START(); 
            	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:139:21: ( IDENT_CONT )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( ((LA49_0 >= '0' && LA49_0 <= '9') || (LA49_0 >= 'A' && LA49_0 <= 'Z') || LA49_0 == '\\' || LA49_0 == '_' || (LA49_0 >= 'a' && LA49_0 <= 'z')) )
            	    {
            	        alt49 = 1;
            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:139:21: IDENT_CONT
            			    {
            			    	mIDENT_CONT(); 

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "OP"
    public void mOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:4: ( '++' | '--' | '->' | '.' | '+' | '-' | '!' | '~' | '(' | ')' | '&' | '*' | '**' | '/' | '%' | '<<' | '>>' | '<' | '>' | '[' | ']' | '<=' | '>=' | '==' | '!=' | '^' | '|' | '&&' | '||' | '?' | ':' | '=' | '+=' | '-=' | '*=' | '/=' | '%=' | '&=' | '|=' | '^=' | '<<=' | '>>=' | '??' | ',' | ';' | '@' )
            int alt50 = 46;
            alt50 = dfa50.Predict(input);
            switch (alt50) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:6: '++'
                    {
                    	Match("++"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:13: '--'
                    {
                    	Match("--"); 


                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:20: '->'
                    {
                    	Match("->"); 


                    }
                    break;
                case 4 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:27: '.'
                    {
                    	Match('.'); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:33: '+'
                    {
                    	Match('+'); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:39: '-'
                    {
                    	Match('-'); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:45: '!'
                    {
                    	Match('!'); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:51: '~'
                    {
                    	Match('~'); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:57: '('
                    {
                    	Match('('); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:143:63: ')'
                    {
                    	Match(')'); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:4: '&'
                    {
                    	Match('&'); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:10: '*'
                    {
                    	Match('*'); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:16: '**'
                    {
                    	Match("**"); 


                    }
                    break;
                case 14 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:23: '/'
                    {
                    	Match('/'); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:29: '%'
                    {
                    	Match('%'); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:35: '<<'
                    {
                    	Match("<<"); 


                    }
                    break;
                case 17 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:42: '>>'
                    {
                    	Match(">>"); 


                    }
                    break;
                case 18 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:49: '<'
                    {
                    	Match('<'); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:55: '>'
                    {
                    	Match('>'); 

                    }
                    break;
                case 20 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:61: '['
                    {
                    	Match('['); 

                    }
                    break;
                case 21 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:144:67: ']'
                    {
                    	Match(']'); 

                    }
                    break;
                case 22 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:4: '<='
                    {
                    	Match("<="); 


                    }
                    break;
                case 23 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:11: '>='
                    {
                    	Match(">="); 


                    }
                    break;
                case 24 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:18: '=='
                    {
                    	Match("=="); 


                    }
                    break;
                case 25 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:25: '!='
                    {
                    	Match("!="); 


                    }
                    break;
                case 26 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:32: '^'
                    {
                    	Match('^'); 

                    }
                    break;
                case 27 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:38: '|'
                    {
                    	Match('|'); 

                    }
                    break;
                case 28 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:44: '&&'
                    {
                    	Match("&&"); 


                    }
                    break;
                case 29 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:51: '||'
                    {
                    	Match("||"); 


                    }
                    break;
                case 30 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:145:58: '?'
                    {
                    	Match('?'); 

                    }
                    break;
                case 31 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:4: ':'
                    {
                    	Match(':'); 

                    }
                    break;
                case 32 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:10: '='
                    {
                    	Match('='); 

                    }
                    break;
                case 33 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:16: '+='
                    {
                    	Match("+="); 


                    }
                    break;
                case 34 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:23: '-='
                    {
                    	Match("-="); 


                    }
                    break;
                case 35 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:30: '*='
                    {
                    	Match("*="); 


                    }
                    break;
                case 36 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:37: '/='
                    {
                    	Match("/="); 


                    }
                    break;
                case 37 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:44: '%='
                    {
                    	Match("%="); 


                    }
                    break;
                case 38 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:51: '&='
                    {
                    	Match("&="); 


                    }
                    break;
                case 39 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:146:58: '|='
                    {
                    	Match("|="); 


                    }
                    break;
                case 40 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:147:4: '^='
                    {
                    	Match("^="); 


                    }
                    break;
                case 41 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:147:11: '<<='
                    {
                    	Match("<<="); 


                    }
                    break;
                case 42 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:147:19: '>>='
                    {
                    	Match(">>="); 


                    }
                    break;
                case 43 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:147:27: '??'
                    {
                    	Match("??"); 


                    }
                    break;
                case 44 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:147:34: ','
                    {
                    	Match(','); 

                    }
                    break;
                case 45 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:147:40: ';'
                    {
                    	Match(';'); 

                    }
                    break;
                case 46 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:147:46: '@'
                    {
                    	Match('@'); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OP"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:151:5: ( '/*' ( options {greedy=false; } : . )* '*/' | '/*' (~ '\\n' )* | '//' (~ '\\n' )* )
            int alt54 = 3;
            alt54 = dfa54.Predict(input);
            switch (alt54) 
            {
                case 1 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:151:7: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:151:12: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt51 = 2;
                    	    int LA51_0 = input.LA(1);

                    	    if ( (LA51_0 == '*') )
                    	    {
                    	        int LA51_1 = input.LA(2);

                    	        if ( (LA51_1 == '/') )
                    	        {
                    	            alt51 = 2;
                    	        }
                    	        else if ( ((LA51_1 >= '\u0000' && LA51_1 <= '.') || (LA51_1 >= '0' && LA51_1 <= '\uFFFF')) )
                    	        {
                    	            alt51 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA51_0 >= '\u0000' && LA51_0 <= ')') || (LA51_0 >= '+' && LA51_0 <= '\uFFFF')) )
                    	    {
                    	        alt51 = 1;
                    	    }


                    	    switch (alt51) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:151:38: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop51;
                    	    }
                    	} while (true);

                    	loop51:
                    		;	// Stops C# compiler whining that label 'loop51' has no statements

                    	Match("*/"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:152:7: '/*' (~ '\\n' )*
                    {
                    	Match("/*"); 

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:152:12: (~ '\\n' )*
                    	do 
                    	{
                    	    int alt52 = 2;
                    	    int LA52_0 = input.LA(1);

                    	    if ( ((LA52_0 >= '\u0000' && LA52_0 <= '\t') || (LA52_0 >= '\u000B' && LA52_0 <= '\uFFFF')) )
                    	    {
                    	        alt52 = 1;
                    	    }


                    	    switch (alt52) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:152:13: ~ '\\n'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop52;
                    	    }
                    	} while (true);

                    	loop52:
                    		;	// Stops C# compiler whining that label 'loop52' has no statements


                    }
                    break;
                case 3 :
                    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:153:7: '//' (~ '\\n' )*
                    {
                    	Match("//"); 

                    	// C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:153:12: (~ '\\n' )*
                    	do 
                    	{
                    	    int alt53 = 2;
                    	    int LA53_0 = input.LA(1);

                    	    if ( ((LA53_0 >= '\u0000' && LA53_0 <= '\t') || (LA53_0 >= '\u000B' && LA53_0 <= '\uFFFF')) )
                    	    {
                    	        alt53 = 1;
                    	    }


                    	    switch (alt53) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:153:13: ~ '\\n'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop53;
                    	    }
                    	} while (true);

                    	loop53:
                    		;	// Stops C# compiler whining that label 'loop53' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:8: ( WS | STR | CHAR | NUM | KEYWORD | IDENT | OP | COMMENT )
        int alt55 = 8;
        alt55 = dfa55.Predict(input);
        switch (alt55) 
        {
            case 1 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:10: WS
                {
                	mWS(); 

                }
                break;
            case 2 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:13: STR
                {
                	mSTR(); 

                }
                break;
            case 3 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:17: CHAR
                {
                	mCHAR(); 

                }
                break;
            case 4 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:22: NUM
                {
                	mNUM(); 

                }
                break;
            case 5 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:26: KEYWORD
                {
                	mKEYWORD(); 

                }
                break;
            case 6 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:34: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 7 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:40: OP
                {
                	mOP(); 

                }
                break;
            case 8 :
                // C:\\Users\\COD\\Documents\\Visual Studio 2010\\Projects\\Open Source\\CSharp Eval\\Source\\CSharpEval\\AntlrParser\\CseSHLexer.g:1:43: COMMENT
                {
                	mCOMMENT(); 

                }
                break;

        }

    }


    protected DFA5 dfa5;
    protected DFA11 dfa11;
    protected DFA14 dfa14;
    protected DFA16 dfa16;
    protected DFA46 dfa46;
    protected DFA47 dfa47;
    protected DFA50 dfa50;
    protected DFA54 dfa54;
    protected DFA55 dfa55;
	private void InitializeCyclicDFAs()
	{
	    this.dfa5 = new DFA5(this);
	    this.dfa11 = new DFA11(this);
	    this.dfa14 = new DFA14(this);
	    this.dfa16 = new DFA16(this);
	    this.dfa46 = new DFA46(this);
	    this.dfa47 = new DFA47(this);
	    this.dfa50 = new DFA50(this);
	    this.dfa54 = new DFA54(this);
	    this.dfa55 = new DFA55(this);
	    this.dfa11.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA11_SpecialStateTransition);
	    this.dfa14.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA14_SpecialStateTransition);
	    this.dfa54.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA54_SpecialStateTransition);
	}

    const string DFA5_eotS =
        "\x0c\uffff\x01\x10\x01\x12\x01\x14\x01\x15\x01\uffff\x01\x17\x01"+
        "\uffff\x01\x19\x02\uffff\x01\x1b\x01\uffff\x01\x1d\x01\uffff\x01"+
        "\x1f\x01\uffff\x01\x21\x01\uffff\x01\x23\x01\uffff\x01\x25\x05\uffff"+
        "\x01\x27\x01\uffff\x01\x29\x01\uffff\x01\x2b\x01\uffff\x01\x2d\x02"+
        "\uffff";
    const string DFA5_eofS =
        "\x2f\uffff";
    const string DFA5_minS =
        "\x01\x22\x0b\uffff\x04\x30\x01\uffff\x01\x30\x01\uffff\x01\x30"+
        "\x02\uffff\x01\x30\x01\uffff\x01\x30\x01\uffff\x01\x30\x01\uffff"+
        "\x01\x30\x01\uffff\x01\x30\x01\uffff\x01\x30\x05\uffff\x01\x30\x01"+
        "\uffff\x01\x30\x01\uffff\x01\x30\x01\uffff\x01\x30\x02\uffff";
    const string DFA5_maxS =
        "\x01\x78\x0b\uffff\x04\x66\x01\uffff\x01\x66\x01\uffff\x01\x66"+
        "\x02\uffff\x01\x66\x01\uffff\x01\x66\x01\uffff\x01\x66\x01\uffff"+
        "\x01\x66\x01\uffff\x01\x66\x01\uffff\x01\x66\x05\uffff\x01\x66\x01"+
        "\uffff\x01\x66\x01\uffff\x01\x66\x01\uffff\x01\x66\x02\uffff";
    const string DFA5_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x04\uffff\x01\x0c\x01\uffff"+
        "\x01\x11\x01\uffff\x01\x16\x01\x0d\x01\uffff\x01\x12\x01\uffff\x01"+
        "\x17\x01\uffff\x01\x0e\x01\uffff\x01\x13\x01\uffff\x01\x18\x01\uffff"+
        "\x01\x0f\x01\x10\x01\x14\x01\x15\x01\x19\x01\uffff\x01\x1a\x01\uffff"+
        "\x01\x1b\x01\uffff\x01\x1c\x01\uffff\x01\x1d\x01\x1e";
    const string DFA5_specialS =
        "\x2f\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x09\x04\uffff\x01\x0a\x08\uffff\x01\x08\x24\uffff\x01"+
            "\x0e\x06\uffff\x01\x0b\x04\uffff\x01\x01\x01\x02\x03\uffff\x01"+
            "\x03\x07\uffff\x01\x04\x03\uffff\x01\x05\x01\uffff\x01\x06\x01"+
            "\x0d\x01\x07\x01\uffff\x01\x0c",
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
            "\x0a\x0f\x07\uffff\x06\x0f\x1a\uffff\x06\x0f",
            "\x0a\x11\x07\uffff\x06\x11\x1a\uffff\x06\x11",
            "\x0a\x13\x07\uffff\x06\x13\x1a\uffff\x06\x13",
            "\x0a\x16\x07\uffff\x06\x16\x1a\uffff\x06\x16",
            "",
            "\x0a\x18\x07\uffff\x06\x18\x1a\uffff\x06\x18",
            "",
            "\x0a\x1a\x07\uffff\x06\x1a\x1a\uffff\x06\x1a",
            "",
            "",
            "\x0a\x1c\x07\uffff\x06\x1c\x1a\uffff\x06\x1c",
            "",
            "\x0a\x1e\x07\uffff\x06\x1e\x1a\uffff\x06\x1e",
            "",
            "\x0a\x20\x07\uffff\x06\x20\x1a\uffff\x06\x20",
            "",
            "\x0a\x22\x07\uffff\x06\x22\x1a\uffff\x06\x22",
            "",
            "\x0a\x24\x07\uffff\x06\x24\x1a\uffff\x06\x24",
            "",
            "\x0a\x26\x07\uffff\x06\x26\x1a\uffff\x06\x26",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x28\x07\uffff\x06\x28\x1a\uffff\x06\x28",
            "",
            "\x0a\x2a\x07\uffff\x06\x2a\x1a\uffff\x06\x2a",
            "",
            "\x0a\x2c\x07\uffff\x06\x2c\x1a\uffff\x06\x2c",
            "",
            "\x0a\x2e\x07\uffff\x06\x2e\x1a\uffff\x06\x2e",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
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

        override public string Description
        {
            get { return "36:10: fragment ESC_SEQ : ( 'a' | 'b' | 'f' | 'n' | 'r' | 't' | 'v' | '0' | '\\\"' | '\\'' | '\\\\' | 'x' | 'x' HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'x' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'u' | 'u' HEX_DIGIT | 'u' HEX_DIGIT HEX_DIGIT | 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' | 'U' HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT | 'U' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT );"; }
        }

    }

    const string DFA11_eotS =
        "\x01\uffff\x01\x04\x01\uffff\x01\x04\x02\uffff\x01\x04\x01\x17"+
        "\x0e\x04\x02\uffff\x01\x17\x10\x04";
    const string DFA11_eofS =
        "\x29\uffff";
    const string DFA11_minS =
        "\x01\x22\x01\x00\x02\x22\x02\uffff\x10\x00\x02\uffff\x11\x00";
    const string DFA11_maxS =
        "\x01\x40\x01\uffff\x01\x22\x01\x78\x02\uffff\x10\uffff\x02\uffff"+
        "\x11\uffff";
    const string DFA11_acceptS =
        "\x04\uffff\x01\x02\x01\x01\x10\uffff\x01\x03\x01\x04\x11\uffff";
    const string DFA11_specialS =
        "\x01\uffff\x01\x1d\x04\uffff\x01\x19\x01\x14\x01\x04\x01\x03\x01"+
        "\x0b\x01\x09\x01\x08\x01\x07\x01\x10\x01\x0f\x01\x0d\x01\x0c\x01"+
        "\x16\x01\x15\x01\x20\x01\x11\x02\uffff\x01\x0a\x01\x02\x01\x00\x01"+
        "\x12\x01\x0e\x01\x1c\x01\x01\x01\x1b\x01\x1a\x01\x1e\x01\x06\x01"+
        "\x18\x01\x21\x01\x17\x01\x1f\x01\x13\x01\x05}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x1d\uffff\x01\x02",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x01\x07",
            "\x01\x10\x04\uffff\x01\x11\x08\uffff\x01\x0f\x24\uffff\x01"+
            "\x15\x06\uffff\x01\x12\x04\uffff\x01\x08\x01\x09\x03\uffff\x01"+
            "\x0a\x07\uffff\x01\x0b\x03\uffff\x01\x0c\x01\uffff\x01\x0d\x01"+
            "\x14\x01\x0e\x01\uffff\x01\x13",
            "",
            "",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x18\x01\x16\x17\x18\x01\x16\uffdd\x18",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x19\x07\x06\x06"+
            "\x19\x15\x06\x01\x03\x04\x06\x06\x19\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x1a\x07\x06\x06"+
            "\x1a\x15\x06\x01\x03\x04\x06\x06\x1a\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x1b\x07\x06\x06"+
            "\x1b\x15\x06\x01\x03\x04\x06\x06\x1b\uff99\x06",
            "",
            "",
            "\x0a\x18\x01\x16\x17\x18\x01\x16\uffdd\x18",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x1c\x07\x06\x06"+
            "\x1c\x15\x06\x01\x03\x04\x06\x06\x1c\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x1d\x07\x06\x06"+
            "\x1d\x15\x06\x01\x03\x04\x06\x06\x1d\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x1e\x07\x06\x06"+
            "\x1e\x15\x06\x01\x03\x04\x06\x06\x1e\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x1f\x07\x06\x06"+
            "\x1f\x15\x06\x01\x03\x04\x06\x06\x1f\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x20\x07\x06\x06"+
            "\x20\x15\x06\x01\x03\x04\x06\x06\x20\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x21\x07\x06\x06"+
            "\x21\x15\x06\x01\x03\x04\x06\x06\x21\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x22\x07\x06\x06"+
            "\x22\x15\x06\x01\x03\x04\x06\x06\x22\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x23\x07\x06\x06"+
            "\x23\x15\x06\x01\x03\x04\x06\x06\x23\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x24\x07\x06\x06"+
            "\x24\x15\x06\x01\x03\x04\x06\x06\x24\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x25\x07\x06\x06"+
            "\x25\x15\x06\x01\x03\x04\x06\x06\x25\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x26\x07\x06\x06"+
            "\x26\x15\x06\x01\x03\x04\x06\x06\x26\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x27\x07\x06\x06"+
            "\x27\x15\x06\x01\x03\x04\x06\x06\x27\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x0d\x06\x0a\x28\x07\x06\x06"+
            "\x28\x15\x06\x01\x03\x04\x06\x06\x28\uff99\x06",
            "\x0a\x06\x01\x05\x17\x06\x01\x05\x39\x06\x01\x03\uffa3\x06"
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "81:1: STR : ( '\"' ( options {greedy=false; } : ( '\\\\' ESC_SEQ ) | ~ '\\\\' )* '\"' | '\"' (~ '\\n' )* | '@' '\"' ( '\"\"' | ~ '\"' )* '\"' | '@' '\"' (~ '\\n' )* );"; }
        }

    }


    protected internal int DFA11_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA11_26 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_26 == '\n' || LA11_26 == '\"') ) { s = 5; }

                   	else if ( (LA11_26 == '\\') ) { s = 3; }

                   	else if ( ((LA11_26 >= '0' && LA11_26 <= '9') || (LA11_26 >= 'A' && LA11_26 <= 'F') || (LA11_26 >= 'a' && LA11_26 <= 'f')) ) { s = 29; }

                   	else if ( ((LA11_26 >= '\u0000' && LA11_26 <= '\t') || (LA11_26 >= '\u000B' && LA11_26 <= '!') || (LA11_26 >= '#' && LA11_26 <= '/') || (LA11_26 >= ':' && LA11_26 <= '@') || (LA11_26 >= 'G' && LA11_26 <= '[') || (LA11_26 >= ']' && LA11_26 <= '`') || (LA11_26 >= 'g' && LA11_26 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA11_30 = input.LA(1);

                   	s = -1;
                   	if ( ((LA11_30 >= '0' && LA11_30 <= '9') || (LA11_30 >= 'A' && LA11_30 <= 'F') || (LA11_30 >= 'a' && LA11_30 <= 'f')) ) { s = 33; }

                   	else if ( (LA11_30 == '\n' || LA11_30 == '\"') ) { s = 5; }

                   	else if ( (LA11_30 == '\\') ) { s = 3; }

                   	else if ( ((LA11_30 >= '\u0000' && LA11_30 <= '\t') || (LA11_30 >= '\u000B' && LA11_30 <= '!') || (LA11_30 >= '#' && LA11_30 <= '/') || (LA11_30 >= ':' && LA11_30 <= '@') || (LA11_30 >= 'G' && LA11_30 <= '[') || (LA11_30 >= ']' && LA11_30 <= '`') || (LA11_30 >= 'g' && LA11_30 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA11_25 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_25 == '\n' || LA11_25 == '\"') ) { s = 5; }

                   	else if ( (LA11_25 == '\\') ) { s = 3; }

                   	else if ( ((LA11_25 >= '0' && LA11_25 <= '9') || (LA11_25 >= 'A' && LA11_25 <= 'F') || (LA11_25 >= 'a' && LA11_25 <= 'f')) ) { s = 28; }

                   	else if ( ((LA11_25 >= '\u0000' && LA11_25 <= '\t') || (LA11_25 >= '\u000B' && LA11_25 <= '!') || (LA11_25 >= '#' && LA11_25 <= '/') || (LA11_25 >= ':' && LA11_25 <= '@') || (LA11_25 >= 'G' && LA11_25 <= '[') || (LA11_25 >= ']' && LA11_25 <= '`') || (LA11_25 >= 'g' && LA11_25 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA11_9 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_9 == '\n' || LA11_9 == '\"') ) { s = 5; }

                   	else if ( (LA11_9 == '\\') ) { s = 3; }

                   	else if ( ((LA11_9 >= '\u0000' && LA11_9 <= '\t') || (LA11_9 >= '\u000B' && LA11_9 <= '!') || (LA11_9 >= '#' && LA11_9 <= '[') || (LA11_9 >= ']' && LA11_9 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA11_8 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_8 == '\n' || LA11_8 == '\"') ) { s = 5; }

                   	else if ( (LA11_8 == '\\') ) { s = 3; }

                   	else if ( ((LA11_8 >= '\u0000' && LA11_8 <= '\t') || (LA11_8 >= '\u000B' && LA11_8 <= '!') || (LA11_8 >= '#' && LA11_8 <= '[') || (LA11_8 >= ']' && LA11_8 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA11_40 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_40 == '\n' || LA11_40 == '\"') ) { s = 5; }

                   	else if ( (LA11_40 == '\\') ) { s = 3; }

                   	else if ( ((LA11_40 >= '\u0000' && LA11_40 <= '\t') || (LA11_40 >= '\u000B' && LA11_40 <= '!') || (LA11_40 >= '#' && LA11_40 <= '[') || (LA11_40 >= ']' && LA11_40 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA11_34 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_34 == '\n' || LA11_34 == '\"') ) { s = 5; }

                   	else if ( (LA11_34 == '\\') ) { s = 3; }

                   	else if ( ((LA11_34 >= '\u0000' && LA11_34 <= '\t') || (LA11_34 >= '\u000B' && LA11_34 <= '!') || (LA11_34 >= '#' && LA11_34 <= '[') || (LA11_34 >= ']' && LA11_34 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA11_13 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_13 == '\n' || LA11_13 == '\"') ) { s = 5; }

                   	else if ( (LA11_13 == '\\') ) { s = 3; }

                   	else if ( ((LA11_13 >= '\u0000' && LA11_13 <= '\t') || (LA11_13 >= '\u000B' && LA11_13 <= '!') || (LA11_13 >= '#' && LA11_13 <= '[') || (LA11_13 >= ']' && LA11_13 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA11_12 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_12 == '\n' || LA11_12 == '\"') ) { s = 5; }

                   	else if ( (LA11_12 == '\\') ) { s = 3; }

                   	else if ( ((LA11_12 >= '\u0000' && LA11_12 <= '\t') || (LA11_12 >= '\u000B' && LA11_12 <= '!') || (LA11_12 >= '#' && LA11_12 <= '[') || (LA11_12 >= ']' && LA11_12 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA11_11 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_11 == '\n' || LA11_11 == '\"') ) { s = 5; }

                   	else if ( (LA11_11 == '\\') ) { s = 3; }

                   	else if ( ((LA11_11 >= '\u0000' && LA11_11 <= '\t') || (LA11_11 >= '\u000B' && LA11_11 <= '!') || (LA11_11 >= '#' && LA11_11 <= '[') || (LA11_11 >= ']' && LA11_11 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA11_24 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_24 == '\n' || LA11_24 == '\"') ) { s = 22; }

                   	else if ( ((LA11_24 >= '\u0000' && LA11_24 <= '\t') || (LA11_24 >= '\u000B' && LA11_24 <= '!') || (LA11_24 >= '#' && LA11_24 <= '\uFFFF')) ) { s = 24; }

                   	else s = 23;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA11_10 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_10 == '\n' || LA11_10 == '\"') ) { s = 5; }

                   	else if ( (LA11_10 == '\\') ) { s = 3; }

                   	else if ( ((LA11_10 >= '\u0000' && LA11_10 <= '\t') || (LA11_10 >= '\u000B' && LA11_10 <= '!') || (LA11_10 >= '#' && LA11_10 <= '[') || (LA11_10 >= ']' && LA11_10 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA11_17 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_17 == '\n' || LA11_17 == '\"') ) { s = 5; }

                   	else if ( (LA11_17 == '\\') ) { s = 3; }

                   	else if ( ((LA11_17 >= '\u0000' && LA11_17 <= '\t') || (LA11_17 >= '\u000B' && LA11_17 <= '!') || (LA11_17 >= '#' && LA11_17 <= '[') || (LA11_17 >= ']' && LA11_17 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA11_16 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_16 == '\n' || LA11_16 == '\"') ) { s = 5; }

                   	else if ( (LA11_16 == '\\') ) { s = 3; }

                   	else if ( ((LA11_16 >= '\u0000' && LA11_16 <= '\t') || (LA11_16 >= '\u000B' && LA11_16 <= '!') || (LA11_16 >= '#' && LA11_16 <= '[') || (LA11_16 >= ']' && LA11_16 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA11_28 = input.LA(1);

                   	s = -1;
                   	if ( ((LA11_28 >= '0' && LA11_28 <= '9') || (LA11_28 >= 'A' && LA11_28 <= 'F') || (LA11_28 >= 'a' && LA11_28 <= 'f')) ) { s = 31; }

                   	else if ( (LA11_28 == '\n' || LA11_28 == '\"') ) { s = 5; }

                   	else if ( (LA11_28 == '\\') ) { s = 3; }

                   	else if ( ((LA11_28 >= '\u0000' && LA11_28 <= '\t') || (LA11_28 >= '\u000B' && LA11_28 <= '!') || (LA11_28 >= '#' && LA11_28 <= '/') || (LA11_28 >= ':' && LA11_28 <= '@') || (LA11_28 >= 'G' && LA11_28 <= '[') || (LA11_28 >= ']' && LA11_28 <= '`') || (LA11_28 >= 'g' && LA11_28 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA11_15 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_15 == '\n' || LA11_15 == '\"') ) { s = 5; }

                   	else if ( (LA11_15 == '\\') ) { s = 3; }

                   	else if ( ((LA11_15 >= '\u0000' && LA11_15 <= '\t') || (LA11_15 >= '\u000B' && LA11_15 <= '!') || (LA11_15 >= '#' && LA11_15 <= '[') || (LA11_15 >= ']' && LA11_15 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA11_14 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_14 == '\n' || LA11_14 == '\"') ) { s = 5; }

                   	else if ( (LA11_14 == '\\') ) { s = 3; }

                   	else if ( ((LA11_14 >= '\u0000' && LA11_14 <= '\t') || (LA11_14 >= '\u000B' && LA11_14 <= '!') || (LA11_14 >= '#' && LA11_14 <= '[') || (LA11_14 >= ']' && LA11_14 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA11_21 = input.LA(1);

                   	s = -1;
                   	if ( ((LA11_21 >= '0' && LA11_21 <= '9') || (LA11_21 >= 'A' && LA11_21 <= 'F') || (LA11_21 >= 'a' && LA11_21 <= 'f')) ) { s = 27; }

                   	else if ( (LA11_21 == '\n' || LA11_21 == '\"') ) { s = 5; }

                   	else if ( (LA11_21 == '\\') ) { s = 3; }

                   	else if ( ((LA11_21 >= '\u0000' && LA11_21 <= '\t') || (LA11_21 >= '\u000B' && LA11_21 <= '!') || (LA11_21 >= '#' && LA11_21 <= '/') || (LA11_21 >= ':' && LA11_21 <= '@') || (LA11_21 >= 'G' && LA11_21 <= '[') || (LA11_21 >= ']' && LA11_21 <= '`') || (LA11_21 >= 'g' && LA11_21 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA11_27 = input.LA(1);

                   	s = -1;
                   	if ( ((LA11_27 >= '0' && LA11_27 <= '9') || (LA11_27 >= 'A' && LA11_27 <= 'F') || (LA11_27 >= 'a' && LA11_27 <= 'f')) ) { s = 30; }

                   	else if ( (LA11_27 == '\n' || LA11_27 == '\"') ) { s = 5; }

                   	else if ( (LA11_27 == '\\') ) { s = 3; }

                   	else if ( ((LA11_27 >= '\u0000' && LA11_27 <= '\t') || (LA11_27 >= '\u000B' && LA11_27 <= '!') || (LA11_27 >= '#' && LA11_27 <= '/') || (LA11_27 >= ':' && LA11_27 <= '@') || (LA11_27 >= 'G' && LA11_27 <= '[') || (LA11_27 >= ']' && LA11_27 <= '`') || (LA11_27 >= 'g' && LA11_27 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA11_39 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_39 == '\n' || LA11_39 == '\"') ) { s = 5; }

                   	else if ( (LA11_39 == '\\') ) { s = 3; }

                   	else if ( ((LA11_39 >= '0' && LA11_39 <= '9') || (LA11_39 >= 'A' && LA11_39 <= 'F') || (LA11_39 >= 'a' && LA11_39 <= 'f')) ) { s = 40; }

                   	else if ( ((LA11_39 >= '\u0000' && LA11_39 <= '\t') || (LA11_39 >= '\u000B' && LA11_39 <= '!') || (LA11_39 >= '#' && LA11_39 <= '/') || (LA11_39 >= ':' && LA11_39 <= '@') || (LA11_39 >= 'G' && LA11_39 <= '[') || (LA11_39 >= ']' && LA11_39 <= '`') || (LA11_39 >= 'g' && LA11_39 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA11_7 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_7 == '\n' || LA11_7 == '\"') ) { s = 22; }

                   	else if ( ((LA11_7 >= '\u0000' && LA11_7 <= '\t') || (LA11_7 >= '\u000B' && LA11_7 <= '!') || (LA11_7 >= '#' && LA11_7 <= '\uFFFF')) ) { s = 24; }

                   	else s = 23;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA11_19 = input.LA(1);

                   	s = -1;
                   	if ( ((LA11_19 >= '0' && LA11_19 <= '9') || (LA11_19 >= 'A' && LA11_19 <= 'F') || (LA11_19 >= 'a' && LA11_19 <= 'f')) ) { s = 25; }

                   	else if ( (LA11_19 == '\n' || LA11_19 == '\"') ) { s = 5; }

                   	else if ( (LA11_19 == '\\') ) { s = 3; }

                   	else if ( ((LA11_19 >= '\u0000' && LA11_19 <= '\t') || (LA11_19 >= '\u000B' && LA11_19 <= '!') || (LA11_19 >= '#' && LA11_19 <= '/') || (LA11_19 >= ':' && LA11_19 <= '@') || (LA11_19 >= 'G' && LA11_19 <= '[') || (LA11_19 >= ']' && LA11_19 <= '`') || (LA11_19 >= 'g' && LA11_19 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA11_18 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_18 == '\n' || LA11_18 == '\"') ) { s = 5; }

                   	else if ( (LA11_18 == '\\') ) { s = 3; }

                   	else if ( ((LA11_18 >= '\u0000' && LA11_18 <= '\t') || (LA11_18 >= '\u000B' && LA11_18 <= '!') || (LA11_18 >= '#' && LA11_18 <= '[') || (LA11_18 >= ']' && LA11_18 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA11_37 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_37 == '\n' || LA11_37 == '\"') ) { s = 5; }

                   	else if ( (LA11_37 == '\\') ) { s = 3; }

                   	else if ( ((LA11_37 >= '0' && LA11_37 <= '9') || (LA11_37 >= 'A' && LA11_37 <= 'F') || (LA11_37 >= 'a' && LA11_37 <= 'f')) ) { s = 38; }

                   	else if ( ((LA11_37 >= '\u0000' && LA11_37 <= '\t') || (LA11_37 >= '\u000B' && LA11_37 <= '!') || (LA11_37 >= '#' && LA11_37 <= '/') || (LA11_37 >= ':' && LA11_37 <= '@') || (LA11_37 >= 'G' && LA11_37 <= '[') || (LA11_37 >= ']' && LA11_37 <= '`') || (LA11_37 >= 'g' && LA11_37 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA11_35 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_35 == '\n' || LA11_35 == '\"') ) { s = 5; }

                   	else if ( (LA11_35 == '\\') ) { s = 3; }

                   	else if ( ((LA11_35 >= '\u0000' && LA11_35 <= '\t') || (LA11_35 >= '\u000B' && LA11_35 <= '!') || (LA11_35 >= '#' && LA11_35 <= '[') || (LA11_35 >= ']' && LA11_35 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA11_6 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_6 == '\n' || LA11_6 == '\"') ) { s = 5; }

                   	else if ( (LA11_6 == '\\') ) { s = 3; }

                   	else if ( ((LA11_6 >= '\u0000' && LA11_6 <= '\t') || (LA11_6 >= '\u000B' && LA11_6 <= '!') || (LA11_6 >= '#' && LA11_6 <= '[') || (LA11_6 >= ']' && LA11_6 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA11_32 = input.LA(1);

                   	s = -1;
                   	if ( ((LA11_32 >= '0' && LA11_32 <= '9') || (LA11_32 >= 'A' && LA11_32 <= 'F') || (LA11_32 >= 'a' && LA11_32 <= 'f')) ) { s = 35; }

                   	else if ( (LA11_32 == '\n' || LA11_32 == '\"') ) { s = 5; }

                   	else if ( (LA11_32 == '\\') ) { s = 3; }

                   	else if ( ((LA11_32 >= '\u0000' && LA11_32 <= '\t') || (LA11_32 >= '\u000B' && LA11_32 <= '!') || (LA11_32 >= '#' && LA11_32 <= '/') || (LA11_32 >= ':' && LA11_32 <= '@') || (LA11_32 >= 'G' && LA11_32 <= '[') || (LA11_32 >= ']' && LA11_32 <= '`') || (LA11_32 >= 'g' && LA11_32 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA11_31 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_31 == '\n' || LA11_31 == '\"') ) { s = 5; }

                   	else if ( (LA11_31 == '\\') ) { s = 3; }

                   	else if ( ((LA11_31 >= '0' && LA11_31 <= '9') || (LA11_31 >= 'A' && LA11_31 <= 'F') || (LA11_31 >= 'a' && LA11_31 <= 'f')) ) { s = 34; }

                   	else if ( ((LA11_31 >= '\u0000' && LA11_31 <= '\t') || (LA11_31 >= '\u000B' && LA11_31 <= '!') || (LA11_31 >= '#' && LA11_31 <= '/') || (LA11_31 >= ':' && LA11_31 <= '@') || (LA11_31 >= 'G' && LA11_31 <= '[') || (LA11_31 >= ']' && LA11_31 <= '`') || (LA11_31 >= 'g' && LA11_31 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA11_29 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_29 == '\n' || LA11_29 == '\"') ) { s = 5; }

                   	else if ( (LA11_29 == '\\') ) { s = 3; }

                   	else if ( ((LA11_29 >= '0' && LA11_29 <= '9') || (LA11_29 >= 'A' && LA11_29 <= 'F') || (LA11_29 >= 'a' && LA11_29 <= 'f')) ) { s = 32; }

                   	else if ( ((LA11_29 >= '\u0000' && LA11_29 <= '\t') || (LA11_29 >= '\u000B' && LA11_29 <= '!') || (LA11_29 >= '#' && LA11_29 <= '/') || (LA11_29 >= ':' && LA11_29 <= '@') || (LA11_29 >= 'G' && LA11_29 <= '[') || (LA11_29 >= ']' && LA11_29 <= '`') || (LA11_29 >= 'g' && LA11_29 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA11_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_1 == '\\') ) { s = 3; }

                   	else if ( (LA11_1 == '\n' || LA11_1 == '\"') ) { s = 5; }

                   	else if ( ((LA11_1 >= '\u0000' && LA11_1 <= '\t') || (LA11_1 >= '\u000B' && LA11_1 <= '!') || (LA11_1 >= '#' && LA11_1 <= '[') || (LA11_1 >= ']' && LA11_1 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA11_33 = input.LA(1);

                   	s = -1;
                   	if ( ((LA11_33 >= '0' && LA11_33 <= '9') || (LA11_33 >= 'A' && LA11_33 <= 'F') || (LA11_33 >= 'a' && LA11_33 <= 'f')) ) { s = 36; }

                   	else if ( (LA11_33 == '\n' || LA11_33 == '\"') ) { s = 5; }

                   	else if ( (LA11_33 == '\\') ) { s = 3; }

                   	else if ( ((LA11_33 >= '\u0000' && LA11_33 <= '\t') || (LA11_33 >= '\u000B' && LA11_33 <= '!') || (LA11_33 >= '#' && LA11_33 <= '/') || (LA11_33 >= ':' && LA11_33 <= '@') || (LA11_33 >= 'G' && LA11_33 <= '[') || (LA11_33 >= ']' && LA11_33 <= '`') || (LA11_33 >= 'g' && LA11_33 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA11_38 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_38 == '\n' || LA11_38 == '\"') ) { s = 5; }

                   	else if ( (LA11_38 == '\\') ) { s = 3; }

                   	else if ( ((LA11_38 >= '0' && LA11_38 <= '9') || (LA11_38 >= 'A' && LA11_38 <= 'F') || (LA11_38 >= 'a' && LA11_38 <= 'f')) ) { s = 39; }

                   	else if ( ((LA11_38 >= '\u0000' && LA11_38 <= '\t') || (LA11_38 >= '\u000B' && LA11_38 <= '!') || (LA11_38 >= '#' && LA11_38 <= '/') || (LA11_38 >= ':' && LA11_38 <= '@') || (LA11_38 >= 'G' && LA11_38 <= '[') || (LA11_38 >= ']' && LA11_38 <= '`') || (LA11_38 >= 'g' && LA11_38 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA11_20 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_20 == '\n' || LA11_20 == '\"') ) { s = 5; }

                   	else if ( (LA11_20 == '\\') ) { s = 3; }

                   	else if ( ((LA11_20 >= '0' && LA11_20 <= '9') || (LA11_20 >= 'A' && LA11_20 <= 'F') || (LA11_20 >= 'a' && LA11_20 <= 'f')) ) { s = 26; }

                   	else if ( ((LA11_20 >= '\u0000' && LA11_20 <= '\t') || (LA11_20 >= '\u000B' && LA11_20 <= '!') || (LA11_20 >= '#' && LA11_20 <= '/') || (LA11_20 >= ':' && LA11_20 <= '@') || (LA11_20 >= 'G' && LA11_20 <= '[') || (LA11_20 >= ']' && LA11_20 <= '`') || (LA11_20 >= 'g' && LA11_20 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA11_36 = input.LA(1);

                   	s = -1;
                   	if ( (LA11_36 == '\n' || LA11_36 == '\"') ) { s = 5; }

                   	else if ( (LA11_36 == '\\') ) { s = 3; }

                   	else if ( ((LA11_36 >= '0' && LA11_36 <= '9') || (LA11_36 >= 'A' && LA11_36 <= 'F') || (LA11_36 >= 'a' && LA11_36 <= 'f')) ) { s = 37; }

                   	else if ( ((LA11_36 >= '\u0000' && LA11_36 <= '\t') || (LA11_36 >= '\u000B' && LA11_36 <= '!') || (LA11_36 >= '#' && LA11_36 <= '/') || (LA11_36 >= ':' && LA11_36 <= '@') || (LA11_36 >= 'G' && LA11_36 <= '[') || (LA11_36 >= ']' && LA11_36 <= '`') || (LA11_36 >= 'g' && LA11_36 <= '\uFFFF')) ) { s = 6; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae11 =
            new NoViableAltException(dfa.Description, 11, _s, input);
        dfa.Error(nvae11);
        throw nvae11;
    }
    const string DFA14_eotS =
        "\x01\uffff\x01\x04\x01\uffff\x01\x04\x01\uffff\x0e\x04\x01\uffff"+
        "\x10\x04";
    const string DFA14_eofS =
        "\x24\uffff";
    const string DFA14_minS =
        "\x01\x27\x01\x00\x01\x22\x01\x27\x01\uffff\x0e\x27\x01\uffff\x10"+
        "\x27";
    const string DFA14_maxS =
        "\x01\x27\x01\uffff\x01\x78\x01\x27\x01\uffff\x0b\x27\x03\x66\x01"+
        "\uffff\x09\x66\x02\x27\x04\x66\x01\x27";
    const string DFA14_acceptS =
        "\x04\uffff\x01\x02\x0e\uffff\x01\x01\x10\uffff";
    const string DFA14_specialS =
        "\x01\uffff\x01\x00\x22\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x01\x01",
            "\x5c\x03\x01\x02\uffa3\x03",
            "\x01\x0d\x04\uffff\x01\x0e\x08\uffff\x01\x0c\x24\uffff\x01"+
            "\x12\x06\uffff\x01\x0f\x04\uffff\x01\x05\x01\x06\x03\uffff\x01"+
            "\x07\x07\uffff\x01\x08\x03\uffff\x01\x09\x01\uffff\x01\x0a\x01"+
            "\x11\x01\x0b\x01\uffff\x01\x10",
            "\x01\x13",
            "",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13\x08\uffff\x0a\x14\x07\uffff\x06\x14\x1a\uffff\x06"+
            "\x14",
            "\x01\x13\x08\uffff\x0a\x15\x07\uffff\x06\x15\x1a\uffff\x06"+
            "\x15",
            "\x01\x13\x08\uffff\x0a\x16\x07\uffff\x06\x16\x1a\uffff\x06"+
            "\x16",
            "",
            "\x01\x13\x08\uffff\x0a\x17\x07\uffff\x06\x17\x1a\uffff\x06"+
            "\x17",
            "\x01\x13\x08\uffff\x0a\x18\x07\uffff\x06\x18\x1a\uffff\x06"+
            "\x18",
            "\x01\x13\x08\uffff\x0a\x19\x07\uffff\x06\x19\x1a\uffff\x06"+
            "\x19",
            "\x01\x13\x08\uffff\x0a\x1a\x07\uffff\x06\x1a\x1a\uffff\x06"+
            "\x1a",
            "\x01\x13\x08\uffff\x0a\x1b\x07\uffff\x06\x1b\x1a\uffff\x06"+
            "\x1b",
            "\x01\x13\x08\uffff\x0a\x1c\x07\uffff\x06\x1c\x1a\uffff\x06"+
            "\x1c",
            "\x01\x13\x08\uffff\x0a\x1d\x07\uffff\x06\x1d\x1a\uffff\x06"+
            "\x1d",
            "\x01\x13\x08\uffff\x0a\x1e\x07\uffff\x06\x1e\x1a\uffff\x06"+
            "\x1e",
            "\x01\x13\x08\uffff\x0a\x1f\x07\uffff\x06\x1f\x1a\uffff\x06"+
            "\x1f",
            "\x01\x13",
            "\x01\x13",
            "\x01\x13\x08\uffff\x0a\x20\x07\uffff\x06\x20\x1a\uffff\x06"+
            "\x20",
            "\x01\x13\x08\uffff\x0a\x21\x07\uffff\x06\x21\x1a\uffff\x06"+
            "\x21",
            "\x01\x13\x08\uffff\x0a\x22\x07\uffff\x06\x22\x1a\uffff\x06"+
            "\x22",
            "\x01\x13\x08\uffff\x0a\x23\x07\uffff\x06\x23\x1a\uffff\x06"+
            "\x23",
            "\x01\x13"
    };

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "87:1: CHAR : ( '\\'' ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' ) '\\'' | '\\'' ( ( '\\\\' ESC_SEQ ) | ~ '\\\\' )? );"; }
        }

    }


    protected internal int DFA14_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA14_1 = input.LA(1);

                   	s = -1;
                   	if ( (LA14_1 == '\\') ) { s = 2; }

                   	else if ( ((LA14_1 >= '\u0000' && LA14_1 <= '[') || (LA14_1 >= ']' && LA14_1 <= '\uFFFF')) ) { s = 3; }

                   	else s = 4;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae14 =
            new NoViableAltException(dfa.Description, 14, _s, input);
        dfa.Error(nvae14);
        throw nvae14;
    }
    const string DFA16_eotS =
        "\x07\uffff\x01\x0d\x01\x10\x08\uffff";
    const string DFA16_eofS =
        "\x11\uffff";
    const string DFA16_minS =
        "\x01\x44\x06\uffff\x02\x4c\x08\uffff";
    const string DFA16_maxS =
        "\x01\x75\x06\uffff\x02\x6c\x08\uffff";
    const string DFA16_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x02"+
        "\uffff\x01\x09\x01\x0a\x01\x0b\x01\x0d\x01\x07\x01\x0c\x01\x0e\x01"+
        "\x08";
    const string DFA16_specialS =
        "\x11\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x01\x06\x01\uffff\x01\x02\x05\uffff\x01\x0a\x01\x04\x07\uffff"+
            "\x01\x08\x0e\uffff\x01\x05\x01\uffff\x01\x01\x05\uffff\x01\x09"+
            "\x01\x03\x07\uffff\x01\x07",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x1f\uffff\x01\x0b",
            "\x01\x0f\x1f\uffff\x01\x0e",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "92:11: ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' | 'u' | 'U' | 'l' | 'L' | 'ul' | 'Ul' | 'uL' | 'UL' )"; }
        }

    }

    const string DFA46_eotS =
        "\x01\uffff\x01\x03\x02\uffff\x01\x08\x01\x0b\x01\uffff\x01\x0d"+
        "\x01\uffff\x01\x10\x01\x12\x06\uffff\x01\x17\x01\uffff\x01\x18\x01"+
        "\uffff\x01\x19\x04\uffff";
    const string DFA46_eofS =
        "\x1a\uffff";
    const string DFA46_minS =
        "\x02\x2e\x01\x30\x01\uffff\x01\x30\x01\x2b\x01\uffff\x01\x30\x01"+
        "\uffff\x02\x30\x03\uffff\x01\x2b\x02\uffff\x01\x2b\x01\uffff\x01"+
        "\x30\x01\uffff\x01\x30\x04\uffff";
    const string DFA46_maxS =
        "\x01\x39\x01\x75\x01\x39\x01\uffff\x02\x39\x01\uffff\x01\x6d\x01"+
        "\uffff\x01\x6d\x01\x39\x03\uffff\x01\x39\x02\uffff\x01\x39\x01\uffff"+
        "\x01\x39\x01\uffff\x01\x39\x04\uffff";
    const string DFA46_acceptS =
        "\x03\uffff\x01\x07\x02\uffff\x01\x0d\x01\uffff\x01\x0a\x02\uffff"+
        "\x01\x0b\x01\x01\x01\x09\x01\uffff\x01\x0e\x01\x08\x01\uffff\x01"+
        "\x04\x01\uffff\x01\x03\x01\uffff\x01\x02\x01\x0c\x01\x06\x01\x05";
    const string DFA46_specialS =
        "\x1a\uffff}>";
    static readonly string[] DFA46_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x04\x01\uffff\x0a\x01\x0a\uffff\x01\x06\x01\x05\x01\x06"+
            "\x05\uffff\x02\x06\x07\uffff\x01\x06\x0e\uffff\x01\x06\x01\x05"+
            "\x01\x06\x05\uffff\x02\x06\x07\uffff\x01\x06",
            "\x0a\x07",
            "",
            "\x0a\x09",
            "\x01\x0a\x01\uffff\x01\x0a\x02\uffff\x0a\x0c",
            "",
            "\x0a\x07\x0a\uffff\x01\x0f\x01\x0e\x01\x0f\x06\uffff\x01\x0f"+
            "\x16\uffff\x01\x0f\x01\x0e\x01\x0f\x06\uffff\x01\x0f",
            "",
            "\x0a\x09\x0a\uffff\x01\x0f\x01\x11\x01\x0f\x06\uffff\x01\x0f"+
            "\x16\uffff\x01\x0f\x01\x11\x01\x0f\x06\uffff\x01\x0f",
            "\x0a\x0c",
            "",
            "",
            "",
            "\x01\x13\x01\uffff\x01\x13\x02\uffff\x0a\x14",
            "",
            "",
            "\x01\x15\x01\uffff\x01\x15\x02\uffff\x0a\x16",
            "",
            "\x0a\x14",
            "",
            "\x0a\x16",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA46_eot = DFA.UnpackEncodedString(DFA46_eotS);
    static readonly short[] DFA46_eof = DFA.UnpackEncodedString(DFA46_eofS);
    static readonly char[] DFA46_min = DFA.UnpackEncodedStringToUnsignedChars(DFA46_minS);
    static readonly char[] DFA46_max = DFA.UnpackEncodedStringToUnsignedChars(DFA46_maxS);
    static readonly short[] DFA46_accept = DFA.UnpackEncodedString(DFA46_acceptS);
    static readonly short[] DFA46_special = DFA.UnpackEncodedString(DFA46_specialS);
    static readonly short[][] DFA46_transition = DFA.UnpackEncodedStringArray(DFA46_transitionS);

    protected class DFA46 : DFA
    {
        public DFA46(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 46;
            this.eot = DFA46_eot;
            this.eof = DFA46_eof;
            this.min = DFA46_min;
            this.max = DFA46_max;
            this.accept = DFA46_accept;
            this.special = DFA46_special;
            this.transition = DFA46_transition;

        }

        override public string Description
        {
            get { return "100:1: NUM : ( ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )? | ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )? | DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' )? ( DIGIT )+ ( 'f' | 'F' | 'm' | 'M' | 'd' | 'D' )? | ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' ) | ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' ) | DOT ( DIGIT )+ ( 'e' | 'E' ) ( '+' | '-' ) | ( DIGIT )+ | ( DIGIT )+ DOT ( DIGIT )+ | DOT ( DIGIT )+ | ( DIGIT )+ DOT | ( DIGIT )+ ( 'e' | 'E' ) | ( DIGIT )+ DOT ( DIGIT )+ ( 'e' | 'E' ) | INTWITHSUFFIX | FLTWITHSUFFIX );"; }
        }

    }

    const string DFA47_eotS =
        "\x3e\uffff\x01\x5d\x03\uffff\x01\x65\x0d\uffff\x01\x6f\x0b\uffff"+
        "\x01\x73\x1a\uffff";
    const string DFA47_eofS =
        "\x77\uffff";
    const string DFA47_minS =
        "\x01\x61\x01\x62\x01\x6c\x01\x61\x01\x62\x01\x61\x01\x62\x01\x68"+
        "\x03\x61\x01\x69\x01\uffff\x01\x66\x02\x65\x01\x69\x01\uffff\x01"+
        "\x6f\x03\uffff\x01\x70\x05\uffff\x01\x61\x0d\uffff\x01\x69\x01\x75"+
        "\x02\uffff\x01\x6e\x01\uffff\x01\x72\x01\x73\x01\x61\x01\uffff\x01"+
        "\x6e\x01\uffff\x01\x69\x03\uffff\x01\x63\x01\x68\x02\uffff\x01\x74"+
        "\x01\uffff\x01\x61\x01\x63\x01\x75\x01\uffff\x01\x69\x01\x63\x02"+
        "\uffff\x01\x69\x01\x63\x06\uffff\x01\x65\x04\uffff\x01\x73\x06\uffff"+
        "\x01\x65\x15\uffff\x01\x72\x01\uffff\x01\x66\x02\uffff";
    const string DFA47_maxS =
        "\x01\x77\x01\x73\x01\x78\x01\x75\x01\x77\x01\x79\x01\x76\x01\x79"+
        "\x02\x6f\x01\x75\x01\x73\x01\uffff\x01\x73\x01\x65\x02\x6f\x01\uffff"+
        "\x01\x6f\x03\uffff\x01\x74\x05\uffff\x01\x72\x0d\uffff\x01\x72\x01"+
        "\x79\x02\uffff\x01\x78\x01\uffff\x01\x72\x01\x74\x01\x65\x01\uffff"+
        "\x01\x6e\x01\uffff\x01\x6f\x03\uffff\x01\x73\x01\x69\x02\uffff\x01"+
        "\x74\x01\uffff\x01\x74\x01\x6c\x01\x75\x01\uffff\x01\x6c\x01\x6e"+
        "\x02\uffff\x01\x75\x01\x74\x06\uffff\x01\x65\x04\uffff\x01\x74\x06"+
        "\uffff\x01\x65\x15\uffff\x01\x72\x01\uffff\x01\x6e\x02\uffff";
    const string DFA47_acceptS =
        "\x0c\uffff\x01\x26\x04\uffff\x01\x44\x01\uffff\x01\x01\x01\x05"+
        "\x01\x02\x01\uffff\x01\x48\x01\x4b\x01\x03\x01\x07\x01\x4c\x01\uffff"+
        "\x01\x08\x01\x37\x01\x3b\x01\x3f\x01\x43\x01\x09\x01\x0d\x01\x11"+
        "\x01\x15\x01\x0b\x01\x0f\x01\x13\x01\x17\x02\uffff\x01\x1c\x01\x0e"+
        "\x01\uffff\x01\x1a\x03\uffff\x01\x29\x01\uffff\x01\x1b\x01\uffff"+
        "\x01\x27\x01\x20\x01\x24\x02\uffff\x01\x2a\x01\x2e\x01\uffff\x01"+
        "\x42\x03\uffff\x01\x38\x02\uffff\x01\x06\x01\x0a\x02\uffff\x01\x0c"+
        "\x01\x10\x01\x14\x01\x18\x01\x12\x01\x16\x01\uffff\x01\x19\x01\x1d"+
        "\x01\x21\x01\x25\x01\uffff\x01\x1f\x01\x23\x01\x28\x01\x2c\x01\x30"+
        "\x01\x34\x01\uffff\x01\x32\x01\x2b\x01\x2f\x01\x33\x01\x35\x01\x39"+
        "\x01\x3d\x01\x45\x01\x41\x01\x3c\x01\x40\x01\x46\x01\x49\x01\x04"+
        "\x01\x4d\x01\x47\x01\x4a\x01\x22\x01\x1e\x01\x2d\x01\x31\x01\uffff"+
        "\x01\x36\x01\uffff\x01\x3a\x01\x3e";
    const string DFA47_specialS =
        "\x77\uffff}>";
    static readonly string[] DFA47_transitionS = {
            "\x01\x01\x01\x05\x01\x09\x01\x0f\x01\x02\x01\x08\x01\x0c\x01"+
            "\uffff\x01\x0d\x02\uffff\x01\x12\x01\uffff\x01\x03\x01\x06\x01"+
            "\x0a\x01\uffff\x01\x0e\x01\x04\x01\x07\x01\x0b\x01\x10\x01\x11",
            "\x01\x13\x10\uffff\x01\x14",
            "\x01\x17\x01\uffff\x01\x18\x07\uffff\x01\x15\x01\uffff\x01"+
            "\x16",
            "\x01\x1b\x03\uffff\x01\x19\x0f\uffff\x01\x1a",
            "\x01\x1e\x02\uffff\x01\x1f\x02\uffff\x01\x20\x01\x21\x0a\uffff"+
            "\x01\x1c\x02\uffff\x01\x1d",
            "\x01\x22\x0d\uffff\x01\x23\x02\uffff\x01\x24\x06\uffff\x01"+
            "\x25",
            "\x01\x26\x0d\uffff\x01\x27\x04\uffff\x01\x28\x01\x29",
            "\x01\x2a\x09\uffff\x01\x2b\x06\uffff\x01\x2c",
            "\x01\x2d\x07\uffff\x01\x2e\x02\uffff\x01\x2f\x02\uffff\x01"+
            "\x30",
            "\x01\x31\x06\uffff\x01\x32\x03\uffff\x01\x33\x02\uffff\x01"+
            "\x34",
            "\x01\x35\x10\uffff\x01\x36\x02\uffff\x01\x37",
            "\x01\x38\x02\uffff\x01\x39\x01\uffff\x01\x3a\x04\uffff\x01"+
            "\x3b",
            "",
            "\x01\x3c\x06\uffff\x01\x3d\x01\x3e\x04\uffff\x01\x3f",
            "\x01\x40",
            "\x01\x41\x09\uffff\x01\x42",
            "\x01\x43\x05\uffff\x01\x44",
            "",
            "\x01\x45",
            "",
            "",
            "",
            "\x01\x46\x03\uffff\x01\x47",
            "",
            "",
            "",
            "",
            "",
            "\x01\x49\x10\uffff\x01\x48",
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
            "\x01\x4a\x08\uffff\x01\x4b",
            "\x01\x4c\x03\uffff\x01\x4d",
            "",
            "",
            "\x01\x4e\x09\uffff\x01\x4f",
            "",
            "\x01\x50",
            "\x01\x51\x01\x52",
            "\x01\x53\x03\uffff\x01\x54",
            "",
            "\x01\x55",
            "",
            "\x01\x56\x05\uffff\x01\x57",
            "",
            "",
            "",
            "\x01\x58\x0f\uffff\x01\x59",
            "\x01\x5a\x01\x5b",
            "",
            "",
            "\x01\x5c",
            "",
            "\x01\x5e\x04\uffff\x01\x5f\x0d\uffff\x01\x60",
            "\x01\x61\x02\uffff\x01\x62\x05\uffff\x01\x63",
            "\x01\x64",
            "",
            "\x01\x67\x02\uffff\x01\x66",
            "\x01\x68\x0a\uffff\x01\x69",
            "",
            "",
            "\x01\x6b\x0b\uffff\x01\x6a",
            "\x01\x6c\x10\uffff\x01\x6d",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x6e",
            "",
            "",
            "",
            "",
            "\x01\x70\x01\x71",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x72",
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
            "\x01\x74",
            "",
            "\x01\x75\x07\uffff\x01\x76",
            "",
            ""
    };

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "119:1: KEYWORD : ( 'abstract' | 'event' | 'new' | 'struct' | 'as' | 'explicit' | 'null' | 'switch' | 'base' | 'extern' | 'object' | 'this' | 'bool' | 'false' | 'operator' | 'throw' | 'break' | 'finally' | 'out' | 'true' | 'byte' | 'fixed' | 'override' | 'try' | 'case' | 'float' | 'params' | 'typeof' | 'catch' | 'for' | 'private' | 'uint' | 'char' | 'foreach' | 'protected' | 'ulong' | 'checked' | 'goto' | 'public' | 'unchecked' | 'class' | 'if' | 'readonly' | 'unsafe' | 'const' | 'implicit' | 'ref' | 'ushort' | 'continue' | 'in' | 'return' | 'using' | 'decimal' | 'int' | 'sbyte' | 'virtual' | 'default' | 'interface' | 'sealed' | 'volatile' | 'delegate' | 'internal' | 'short' | 'void' | 'do' | 'is' | 'sizeof' | 'while' | 'double' | 'lock' | 'stackalloc' | 'else' | 'long' | 'static' | 'enum' | 'namespace' | 'string' );"; }
        }

    }

    const string DFA50_eotS =
        "\x01\uffff\x01\x1a\x01\x1e\x01\uffff\x01\x20\x03\uffff\x01\x23"+
        "\x01\x26\x01\x28\x01\x2a\x01\x2d\x01\x30\x02\uffff\x01\x32\x01\x34"+
        "\x01\x37\x01\x39\x17\uffff\x01\x3b\x02\uffff\x01\x3d\x0f\uffff";
    const string DFA50_eofS =
        "\x3e\uffff";
    const string DFA50_minS =
        "\x01\x21\x01\x2b\x01\x2d\x01\uffff\x01\x3d\x03\uffff\x01\x26\x01"+
        "\x2a\x02\x3d\x01\x3c\x01\x3d\x02\uffff\x03\x3d\x01\x3f\x17\uffff"+
        "\x01\x3d\x02\uffff\x01\x3d\x0f\uffff";
    const string DFA50_maxS =
        "\x01\x7e\x01\x3d\x01\x3e\x01\uffff\x01\x3d\x03\uffff\x05\x3d\x01"+
        "\x3e\x02\uffff\x02\x3d\x01\x7c\x01\x3f\x17\uffff\x01\x3d\x02\uffff"+
        "\x01\x3d\x0f\uffff";
    const string DFA50_acceptS =
        "\x03\uffff\x01\x04\x01\uffff\x01\x08\x01\x09\x01\x0a\x06\uffff"+
        "\x01\x14\x01\x15\x04\uffff\x01\x1f\x01\x2c\x01\x2d\x01\x2e\x01\x01"+
        "\x01\x21\x01\x05\x01\x02\x01\x03\x01\x22\x01\x06\x01\x19\x01\x07"+
        "\x01\x1c\x01\x26\x01\x0b\x01\x0d\x01\x23\x01\x0c\x01\x24\x01\x0e"+
        "\x01\x25\x01\x0f\x01\uffff\x01\x16\x01\x12\x01\uffff\x01\x17\x01"+
        "\x13\x01\x18\x01\x20\x01\x28\x01\x1a\x01\x1d\x01\x27\x01\x1b\x01"+
        "\x2b\x01\x1e\x01\x29\x01\x10\x01\x2a\x01\x11";
    const string DFA50_specialS =
        "\x3e\uffff}>";
    static readonly string[] DFA50_transitionS = {
            "\x01\x04\x03\uffff\x01\x0b\x01\x08\x01\uffff\x01\x06\x01\x07"+
            "\x01\x09\x01\x01\x01\x15\x01\x02\x01\x03\x01\x0a\x0a\uffff\x01"+
            "\x14\x01\x16\x01\x0c\x01\x10\x01\x0d\x01\x13\x01\x17\x1a\uffff"+
            "\x01\x0e\x01\uffff\x01\x0f\x01\x11\x1d\uffff\x01\x12\x01\uffff"+
            "\x01\x05",
            "\x01\x18\x11\uffff\x01\x19",
            "\x01\x1b\x0f\uffff\x01\x1d\x01\x1c",
            "",
            "\x01\x1f",
            "",
            "",
            "",
            "\x01\x21\x16\uffff\x01\x22",
            "\x01\x24\x12\uffff\x01\x25",
            "\x01\x27",
            "\x01\x29",
            "\x01\x2b\x01\x2c",
            "\x01\x2f\x01\x2e",
            "",
            "",
            "\x01\x31",
            "\x01\x33",
            "\x01\x36\x3e\uffff\x01\x35",
            "\x01\x38",
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
            "\x01\x3a",
            "",
            "",
            "\x01\x3c",
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

    static readonly short[] DFA50_eot = DFA.UnpackEncodedString(DFA50_eotS);
    static readonly short[] DFA50_eof = DFA.UnpackEncodedString(DFA50_eofS);
    static readonly char[] DFA50_min = DFA.UnpackEncodedStringToUnsignedChars(DFA50_minS);
    static readonly char[] DFA50_max = DFA.UnpackEncodedStringToUnsignedChars(DFA50_maxS);
    static readonly short[] DFA50_accept = DFA.UnpackEncodedString(DFA50_acceptS);
    static readonly short[] DFA50_special = DFA.UnpackEncodedString(DFA50_specialS);
    static readonly short[][] DFA50_transition = DFA.UnpackEncodedStringArray(DFA50_transitionS);

    protected class DFA50 : DFA
    {
        public DFA50(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 50;
            this.eot = DFA50_eot;
            this.eof = DFA50_eof;
            this.min = DFA50_min;
            this.max = DFA50_max;
            this.accept = DFA50_accept;
            this.special = DFA50_special;
            this.transition = DFA50_transition;

        }

        override public string Description
        {
            get { return "143:1: OP : ( '++' | '--' | '->' | '.' | '+' | '-' | '!' | '~' | '(' | ')' | '&' | '*' | '**' | '/' | '%' | '<<' | '>>' | '<' | '>' | '[' | ']' | '<=' | '>=' | '==' | '!=' | '^' | '|' | '&&' | '||' | '?' | ':' | '=' | '+=' | '-=' | '*=' | '/=' | '%=' | '&=' | '|=' | '^=' | '<<=' | '>>=' | '??' | ',' | ';' | '@' );"; }
        }

    }

    const string DFA54_eotS =
        "\x02\uffff\x01\x07\x01\uffff\x02\x07\x03\uffff";
    const string DFA54_eofS =
        "\x09\uffff";
    const string DFA54_minS =
        "\x01\x2f\x01\x2a\x01\x00\x01\uffff\x02\x00\x03\uffff";
    const string DFA54_maxS =
        "\x02\x2f\x01\uffff\x01\uffff\x02\uffff\x03\uffff";
    const string DFA54_acceptS =
        "\x03\uffff\x01\x03\x02\uffff\x01\x01\x01\x02\x01\x01";
    const string DFA54_specialS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x01\x00\x03\uffff}>";
    static readonly string[] DFA54_transitionS = {
            "\x01\x01",
            "\x01\x02\x04\uffff\x01\x03",
            "\x0a\x05\x01\x06\x1f\x05\x01\x04\uffd5\x05",
            "",
            "\x0a\x05\x01\x06\x1f\x05\x01\x04\x04\x05\x01\x08\uffd0\x05",
            "\x0a\x05\x01\x06\x1f\x05\x01\x04\uffd5\x05",
            "",
            "",
            ""
    };

    static readonly short[] DFA54_eot = DFA.UnpackEncodedString(DFA54_eotS);
    static readonly short[] DFA54_eof = DFA.UnpackEncodedString(DFA54_eofS);
    static readonly char[] DFA54_min = DFA.UnpackEncodedStringToUnsignedChars(DFA54_minS);
    static readonly char[] DFA54_max = DFA.UnpackEncodedStringToUnsignedChars(DFA54_maxS);
    static readonly short[] DFA54_accept = DFA.UnpackEncodedString(DFA54_acceptS);
    static readonly short[] DFA54_special = DFA.UnpackEncodedString(DFA54_specialS);
    static readonly short[][] DFA54_transition = DFA.UnpackEncodedStringArray(DFA54_transitionS);

    protected class DFA54 : DFA
    {
        public DFA54(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 54;
            this.eot = DFA54_eot;
            this.eof = DFA54_eof;
            this.min = DFA54_min;
            this.max = DFA54_max;
            this.accept = DFA54_accept;
            this.special = DFA54_special;
            this.transition = DFA54_transition;

        }

        override public string Description
        {
            get { return "150:1: COMMENT : ( '/*' ( options {greedy=false; } : . )* '*/' | '/*' (~ '\\n' )* | '//' (~ '\\n' )* );"; }
        }

    }


    protected internal int DFA54_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA54_5 = input.LA(1);

                   	s = -1;
                   	if ( (LA54_5 == '*') ) { s = 4; }

                   	else if ( ((LA54_5 >= '\u0000' && LA54_5 <= '\t') || (LA54_5 >= '\u000B' && LA54_5 <= ')') || (LA54_5 >= '+' && LA54_5 <= '\uFFFF')) ) { s = 5; }

                   	else if ( (LA54_5 == '\n') ) { s = 6; }

                   	else s = 7;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA54_4 = input.LA(1);

                   	s = -1;
                   	if ( (LA54_4 == '/') ) { s = 8; }

                   	else if ( (LA54_4 == '*') ) { s = 4; }

                   	else if ( ((LA54_4 >= '\u0000' && LA54_4 <= '\t') || (LA54_4 >= '\u000B' && LA54_4 <= ')') || (LA54_4 >= '+' && LA54_4 <= '.') || (LA54_4 >= '0' && LA54_4 <= '\uFFFF')) ) { s = 5; }

                   	else if ( (LA54_4 == '\n') ) { s = 6; }

                   	else s = 7;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA54_2 = input.LA(1);

                   	s = -1;
                   	if ( (LA54_2 == '*') ) { s = 4; }

                   	else if ( ((LA54_2 >= '\u0000' && LA54_2 <= '\t') || (LA54_2 >= '\u000B' && LA54_2 <= ')') || (LA54_2 >= '+' && LA54_2 <= '\uFFFF')) ) { s = 5; }

                   	else if ( (LA54_2 == '\n') ) { s = 6; }

                   	else s = 7;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae54 =
            new NoViableAltException(dfa.Description, 54, _s, input);
        dfa.Error(nvae54);
        throw nvae54;
    }
    const string DFA55_eotS =
        "\x03\uffff\x01\x1a\x02\uffff\x01\x1a\x12\x19\x02\uffff\x01\x1a"+
        "\x01\x19\x01\x53\x28\x19\x01\x53\x01\x19\x02\x53\x02\x19\x01\x53"+
        "\x04\x19\x01\uffff\x01\x19\x01\uffff\x05\x19\x01\x53\x0f\x19\x01"+
        "\x53\x04\x19\x01\x53\x05\x19\x01\x53\x12\x19\x01\x53\x01\x19\x01"+
        "\x53\x0f\x19\x03\x53\x0a\x19\x02\x53\x01\x19\x01\x53\x03\x19\x01"+
        "\x53\x01\x19\x01\x53\x06\x19\x01\x53\x01\x19\x01\x53\x08\x19\x01"+
        "\x53\x05\x19\x01\x53\x0a\x19\x01\x53\x01\x19\x02\x53\x01\x19\x01"+
        "\x53\x08\x19\x01\x53\x01\x19\x01\x53\x01\x19\x01\x53\x03\x19\x01"+
        "\x53\x01\x19\x01\x53\x01\x19\x02\x53\x01\x19\x01\x53\x01\x19\x02"+
        "\x53\x05\x19\x01\x53\x03\x19\x01\x53\x0a\x19\x01\x53\x02\x19\x01"+
        "\x53\x01\x19\x02\x53\x01\x19\x05\x53\x02\x19\x01\x53\x04\x19\x01"+
        "\x53\x02\x19\x01\x53\x01\x19\x02\x53\x04\x19\x01\x53\x03\x19\x01"+
        "\x53\x08\x19\x03\x53\x01\x19\x01\x53\x06\x19\x02\x53\x01\x19\x01"+
        "\x53\x01\x19\x02\x53\x02\x19\x03\x53\x02\x19\x01\x53\x01\x19\x05"+
        "\x53\x01\x19\x04\x53";
    const string DFA55_eofS =
        "\u0158\uffff";
    const string DFA55_minS =
        "\x01\x09\x02\uffff\x01\x22\x02\uffff\x01\x30\x01\x62\x01\x6c\x01"+
        "\x61\x01\x62\x01\x61\x01\x62\x01\x68\x03\x61\x01\x69\x01\x6f\x01"+
        "\x66\x02\x65\x01\x69\x01\x68\x01\x6f\x02\uffff\x01\x2a\x01\x73\x01"+
        "\x30\x01\x65\x01\x70\x01\x73\x01\x75\x01\x77\x01\x6c\x01\x6d\x01"+
        "\x61\x01\x69\x01\x79\x01\x61\x01\x6f\x01\x7a\x01\x73\x01\x6f\x01"+
        "\x65\x01\x74\x01\x6a\x01\x65\x01\x74\x01\x65\x01\x69\x01\x75\x01"+
        "\x70\x01\x6c\x01\x6e\x01\x6f\x01\x72\x01\x73\x02\x61\x01\x6e\x01"+
        "\x72\x01\x69\x01\x62\x01\x6e\x01\x6f\x01\x63\x01\x68\x01\x74\x01"+
        "\x30\x01\x70\x02\x30\x01\x61\x01\x63\x01\x30\x01\x72\x02\x69\x01"+
        "\x63\x01\uffff\x01\x74\x01\uffff\x01\x6e\x01\x6c\x02\x65\x01\x6d"+
        "\x01\x30\x01\x6c\x01\x65\x01\x69\x01\x63\x02\x74\x01\x6c\x01\x72"+
        "\x02\x65\x01\x6c\x01\x61\x02\x65\x01\x72\x01\x30\x01\x72\x01\x73"+
        "\x01\x6f\x01\x65\x01\x30\x01\x65\x01\x73\x01\x61\x01\x65\x01\x61"+
        "\x01\x30\x01\x65\x01\x63\x01\x72\x01\x63\x02\x73\x01\x61\x01\x76"+
        "\x01\x74\x01\x6c\x01\x74\x01\x6e\x01\x68\x01\x61\x01\x6f\x01\x6e"+
        "\x01\x6f\x01\x6c\x01\x30\x01\x64\x01\x30\x01\x75\x01\x69\x01\x61"+
        "\x01\x65\x01\x62\x01\x74\x01\x61\x01\x64\x01\x6c\x01\x6b\x01\x67"+
        "\x01\x72\x01\x74\x01\x69\x01\x72\x03\x30\x01\x73\x01\x63\x01\x6e"+
        "\x01\x6b\x01\x69\x01\x63\x02\x65\x01\x74\x01\x6f\x02\x30\x01\x6b"+
        "\x01\x30\x01\x63\x01\x61\x01\x72\x01\x30\x01\x77\x01\x30\x01\x6f"+
        "\x01\x65\x01\x6c\x01\x64\x01\x74\x01\x61\x01\x30\x01\x68\x01\x30"+
        "\x01\x6b\x01\x73\x01\x74\x01\x69\x01\x6d\x01\x61\x01\x65\x01\x69"+
        "\x01\x30\x01\x67\x01\x65\x01\x66\x01\x72\x01\x67\x01\x30\x01\x69"+
        "\x01\x72\x01\x6f\x01\x72\x01\x6d\x01\x75\x01\x67\x01\x6c\x01\x75"+
        "\x01\x74\x01\x30\x01\x65\x02\x30\x01\x61\x01\x30\x01\x63\x01\x6e"+
        "\x01\x70\x01\x74\x01\x67\x01\x61\x01\x63\x01\x68\x01\x30\x01\x64"+
        "\x01\x30\x01\x66\x01\x30\x02\x74\x01\x69\x01\x30\x01\x66\x01\x30"+
        "\x01\x6c\x02\x30\x01\x63\x01\x30\x01\x65\x02\x30\x01\x6e\x01\x73"+
        "\x01\x74\x02\x63\x01\x30\x01\x63\x01\x65\x01\x74\x01\x30\x01\x63"+
        "\x01\x66\x02\x6e\x01\x61\x01\x6c\x01\x61\x01\x65\x01\x61\x01\x69"+
        "\x01\x30\x01\x63\x01\x69\x01\x30\x01\x61\x02\x30\x01\x6c\x05\x30"+
        "\x01\x6f\x01\x64\x01\x30\x01\x79\x01\x68\x01\x64\x01\x75\x01\x30"+
        "\x01\x65\x01\x74\x01\x30\x01\x6b\x02\x30\x01\x69\x02\x61\x01\x6c"+
        "\x01\x30\x01\x6c\x02\x74\x01\x30\x02\x6c\x02\x74\x01\x63\x01\x6c"+
        "\x01\x72\x01\x65\x03\x30\x01\x65\x01\x30\x02\x65\x01\x74\x01\x63"+
        "\x01\x6c\x01\x79\x02\x30\x01\x65\x01\x30\x01\x65\x02\x30\x01\x65"+
        "\x01\x6f\x03\x30\x02\x64\x01\x30\x01\x65\x05\x30\x01\x63\x04\x30";
    const string DFA55_maxS =
        "\x01\x7e\x02\uffff\x01\x7a\x02\uffff\x01\x39\x01\x73\x01\x78\x01"+
        "\x75\x01\x77\x01\x79\x01\x76\x01\x79\x02\x6f\x01\x75\x01\x73\x01"+
        "\x6f\x01\x73\x01\x65\x02\x6f\x01\x68\x01\x6f\x02\uffff\x01\x2f\x01"+
        "\x73\x01\x7a\x01\x65\x01\x74\x01\x73\x01\x75\x01\x77\x01\x6c\x01"+
        "\x6d\x01\x72\x01\x69\x01\x79\x01\x61\x01\x6f\x01\x7a\x01\x73\x01"+
        "\x6f\x01\x65\x01\x74\x01\x6a\x01\x65\x01\x74\x01\x65\x01\x72\x01"+
        "\x79\x01\x70\x01\x6c\x01\x78\x01\x6f\x01\x72\x01\x74\x01\x65\x01"+
        "\x61\x01\x6e\x01\x72\x01\x6f\x01\x62\x01\x6e\x01\x6f\x01\x73\x01"+
        "\x69\x01\x74\x01\x7a\x01\x70\x02\x7a\x01\x74\x01\x6c\x01\x7a\x01"+
        "\x72\x01\x6c\x01\x69\x01\x6e\x01\uffff\x01\x74\x01\uffff\x01\x6e"+
        "\x01\x6c\x02\x65\x01\x6d\x01\x7a\x01\x6c\x01\x65\x01\x75\x03\x74"+
        "\x01\x6c\x01\x72\x02\x65\x01\x6c\x01\x61\x02\x65\x01\x72\x01\x7a"+
        "\x01\x72\x01\x73\x01\x6f\x01\x65\x01\x7a\x01\x65\x01\x73\x01\x61"+
        "\x01\x65\x01\x61\x01\x7a\x01\x65\x01\x63\x01\x72\x01\x63\x01\x73"+
        "\x01\x74\x01\x61\x01\x76\x01\x74\x01\x6c\x01\x74\x01\x6e\x01\x68"+
        "\x01\x61\x01\x6f\x01\x6e\x01\x6f\x01\x6c\x01\x7a\x01\x64\x01\x7a"+
        "\x01\x75\x01\x69\x01\x61\x01\x65\x01\x62\x01\x74\x01\x61\x01\x64"+
        "\x01\x6c\x01\x6b\x01\x67\x01\x72\x01\x74\x01\x69\x01\x72\x03\x7a"+
        "\x01\x73\x01\x63\x01\x6e\x01\x6b\x01\x69\x01\x63\x02\x65\x01\x74"+
        "\x01\x6f\x02\x7a\x01\x6b\x01\x7a\x01\x63\x01\x61\x01\x72\x01\x7a"+
        "\x01\x77\x01\x7a\x01\x6f\x01\x65\x01\x6c\x01\x64\x01\x74\x01\x61"+
        "\x01\x7a\x01\x68\x01\x7a\x01\x6b\x01\x73\x01\x74\x01\x69\x01\x6d"+
        "\x01\x61\x01\x65\x01\x69\x01\x7a\x01\x67\x01\x65\x01\x66\x01\x72"+
        "\x01\x67\x01\x7a\x01\x69\x01\x72\x01\x6f\x01\x72\x01\x6d\x01\x75"+
        "\x01\x67\x01\x6c\x01\x75\x01\x74\x01\x7a\x01\x65\x02\x7a\x01\x61"+
        "\x01\x7a\x01\x63\x01\x6e\x01\x70\x01\x74\x01\x67\x01\x61\x01\x63"+
        "\x01\x68\x01\x7a\x01\x64\x01\x7a\x01\x66\x01\x7a\x02\x74\x01\x69"+
        "\x01\x7a\x01\x66\x01\x7a\x01\x6c\x02\x7a\x01\x63\x01\x7a\x01\x65"+
        "\x02\x7a\x01\x6e\x01\x73\x01\x74\x02\x63\x01\x7a\x01\x63\x01\x65"+
        "\x01\x74\x01\x7a\x01\x63\x03\x6e\x01\x61\x01\x6c\x01\x61\x01\x65"+
        "\x01\x61\x01\x69\x01\x7a\x01\x63\x01\x69\x01\x7a\x01\x61\x02\x7a"+
        "\x01\x6c\x05\x7a\x01\x6f\x01\x64\x01\x7a\x01\x79\x01\x68\x01\x64"+
        "\x01\x75\x01\x7a\x01\x65\x01\x74\x01\x7a\x01\x6b\x02\x7a\x01\x69"+
        "\x02\x61\x01\x6c\x01\x7a\x01\x6c\x02\x74\x01\x7a\x02\x6c\x02\x74"+
        "\x01\x63\x01\x6c\x01\x72\x01\x65\x03\x7a\x01\x65\x01\x7a\x02\x65"+
        "\x01\x74\x01\x63\x01\x6c\x01\x79\x02\x7a\x01\x65\x01\x7a\x01\x65"+
        "\x02\x7a\x01\x65\x01\x6f\x03\x7a\x02\x64\x01\x7a\x01\x65\x05\x7a"+
        "\x01\x63\x04\x7a";
    const string DFA55_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x03\x01\x04\x13\uffff"+
        "\x01\x06\x01\x07\x36\uffff\x01\x08\x01\uffff\x01\x05\u0104\uffff";
    const string DFA55_specialS =
        "\u0158\uffff}>";
    static readonly string[] DFA55_transitionS = {
            "\x02\x01\x02\uffff\x01\x01\x12\uffff\x01\x01\x01\x1a\x01\x02"+
            "\x02\uffff\x02\x1a\x01\x04\x06\x1a\x01\x06\x01\x1b\x0a\x05\x06"+
            "\x1a\x01\x03\x1a\x19\x01\x1a\x01\x19\x02\x1a\x01\x19\x01\uffff"+
            "\x01\x07\x01\x0b\x01\x0f\x01\x15\x01\x08\x01\x0e\x01\x12\x01"+
            "\x19\x01\x13\x02\x19\x01\x18\x01\x19\x01\x09\x01\x0c\x01\x10"+
            "\x01\x19\x01\x14\x01\x0a\x01\x0d\x01\x11\x01\x16\x01\x17\x03"+
            "\x19\x01\uffff\x01\x1a\x01\uffff\x01\x1a",
            "",
            "",
            "\x01\x02\x1e\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "",
            "",
            "\x0a\x05",
            "\x01\x1c\x10\uffff\x01\x1d",
            "\x01\x20\x01\uffff\x01\x21\x07\uffff\x01\x1e\x01\uffff\x01"+
            "\x1f",
            "\x01\x24\x03\uffff\x01\x22\x0f\uffff\x01\x23",
            "\x01\x27\x02\uffff\x01\x28\x02\uffff\x01\x29\x01\x2a\x0a\uffff"+
            "\x01\x25\x02\uffff\x01\x26",
            "\x01\x2b\x0d\uffff\x01\x2c\x02\uffff\x01\x2d\x06\uffff\x01"+
            "\x2e",
            "\x01\x2f\x0d\uffff\x01\x30\x04\uffff\x01\x31\x01\x32",
            "\x01\x33\x09\uffff\x01\x34\x06\uffff\x01\x35",
            "\x01\x36\x07\uffff\x01\x37\x02\uffff\x01\x38\x02\uffff\x01"+
            "\x39",
            "\x01\x3a\x06\uffff\x01\x3b\x03\uffff\x01\x3c\x02\uffff\x01"+
            "\x3d",
            "\x01\x3e\x10\uffff\x01\x3f\x02\uffff\x01\x40",
            "\x01\x41\x02\uffff\x01\x42\x01\uffff\x01\x43\x04\uffff\x01"+
            "\x44",
            "\x01\x45",
            "\x01\x46\x06\uffff\x01\x47\x01\x48\x04\uffff\x01\x49",
            "\x01\x4a",
            "\x01\x4b\x09\uffff\x01\x4c",
            "\x01\x4d\x05\uffff\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "",
            "",
            "\x01\x51\x04\uffff\x01\x51",
            "\x01\x52",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\x54",
            "\x01\x55\x03\uffff\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5d\x10\uffff\x01\x5c",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b\x08\uffff\x01\x6c",
            "\x01\x6d\x03\uffff\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71\x09\uffff\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75\x01\x76",
            "\x01\x77\x03\uffff\x01\x78",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c\x05\uffff\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081\x0f\uffff\x01\u0082",
            "\x01\u0083\x01\u0084",
            "\x01\u0085",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0086",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x13\x19\x01\u0087\x06\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0088\x04\uffff\x01\u0089\x0d\uffff\x01\u008a",
            "\x01\u008b\x02\uffff\x01\u008c\x05\uffff\x01\u008d",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x14\x19\x01\u008e\x05\x19",
            "\x01\u008f",
            "\x01\u0091\x02\uffff\x01\u0090",
            "\x01\u0092",
            "\x01\u0093\x0a\uffff\x01\u0094",
            "",
            "\x01\u0095",
            "",
            "\x01\u0096",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u009b",
            "\x01\u009c",
            "\x01\u009e\x0b\uffff\x01\u009d",
            "\x01\u009f\x10\uffff\x01\u00a0",
            "\x01\u00a1",
            "\x01\u00a2",
            "\x01\u00a3",
            "\x01\u00a4",
            "\x01\u00a5",
            "\x01\u00a6",
            "\x01\u00a7",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\u00ab",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00ac",
            "\x01\u00ad",
            "\x01\u00ae",
            "\x01\u00af",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00b0",
            "\x01\u00b1",
            "\x01\u00b2",
            "\x01\u00b3",
            "\x01\u00b4",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x04\x19\x01\u00b5\x15\x19",
            "\x01\u00b6",
            "\x01\u00b7",
            "\x01\u00b8",
            "\x01\u00b9",
            "\x01\u00ba",
            "\x01\u00bb\x01\u00bc",
            "\x01\u00bd",
            "\x01\u00be",
            "\x01\u00bf",
            "\x01\u00c0",
            "\x01\u00c1",
            "\x01\u00c2",
            "\x01\u00c3",
            "\x01\u00c4",
            "\x01\u00c5",
            "\x01\u00c6",
            "\x01\u00c7",
            "\x01\u00c8",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x04\x19\x01\u00c9\x15\x19",
            "\x01\u00ca",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00cb",
            "\x01\u00cc",
            "\x01\u00cd",
            "\x01\u00ce",
            "\x01\u00cf",
            "\x01\u00d0",
            "\x01\u00d1",
            "\x01\u00d2",
            "\x01\u00d3",
            "\x01\u00d4",
            "\x01\u00d5",
            "\x01\u00d6",
            "\x01\u00d7",
            "\x01\u00d8",
            "\x01\u00d9",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00da",
            "\x01\u00db",
            "\x01\u00dc",
            "\x01\u00dd",
            "\x01\u00de",
            "\x01\u00df",
            "\x01\u00e0",
            "\x01\u00e1",
            "\x01\u00e2",
            "\x01\u00e3",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00e4",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00e5",
            "\x01\u00e6",
            "\x01\u00e7",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00e8",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00e9",
            "\x01\u00ea",
            "\x01\u00eb",
            "\x01\u00ec",
            "\x01\u00ed",
            "\x01\u00ee",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00ef",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00f0",
            "\x01\u00f1",
            "\x01\u00f2",
            "\x01\u00f3",
            "\x01\u00f4",
            "\x01\u00f5",
            "\x01\u00f6",
            "\x01\u00f7",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00f8",
            "\x01\u00f9",
            "\x01\u00fa",
            "\x01\u00fb",
            "\x01\u00fc",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u00fd",
            "\x01\u00fe",
            "\x01\u00ff",
            "\x01\u0100",
            "\x01\u0101",
            "\x01\u0102",
            "\x01\u0103",
            "\x01\u0104",
            "\x01\u0105",
            "\x01\u0106",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0107",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0108",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0109",
            "\x01\u010a",
            "\x01\u010b",
            "\x01\u010c",
            "\x01\u010d",
            "\x01\u010e",
            "\x01\u010f",
            "\x01\u0110",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0111",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0112",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0113",
            "\x01\u0114",
            "\x01\u0115",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0116",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0117",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0118",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0119",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u011a",
            "\x01\u011b",
            "\x01\u011c",
            "\x01\u011d",
            "\x01\u011e",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u011f",
            "\x01\u0120",
            "\x01\u0121",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0122",
            "\x01\u0123\x07\uffff\x01\u0124",
            "\x01\u0125",
            "\x01\u0126",
            "\x01\u0127",
            "\x01\u0128",
            "\x01\u0129",
            "\x01\u012a",
            "\x01\u012b",
            "\x01\u012c",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u012d",
            "\x01\u012e",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u012f",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0130",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0131",
            "\x01\u0132",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0133",
            "\x01\u0134",
            "\x01\u0135",
            "\x01\u0136",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0137",
            "\x01\u0138",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0139",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u013a",
            "\x01\u013b",
            "\x01\u013c",
            "\x01\u013d",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u013e",
            "\x01\u013f",
            "\x01\u0140",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0141",
            "\x01\u0142",
            "\x01\u0143",
            "\x01\u0144",
            "\x01\u0145",
            "\x01\u0146",
            "\x01\u0147",
            "\x01\u0148",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0149",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u014a",
            "\x01\u014b",
            "\x01\u014c",
            "\x01\u014d",
            "\x01\u014e",
            "\x01\u014f",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0150",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0151",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0152",
            "\x01\u0153",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0154",
            "\x01\u0155",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0156",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x01\u0157",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19",
            "\x0a\x19\x07\uffff\x1a\x19\x01\uffff\x01\x19\x02\uffff\x01"+
            "\x19\x01\uffff\x1a\x19"
    };

    static readonly short[] DFA55_eot = DFA.UnpackEncodedString(DFA55_eotS);
    static readonly short[] DFA55_eof = DFA.UnpackEncodedString(DFA55_eofS);
    static readonly char[] DFA55_min = DFA.UnpackEncodedStringToUnsignedChars(DFA55_minS);
    static readonly char[] DFA55_max = DFA.UnpackEncodedStringToUnsignedChars(DFA55_maxS);
    static readonly short[] DFA55_accept = DFA.UnpackEncodedString(DFA55_acceptS);
    static readonly short[] DFA55_special = DFA.UnpackEncodedString(DFA55_specialS);
    static readonly short[][] DFA55_transition = DFA.UnpackEncodedStringArray(DFA55_transitionS);

    protected class DFA55 : DFA
    {
        public DFA55(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 55;
            this.eot = DFA55_eot;
            this.eof = DFA55_eof;
            this.min = DFA55_min;
            this.max = DFA55_max;
            this.accept = DFA55_accept;
            this.special = DFA55_special;
            this.transition = DFA55_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( WS | STR | CHAR | NUM | KEYWORD | IDENT | OP | COMMENT );"; }
        }

    }

 
    
}
