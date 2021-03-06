grammar QueryLanguage;

/*
 * Parser Rules
 */

condition
	: LogicalExpression=logical_expression EOF
	;

logical_expression 
	: LeftExpression=logical_expression AND RightExpression=logical_expression	#LogicalAndExpression
	| LeftExpression=logical_expression OR RightExpression=logical_expression	#LogicalOrExpression
	| Comparison=comparison_expression											#ComparisonExpression
	| logical_entity															#LogicalEntity
	| LPAREN logical_expression RPAREN											#LogicalExpressionInParen
	;

comparison_expression
	: LeftOperand=comparison_operand Operator=comparison_operator RightOperand=comparison_operand	#ComparisonExpressionWithOperators
	| LPAREN comparison_expression RPAREN															#ComparisonExpressionInParens
	;

comparison_operand
	: logical_entity
	;
comparison_operator
	: EQ
	| STARTSWITH
	| ENDSWITH
	| CONTAINS
	;

logical_entity
	: BooleanEntity=(TRUE | FALSE)				#LogicalConst
	| STRING									#LogicalVariable
	| THIS										#AliasedVariable
	;



/*
 * Lexer Rules
 */
AND : 'and';
OR  : 'or';

EQ:			'equals';
STARTSWITH: 'startsWith';
ENDSWITH:	'endsWith';
CONTAINS:	'contains';

TRUE:	'true';
FALSE:	'false';

LPAREN: '(';
RPAREN: ')';
QUOTE: '\'';

THIS: '$this';

IDENTIFIER: [a-zA-Z_][a-zA-Z_0-9.]*;

STRING
   : QUOTE (ESC | SAFECODEPOINT)* QUOTE
;


fragment ESC
   : '\\' (['\\/bfnrt] | UNICODE)
   ;
fragment UNICODE
   : 'u' HEX HEX HEX HEX
   ;
fragment HEX
   : [0-9a-fA-F]
   ;
fragment SAFECODEPOINT
   : ~ ['\\\u0000-\u001F]
   ;


WS
	: [ \t\n\r] + -> skip
;
