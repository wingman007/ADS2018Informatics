package lexer;

public enum TokenType {
	INT_CONST, // [0-9]+
	EOF, // input stream has been consumed
	UNKNOWN, // character/token could not be processed
	NOTSYMMETRIC, // not symmetric character
	SYMMETRIC, // Symmetric characters
	// punctuation
	LPAREN, // (
	RPAREN, // )
	LBRACKET, // [
	RBRACKET, // ]
	LBRACE, // {
	RBRACE, // }
	DIV, // /
	TIMES, // *
	LCOMENT, // /*
	RCOMENT, // */
	
	// for error reporting
	STATEMENT,
	EXPRESSION,
	OPERATOR,
	TYPE
}