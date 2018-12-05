package matrix;

import utils.Coordinates;

public class Matrix {

    private int[][] matrix;

    public Matrix(int[][] matrix) {
        this.matrix = matrix;
    }

    public boolean isInMatrix(int number) {
        for (int row = 0; row < this.matrix.length; row++) {
            for (int col = 0; col < this.matrix[0].length; col++) {
                if (this.matrix[row][col] == number) {
                    return true;
                }
            }
        }
        return false;
    }

    public Coordinates findNumber(int number) {
        for (int row = 0; row < this.matrix.length; row++) {
            for (int col = 0; col < this.matrix[0].length; col++) {
                if (this.matrix[row][col] == number) {
                    return new Coordinates(row, col);
                }
            }
        }
        return null;
    }

    public void printNumber() {
        for (int i = 0; i < this.matrix.length; i++) {
            for (int j = 0; j < this.matrix[0].length; j++) {
                System.out.print(this.matrix[i][j] + " ");
            }
            System.out.println();
        }
    }
}
