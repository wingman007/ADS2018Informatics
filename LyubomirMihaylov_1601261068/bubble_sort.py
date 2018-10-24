
arr = [ 13, 44, 5, 7, 67, 2, 34, 545, 5555, 2, 8, 89, 5, 1 ]

def bubbleSort(arr):
    n = len(arr)
    for i in range(n):
        for j in range(0, n-1):
            if arr[j] > arr[j+1] :
                arr[j], arr[j+1] = arr[j+1], arr[j]
    print(arr)
				
bubbleSort(arr)
