#include "SearchMatrix.h"
#include <iostream>

//using namespace std;
SearchMatrix::SearchMatrix()
{
}


SearchMatrix::~SearchMatrix()
{
}
void SearchMatrix::searchInMatrix( int num )
{
	for (int rows = 0; rows < 3; rows++)
	{
		for (int col = 0; col < 3; col++)
		{
			if (m_matrix[rows][col] == num)
			{
				std::cout << "Element " << num << " found at row " << rows + 1 << " column " << col + 1 << std::endl;
				return;
			}
		}
	}
	std::cout << "No element found!!!" << std::endl;
}

void SearchMatrix::printMatrix()
{
	for (int rows = 0; rows < 3; rows++)
	{
		for (int col = 0; col < 3; col++)
		{
			std::cout << m_matrix[rows][col] << ' ';
		}
		std::cout << std::endl;
	}

}