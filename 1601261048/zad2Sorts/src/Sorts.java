import static java.lang.System.in;
import java.util.Scanner;
import javax.xml.bind.ParseConversionEvent;

public class Sorts {
    
       
        public static int partition(int arr[], int low, int high) 
        { 
            int bolt = arr[high];  
            int i = low-1; 
            for (int j= low; j < high; j++) 
            { 
                if (arr[j] <= bolt) 
                { 
                    i++; 

                    int tmp = arr[i]; 
                    arr[i] = arr[j]; 
                    arr[j] = tmp; 
                } 
            } 

            int tmp = arr[i+1]; 
            arr[i+1] = arr[high]; 
            arr[high] = tmp; 

            return i+1; 
        }
        
        public static void Qsort(int arr[], int low, int high) 
        { 
            if (low < high) 
            {
                int partIndex = partition(arr, low, high); 

                Qsort(arr, low, partIndex-1); 
                Qsort(arr, partIndex+1, high); 
            } 
        }
    
    
    public static void BubbleSort(int[] series){
        int len = series.length;
        for (int i = 0; i < len; i++) {
                for(int j = len-2; j >= i; j--){
                    if(series[j] > series[j + 1]) {
                       int tmp = series[j];
                       series[j] = series[j + 1];
                       series[j + 1] = tmp;
                    }
                }
        }
    }
    
    public static StringBuilder arrToString(int[] series){
        int len = series.length;
        StringBuilder result = new StringBuilder();
        for(int i = 0; i < len; i++){
            result.append(series[i]);
            if (i < len-1){
                result.append(", ");
            }
        }
        return result;
    }
        
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int [] series = {28, 31, 47, 14, 38, 37, 44, 35};
        System.out.println("Не сортиран: " + arrToString(series));
        int len = series.length;
        System.out.print("Избор на сортиране(1 за BubbleSort или 2 за QuickSort ): ");
        int checker = in.nextInt();
        if (checker == 1){        
        BubbleSort(series);
        System.out.println("Bubble Сортиран: " + arrToString(series));
        }else if(checker == 2){
            Qsort(series, 0, len-1);
            System.out.println("QuickSort Сортиран: " + arrToString(series));
            
            
        }else{
            System.out.println("Не си въвел от посочените!");
        }
    }
    
    
}
