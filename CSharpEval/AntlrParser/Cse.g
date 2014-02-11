grammar Cse;


/* GLOBAL */
/*-------------------------------------------------------*/
// Options
//------------------------------
options {
	language = 'CSharp3';
	backtrack = true;
}
//------------------------------

// Header
//------------------------------
@header {
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

using CSE;
using CSE.Exps;
}
@lexer::header {
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

}
//------------------------------

// Namespace
//------------------------------
@namespace		  {CSE.AntlrParser}
@lexer::namespace {CSE.AntlrParser}
//------------------------------

// Members
//------------------------------
@members {
public override void EmitErrorMessage(String msg) {
	throw new Exception(msg);
}

protected override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) {
	throw new MismatchedTokenException(ttype, input);
}

public override object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow) {
	throw e;
}
}
@lexer::members {
public override void EmitErrorMessage(String msg) {
	throw new Exception(msg);
}

protected override object RecoverFromMismatchedToken(IIntStream input, int ttype, BitSet follow) {
	throw new MismatchedTokenException(ttype, input);
}

public override object RecoverFromMismatchedSet(IIntStream input, RecognitionException e, BitSet follow) {
	throw e;
}
}
//------------------------------

// Rulecatch
//------------------------------
@rulecatch {
catch {
	throw;
}
}
/*-------------------------------------------------------*/


/* GRAMMAR */
/*-------------------------------------------------------*/
// Parser Rules 
//------------------------------
// start rule
public exp returns [CseObject value]
	: subExp SEMI	{ $value = $subExp.value; }
	;
//-----------

subExp returns [CseObject value]
	: assign		{ $value = $assign.value; }
	| nonAssign		{ $value = $nonAssign.value; }
	;
assign returns [CseObject value]
	: icp=identChainList EQ subExp { $value = AssignExp.Parse($icp.value.EnvChain, $icp.value.EnvNames, $icp.value.EnvIndices, $subExp.value);  }
	| typeExp ID EQ subExp 
		{ 
			$value = new CseObject(null);
			TempIdentifierExp.AddIdent((Type)$typeExp.value.Value, $ID.text, $subExp.value); 
		}
	| icp=identChainList CROSS_EQ (LPAREN typeExp RPAREN)? subExp 
		{ 
			CseObject result = ArithExp.Parse($icp.value, $subExp.value, ArithType.ADD);
			if ($typeExp.value != null) {
				result = CastExp.Parse(null, $typeExp.text, result);
			}
			
			String fullTypeName = $icp.value.Value.GetType().ToString();
			int indexOfDot = fullTypeName.IndexOf('.');
			String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
			
			result = CastExp.Parse(null, typeName, result);
			
			$value = AssignExp.Parse($icp.value.EnvChain, $icp.value.EnvNames, $icp.value.EnvIndices, result); 
		}
	| icp=identChainList DASH_EQ (LPAREN typeExp RPAREN)? subExp 
		{ 
			CseObject result = ArithExp.Parse($icp.value, $subExp.value, ArithType.SUB);
			if ($typeExp.value != null) {	result = CastExp.Parse(null, $typeExp.text, result);	}
			String fullTypeName = $icp.value.Value.GetType().ToString();
			int indexOfDot = fullTypeName.IndexOf('.');
			String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
			result = CastExp.Parse(null, typeName, result);
			$value = AssignExp.Parse($icp.value.EnvChain, $icp.value.EnvNames, $icp.value.EnvIndices, result); 
		}
	| icp=identChainList STAR_EQ (LPAREN typeExp RPAREN)? subExp 
		{ 
			CseObject result = ArithExp.Parse($icp.value, $subExp.value, ArithType.MUL);
			if ($typeExp.value != null) {	result = CastExp.Parse(null, $typeExp.text, result);	}
			String fullTypeName = $icp.value.Value.GetType().ToString();
			int indexOfDot = fullTypeName.IndexOf('.');
			String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
			result = CastExp.Parse(null, typeName, result);
			$value = AssignExp.Parse($icp.value.EnvChain, $icp.value.EnvNames, $icp.value.EnvIndices, result);  
		}
	| icp=identChainList FSLASH_EQ (LPAREN typeExp RPAREN)? subExp 
		{ 
			CseObject result = ArithExp.Parse($icp.value, $subExp.value, ArithType.DIV);
			if ($typeExp.value != null) {	result = CastExp.Parse(null, $typeExp.text, result);	}
			String fullTypeName = $icp.value.Value.GetType().ToString();
			int indexOfDot = fullTypeName.IndexOf('.');
			String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
			result = CastExp.Parse(null, typeName, result);
			$value = AssignExp.Parse($icp.value.EnvChain, $icp.value.EnvNames, $icp.value.EnvIndices, result); 
		}
	| icp=identChainList PER_EQ (LPAREN typeExp RPAREN)? subExp 
		{ 
			CseObject result = ArithExp.Parse($icp.value, $subExp.value, ArithType.MOD);
			if ($typeExp.value != null) {	result = CastExp.Parse(null, $typeExp.text, result);	}
			String fullTypeName = $icp.value.Value.GetType().ToString();
			int indexOfDot = fullTypeName.IndexOf('.');
			String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
			result = CastExp.Parse(null, typeName, result);
			$value = AssignExp.Parse($icp.value.EnvChain, $icp.value.EnvNames, $icp.value.EnvIndices, result);  
		}
	| icp=identChainList DBLSTAR_EQ (LPAREN typeExp RPAREN)? subExp 
		{ 
			CseObject result = ArithExp.Parse($icp.value, $subExp.value, ArithType.POW);
			
			// TODO: put this part into a C# method
			if ($typeExp.value != null) {	result = CastExp.Parse(null, $typeExp.text, result);	}
			String fullTypeName = $icp.value.Value.GetType().ToString();
			int indexOfDot = fullTypeName.IndexOf('.');
			String typeName = fullTypeName.Substring(indexOfDot + 1, fullTypeName.Length - indexOfDot - 1);
			result = CastExp.Parse(null, typeName, result);
			$value = AssignExp.Parse($icp.value.EnvChain, $icp.value.EnvNames, $icp.value.EnvIndices, result);  
		}
		//TODO: <<=, >>=, &=, ^=, |=
	;
