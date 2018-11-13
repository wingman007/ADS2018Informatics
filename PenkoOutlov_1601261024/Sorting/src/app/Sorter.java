package app;

public class Sorter {

    public static void bubbleSort(int[] array) {
        boolean hasSwapped;

        do {
            hasSwapped = false;

            for (int i = 0; i < array.length - 1; i++) {
                if (array[i] > array[i + 1]) {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;

                    hasSwapped = true;
                }
            }
        } while (hasSwapped);
    }

    public static void selectionSort(int[] array) {
        for (int i = 0; i < array.length - 1; i++) {
            int minValueIndex = i;

            for (int j = i + 1; j < array.length; j++) {
                if (array[j] < array[minValueIndex]) {
                    minValueIndex = j;
                }
            }

            int temp = array[i];
            array[i] = array[minValueIndex];
            array[minValueIndex] = temp;
        }
    }
}