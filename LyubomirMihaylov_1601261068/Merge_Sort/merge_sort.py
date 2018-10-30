def merge( left, right ):
    result = []
    i,j = 0, 0
    # While there are still elements in the sub lists - compare.
    while i < len(left) and j < len( right ):
        # If an element of one of the two subdivided lists
        # is less than the one in the other, insert it back to the previous list ( which combines both ).
        if left[i] <= right[j]:
            result.append(left[i])
            i+=1
        else:
            result.append(right[j])
            j+=1
    # Add to the final result (merged list) first the left part, then the right.
    result += left[i:]
    result += right[j:]
    return result
  
def mergesort(list):
    if(len(list) <= 1):
        return list
    middle = int(len(list) / 2)
    left = mergesort(list[:middle])
    right = mergesort(list[middle:])
    return merge(left, right)
    
list = [ -4, 53, 1, 23, -344, 56, 200, 24, 67 ]
print(mergesort(list))
