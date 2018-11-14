package app;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int[][] matrix = {{1, 2, 3, 4, 5, 6}, {94, 283, 17494, 9173}};

        System.out.print("Enter a search value: ");
        int userInput = input.nextInt();

        if (findInMatrix(matrix, userInput)) {
            System.out.println("Value " + userInput + " is present in the matrix.");
        } else {
            System.out.println("Value " + userInput + " is not present in the matrix.");
        }

        input.close();
    }

    private static boolean findInMatrix(int[][] matrix, int value) {
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                if (matrix[i][j] == value) {
                    return true;
                }
            }
        }

        return false;
    }
}
