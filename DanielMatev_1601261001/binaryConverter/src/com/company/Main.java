package com.company;

public class Main {

    public static void main(String[] args) {
        int number = 11;

        System.out.println(integerToBinary(number));

        System.out.println(binaryToInteger(integerToBinary(number)));

    }

    private static int integerToBinary(int integerNumber) {
        double digits = 0;
        int temp = integerNumber;
        int binaryNumber = 0b0;

        while (temp != 0) {
            temp /= 2;
            digits++;
        }

        for (int i = 0; i < digits; i++) {
            binaryNumber += Math.pow(10, i) * (integerNumber % 2);
            integerNumber /= 2;
        }

        return binaryNumber;
    }

    private static int binaryToInteger(int binaryNumber) {
        int integerNumber = 0;
        double digits = 0;

        while (binaryNumber != 0) {
            integerNumber += Math.pow(2, digits) * (binaryNumber % 10);
            digits++;
            binaryNumber /= 10;
        }

        return integerNumber;
    }
}
