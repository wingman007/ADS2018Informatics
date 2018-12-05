package main;

public class Main {

    private static int[] a = {3, 0, 2, 5, -1, 4, 1};

    public static void main(String[] args) {
        System.out.println("Original array:");
        printArray(a);

        bubbleSort();

        System.out.println();

        System.out.println("Sorted array:");
        printArray(a);
    }

    private static void bubbleSort() {
        int t;

        for (int i = 0; i <= a.length - 2; i++) {
            for (int j = 0; j <= a.length - 2; j++) {
                if (a[j] > a[j + 1]) {
                    t = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = t;
                }
            }
        }
    }

    private static void printArray(int[] array) {
        for (int i : array) {
            System.out.print(i + " ");
        }
    }
}
