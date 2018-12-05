// C++ code for k smallest elements in an array 
#include <stdio.h>  
#include<iostream>
using namespace std;
void swap(int *xp, int *yp)
{
	int temp = *xp;
	*xp = *yp;
	*yp = temp;
}
void bubbleSort(int arr[], int n)
{
	int i, j;
	for (i = 0; i < n - 1; i++)

		// Last i elements are already in place    
		for (j = 0; j < n - i - 1; j++)
			if (arr[j] > arr[j + 1])
				swap(&arr[j], &arr[j + 1]);
}
void printArray(int arr[], int size)
{
	int i;
	for (i = 0; i < size; i++)
		printf("%d ", arr[i]);
	printf("n");
}
void kSmallest(int arr[], int n, int k)
{



	// Print the first kth smallest elements 
	for (int i = 0; i < k; i++)
		cout << arr[i] << " ";
}



// A function to implement bubble sort 

/* Function to print an array */

// driver program 
int main()
{
	int k;
	printf("k=");
	cin >> k;
	int arr[] = { 1, 23, 12, 9, 30, 2, 50 };
	int n = sizeof(arr) / sizeof(arr[0]);

	bubbleSort(arr, n);
	kSmallest(arr, n, k);

	system("PAUSE");

}