nonAssign returns [CseObject value]
	: condExp	{ $value = $condExp.value; }
	| typeExp ID 
		{ 
			$value = new CseObject(null);
			TempIdentifierExp.AddIdent((Type)$typeExp.value.Value, $ID.text); 
		}
	;

condExp returns [CseObject value]
	: loe=logOrExp { $value = $loe.value; }
	(
	  QUESTION se=subExp COLON ce=subExp { $value = CondExp.Ternary($value, $se.value, $ce.value); }
	 )?
	;
	
/*
condExp returns [CseObject value]
	: loe=logOrExp { $value = $loe.value; }
	| loe=logOrExp QUESTION se=logOrExp COLON ce=logOrExp { $value = CondExp.Ternary($loe.value, $se.value, $ce.value); }
	;*/
	
logOrExp returns [CseObject value]
	: lae=logAndExp { $value = $lae.value; } 
	(
		DBLPIPE lae=logAndExp{ $value = LogicalExp.Parse($value, $lae.value, LogicalType.OR); }
	)*
	;
	
logAndExp returns [CseObject value]
	: boe=bitOrExp { $value = $boe.value; } 
	(
		DBLAMP boe=bitOrExp{ $value = LogicalExp.Parse($value, $boe.value, LogicalType.AND); }
	)*
	;
	
bitOrExp returns [CseObject value]
	: xe=xorExp { $value = $xe.value; }
	(
		PIPE xe=xorExp{ $value = BitwiseExp.Parse($value, $xe.value, BitwiseType.OR); }
	)*
	;

xorExp returns [CseObject value]
	: bae=bitAndExp { $value= $bae.value; }
	(
		HAT bae=bitAndExp{ $value = XorExp.Parse($value, $bae.value); }
	)*
	;

bitAndExp returns [CseObject value]
	: ee=eqExp { $value = $ee.value; }
	(
		AMP ee=eqExp{ $value = BitwiseExp.Parse($value, $ee.value, BitwiseType.AND); }
	)*
	;

eqExp returns [CseObject value]
	: re=relExp { $value = $re.value; } 
	  ( DBL_EQ re=relExp{ $value = CondExp.Parse($value, $re.value, CondType.EQ); }
		  |
		BANG_EQ re=relExp{ $value = CondExp.Parse($value, $re.value, CondType.NEQ); }
	  )*
	;
	
