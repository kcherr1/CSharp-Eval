
lexer grammar CseSHLexer;

options {
	language = 'CSharp2';
}

@header {
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
}

fragment OCT_DIGIT:		'0'..'7';
fragment DIGIT: 		'0'..'9';
fragment HEX_DIGIT:		'0'..'9' | 'A'..'F' | 'a'..'f' ;
fragment LETTER:		'a'..'z' | 'A'..'Z';
fragment IDENT_START: 	'_' | LETTER | '\\' ESC_SEQ?;
fragment IDENT_CONT:	'_' | DIGIT | LETTER | '\\' ESC_SEQ?;
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
    
    | 'x'
    | 'x'   HEX_DIGIT
    | 'x'   HEX_DIGIT  HEX_DIGIT
    | 'x'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT
    | 'x'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT
    
    
    | 'u'   
    | 'u'   HEX_DIGIT  
    | 'u'   HEX_DIGIT  HEX_DIGIT  
    | 'u'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  
    | 'u'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT

    | 'U'   
    | 'U'   HEX_DIGIT  
    | 'U'   HEX_DIGIT  HEX_DIGIT  
    | 'U'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  
    | 'U'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  
    | 'U'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  
    | 'U'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  
    | 'U'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  
    | 'U'   HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT  HEX_DIGIT
	;
	
fragment DOT 
	: '.'
	;

WS	: WHITESPACE+
	;
	
STR	: '"' (options {greedy=false;}: ('\\' ESC_SEQ) | ~'\\')* '"'
	| '"' (~'\n')*
	| '@' '"' ('""' | ~'"')* '"'
	| '@' '"' (~'\n')*
	;
	
CHAR: '\'' (('\\' ESC_SEQ) | ~'\\') '\''
	| '\'' (('\\' ESC_SEQ) | ~'\\')?
	;
	
fragment INTWITHSUFFIX
	:	DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D'|'u'|'U'|'l'|'L'|'ul'|'Ul'|'uL'|'UL')
	;
	
fragment FLTWITHSUFFIX
	:	DIGIT+ DOT DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')
	| 	DOT DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')
	;
	
NUM	: DIGIT+ ('e'|'E') ('+'|'-')? DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')?
	| DIGIT+ DOT DIGIT+ ('e'|'E') ('+'|'-')? DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')?
	| DOT DIGIT+ ('e'|'E') ('+'|'-')? DIGIT+ ('f'|'F'|'m'|'M'|'d'|'D')?
	
	| DIGIT+ ('e'|'E') ('+'|'-')
	| DIGIT+ DOT DIGIT+ ('e'|'E') ('+'|'-')
	| DOT DIGIT+ ('e'|'E') ('+'|'-')
	
	| DIGIT+
	| DIGIT+ DOT DIGIT+
	| DOT DIGIT+
	| DIGIT+ DOT
	| DIGIT+ ('e'|'E')
	| DIGIT+ DOT DIGIT+ ('e'|'E')
	| INTWITHSUFFIX
	| FLTWITHSUFFIX
	;
	
	
KEYWORD
	: 'abstract' | 'event' | 'new' | 'struct' | 'as'
	| 'explicit' | 'null' | 'switch' | 'base' | 'extern' 
	| 'object' | 'this' | 'bool' | 'false' | 'operator' 
	| 'throw' | 'break' | 'finally' | 'out' | 'true' 
	| 'byte' | 'fixed' | 'override' | 'try' | 'case' 
	| 'float' | 'params' | 'typeof' | 'catch' | 'for' 
	| 'private' | 'uint' | 'char' | 'foreach' | 'protected' 
	| 'ulong' | 'checked' | 'goto' | 'public' | 'unchecked' 
	| 'class' | 'if' | 'readonly' | 'unsafe' | 'const' 
	| 'implicit' | 'ref' | 'ushort' | 'continue' | 'in' 
	| 'return' | 'using' | 'decimal' | 'int' | 'sbyte' 
	| 'virtual' | 'default' | 'interface' | 'sealed' 
	| 'volatile' | 'delegate' | 'internal' | 'short' 
	| 'void' | 'do' | 'is' | 'sizeof' | 'while' | 'double' 
	| 'lock' | 'stackalloc' | 'else' | 'long' | 'static' 
	| 'enum' | 'namespace' | 'string'
	;
	
IDENT
	: '@'? IDENT_START IDENT_CONT*
	;

	
OP	: '++' | '--' | '->' | '.' | '+' | '-' | '!' | '~' | '(' | ')' | 
	  '&' | '*' | '**' | '/' | '%' | '<<' | '>>' | '<' | '>' | '[' | ']' |
	  '<=' | '>=' | '==' | '!=' | '^' | '|' | '&&' | '||' | '?' | 
	  ':' | '=' | '+=' | '-=' | '*=' | '/=' | '%=' | '&=' | '|=' | 
	  '^=' | '<<=' | '>>=' | '??' | ',' | ';' | '@'
    ;

COMMENT
    : '/*' ( options{greedy=false;}: . )* '*/'
    | '/*' (~'\n')*
    | '//' (~'\n')*
    ;


