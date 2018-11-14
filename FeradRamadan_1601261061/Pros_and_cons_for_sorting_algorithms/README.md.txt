Pros and cons for sorting algorithms:

Quick sort:

One of the most widely used sorting algorithms in computer industry. pros

Most often than not runs at O(nlogn) Quick sort is tried and true, has been used for many years in industry so you can be assured it is not going to fail you High space efficiency by executing in place

cons

Polynomial worst case scenario makes it susceptible for time critical applications Provides non stable sort due to swapping of elements in partitioning step

Practical usage

Best choice for general purpose and in memory sorting Used to be the standard algorithm for sorting of arrays of primitive types in Java qsort utility in C programming language is powered by quick sort.

Merge sort: Having an O(nlogn) worst case scenario run time makes merge sort a powerful sorting algorithm.

pros

Excellent choice when data is fetched from resources other than main memory Having a worst case scenario run time of O(nlogn) which is optimal Tim sort variant is really powerful

cons

Lots of overhead in copying data between arrays and making new arrays Extremely difficult to implement it in place for arrays Space inefficiency

Practical usage

When data is in different locations like cache, main memory, external memory etc. A multi-way merge sort variant is used in GNU sorting utility Tim sort variant is standard sorting algorithm in Python programming language since 2003 Default sorting algorithm of arrays of object type in Java since version 7 onward

Bubble sort Too slow to be practical.

pros

“catchy name”

cons

With polynomial O(n2) it is too slow

Practical usage

Implementing it makes for an interesting programming exercise

