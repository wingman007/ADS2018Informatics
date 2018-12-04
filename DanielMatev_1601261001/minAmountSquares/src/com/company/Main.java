package com.company;

public class Main {

    public static void main(String[] args) {
        int a = 6;
        int b = 8;

        System.out.println(calculateSquares(a, b));

    }

    private static int calculateSquares(int a, int b) {
        int squaresCount = 0;
        while (a * b != 0) {
            int c = Math.min(a, b);
            if (a > b) {
                a -= c;
            } else {
                b -= c;
            }
            squaresCount++;
        }

        return squaresCount;
    }
}
