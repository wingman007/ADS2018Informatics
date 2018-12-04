#include"pch.h"
#include<iostream>

using namespace std;

int main()
{
	int mat[3][3] = { {1,2,3,}, {2,5,3}, {1,0,8} };

	for (int i = 0; i < 3; i++) {
		for (int j = 0; j < 3; j++) {

			printf("%d  ", mat[i][j]);

		}

		printf("\n");
	}

	float determinant = 0;

	
	for (int i = 0; i < 3; i++)
		determinant = determinant + (mat[0][i] * (mat[1][(i + 1) % 3] * mat[2][(i + 2) % 3] - mat[1][(i + 2) % 3] * mat[2][(i + 1) % 3]));

	cout << "\n\ndeterminant: " << determinant;

	cout << "\n\nInverse of matrix is: \n";
	for (int i = 0; i < 3; i++) {
		for (int j = 0; j < 3; j++)
			cout << ((mat[(j + 1) % 3][(i + 1) % 3] * mat[(j + 2) % 3][(i + 2) % 3]) - (mat[(j + 1) % 3][(i + 2) % 3] * mat[(j + 2) % 3][(i + 1) % 3])) / determinant << "\t";

		cout << "\n";
	}

	return 0;
}


