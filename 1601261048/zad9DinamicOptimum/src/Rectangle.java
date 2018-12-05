import java.util.Scanner;

public class Rectangle{
    public static void printRectangle(int x, int y){
        for (int i = 0; i < y; i++) 
        { 
            System.out.println(); 
            for (int j = 0; j < x; j++) 
            {
                if (i == 0 || i == y-1 || 
                    j== 0 || j == x-1) 
                   System.out.print("#"); 
                else
                   System.out.print("0"); 
            } 
        } 
    } 
    
    public static int calculate(int m, int n) {
        int squaresCount = 0;
        System.out.println();
        System.out.println("Квадратите са: ");
        while (m * n != 0) {
            int min = Math.min(m, n);
            if (m > n) {
                m -= min;
                System.out.println(min + "x" + min);
            } else {
                n -= min;
                System.out.println(min + "x" + min);
            }
            squaresCount++;
           
        }
        return squaresCount;
    }
    
    public static void main(String[] args) {
        int max = 0;
        int min = 0;
        int optimum = 0;
        //int squaresS[]={1, 4, 9, 16, 25, 36};
        
        Scanner in = new Scanner(System.in);
        System.out.println("Изберете размерите на правоъгълник(m x n)");
        System.out.print("Избор на m: ");
        int  m = in.nextInt();
        System.out.print("Избор на n: ");
        int n = in.nextInt();
        //int s = m * n;
        System.out.println("Вашия правоъгълник е:");
        printRectangle(m+2, n+2);
        //if (m > n){
            //max = m;
            //min = n;
        //}else max = n; min = m;
        int cal = calculate(m,n);
        System.out.println("Опримално може да се покрие с: " + cal + " квадрат/а");
        
    }
    
}
