package lexer;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

public class Lexer {
	private BufferedReader stream; //input stream reader
	private Token nextToken;
	private int nextChar;
	private int lineNumber = 1; //current line number
	private int columnNumber = 1; //current column number

	private final static Map<Character, TokenType> punctuation; //punctuation characters dictionary
	
	private int errors; //number of errors

	static {

		punctuation = new HashMap<Character, TokenType>();
		punctuation.put('(', TokenType.LPAREN);
		punctuation.put(')', TokenType.RPAREN);
		punctuation.put('[', TokenType.LBRACKET);
		punctuation.put(']', TokenType.RBRACKET);
		punctuation.put('{', TokenType.LBRACE);
		punctuation.put('}', TokenType.RBRACE);
		punctuation.put('*', TokenType.TIMES);
		punctuation.put('/', TokenType.DIV);
	}

	public Lexer(FileReader file) throws FileNotFoundException {
		this.stream = new BufferedReader(file);
		nextChar = getChar();
	}
	
	public int getErrors() {
		return errors;
	}

	// handles I/O for char stream
	private int getChar() {
		try {
			return stream.read();
		} catch (IOException e) {
			System.err.print(e.getMessage());
			System.err.println("IOException occured in Lexer::getChar()");
			return -1;
		}
	}

	private boolean skipNewline() {
		if (nextChar == '\n') {
			lineNumber++;
			columnNumber = 1;
			nextChar = getChar();
			return true;
		}
		if (nextChar == '\r') {
			lineNumber++;
			columnNumber = 1;
			nextChar = getChar();

			// skip over next char if '\n'
			if (nextChar == '\n')
				nextChar = getChar();
			return true;
		}
		// newline char not found
		return false;
	}

	// return the next token without consuming it
	public Token peek() throws IOException {
		// advance token only if its been reset by getToken()
		if (nextToken == null)
			nextToken = getToken();

		return nextToken;
	}

	// return the next token in the input stream (EOF signals end of input)
	public Token getToken() throws IOException {
		// check if peek() was called
		if (nextToken != null) {
			Token token = nextToken;
			nextToken = null; // allow peek to call for next token
			return token;
		}

		// skip whitespace character
		while (Character.isWhitespace(nextChar)) {
			// check if whitespace char is a newline
			if (!skipNewline()) {
				columnNumber++;
				nextChar = getChar();
			}
		}

		// EOF reached
		if (nextChar == -1)
			return new Token(TokenType.EOF, new TokenAttribute(), lineNumber, columnNumber);
		
		// check for binops
		switch (nextChar) {
				case '/':
					columnNumber++;
					nextChar = getChar();

					// check if next char is '*' to match '/*' binop
					if (nextChar == '*') {
						nextChar = getChar();
						return new Token(TokenType.LCOMENT, new TokenAttribute(), lineNumber, columnNumber - 2);
					} else
						return new Token(TokenType.UNKNOWN, new TokenAttribute(), lineNumber, columnNumber - 1);
				case '*':
					columnNumber++;
					nextChar = getChar();

					// check if next char is '/' to match '*/' binop
					if (nextChar == '/') {
						nextChar = getChar();
						return new Token(TokenType.RCOMENT, new TokenAttribute(), lineNumber, columnNumber - 2);
					} else
						return new Token(TokenType.UNKNOWN, new TokenAttribute(), lineNumber, columnNumber - 1);
				case '(':
					columnNumber++;
					nextChar = getChar();
					
					if(nextChar == ')'){
						nextChar = getChar();
						return new Token(TokenType.SYMMETRIC, new TokenAttribute(), lineNumber, columnNumber - 1);
					} else
						return new Token(TokenType.NOTSYMMETRIC, new TokenAttribute(), lineNumber, columnNumber - 1);
				
				case '[':
					columnNumber++;
					nextChar = getChar();
					
					if(nextChar == ']'){
						nextChar = getChar(); 
						return new Token(TokenType.SYMMETRIC, new TokenAttribute(), lineNumber, columnNumber - 1);
					} else
						return new Token(TokenType.NOTSYMMETRIC, new TokenAttribute(), lineNumber, columnNumber - 1);
				
				case '{':
					columnNumber++;
					nextChar = getChar();
					
					if(nextChar == '}'){
						nextChar = getChar();
						return new Token(TokenType.SYMMETRIC, new TokenAttribute(), lineNumber, columnNumber - 1);					
					} else
						return new Token(TokenType.NOTSYMMETRIC, new TokenAttribute(), lineNumber, columnNumber - 1);
					
		}
		
		// check for punctuation
		TokenType type = punctuation.get((char) nextChar);
		columnNumber++;
		nextChar = getChar();

		// found punctuation token
		if (type != null)
			return new Token(type, new TokenAttribute(), lineNumber, columnNumber - 1);

		// token type is unknown
		return new Token(TokenType.UNKNOWN, new TokenAttribute(), lineNumber, columnNumber - 1);
	}
}