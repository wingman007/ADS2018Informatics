/**
 * Created by Ralitsa Tamashova on 14.11.2018 г..
 */
public class RadiusReachability {

    public static void main(String[] args) {
        
        int array[] = new int[]{7, 8, 5, 3, 99, 1, 9, 15, 45, 10};
        int k = 25;
        int d = 17;

        boolean flag = false;

        for (int x : array) {
            System.out.print(x + " ");
        }

        System.out.println("\nk = " + k);
        System.out.println("d = " + d);
        System.out.println("|k – x.key| <= d");

        for (int x : array) {
            if (x >= k - d && x <= k + d) {
                System.out.print(x + " ");
                flag = true;
            }
        }

        if (!flag) System.out.println("\nThere is no such element");

    }
}
