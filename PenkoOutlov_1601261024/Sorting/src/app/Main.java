package app;

import java.util.Random;

public class Main {

    public static void main(String[] args) {
        Random generator = new Random();

        int[] randomValues = new int[20];

        for (int i = 0; i < randomValues.length; i++) {
            randomValues[i] = generator.nextInt(100) + 1;
        }

        Sorter.selectionSort(randomValues);

        System.out.println("The sorted array is");
        printArray(randomValues);
    }

    private static void printArray(int[] array) {
        for (int i = 0; i < array.length - 1; i++) {
            System.out.print(array[i] + ", ");
        }
        System.out.println(array[array.length - 1]);
    }
}