relExp returns [CseObject value]
	: se=shiftExp { $value = $se.value; }
	  ( LANGLE se=shiftExp{ $value = CondExp.Parse($value, $se.value, CondType.LT); }
		  |
		RANGLE se=shiftExp{ $value = CondExp.Parse($value, $se.value, CondType.GT); }
		  |
		LANGLE_EQ se=shiftExp{ $value = CondExp.Parse($value, $se.value, CondType.LTE); }
		  |
		RANGLE_EQ se=shiftExp{ $value = CondExp.Parse($value, $se.value, CondType.GTE); }
	  )*
	;
	
shiftExp returns [CseObject value]
	: ae=addExp { $value = $ae.value; } 
	  ( DBLLANGLE ae=addExp{ $value = BitwiseExp.Parse($value, $ae.value, BitwiseType.SHL); }
		  |
		DBLRANGLE ae=addExp{ $value = BitwiseExp.Parse($value, $ae.value, BitwiseType.SHR); }
	   )*
	;

addExp returns [CseObject value]
	: me=multExp	{ $value = $me.value; }
	  ( CROSS me=multExp{ $value = ArithExp.Parse($value, $me.value, ArithType.ADD); }
		|
		DASH me=multExp	{ $value = ArithExp.Parse($value, $me.value, ArithType.SUB); }
	  )*
	;
multExp returns [CseObject value]
	: pe=powExp	{ $value = $pe.value; } 
	  ( STAR pe=powExp 	{ $value = ArithExp.Parse($value, $pe.value, ArithType.MUL); }
		|
		FSLASH pe=powExp{ $value = ArithExp.Parse($value, $pe.value, ArithType.DIV); }
		|
		PER pe=powExp 	{ $value = ArithExp.Parse($value, $pe.value, ArithType.MOD); }
	  )*
	;
powExp returns [CseObject value]
scope { List<CseObject> powOperands; }
@init { $powExp::powOperands = new List<CseObject>(); }
@after {
	bool negate = false;
	CseObject first = null;
	CseObject second = null;
	double firstValue = 0.0;
	
	if ($powExp::powOperands.Count == 1) {
		$value = $powExp::powOperands[0];
	}
	else if ($powExp::powOperands.Count == 2) {
		first = $powExp::powOperands[0];
		second = $powExp::powOperands[1];
		firstValue = double.Parse(first.Value.ToString());
		
		if (firstValue < 0) {
			negate = true;
			first = new CseObject(Math.Abs(firstValue));
		}
		else {
			negate = false;
		}
		
		$value = ArithExp.Parse(first, second, ArithType.POW);
		
		if (negate)
			$value = -$value;
	}
	else {
		$value = $powExp::powOperands[$powExp::powOperands.Count - 1];
		for(int i = $powExp::powOperands.Count - 2; i >= 0; i--) {
			first = $powExp::powOperands[i];
			firstValue = double.Parse(first.Value.ToString());
			
			if (firstValue < 0) {
				negate = true;
				first = new CseObject(Math.Abs(firstValue));
			}
			else {
				negate = false;
			}
			
			$value = ArithExp.Parse(first, $value, ArithType.POW);
			
			if (negate)
				$value = -$value;
		}
	}
}
	: ue=unaryExp	{ $powExp::powOperands.Add($ue.value); }
	  ( 
		DBLSTAR ue2=unaryExp { $powExp::powOperands.Add($ue2.value); }
	  )*
	;
unaryExp returns [CseObject value]
scope {
	List<char> signs;
}
@init {
	$unaryExp::signs = new List<char>();
}
@after { 
	if ($unaryExp::signs.Count > 0) {
		$unaryExp::signs.Reverse();
		foreach (char c in $unaryExp::signs) {
			if (c == '-')		$value = ArithExp.Negate($value);
			else if (c == '+')	$value = ArithExp.Affirm($value);
			else if (c == '~')	$value = BitwiseExp.Parse($value, null, BitwiseType.NOT);
			else /* c == '!' */	$value = LogicalExp.Parse($value, null, LogicalType.NOT);
		}
	}
}
	: (
		sign=(CROSS|DASH|BANG|TILDE) { $unaryExp::signs.Add($sign.text[0]); }
	  )* 
	  unaryExpPart	{ $value = $unaryExpPart.value; }
	;
