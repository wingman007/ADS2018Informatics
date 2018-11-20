#pragma once
class Queens
{
public:
	Queens();
	~Queens();
	void placeAllQueens();

private:
	void placeQueen( int x, int y );
	void initialize(int board[8][8]);
	void printBoard();
	bool isSafe(int x, int y);

private:
	int board[8][8];
	int placed = 0;
};

