/**
 * Created by Ralitsa Tamashova on 1.11.2018 г..
 */
public class BubbleSort {

    public static void main(String[] args) {
        int a[] =  new int[]{7, 8, 5, 3, 99, 1, 9, 15, 45, 10};
        int len = a.length;

        do {
            for (int j = 0; j < len-1; j++) {
                if (a[j] > a[j+1]) {
                    int swap = a[j];
                    a[j] = a[j+1];
                    a[j+1] = swap;
                }
            }
            len--;
        } while (len != 0);

        for (int array : a) {
            System.out.print(array + " ");
        }
    }
}
