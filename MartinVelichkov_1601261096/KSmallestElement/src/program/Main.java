package program;

import java.util.Arrays;

public class Main {
    private static int[] arr = new int[]{4, 2, 8, 5, 10, 12, 7, 0, 6, 3, 1};
    private static int k = 6;

    public static void main(String[] args) {
        //First task
//        Arrays.sort(arr);
//        printFirstKElements();

        //Second task
        Pyramid();
    }

    private static void printFirstKElements() {
        for (int i = 0; i < k; i++) {
            System.out.print(arr[i] + " ");
        }
    }

    //TODO to be implemented
    private static void minMaxElement() {

    }
    private static void Pyramid(){
        System.out.println("Pyramid");
        int num = arr[0];

        for (int i = 0; i < arr.length; i++){
            for (int j = 0; j <= i; j++ ){
                num = arr[j];
                System.out.print(num + " ");
            }
            System.out.println();
        }
        System.out.println("------------------------------");
    }
}