class Rextester {

	 public static void main(String[] args){ 
        // Given array 
    	int arr[][] = { { 0, 0, 0, 1, 0 }, 
                 		{ 1, 1, 0, 1, 1 }, 
                 		{ 0, 1, 0, 0, 1 }, 
                 		{ 1, 0, 1, 0, 1 }, 
                 		{ 0, 0, 1, 0, 0 } }; 
    	
    	visualize(arr, 5, 5); 

    	 if (isPath(arr)) 
             System.out.println("There is path"); 
         else
             System.out.println("There isn't path"); 
	} 
	
	private static void visualize(int[][] t, int rows, int columns){	
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < columns; j++) {
				System.out.print(t[i][j] + "   ");
			}
			System.out.println();
		}
        System.out.println("--------------------");
	}
	
	private static boolean isPath(int arr[][]) 
    { 
        // set arr[0][0] = 2 
        arr[0][0] = 2; 
  
        // Mark reachable (from top left) nodes 
        // in first row and first column. 
        for (int i = 1; i < 5; i++) 
            if (arr[0][i] != 1) 
                arr[0][i] = arr[0][i - 1]; 
        for (int j = 1; j < 5; j++) 
            if (arr[j][0] != 1) 
                arr[j][0] = arr[j - 1][0]; 
  
        // Mark reachable nodes in 
        //  remaining matrix. 
        for (int i = 1; i < 5; i++) 
            for (int j = 1; j < 5; j++) 
                if (arr[i][j] != 1) 
                    arr[i][j] = Math.max(arr[i][j - 1], 
                                        arr[i - 1][j]); 
        visualize(arr, 5, 5);
        // return yes if right  
        // bottom index is 2 
        return (arr[5 - 1][5 - 1] == 2); 
    } 
}