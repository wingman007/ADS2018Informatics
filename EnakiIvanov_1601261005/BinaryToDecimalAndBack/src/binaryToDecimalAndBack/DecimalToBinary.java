package binaryToDecimalAndBack;

import java.util.Scanner;

public class DecimalToBinary {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		int DecimalNum = 0;
		String BinaryNum = "";
		
		System.out.print("Enter Decimal number to convert: ");
		DecimalNum = in.nextInt();
		
		while (DecimalNum > 1) {
		int rem = DecimalNum % 2;
			BinaryNum = rem + "" + BinaryNum;
			DecimalNum/=2;
		}	
		BinaryNum = DecimalNum + BinaryNum;
		
		System.out.println("The Number in Binary : " + BinaryNum);

	}

}
