/**
 * Created by Ralitsa Tamashova on 7.11.2018 г..
 */
public class SortSelect {

    public static void main(String[] args) {
        int a[] = new int[]{7, 100, 5, 3, 99, 1, 9, 15, 45, 10};
        int len = a.length;

        for (int i = 0; i < len - 1; i++) {
            for (int j = i+1; j < len; j++) {
                if (a[i] > a[j]) {
                    int swap = a[i];
                    a[i] = a[j];
                    a[j] = swap;
                }
            }
        }

        for (int array : a) {
            System.out.print(array + " ");
        }
    }
}