unaryExpPart returns [CseObject value]
	: litExp								{ $value = $litExp.value; }
	| objChainList[CsEval.evalEnvironment]	{ $value = $objChainList.value; }
	| castOrParenExp						{ $value = $castOrParenExp.value; }
	| objCon 								{ $value = $objCon.value; }
	;
objCon returns [CseObject value]
	: NEW typeExp LPAREN al=argList? RPAREN	{ $value = ObjectConstructionExp.Parse(CsEval.evalEnvironment, $typeExp.text, $al.value); }
	  (DOT objChainList[$value])? 			{ if ($objChainList.value != null) { $value = $objChainList.value; } }
	;
castOrParenExp returns [CseObject value]
	: LPAREN typeExp RPAREN unaryExp 	{ $value = CastExp.Parse(CsEval.evalEnvironment, $typeExp.text, $unaryExp.value); }
	| LPAREN subExp RPAREN				{ $value = $subExp.value; }
	  (DOT objChainList[$value])? 		{ if ($objChainList.value != null) { $value = $objChainList.value; } }
	;
typeExp returns [CseObject value]
	: ID 
		{
			Type t = Type.GetType($ID.text);
			
			if (t == null)
				t = TypeExp.GetType($ID.text);
				 
			$value = new CseObject(t);
		}
	;
identChainList returns [CseObject value]
scope {
	List<CseObject> envChain;
	List<string> envNames;
	List<CseObject> envIndices;
	CseObject lastChainValue;
}
@after {
	$value.EnvChain = $identChainList::envChain;
	$value.EnvNames = $identChainList::envNames;
	$value.EnvIndices = $identChainList::envIndices;
}
@init {
	$value = null;
	$identChainList::envChain = new List<CseObject>();
	$identChainList::envNames = new List<string>();
	$identChainList::envIndices = new List<CseObject>();
	$identChainList::lastChainValue = CsEval.evalEnvironment;
}
	:  icp=identChainPart[$identChainList::lastChainValue]
	  {
		$value = $icp.value;
		$identChainList::envChain.Add(CsEval.evalEnvironment);
		$identChainList::envNames.Add($icp.name);
		$identChainList::envIndices.Add($icp.index);
		$identChainList::lastChainValue = $value;
	  }
	  (
		DOT icp=identChainPart[$identChainList::lastChainValue]	
		{
			$identChainList::envChain.Add($value);
			$value = $icp.value;
			$identChainList::envNames.Add($icp.name);
			$identChainList::envIndices.Add($icp.index);			
			$identChainList::lastChainValue = $value;
		}
	  )*
	;
identChainPart[CseObject lastChainValue] returns [CseObject value, string name, CseObject index]
	: identExp[$lastChainValue] 
	  { 
		$value = $identExp.value;
		$name = $identExp.text;
		$index = null;
	  }
	| arrayExp[$lastChainValue] 
	  {
		$value = $arrayExp.value;
		$name = $arrayExp.name;
		$index = $arrayExp.index;
	  }
	;
// TODO: Make this just like identChainList (i.e. saving env stuff)
objChainList[CseObject startChainValue] returns [CseObject value]
scope { CseObject lastChainValue; }
@init { $objChainList::lastChainValue = $startChainValue; }
	: ocp=objChainPart[$objChainList::lastChainValue]	{ $value = $ocp.value;  $objChainList::lastChainValue = $value; }
	  (
		DOT ocp=objChainPart[$objChainList::lastChainValue]	{ $value = $ocp.value;  $objChainList::lastChainValue = $value; }
	  )*
	;
objChainPart[CseObject lastChainValue] returns [CseObject value]
	: identExp[$lastChainValue]	{ $value = $identExp.value; }
	| callExp[$lastChainValue]	{ $value = $callExp.value;  }
	| arrayExp[$lastChainValue] { $value = $arrayExp.value; }
	;
identExp[CseObject lastChainValue] returns [CseObject value]
	: ID	{ $value = IdentifierExp.Parse($lastChainValue, $ID.text); }
	;

callExp[CseObject lastChainValue] returns [CseObject value]
	: ID LPAREN al=argList? RPAREN	{ $value = MethodExp.Parse($lastChainValue, $ID.text, $al.value); }
	;
