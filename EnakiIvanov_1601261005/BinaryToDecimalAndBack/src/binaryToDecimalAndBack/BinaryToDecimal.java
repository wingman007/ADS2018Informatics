package binaryToDecimalAndBack;

import java.util.Scanner;

public class BinaryToDecimal {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		
		int DecimalNum = 0, base_value = 1, rem;
		Long BinaryNum;
		
		System.out.print("Enter Binary number to convert: ");
		BinaryNum = in.nextLong();
		
		while (BinaryNum > 0) {
			rem = (int) (BinaryNum % 10);
			DecimalNum = DecimalNum + rem * base_value;
			BinaryNum = BinaryNum / 10;
			base_value = base_value * 2;
		}
		
		System.out.println("The Number in Decimal : " + DecimalNum);
	}

}
