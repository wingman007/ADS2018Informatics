package com.company;

public class Main {

    public static void main(String[] args) {

        int[] array = {0, 7, 2, 3, 0, 2, 7, 3, 34, 6, 8, 0, 64};
        int[] array2 = {0, 7, 2, 3, 0, 2, 7, 3, 34, 6, 8, 0, 64};

        bubbleSort(array);
        selectionSort(array2);

        printArray(array);
        System.out.println();
        printArray(array2);

    }

    private static void bubbleSort(int[] array) {

        for (int i = 0; i < array.length; i++) {
            for (int j = i + 1; j < array.length; j++) {

                if (array[i] > array[j]) {
                    int temp = array[i];

                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    private static void selectionSort(int[] array) {

        for (int i = 0; i < array.length - 1; i++) {
            int minIndex = i;

            for (int j = i + 1; j < array.length; j++) {

                if (array[minIndex] > array[j]) {
                    minIndex = j;
                }
            }
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    private static void printArray(int[] array) {
        for (int a : array) {
            System.out.print(a + " ");
        }

    }
}