arrayExp[CseObject lastChainValue] returns [CseObject value, string name, CseObject index]
	: ID LBRACK subExp RBRACK
	  { 
		$value = ArrayExp.Parse($lastChainValue, $ID.text, $subExp.value);
		$name = $ID.text;
		$index = $subExp.value;
	  }
	;
argList returns [List<CseObject> value]
@init { $value = new List<CseObject>(); }	
	: a=arg	{ $value.Add($a.value); }
	  (
		COMMA a=arg { $value.Add($a.value); }
	  )*
	;
arg returns [CseObject value]
	: argModExp subExp	
	  { 
		$value = $subExp.value;
		$value.CallMod = $argModExp.value;
	  }
	;
argModExp returns [CallArgMod value]
	: REF	{ $value = CallArgMod.REF; }
	| OUT	{ $value = CallArgMod.OUT; }
	|		{ $value = CallArgMod.VAL; }
	;
/*
lambdaExp returns [CseObject value]
	:(lambdaArgList)+ LAMBDAOP subExp
	|(lambdaArgList)+ LAMBDAOP LBRACE subExp RBRACE
	|LPAREN (lambdaArgList)+ RPAREN LAMBDAOP subExp
	|LPAREN (lambdaArgList)+ RPAREN LAMBDAOP LBRACE subExp RBRACE
	;
lambdaArgList returns [CseObject value]
	:typeExp? identExp (',' typeExp? identC)*
	;
*/
litExp returns [CseObject value]
scope { CseObject lastChainValue; }
@init { $litExp::lastChainValue = CsEval.evalEnvironment; }
	: lit	{ $value = $lit.value;  $litExp::lastChainValue = $value; }
	  (
		DOT ocp=objChainPart[$litExp::lastChainValue]	{ $value = $ocp.value;  $litExp::lastChainValue = $value; }
	  )*
	  |
	  CH_INT
		{ $litExp::lastChainValue = LiteralExp.ParseIntType($CH_INT.text.Substring(0, $CH_INT.text.Length-1), false); }
	  ocp=objChainPart[$litExp::lastChainValue]
		{ $value = $ocp.value;  $litExp::lastChainValue = $value; }
	  (
		DOT ocp=objChainPart[$litExp::lastChainValue]	{ $value = $ocp.value;  $litExp::lastChainValue = $value; }
	  )*
	;
lit returns [CseObject value]
	: boolLit	{ $value = $boolLit.value; }
	| numLit	{ $value = $numLit.value;  }
	| strLit	{ $value = $strLit.value;  }
	| charLit	{ $value = $charLit.value; }
	| nullLit	{ $value = new CseObject(null); }
	| termConst { $value = $termConst.value; }
	;
numLit returns [CseObject value]
	: expNum = (EINT | EFLT)
		{ $value = LiteralExp.ParseEType($expNum.text); }
	| INT
		{ $value = LiteralExp.ParseIntType($INT.text, false); }
	| FLT
		{ $value = LiteralExp.ParseFloatType($FLT.text, false); }
	| INTWITHSUFFIX
		{ $value = LiteralExp.ParseIntType($INTWITHSUFFIX.text, true); }
	| FLTWITHSUFFIX
		{ $value = LiteralExp.ParseFloatType($FLTWITHSUFFIX.text, true); }
	;
boolLit returns [CseObject value]
	: BOOL	{ $value = LiteralExp.ParseBool($BOOL.text); }
	;
strLit returns [CseObject value]
	: STR	{ $value = LiteralExp.ParseStr($STR.text); }
	;
charLit returns [CseObject value]
	: CHAR	{ $value = LiteralExp.ParseChar($CHAR.text); }
	;
nullLit
	: NULL
	;

termConst returns [CseObject value]
	: constLbl = TERMCONST
		{
			if		( $constLbl.text == "#E" ) 	$value = new CseObject(Math.E);
			else if	( $constLbl.text == "#G") 	$value = new CseObject(9.8);
			else if	( $constLbl.text == "#PI") 	$value = new CseObject(Math.PI);
			else if	( $constLbl.text == "#GC")	$value = new CseObject(6.673e-11);
			else if	( $constLbl.text == "#PHI")	$value = new CseObject((Math.Sqrt(5) + 1.0) / 2.0);
			else if	( $constLbl.text == "#GAMMA")$value = new CseObject(0.5772156649);
			else if	( $constLbl.text == "#C")	$value = new CseObject(299792458);
			else if	( $constLbl.text == "#H")	$value = new CseObject(6.62606893e-34);
		}
	;
