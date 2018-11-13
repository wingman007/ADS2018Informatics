#pragma once
class SearchMatrix
{
public:
	SearchMatrix();
	~SearchMatrix();

	void searchInMatrix(int num);
	void printMatrix();

private:
	int m_matrix[3][3] = { 
							{ 1,5,7 },
							{ 4,15,22 },
							{ 2,6,33 }
						 };
};

