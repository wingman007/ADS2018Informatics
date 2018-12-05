import java.util.Arrays;

class Rextester {
	public static int maxPosition = 0;
	
	public static void main(String[] args) {
		System.out.println("Visualise Array");
		int[] array = { 64, 34, 90, 12, 22, 11, 25};

		VisualiseArray(array);

		FindMinAndMax(array);
		
		SplitAndSortArray(array);

		Sort(array, 7);

		Pyramid(array);
	}
	
	private static void VisualiseArray(int[] arr){
		 for (int i = 0; i < arr.length; i++) {
	        	System.out.print(arr[i] + " ");
			}
		 System.out.println("\n------------------------------"); 
	}

	private static void FindMinAndMax(int[] arr) {
		System.out.println("Find Min and Max");
		int min = arr[0];
		int max = 0;
		for (int i = 0; i < arr.length; i++) {
			if (min > arr[i]) min = arr[i];
			
			if(max < arr[i])  max = arr[i];	
		}
		
		for (int i = 0; i < arr.length; i++) {
			if(max == arr[i]){
				maxPosition = i;
			}
		}
		System.out.println("Min number is " + min);
		System.out.println("Max number is " + max);
		System.out.println("------------------------------"); 
	}

	private static void Sort(int[] arr, int n){
		System.out.println("Sorting");
		Arrays.sort(arr);
		for (int i = 0; i < n; i++) {
			System.out.print(arr[i] + " ");
		}
		System.out.println("\n------------------------------"); 
	}
	
	private static void SplitAndSortArray(int[] arr){
		System.out.println("Splited and Sorted");
		int[] firstHalf = Arrays.copyOfRange(arr, 0, maxPosition);
		int[] secondHalf = Arrays.copyOfRange(arr, maxPosition, arr.length);
		Arrays.sort(firstHalf);
		System.out.println(Arrays.toString(firstHalf) + " " + Arrays.toString(secondHalf));
		System.out.println("------------------------------"); 	
	}
	
	private static void Pyramid(int[] arr){
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