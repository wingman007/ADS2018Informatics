class Rextester
{     
  public static void main(String[] args){
		
		char[] array ={'a','b','c','d','e','d'};
		char src = 'c';
		
		visualization(array);
		
		searchInArray(array, src);
		
	}
	
	public static void visualization(char[] arr){
        System.out.print("Array: ");
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
		System.out.println();
	}
	
	public static void searchInArray(char[] arr, char src){
		boolean CharFound = false;
		for (int i = 0; i < arr.length; i++) {
			if(src == (arr[i])){
				System.out.println("Founded at position: " + i);
				CharFound = true;
			}
		}
		if(!CharFound) System.err.println("Element not found");
	}
}