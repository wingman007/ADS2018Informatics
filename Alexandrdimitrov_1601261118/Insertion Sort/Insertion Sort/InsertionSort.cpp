#include <iostream>
#include <cstdlib>
using namespace std;

void insertion_sort(int arr[], int length);
void print_array(int array[], int size);

int main()
{
	int array[] = { 55,1,31,245,7,4563,420,23,456,42 };
	insertion_sort(array, 9);
	print_array(array, 9);
	return 0;
}

void insertion_sort(int arr[], int length)
{
	int i, j, tmp;
	for (i = 1; i < length; i++) {
		j = i;
		while (j > 0 && arr[j - 1] > arr[j]) {
			tmp = arr[j];
			arr[j] = arr[j - 1];
			arr[j - 1] = tmp;
			j--;
		}
	}
}

void print_array(int array[], int size)
{
	
	cout << "Eltmenti otsartirovani! =)" << endl;
	
	int j;
	for (j = 0; j < size; j++)
	{
		
		cout << array[j] <<endl;
	}

	system("pause");
}