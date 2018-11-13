#include <iostream>
using namespace std;

void search(int mat[4][4], int n, int x)
{
	int i = 0, j = n - 1; 
	while (i < n && j >= 0)
	{
		if (mat[i][j] == x)
		{
			cout << "n found at "
				<< i << ", " << j;
		}
		if (mat[i][j] > x)
			j--;
		else 
			i++;
	}

	cout << "n element not found";
}

int main()
{
	int mat[4][4] = { {10, 20, 30, 40},
						{15, 25, 35, 45},
						{27, 29, 37, 48},
						{32, 33, 39, 50} };
	search(mat, 4, 29);

	system("pause");
	return 0;
}