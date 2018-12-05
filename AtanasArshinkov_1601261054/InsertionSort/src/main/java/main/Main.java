package main;

public class Main {

    private static int[] arr = {-2, 8, 1, 2, 6, -7, 40, 23, 5, 34};

    public static void main(String[] args) {
        System.out.println("Array: ");
        printArray(arr);

        sort(arr);

        System.out.println("Ordered array");
        printArray(arr);
    }

    private static void sort(int[] arr) {
        for (int i = 1; i < arr.length; i++) {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    private static void printArray(int[] arr) {

        for (int i = 0; i < arr.length - 1; i++) {
            System.out.print(arr[i] + " ");
        }

        System.out.println();
    }

}
