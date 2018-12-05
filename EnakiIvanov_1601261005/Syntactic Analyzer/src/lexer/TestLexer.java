package lexer;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

import javax.swing.plaf.synth.SynthSeparatorUI;

import lexer.Lexer;
import lexer.Token;
import lexer.TokenType;

public class TestLexer {
	public static void main(String[] args) throws IOException {
		if (args.length == 0)
			System.err.println("No file arguments given");
		else {
			// parse each file argument given
			for (int i = 0; i < args.length; i++) {
				FileReader file;
				// attempt to open file
				try {
					file = new FileReader(args[i]);
				} catch (FileNotFoundException e) {
					System.err.println(args[i] + " was not found!");
					continue; // try next file
				}
				
				// create lexer
				Lexer lexer = new Lexer(file);
				
				// start tokenizing file
				System.out.println("Tokenizing " + args[i] + "...");
				long startTime = System.currentTimeMillis();
				int numTokens = 0;
				Token token;
				do {
					token = lexer.getToken();
					
					numTokens++;

					if(token.getType() == TokenType.UNKNOWN){
						// print token type and location
						System.err.print(token.getType());
						System.err.print(" (" + token.getLineNumber() + "," + token.getColumnNumber() + ")");
						System.out.println();
						continue;
					}
					
					if(token.getType() == TokenType.NOTSYMMETRIC){
						// print token type and location
						System.out.print(token.getType());
						System.out.print(" (" + token.getLineNumber() + "," + token.getColumnNumber() + ")");
						System.out.println();
						continue;
					}
					
					System.out.print(token.getType());
					System.out.println(" (" + "Line: " +token.getLineNumber() + "," + "Column: " +token.getColumnNumber() + ")");
						
				} while (token.getType() != TokenType.EOF);
				
				
				long endTime = System.currentTimeMillis();
				
				// print out statistics
				System.out.println("---");
				System.out.println("Number of tokens: " + numTokens);
				System.out.println("Execution time: " + (endTime - startTime) + "ms");
				System.out.println();
			}
		}
	}
}