//------------------------------


// Lexer Rules 
//------------------------------
fragment OCT_DIGIT:		'0'..'7';
fragment DIGIT: 		'0'..'9';
fragment HEX_DIGIT:		'0'..'9' | 'A'..'F' | 'a'..'f' ;
fragment LETTER:		'a'..'z' | 'A'..'Z';
fragment IDENT_START: 	'_' | LETTER | '\\' ESC_SEQ;
fragment IDENT_CONT:	'_' | DIGIT | LETTER | '\\' ESC_SEQ;
fragment WHITESPACE:	' ' | '\t' | '\n' | '\r';
fragment ESC_SEQ 
	: 'a'
	| 'b'
	| 'f'
	| 'n'
	| 'r'
	| 't'
	| 'v'
	| '0'
	
	| '\"'
	| '\''
	| '\\'
	
	| 'x'   HEX_DIGIT
	| 'x'   HEX_DIGIT  HEX_DIGIT
	| 'x'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT
	| 'x'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT
	
	| 'u'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT
	| 'U'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT
	;
TERMCONST:	'#' ('E'|'PI'|'G'|'GC'|'PHI'|'GAMMA'|'C'|'H');
EQ:			'=';
DBL_EQ:		'==';
BANG_EQ:	'!=';
LANGLE_EQ:	'<=';
RANGLE_EQ:	'>=';
LANGLE:		'<';
RANGLE:		'>';
DBLLANGLE:	'<<';
DBLRANGLE:	'>>';
PIPE:		'|';
DBLPIPE:	'||';
AMP:		'&';
DBLAMP:		'&&';
HAT	:		'^';
BANG:		'!';
TILDE:	 	'~';
QUESTION:	'?';
COLON:		':';
CROSS:		'+';
DASH:		'-';
STAR:		'*';
FSLASH:		'/';
PER:		'%';
DBLSTAR:	'**';
DBLCROSS:	'++';
DBLDASH:	'--';
CROSS_EQ:	'+=';
DASH_EQ:	'-=';
STAR_EQ:	'*=';
FSLASH_EQ:	'/=';
PER_EQ:		'%=';
DBLSTAR_EQ:	'**=';
DOT :	'.';
COMMA:	',';
SEMI:	';';
LAMBDAOP: '=>';
LPAREN: '(';
RPAREN: ')';
LBRACE: '{';
RBRACE: '}';
LBRACK:	'[';
RBRACK: ']';
COMMENT
	: '/*' ( options{greedy=false;}: . )* '*/'  { Skip(); }
	| '/*' (~'\n')*  { Skip(); }
	| '//' (~'\n')*  { Skip(); }
	;
	
NULL:	'null';
BOOL:	'true' | 'false';
REF	:	'ref';
OUT	:	'out';
NEW :	'new';
ID	:	'@'? IDENT_START IDENT_CONT*;
EINT:   DIGIT+ ('e'|'E') ('+'|'-')? DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')?;
EFLT: 	DIGIT+ DOT DIGIT+ ('e'|'E') ('+'|'-')? DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')?
	|	DOT DIGIT+ ('e'|'E') ('+'|'-')? DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')?
	;
CH_INT: DIGIT+ DOT;
INT	:	DIGIT+;
FLT : 	DIGIT+ DOT DIGIT+
	|	DOT DIGIT+
	;
INTWITHSUFFIX
	:	INT ('f'|'F'|'m'|'M'|'d'|'D'|'u'|'U'|'l'|'L'|'ul'|'Ul'|'uL'|'UL')
	;
FLTWITHSUFFIX
	:	FLT ('f'|'F'|'m'|'M'|'d'|'D')
	;
CHAR:	'\'' (('\\' ESC_SEQ) | ~'\\') '\'';
STR	:	'"' (options {greedy=false;}: ('\\' ESC_SEQ) | ~'\\')* '"'
	|	'@' '"' ('""' | ~'"')* '"'
	;
WS	:	WHITESPACE+ { Skip(); } ;

//------------------------------
/*-------------------------------------------------------*/
