~~~~~~~~~ Finding the Closest Points

My task is - N points are given in the plane set with their coordinates. Find a pair of points between which the distance is minimal. ~ Will your algorithm work in three-dimensional space? And in the n-meter?

~ The main idea is to cover the entire space occupied by points with a rectangular regular grid.
~ Each grid cell contains a small subset of points which are located within the cell.
~ Since the grid is regular, for a given point we can easily calculate its cell index (I, J).
~ Next we search for the nearest point in the range I-1 <= i <= I+1, J-1 <= j <= J+1.
~ If no points found, iterate for all indexes in the range I-n <= i <= I+n, J-n <= j <= J+n for n = 2, 3, ..., except indexes from the previous steps.

Credit: 
~~ Dmitry ~~ https://codereview.stackexchange.com/questions/139059/order-a-list-of-points-by-closest-distance