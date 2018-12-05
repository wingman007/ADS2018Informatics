#include "Queens.h"
#include <iostream>

const int ROW_COUNT = 8;

Queens::Queens()
{

}


Queens::~Queens()
{
}

void Queens:: placeAllQueens()
{
	initialize(board);
	placeQueen(0, 0);
	printBoard();
	if (!placed)
		std::cout << "CANT PLACE QUEENS" << std::endl;
}

void Queens::placeQueen(int x, int y)
{
	if (y == ROW_COUNT)
	{
		placed++;
		return;
	}

	for (int i = 0; x + i < ROW_COUNT; i++)
	{
		if (!placed && isSafe(x + i, y))
		{
			board[x + i][y] = 1;
			placeQueen(0, y + 1);

			if (!placed)
				board[x + i][y] = 0;
		}
	}
}

void Queens::initialize(int board[8][8])
{
	for (int i = 0; i< ROW_COUNT; i++)
	{
		for (int j = 0; j< ROW_COUNT; j++)
			board[i][j] = 0;
	}
}

//%2d in c language pads the number with an empty space. The number should take less than 2 characters to display.
void Queens::printBoard()
{
	if (!placed) 
		return;
	std::cout << std::endl;
	std::cout << std::endl;
	for (int i = 0; i< ROW_COUNT; i++) {
		for (int j = 0; j< ROW_COUNT; j++) {
			printf("%2d ", board[i][j]);
		}
		std::cout << std::endl;
		std::cout << std::endl;
	}
}

//abs() - This function in C++ returns the absolute value of an integer number.
bool Queens::isSafe(int x, int y)
{
	for (int i = 0; i < ROW_COUNT; i++) {
		for (int j = 0; j < ROW_COUNT; j++) {
			if (((i == x) || (j == y) || (abs(i - x) == abs(j - y))) && board[i][j] == 1)
				return false;
		}
	}
	 return true;
}