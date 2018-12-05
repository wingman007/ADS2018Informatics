#include <iostream>
#include <time.h>

using namespace std;

int partition(int arr[], int low, int high) {
	int pivot = arr[high];
	int i = (low - 1);

	for (int j = low; j <= (high - 1); j++) {
		if (arr[j] <= pivot) {
			i++;
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	}
	int temp1 = arr[i + 1];
	arr[i + 1] = arr[high];
	arr[high] = temp1;
	return(i + 1);

}

void quickSort(int arr[], int low, int high) {
	if (low < high) {
		int pi = partition(arr, low, high);
		quickSort(arr, low, (pi - 1));
		quickSort(arr, (pi + 1), high);
	}
}

void quickerSort(int arr[], int low, int high) {
	while (low < high) {
		int pi = partition(arr, low, high);

		if ((pi - low) < (high - pi)) {
			quickerSort(arr, low, (pi - 1));
			low = pi + 1;
		}
		else {
			quickerSort(arr, (pi + 1), high);
			high = pi - 1;
		}
	}
}

double findMedian(int arr[], int n) {
	if (n % 2 != 0) {
		return (double)arr[n / 2];
	}
	else return (double)(arr[(n - 1) / 2] + arr[n / 2]) / 2.0;
}

void printArray(int arr[], int size) {
	int i;

	for (i = 0; i < size; i++)
		printf("%d", arr[i]);
	printf("n");
}

int main() {
	int arr[] = { 5,3,1,2,4 };
	int n = sizeof(arr) / sizeof(arr[0]);
	quickSort(arr, 0, (n - 1));
	clock_t t;
	t = clock();
	quickSort(arr,0,(n-1));
	t = clock() - t;
	double time_taken = ((double)t) / CLOCKS_PER_SEC; // in seconds 
	printf("quickSort() took %f seconds to execute \n", time_taken);
	cout << "Median= " << findMedian(arr, n) << endl;
	printf("Sorted array: ");
	printArray(arr, n);
	cout << endl;

	int arr2[] = { 9,6,8,7,5};
	int m = sizeof(arr2) / sizeof(arr2[0]);
	quickerSort(arr2, 0, (n - 1));
	clock_t t1;
	t1 = clock();
	quickerSort(arr2, 0, (n - 1));
	t1 = clock() - t;
	double time_taken1 = ((double)t1) / CLOCKS_PER_SEC; // in seconds 
	printf("quickerSort() took %f seconds to execute \n", time_taken1);
	cout << "Median= " << findMedian(arr2, n) << endl;
	printf("Sorted array: ");
	printArray(arr2, m);
	cout<<endl;


	system("pause");
	return 0;
}