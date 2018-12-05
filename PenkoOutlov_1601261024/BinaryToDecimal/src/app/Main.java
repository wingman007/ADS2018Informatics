package app;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter a binary value: ");
        String binaryValue = input.nextLine();

        long decimalValue = Converter.convertToDecimal(binaryValue);
        String binary = Converter.convertToBinary(decimalValue);

        System.out.println("The decimal value of " + binaryValue + " is: " + decimalValue);
        System.out.println("The binary value of " +  decimalValue + " is: " + binary);

        input.close();
    }
}
