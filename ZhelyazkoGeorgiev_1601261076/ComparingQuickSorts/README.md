			Comparing the Quick Sorts
   Compare the theoretical and empirical quick sorting, Rabbit and 		      Turtle Method, and pyramidal sorting.


1. QuickSort *theoretical*
- The array m[] is not passed as a paramer, but is considered a global variable: saving space in the stack and gaining speed because the function is recursive.
  The method works in a way that you pick a element x of an array is selected. In the left part of the array there must be the numbers that are less than or equal to it and in the right side - strictly larger than x.

2. Rabbit and Turtle Method *theoretical*
-  This method has fast and slow elements which we call Rabbit and Turtle elements. The "Rabbit" elements are the ones that are sorted quicker and the "Turtle" elements are the ones that are sorted slower. In every method there is atleast one "turtle" element which in leads to a maximum delay. We can reduce this treath by changing the traverse direction. In this method, however, there is a disadvantage in the sorting and that is with the division with decimal numbers. The division can be avoided by using multiplication instead. 

3. Pyramidal Sorting *theoretical*
- The pyramid is a tree in which each node has at most two descendants, and the node is always greater or equal to its descendants (thus the largest element is always on top of the pyramid).
  If the original array has n elements, then the last (n / 2) elements become the foundation of the pyramid.
  It is convenient to place the pyramid in the array. Thus each element of the array a[i] must be greater than or equal to elements a[2 * i + 1] and a[2 * i + 2] so each node of the pyramid will be larger than its descendants.
  During the sorting, we move the maximum element into the end of the array, then exclude it from the further sorting process. Since the maximum element is always at the top of the pyramid, we must swap the elements a[0] and a[n-1] (the last element). Next, we will consider the array only up to the (n-2)-th element.